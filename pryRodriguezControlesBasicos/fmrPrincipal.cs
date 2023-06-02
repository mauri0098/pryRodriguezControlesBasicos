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
    public partial class fmrPrincipal : Form
    {
        Random rnd = new Random();
        public fmrPrincipal()
        {
            InitializeComponent();
        }

        private void cmdInicio_Click(object sender, EventArgs e)
        {
            fmrInicio frm = new fmrInicio();
            frm.ShowDialog();

        }

        private void fmrPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            lblEjeX.Text = e.X.ToString();
            lblEjeY.Text = e.Y.ToString();
        }

        private void fmrPrincipal_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void fmrPrincipal_Click(object sender, EventArgs e)
        {
            lblBienvenidos.Visible = true;
        }

        private void lblBienvenidos_MouseEnter(object sender, EventArgs e)
        {
            lblBienvenidos.Location = new Point(rnd.Next(10, 300), rnd.Next(10, 400));
        }
    }
}
