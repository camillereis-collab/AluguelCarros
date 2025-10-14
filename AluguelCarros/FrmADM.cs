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

            string connectionString = @"sua_string_de_conexao_aqui";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT senha FROM Clientes WHERE email=@Email";
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
                            MessageBox.Show("Login efetuado com sucesso!");
                            // Abrir tela principal
                            this.Hide();
                            FrmCentral form = new FrmCentral();
                            form.Show();
                        }
                        else
                        {
                            MessageBox.Show("Senha incorreta.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuário não encontrado.");
                    }
                }
            }
        }

    }
}

