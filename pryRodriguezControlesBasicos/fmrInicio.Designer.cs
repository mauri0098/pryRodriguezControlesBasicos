namespace pryRodriguezControlesBasicos
{
    partial class fmrInicio
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
            this.lbltexto = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.cmdAsignar = new System.Windows.Forms.Button();
            this.optAzul = new System.Windows.Forms.RadioButton();
            this.optRojo = new System.Windows.Forms.RadioButton();
            this.gbAderezo = new System.Windows.Forms.GroupBox();
            this.chkMostaza = new System.Windows.Forms.CheckBox();
            this.chkMayonesa = new System.Windows.Forms.CheckBox();
            this.chkPicante = new System.Windows.Forms.CheckBox();
            this.lblEscribir = new System.Windows.Forms.Label();
            this.cmdSeleccionar = new System.Windows.Forms.Button();
            this.cboAdiciona = new System.Windows.Forms.ComboBox();
            this.gbAderezo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltexto
            // 
            this.lbltexto.AutoSize = true;
            this.lbltexto.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltexto.Location = new System.Drawing.Point(146, 72);
            this.lbltexto.Name = "lbltexto";
            this.lbltexto.Size = new System.Drawing.Size(35, 15);
            this.lbltexto.TabIndex = 0;
            this.lbltexto.Text = "Texto";
            this.lbltexto.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTexto
            // 
            this.txtTexto.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTexto.Location = new System.Drawing.Point(143, 35);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(181, 23);
            this.txtTexto.TabIndex = 1;
            this.txtTexto.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // cmdAsignar
            // 
            this.cmdAsignar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAsignar.Location = new System.Drawing.Point(172, 138);
            this.cmdAsignar.Name = "cmdAsignar";
            this.cmdAsignar.Size = new System.Drawing.Size(105, 25);
            this.cmdAsignar.TabIndex = 2;
            this.cmdAsignar.Text = "Asignar";
            this.cmdAsignar.UseVisualStyleBackColor = true;
            this.cmdAsignar.Click += new System.EventHandler(this.cmdAsignar_Click);
            // 
            // optAzul
            // 
            this.optAzul.AutoSize = true;
            this.optAzul.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optAzul.Location = new System.Drawing.Point(149, 103);
            this.optAzul.Name = "optAzul";
            this.optAzul.Size = new System.Drawing.Size(48, 19);
            this.optAzul.TabIndex = 3;
            this.optAzul.TabStop = true;
            this.optAzul.Text = "Azul";
            this.optAzul.UseVisualStyleBackColor = true;
            // 
            // optRojo
            // 
            this.optRojo.AutoSize = true;
            this.optRojo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optRojo.Location = new System.Drawing.Point(227, 103);
            this.optRojo.Name = "optRojo";
            this.optRojo.Size = new System.Drawing.Size(50, 19);
            this.optRojo.TabIndex = 4;
            this.optRojo.TabStop = true;
            this.optRojo.Text = "Rojo";
            this.optRojo.UseVisualStyleBackColor = true;
            this.optRojo.CheckedChanged += new System.EventHandler(this.optRojo_CheckedChanged);
            // 
            // gbAderezo
            // 
            this.gbAderezo.Controls.Add(this.chkMostaza);
            this.gbAderezo.Controls.Add(this.chkMayonesa);
            this.gbAderezo.Controls.Add(this.chkPicante);
            this.gbAderezo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAderezo.Location = new System.Drawing.Point(143, 169);
            this.gbAderezo.Name = "gbAderezo";
            this.gbAderezo.Size = new System.Drawing.Size(181, 100);
            this.gbAderezo.TabIndex = 5;
            this.gbAderezo.TabStop = false;
            this.gbAderezo.Text = "Aderezo";
            // 
            // chkMostaza
            // 
            this.chkMostaza.AutoSize = true;
            this.chkMostaza.Location = new System.Drawing.Point(6, 65);
            this.chkMostaza.Name = "chkMostaza";
            this.chkMostaza.Size = new System.Drawing.Size(73, 19);
            this.chkMostaza.TabIndex = 8;
            this.chkMostaza.Text = "Mostaza";
            this.chkMostaza.UseVisualStyleBackColor = true;
            // 
            // chkMayonesa
            // 
            this.chkMayonesa.AutoSize = true;
            this.chkMayonesa.Location = new System.Drawing.Point(6, 42);
            this.chkMayonesa.Name = "chkMayonesa";
            this.chkMayonesa.Size = new System.Drawing.Size(83, 19);
            this.chkMayonesa.TabIndex = 7;
            this.chkMayonesa.Text = "Mayonesa";
            this.chkMayonesa.UseVisualStyleBackColor = true;
            // 
            // chkPicante
            // 
            this.chkPicante.AutoSize = true;
            this.chkPicante.Location = new System.Drawing.Point(6, 19);
            this.chkPicante.Name = "chkPicante";
            this.chkPicante.Size = new System.Drawing.Size(67, 19);
            this.chkPicante.TabIndex = 6;
            this.chkPicante.Text = "Picante";
            this.chkPicante.UseVisualStyleBackColor = true;
            this.chkPicante.CheckedChanged += new System.EventHandler(this.chkPicante_CheckedChanged);
            // 
            // lblEscribir
            // 
            this.lblEscribir.AutoSize = true;
            this.lblEscribir.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscribir.Location = new System.Drawing.Point(274, 296);
            this.lblEscribir.Name = "lblEscribir";
            this.lblEscribir.Size = new System.Drawing.Size(50, 15);
            this.lblEscribir.TabIndex = 9;
            this.lblEscribir.Text = "Escribir";
            this.lblEscribir.Click += new System.EventHandler(this.lblEscribir_Click);
            // 
            // cmdSeleccionar
            // 
            this.cmdSeleccionar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSeleccionar.Location = new System.Drawing.Point(143, 290);
            this.cmdSeleccionar.Name = "cmdSeleccionar";
            this.cmdSeleccionar.Size = new System.Drawing.Size(97, 21);
            this.cmdSeleccionar.TabIndex = 10;
            this.cmdSeleccionar.Text = "Seleccionar";
            this.cmdSeleccionar.UseVisualStyleBackColor = true;
            this.cmdSeleccionar.Click += new System.EventHandler(this.cmdSeleccionar_Click);
            // 
            // cboAdiciona
            // 
            this.cboAdiciona.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAdiciona.FormattingEnabled = true;
            this.cboAdiciona.Location = new System.Drawing.Point(143, 330);
            this.cboAdiciona.Name = "cboAdiciona";
            this.cboAdiciona.Size = new System.Drawing.Size(181, 23);
            this.cboAdiciona.TabIndex = 12;
            this.cboAdiciona.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // fmrInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 465);
            this.Controls.Add(this.cboAdiciona);
            this.Controls.Add(this.cmdSeleccionar);
            this.Controls.Add(this.lblEscribir);
            this.Controls.Add(this.gbAderezo);
            this.Controls.Add(this.optRojo);
            this.Controls.Add(this.optAzul);
            this.Controls.Add(this.cmdAsignar);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.lbltexto);
            this.Name = "fmrInicio";
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fmrInicio_Load);
            this.gbAderezo.ResumeLayout(false);
            this.gbAderezo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltexto;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Button cmdAsignar;
        private System.Windows.Forms.RadioButton optAzul;
        private System.Windows.Forms.RadioButton optRojo;
        private System.Windows.Forms.GroupBox gbAderezo;
        private System.Windows.Forms.CheckBox chkMostaza;
        private System.Windows.Forms.CheckBox chkMayonesa;
        private System.Windows.Forms.CheckBox chkPicante;
        private System.Windows.Forms.Label lblEscribir;
        private System.Windows.Forms.Button cmdSeleccionar;
        private System.Windows.Forms.ComboBox cboAdiciona;
    }
}