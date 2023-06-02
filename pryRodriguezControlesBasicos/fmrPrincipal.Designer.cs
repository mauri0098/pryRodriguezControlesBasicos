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
            this.cmdInicio = new System.Windows.Forms.Button();
            this.lblBienvenidos = new System.Windows.Forms.Label();
            this.lblEjeX = new System.Windows.Forms.Label();
            this.lblEjeY = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdInicio
            // 
            this.cmdInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdInicio.Location = new System.Drawing.Point(165, 176);
            this.cmdInicio.Name = "cmdInicio";
            this.cmdInicio.Size = new System.Drawing.Size(145, 47);
            this.cmdInicio.TabIndex = 4;
            this.cmdInicio.Text = "Inicio";
            this.cmdInicio.UseVisualStyleBackColor = true;
            this.cmdInicio.Click += new System.EventHandler(this.cmdInicio_Click);
            this.cmdInicio.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cmdInicio_MouseMove);
            // 
            // lblBienvenidos
            // 
            this.lblBienvenidos.AutoSize = true;
            this.lblBienvenidos.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenidos.Location = new System.Drawing.Point(56, 61);
            this.lblBienvenidos.Name = "lblBienvenidos";
            this.lblBienvenidos.Size = new System.Drawing.Size(423, 64);
            this.lblBienvenidos.TabIndex = 5;
            this.lblBienvenidos.Text = "Bienvenidos ";
            this.lblBienvenidos.Visible = false;
            // 
            // lblEjeX
            // 
            this.lblEjeX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEjeX.AutoSize = true;
            this.lblEjeX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjeX.Location = new System.Drawing.Point(539, 23);
            this.lblEjeX.Name = "lblEjeX";
            this.lblEjeX.Size = new System.Drawing.Size(24, 24);
            this.lblEjeX.TabIndex = 6;
            this.lblEjeX.Text = "X";
            // 
            // lblEjeY
            // 
            this.lblEjeY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEjeY.AutoSize = true;
            this.lblEjeY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjeY.Location = new System.Drawing.Point(539, 101);
            this.lblEjeY.Name = "lblEjeY";
            this.lblEjeY.Size = new System.Drawing.Size(22, 24);
            this.lblEjeY.TabIndex = 7;
            this.lblEjeY.Text = "Y";
            // 
            // fmrPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 450);
            this.Controls.Add(this.lblEjeY);
            this.Controls.Add(this.lblEjeX);
            this.Controls.Add(this.lblBienvenidos);
            this.Controls.Add(this.cmdInicio);
            this.Name = "fmrPrincipal";
            this.Text = "fmrPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdInicio;
        private System.Windows.Forms.Label lblBienvenidos;
        private System.Windows.Forms.Label lblEjeX;
        private System.Windows.Forms.Label lblEjeY;
    }
}