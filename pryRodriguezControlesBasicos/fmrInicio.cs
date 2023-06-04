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
            Ibltexto.Text = txtTexto.Text;
        }

        private void cmdAsignar_Click(object sender, EventArgs e)
        {
            if (optAzul.Checked == true)
            {
                Ibltexto.ForeColor = Color.Blue;
                txtTexto.ForeColor = Color.Blue;
            }
            if (optRojo.Checked == true)
            {
                Ibltexto.ForeColor = Color.Red;
                txtTexto.ForeColor = Color.Red;

            }
        }

        private void Asignacion_Enter(object sender, EventArgs e)
        {

        }

        private void chkPicante_CheckedChanged(object sender, EventArgs e)
        {
            
            

            
        }

        private void lblEscribir_Click(object sender, EventArgs e)
        {

        }

        private void cmdSeleccionar_Click(object sender, EventArgs e)
        {
            string textoConcatenar = "";

            if (chkPicante.Checked == true)
            {
                lblEscribir.Text = "Picante ";
                textoConcatenar = textoConcatenar + "Picante ";
            }


            if (chkMayonesa.Checked == true)
            {
                lblEscribir.Text = "Mayonesa "; 
                textoConcatenar = textoConcatenar + " Mayonesa ";
            }

            if (chkMostaza.Checked == true)
            {
                lblEscribir.Text = "Mostaza ";
                textoConcatenar = textoConcatenar  + " Mostaza ";



            }
            if (chkMostaza.Checked == true || chkPicante.Checked == true || chkMayonesa.Checked == true)
            {
                lblEscribir.Text = textoConcatenar;
            }

            //agregar un item al combobox - lista

            lstAderezos.Items.Add(textoConcatenar);
        }  

       
          


        

        
      


      
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fmrInicio_Load(object sender, EventArgs e)
        {

        }

        private void optRojo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
    
    
    
    

