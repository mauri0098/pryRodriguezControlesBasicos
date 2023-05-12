using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRodriguezControlesBasicos
{
    public partial class fmrInicio : Form
    {
        public fmrInicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            lblUsuario.Text = txtUsuario.Text;
        }

        private void cmdAsignar_Click(object sender, EventArgs e)
        {
            if (optAzul.Checked == true)
            {
                lblUsuario.ForeColor = Color.Blue;
                txtUsuario.ForeColor = Color.Blue;
            }
            if (optRojo.Checked == true)
            {
                lblUsuario.ForeColor = Color.Red;
                txtUsuario.ForeColor = Color.Red;

            }
        }
            
               
}
}
