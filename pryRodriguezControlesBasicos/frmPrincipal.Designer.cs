namespace pryRodriguezControlesBasicos
{
    partial class frmTitulodelaVentana
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEjeX = new System.Windows.Forms.Label();
            this.lblEjeY = new System.Windows.Forms.Label();
            this.lblBienvenidosalSistema = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEjeX
            // 
            this.lblEjeX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEjeX.AutoSize = true;
            this.lblEjeX.Location = new System.Drawing.Point(344, 21);
            this.lblEjeX.Name = "lblEjeX";
            this.lblEjeX.Size = new System.Drawing.Size(14, 13);
            this.lblEjeX.TabIndex = 0;
            this.lblEjeX.Text = "X";
            this.lblEjeX.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEjeY
            // 
            this.lblEjeY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEjeY.AutoSize = true;
            this.lblEjeY.Location = new System.Drawing.Point(344, 44);
            this.lblEjeY.Name = "lblEjeY";
            this.lblEjeY.Size = new System.Drawing.Size(14, 13);
            this.lblEjeY.TabIndex = 1;
            this.lblEjeY.Text = "Y";
            // 
            // lblBienvenidosalSistema
            // 
            this.lblBienvenidosalSistema.AutoSize = true;
            this.lblBienvenidosalSistema.Location = new System.Drawing.Point(12, 68);
            this.lblBienvenidosalSistema.Name = "lblBienvenidosalSistema";
            this.lblBienvenidosalSistema.Size = new System.Drawing.Size(116, 13);
            this.lblBienvenidosalSistema.TabIndex = 2;
            this.lblBienvenidosalSistema.Text = "Bienvenidos al Sistema";
            this.lblBienvenidosalSistema.Visible = false;
            this.lblBienvenidosalSistema.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmTitulodelaVentana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 426);
            this.Controls.Add(this.lblBienvenidosalSistema);
            this.Controls.Add(this.lblEjeY);
            this.Controls.Add(this.lblEjeX);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTitulodelaVentana";
            this.Text = "Titulo de la Ventana";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTitulodelaVentana_Load);
            this.Click += new System.EventHandler(this.frmTitulodelaVentana_Click);
            this.MouseEnter += new System.EventHandler(this.frmTitulodelaVentana_MouseEnter);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmTitulodelaVentana_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEjeX;
        private System.Windows.Forms.Label lblEjeY;
        private System.Windows.Forms.Label lblBienvenidosalSistema;
    }
}