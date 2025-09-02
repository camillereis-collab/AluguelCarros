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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
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
            FrmPrincipal product = new FrmPrincipal();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;

            string nomecompleto = c.Text;
            string email = txbEmail.Text;
            string telefone = txbTelefone.Text;
            string cpf = txbCpf.Text;
            string senha = txbsenha.Text;
            string confirmarsenha = txbconfirmarsenha.Text;
            MessageBox.Show($"Cadastro realizado com sucesso!\n\nNome Completo: {nomecompleto}\nE-mail: {email}\nTelefone: {telefone}\nCPF: {cpf}\nSenha: {senha}\nConfirmar Senha: {confirmarsenha}",
                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void lblCpf_Click(object sender, EventArgs e)
        {

        }
    }
}
