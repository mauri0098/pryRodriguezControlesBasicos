namespace pryRodriguezControlesBasicos
{
    partial class frmPrincipal
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
            this.lblBienvenidos = new System.Windows.Forms.Label();
            this.cmdInicio = new System.Windows.Forms.Button();
            this.IblEjeX = new System.Windows.Forms.Label();
            this.IblEjeY = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBienvenidos
            // 
            this.lblBienvenidos.AutoSize = true;
            this.lblBienvenidos.Font = new System.Drawing.Font("Calibri", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenidos.Location = new System.Drawing.Point(27, 58);
            this.lblBienvenidos.Name = "lblBienvenidos";
            this.lblBienvenidos.Size = new System.Drawing.Size(559, 117);
            this.lblBienvenidos.TabIndex = 3;
            this.lblBienvenidos.Text = "Bienvenidos ";
            this.lblBienvenidos.Visible = false;
            this.lblBienvenidos.MouseEnter += new System.EventHandler(this.lblBienvenidos_MouseEnter);
            // 
            // cmdInicio
            // 
            this.cmdInicio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdInicio.Location = new System.Drawing.Point(167, 188);
            this.cmdInicio.Name = "cmdInicio";
            this.cmdInicio.Size = new System.Drawing.Size(222, 53);
            this.cmdInicio.TabIndex = 4;
            this.cmdInicio.Text = "Inicio";
            this.cmdInicio.UseVisualStyleBackColor = true;
            this.cmdInicio.Click += new System.EventHandler(this.cmdInicio_Click);
            // 
            // IblEjeX
            // 
            this.IblEjeX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IblEjeX.AutoSize = true;
            this.IblEjeX.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblEjeX.Location = new System.Drawing.Point(624, 15);
            this.IblEjeX.Name = "IblEjeX";
            this.IblEjeX.Size = new System.Drawing.Size(25, 25);
            this.IblEjeX.TabIndex = 5;
            this.IblEjeX.Text = "X";
            // 
            // IblEjeY
            // 
            this.IblEjeY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IblEjeY.AutoSize = true;
            this.IblEjeY.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblEjeY.Location = new System.Drawing.Point(624, 58);
            this.IblEjeY.Name = "IblEjeY";
            this.IblEjeY.Size = new System.Drawing.Size(23, 26);
            this.IblEjeY.TabIndex = 6;
            this.IblEjeY.Text = "Y";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 416);
            this.Controls.Add(this.IblEjeY);
            this.Controls.Add(this.IblEjeX);
            this.Controls.Add(this.cmdInicio);
            this.Controls.Add(this.lblBienvenidos);
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Click += new System.EventHandler(this.fmrPrincipal_Click);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.fmrPrincipal_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.fmrPrincipal_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenidos;
        private System.Windows.Forms.Button cmdInicio;
        private System.Windows.Forms.Label IblEjeX;
        private System.Windows.Forms.Label IblEjeY;
    }
}