using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AluguelCarros
{
    public partial class FrmInicial : Form
    {
        public FrmInicial()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            FrmCad product = new FrmCad();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            FrmLogin product = new FrmLogin();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
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

        private void PtbInicial_Click(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FrmLogADM product = new FrmLogADM();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }
    }

}
