using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AluguelCarros
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bntEntrar_Click(object sender, EventArgs e)
        {
            string nome = txbName.Text;
            string email = txbEma.Text;
            string senha = txbSen.Text;

            string sql = "SELECT COUNT(*) FROM Clientes WHERE Nome = @Nome AND Email = @Email AND Senha = @Senha";
            string conexao = @"Server=sqlexpress;Database=CJ302752XPR2;User Id=aluno;Password=aluno";

            using (SqlConnection conn = new SqlConnection(conexao))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Senha", senha);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show($"Bem-vindo, {nome}!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FrmCentral central = new FrmCentral();
                    this.Hide();
                    central.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Usuário, e-mail ou senha inválidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void txbConSen_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmInicial telaAnterior = new FrmInicial();
            telaAnterior.Show();
        }

        private void PtbLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnAqui_Click(object sender, EventArgs e)
        {
            FrmCad product = new FrmCad();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }
    }
}
