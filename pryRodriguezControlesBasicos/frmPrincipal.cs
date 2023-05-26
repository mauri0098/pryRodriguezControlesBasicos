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
    public partial class frmPrincipla : Form
    {
        public frmPrincipla()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void frmTitulodelaVentana_Load(object sender, EventArgs e)
        {
       


        }

        private void frmTitulodelaVentana_MouseMove(object sender, MouseEventArgs e)
        {
            lblEjeX.Text = e.X.ToString();
            lblEjeY.Text = e.Y.ToString();
        }

        private void frmTitulodelaVentana_Click(object sender, EventArgs e)
        {
         lblBienvenidos.Visible = true;
        }

        private void frmTitulodelaVentana_MouseEnter(object sender, EventArgs e)
        {
            lblBienvenidos.Location = new Point(125);
        }

        private void cmdInicio_Click(object sender, EventArgs e)
        {
            fmrInicio frm = new fmrInicio();
            frm.ShowDialog();
        }
    }
}
