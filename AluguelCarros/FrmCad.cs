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
    public partial class FrmCad : Form
    {
        public FrmCad()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblcadastro_Click(object sender, EventArgs e)
        {

        }
        //INCLUSÃO DE USUARIO

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }




        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void lblCpf_Click(object sender, EventArgs e)
        {

        }

        private void c_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbCpf_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "Deseja mesmo sair?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnaVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmInicial telaAnterior = new FrmInicial();
            telaAnterior.Show();
        }

        private void PtbCad_Click(object sender, EventArgs e)
        {

        }

        private void txbconfirmarsenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            {
                string nomecompleto = c.Text;
                string email = txbEmail.Text;
                string telefone = txbTelefone.Text;
                string cpf = txbCpf.Text;
                string Cnh = txbCnh.Text;
                string senha = txbsenha.Text;
                string confirmarsenha = txbconfirmarsenha.Text;

                // Validação
                if (string.IsNullOrEmpty(nomecompleto) ||
                    string.IsNullOrEmpty(email) ||
                    string.IsNullOrEmpty(telefone) ||
                    string.IsNullOrEmpty(cpf) ||
                    string.IsNullOrEmpty(Cnh) ||
                    string.IsNullOrEmpty(senha) ||
                    string.IsNullOrEmpty(confirmarsenha))
                {
                    MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
                    return;
                }
                if (senha != confirmarsenha)
                {
                    MessageBox.Show("As senhas não conferem! Digite novamente.");
                    txbsenha.Clear();
                    txbconfirmarsenha.Clear();
                    txbsenha.Focus();
                    return;
                }

                string conexao = @"Server=sqlexpress;Database=CJ302752XPR2;User Id=aluno;Password=aluno";
                string sql = "INSERT INTO Clientes (Nome, CPF, CNH, Telefone, Email, Senha) VALUES (@Nome, @CPF, @CNH, @Telefone, @Email, @Senha)";

                try
                {
                    using (SqlConnection conn = new SqlConnection(conexao))
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nome", nomecompleto);
                        cmd.Parameters.AddWithValue("@CPF", cpf);
                        cmd.Parameters.AddWithValue("@CNH", Cnh);
                        cmd.Parameters.AddWithValue("@Telefone", telefone);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Senha", senha);

                        conn.Open(); // <-- abre só aqui
                        cmd.ExecuteNonQuery();
                    } // <-- aqui o conn é fechado automaticamente

                    MessageBox.Show(
                        $"Cadastro realizado com sucesso!\n\nNome Completo: {nomecompleto}\nE-mail: {email}\nTelefone: {telefone}\nCPF: {cpf}\nCNH: {Cnh}\nSenha: {senha}\nConfirmar Senha: {confirmarsenha}",
                        "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information
                    );

                    FrmConsultaVeiculos product = new FrmConsultaVeiculos();
                    this.Visible = false;
                    product.ShowDialog();
                    this.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar: " + ex.Message);
                }
            }


        }

        private void btn_Click(object sender, EventArgs e)
        {

        }

        private void btnAdm_Click(object sender, EventArgs e)
        {
            {
                string nomecompleto = c.Text;
                string email = txbEmail.Text;
                string telefone = txbTelefone.Text;
                string cpf = txbCpf.Text;
                string Cnh = txbCnh.Text;
                string senha = txbsenha.Text;
                string confirmarsenha = txbconfirmarsenha.Text;

                // Validação
                if (string.IsNullOrEmpty(nomecompleto) ||
                    string.IsNullOrEmpty(email) ||
                    string.IsNullOrEmpty(telefone) ||
                    string.IsNullOrEmpty(cpf) ||
                    string.IsNullOrEmpty(Cnh) ||
                    string.IsNullOrEmpty(senha) ||
                    string.IsNullOrEmpty(confirmarsenha))
                {
                    MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
                    return;
                }
                if (senha != confirmarsenha)
                {
                    MessageBox.Show("As senhas não conferem! Digite novamente.");
                    txbsenha.Clear();
                    txbconfirmarsenha.Clear();
                    txbsenha.Focus();
                    return;
                }

                string conexao = @"Server=sqlexpress;Database=CJ302752XPR2;User Id=aluno;Password=aluno";
                string sql = "INSERT INTO Clientes (Nome, CPF, CNH, Telefone, Email, Senha) VALUES (@Nome, @CPF, @CNH, @Telefone, @Email, @Senha)";

                try
                {
                    using (SqlConnection conn = new SqlConnection(conexao))
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nome", nomecompleto);
                        cmd.Parameters.AddWithValue("@CPF", cpf);
                        cmd.Parameters.AddWithValue("@CNH", Cnh);
                        cmd.Parameters.AddWithValue("@Telefone", telefone);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Senha", senha);

                        conn.Open(); // <-- abre só aqui
                        cmd.ExecuteNonQuery();
                    } // <-- aqui o conn é fechado automaticamente

                    MessageBox.Show(
                        $"Cadastro realizado com sucesso!\n\nNome Completo: {nomecompleto}\nE-mail: {email}\nTelefone: {telefone}\nCPF: {cpf}\nCNH: {Cnh}\nSenha: {senha}\nConfirmar Senha: {confirmarsenha}",
                        "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information
                    );

                    FrmCentral product = new FrmCentral();
                    this.Visible = false;
                    product.ShowDialog();
                    this.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar: " + ex.Message);
                }
            }
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }
    }
}

            
    


