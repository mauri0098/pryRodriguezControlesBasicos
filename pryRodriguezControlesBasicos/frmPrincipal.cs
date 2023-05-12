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
    public partial class frmTitulodelaVentana : Form
    {
        public frmTitulodelaVentana()
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
         lblBienvenidosalSistema.Visible = true;
        }

        private void frmTitulodelaVentana_MouseEnter(object sender, EventArgs e)
        {
            lblBienvenidosalSistema.Location = new Point(125);
        }
    }
}
