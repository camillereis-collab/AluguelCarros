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
    public partial class FrmLogADM : Form
    {
        public FrmLogADM()
        {
            InitializeComponent();
        }

        private void btnAQUIADM_Click(object sender, EventArgs e)
        {
            FrmCadAdm product = new FrmCadAdm();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }
    }
}
