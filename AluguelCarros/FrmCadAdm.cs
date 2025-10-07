using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AluguelCarros
{
    public partial class FrmCadAdm : Form
    {
        string connectionString = "Server=sqlexpress;;Database=CJ302752XPR2;User Id=aluno;Password=aluno";
        public FrmCadAdm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmInicial telaAnterior = new FrmInicial();
            telaAnterior.Show();
        }

        private void BTNtestarConexao_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=sqlexpress;Initial Catalog=CJ302752XPR2;User Id=aluno;Password=aluno;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    MessageBox.Show("Conexão realizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro na conexão: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para criptografar a senha (IMPORTANTE para segurança!)
        private string CriptografarSenha(string senha)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(senha));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        // Validar formato de CPF
        private bool ValidarCPF(string cpf)
        {
            // Remove pontos e traços
            cpf = cpf.Replace(".", "").Replace("-", "").Trim();

            // Verifica se tem 11 dígitos
            if (cpf.Length != 11 || !long.TryParse(cpf, out _))
            {
                return false;
            }

            return true;
        }

        // Validar formato de email
        private bool ValidarEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void BTNsalvar_Click(object sender, EventArgs e)
        {
            // 1️⃣ Verificação de campos obrigatórios
            if (string.IsNullOrWhiteSpace(txbNomeADM.Text))
            {
                MessageBox.Show("Por favor, preencha o nome!", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbNomeADM.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txbEmailADM.Text))
            {
                MessageBox.Show("Por favor, preencha o email!", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbEmailADM.Focus();
                return;
            }

            // Validar formato do email
            if (!ValidarEmail(txbEmailADM.Text))
            {
                MessageBox.Show("Por favor, insira um email válido!", "Email Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbEmailADM.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txbADM.Text))
            {
                MessageBox.Show("Por favor, preencha o telefone!", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbADM.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txbCPFADM.Text))
            {
                MessageBox.Show("Por favor, preencha o CPF!", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbCPFADM.Focus();
                return;
            }

            // Validar CPF
            if (!ValidarCPF(txbCPFADM.Text))
            {
                MessageBox.Show("Por favor, insira um CPF válido (11 dígitos)!", "CPF Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbCPFADM.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txbSENHAADM.Text))
            {
                MessageBox.Show("Por favor, preencha a senha!", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbSENHAADM.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txbCONFIGADM.Text))
            {
                MessageBox.Show("Por favor, confirme a senha!", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbCONFIGADM.Focus();
                return;
            }

            // 2️⃣ Verificação de senha
            if (txbSENHAADM.Text.Length < 6)
            {
                MessageBox.Show("A senha deve ter pelo menos 6 caracteres!", "Senha Fraca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbSENHAADM.Focus();
                return;
            }

            if (txbSENHAADM.Text != txbCONFIGADM.Text)
            {
                MessageBox.Show("As senhas não coincidem!", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbCONFIGADM.Focus();
                return;
            }

            // 3️⃣ Verificar se o CPF já está cadastrado
            if (VerificarCPFExiste(txbCPFADM.Text))
            {
                MessageBox.Show("Este CPF já está cadastrado no sistema!", "CPF Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbCPFADM.Focus();
                return;
            }

            // 4️⃣ Verificar se o email já está cadastrado
            if (VerificarEmailExiste(txbEmailADM.Text))
            {
                MessageBox.Show("Este email já está cadastrado no sistema!", "Email Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbEmailADM.Focus();
                return;
            }

            // 5️⃣ Inserção no banco de dados
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"INSERT INTO admins 
                                    (Nome, Email, Senha, Telefone, CPF, DataNascimento, DataCadastro, Status)
                                    VALUES (@Nome, @Email, @Senha, @Telefone, @CPF, @DataNascimento, @DataCadastro, @Status)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Adicionar parâmetros para evitar SQL Injection
                        cmd.Parameters.AddWithValue("@Nome", txbNomeADM.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", txbEmailADM.Text.Trim().ToLower());
                        cmd.Parameters.AddWithValue("@Senha", CriptografarSenha(txbSENHAADM.Text)); // Senha criptografada
                        cmd.Parameters.AddWithValue("@Telefone", txbADM.Text.Trim());
                        cmd.Parameters.AddWithValue("@CPF", txbCPFADM.Text.Replace(".", "").Replace("-", "").Trim());
                        cmd.Parameters.AddWithValue("@DataNascimento", dtpADM.Value.Date);
                        cmd.Parameters.AddWithValue("@DataCadastro", DateTime.Now);
                        cmd.Parameters.AddWithValue("@Status", "Ativo");

                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Administrador cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimparCampos();

                            FrmCentral frmCentral = new FrmCentral();
                            frmCentral.Show();

                            // Fecha completamente a tela de cadastro
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível cadastrar o administrador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show($"Erro no banco de dados: {sqlEx.Message}\n\nVerifique:\n- A string de conexão\n- Se a tabela Administradores existe\n- Se as colunas estão corretas", "Erro SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao cadastrar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Verificar se o CPF já existe no banco
        private bool VerificarCPFExiste(string cpf)
        {
            cpf = cpf.Replace(".", "").Replace("-", "").Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Admins WHERE CPF = @CPF";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CPF", cpf);
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
                catch
                {
                    return false;
                }
            }
        }

        // Verificar se o email já existe no banco
        private bool VerificarEmailExiste(string email)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Admins WHERE Email = @Email";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email.Trim().ToLower());
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
                catch
                {
                    return false;
                }
            }
        }

        // Método para limpar os campos
        private void LimparCampos()
        {
            txbNomeADM.Clear();
            txbEmailADM.Clear();
            txbSENHAADM.Clear();
            txbCONFIGADM.Clear();
            txbADM.Clear();
            txbCPFADM.Clear();
            dtpADM.Value = DateTime.Today;
            txbNomeADM.Focus();
        }
        
                }
}

 

