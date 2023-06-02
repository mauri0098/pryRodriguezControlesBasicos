namespace pryRodriguezControlesBasicos
{
    partial class fmrPrincipal
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
            this.lblEjeX = new System.Windows.Forms.Label();
            this.lblEjeY = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBienvenidos
            // 
            this.lblBienvenidos.AutoSize = true;
            this.lblBienvenidos.Font = new System.Drawing.Font("Microsoft Yi Baiti", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenidos.Location = new System.Drawing.Point(104, 35);
            this.lblBienvenidos.Name = "lblBienvenidos";
            this.lblBienvenidos.Size = new System.Drawing.Size(325, 64);
            this.lblBienvenidos.TabIndex = 3;
            this.lblBienvenidos.Text = "Bienvenidos ";
            this.lblBienvenidos.Visible = false;
            this.lblBienvenidos.MouseEnter += new System.EventHandler(this.lblBienvenidos_MouseEnter);
            // 
            // cmdInicio
            // 
            this.cmdInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdInicio.Location = new System.Drawing.Point(223, 162);
            this.cmdInicio.Name = "cmdInicio";
            this.cmdInicio.Size = new System.Drawing.Size(145, 47);
            this.cmdInicio.TabIndex = 4;
            this.cmdInicio.Text = "Inicio";
            this.cmdInicio.UseVisualStyleBackColor = true;
            this.cmdInicio.Click += new System.EventHandler(this.cmdInicio_Click);
            // 
            // lblEjeX
            // 
            this.lblEjeX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEjeX.AutoSize = true;
            this.lblEjeX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjeX.Location = new System.Drawing.Point(753, 35);
            this.lblEjeX.Name = "lblEjeX";
            this.lblEjeX.Size = new System.Drawing.Size(24, 24);
            this.lblEjeX.TabIndex = 5;
            this.lblEjeX.Text = "X";
            // 
            // lblEjeY
            // 
            this.lblEjeY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEjeY.AutoSize = true;
            this.lblEjeY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjeY.Location = new System.Drawing.Point(753, 86);
            this.lblEjeY.Name = "lblEjeY";
            this.lblEjeY.Size = new System.Drawing.Size(22, 24);
            this.lblEjeY.TabIndex = 6;
            this.lblEjeY.Text = "Y";
            // 
            // fmrPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEjeY);
            this.Controls.Add(this.lblEjeX);
            this.Controls.Add(this.cmdInicio);
            this.Controls.Add(this.lblBienvenidos);
            this.Name = "fmrPrincipal";
            this.Text = "fmrPrincipal";
            this.Click += new System.EventHandler(this.fmrPrincipal_Click);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.fmrPrincipal_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.fmrPrincipal_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenidos;
        private System.Windows.Forms.Button cmdInicio;
        private System.Windows.Forms.Label lblEjeX;
        private System.Windows.Forms.Label lblEjeY;
    }
}