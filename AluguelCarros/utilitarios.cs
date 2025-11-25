using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Linq;

// REMOVA o namespace para ficar global
public class Utilitarios
{
    // String de conexão com o banco de dados
    private static string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=BDAluguelVeiculos;Integrated Security=True;";

    // Método para obter a conexão com o banco
    public static SqlConnection ObterConexao()
    {
        try
        {
            SqlConnection conexao = new SqlConnection(connectionString);
            conexao.Open();
            return conexao;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao conectar com o banco de dados: {ex.Message}", "Erro de Conexão",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }
    }

    // Método para fechar a conexão
    public static void FecharConexao(SqlConnection conexao)
    {
        try
        {
            if (conexao != null && conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
                conexao.Dispose();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao fechar conexão: {ex.Message}", "Erro",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    // Método para criptografar senha usando SHA256
    public static string CriptografarSenha(string senha)
    {
        try
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - retorna byte array
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(senha));

                // Converter byte array para string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao criptografar senha: {ex.Message}", "Erro",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }
    }

    // Método para verificar se a senha corresponde ao hash
    public static bool VerificarSenha(string senha, string hashSenha)
    {
        try
        {
            string hashOfInput = CriptografarSenha(senha);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            return comparer.Compare(hashOfInput, hashSenha) == 0;
        }
        catch (Exception)
        {
            return false;
        }
    }

    // Método para validar email
    public static bool ValidarEmail(string email)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            var addr = new System.Net.Mail.MailAddress(email);
            return addr.Address == email;
        }
        catch
        {
            return false;
        }
    }

    // Método para validar CPF (validação básica)
    public static bool ValidarCPF(string cpf)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(cpf))
                return false;

            // Remove caracteres não numéricos
            cpf = new string(cpf.Where(char.IsDigit).ToArray());

            // Verifica se tem 11 dígitos
            if (cpf.Length != 11)
                return false;

            // Verifica se não é uma sequência de números iguais
            if (cpf.Distinct().Count() == 1)
                return false;

            return true;
        }
        catch
        {
            return false;
        }
    }
}