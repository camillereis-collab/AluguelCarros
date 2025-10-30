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
    public partial class FrmLogADM : Form
    {
        public FrmLogADM()
        {
            InitializeComponent();
        }
        public string GerarHashSHA256(string texto)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(texto));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }
        private void btnAQUIADM_Click(object sender, EventArgs e)
        {
            FrmCadAdm product = new FrmCadAdm();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }

        private void btnlogadm_Click(object sender, EventArgs e)
        {
            string email = txbemailADM.Text.Trim();
            string senha = txbsenhaADM.Text.Trim();

            if (email == "" || senha == "")
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            // ✅ String de conexão correta
            string connectionString = @"Server=sqlexpress;Database=CJ302752XPR2;User Id=aluno;Password=aluno";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // ✅ Busca senha na tabela de administradores
                string query = "SELECT Senha FROM Admins WHERE Email = @Email";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string senhaArmazenada = result.ToString();
                        string senhaHash = GerarHashSHA256(senha);

                        if (senhaHash == senhaArmazenada)
                        {
                            MessageBox.Show("Login efetuado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // ✅ Abre a tela central e fecha o login
                            this.Hide();
                            FrmCadVeículos form = new FrmCadVeículos();
                            form.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Senha incorreta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Administrador não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
