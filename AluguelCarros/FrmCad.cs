using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nomecompleto = c.Text;
            string email = txbEmail.Text;
            string telefone = txbTelefone.Text;
            string cpf = txbCpf.Text;
            string senha = txbsenha.Text;
            string confirmarsenha = txbconfirmarsenha.Text;
            MessageBox.Show($"Cadastro realizado com sucesso!\n\nNome Completo: {nomecompleto}\nE-mail: {email}\nTelefone: {telefone}\nCPF: {cpf}\nSenha: {senha}\nConfirmar Senha: {confirmarsenha}",
                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FrmCentral product = new FrmCentral();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
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
    }
}

