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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.cmdAsignar = new System.Windows.Forms.Button();
            this.optAzul = new System.Windows.Forms.RadioButton();
            this.optRojo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkMostaza = new System.Windows.Forms.CheckBox();
            this.chkMayonesa = new System.Windows.Forms.CheckBox();
            this.chkPicante = new System.Windows.Forms.CheckBox();
            this.lblEscribir = new System.Windows.Forms.Label();
            this.cmdSeleccionar = new System.Windows.Forms.Button();
            this.cboAdiciona = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(12, 28);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(72, 25);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // cmdAsignar
            // 
            this.cmdAsignar.Location = new System.Drawing.Point(138, 72);
            this.cmdAsignar.Name = "cmdAsignar";
            this.cmdAsignar.Size = new System.Drawing.Size(75, 23);
            this.cmdAsignar.TabIndex = 2;
            this.cmdAsignar.Text = "Asignar";
            this.cmdAsignar.UseVisualStyleBackColor = true;
            this.cmdAsignar.Click += new System.EventHandler(this.cmdAsignar_Click);
            // 
            // optAzul
            // 
            this.optAzul.AutoSize = true;
            this.optAzul.Location = new System.Drawing.Point(12, 75);
            this.optAzul.Name = "optAzul";
            this.optAzul.Size = new System.Drawing.Size(45, 17);
            this.optAzul.TabIndex = 3;
            this.optAzul.TabStop = true;
            this.optAzul.Text = "Azul";
            this.optAzul.UseVisualStyleBackColor = true;
            // 
            // optRojo
            // 
            this.optRojo.AutoSize = true;
            this.optRojo.Location = new System.Drawing.Point(63, 75);
            this.optRojo.Name = "optRojo";
            this.optRojo.Size = new System.Drawing.Size(47, 17);
            this.optRojo.TabIndex = 4;
            this.optRojo.TabStop = true;
            this.optRojo.Text = "Rojo";
            this.optRojo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkMostaza);
            this.groupBox1.Controls.Add(this.chkMayonesa);
            this.groupBox1.Controls.Add(this.chkPicante);
            this.groupBox1.Location = new System.Drawing.Point(12, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asignacion";
            // 
            // chkMostaza
            // 
            this.chkMostaza.AutoSize = true;
            this.chkMostaza.Location = new System.Drawing.Point(6, 65);
            this.chkMostaza.Name = "chkMostaza";
            this.chkMostaza.Size = new System.Drawing.Size(66, 17);
            this.chkMostaza.TabIndex = 8;
            this.chkMostaza.Text = "Mostaza";
            this.chkMostaza.UseVisualStyleBackColor = true;
            // 
            // chkMayonesa
            // 
            this.chkMayonesa.AutoSize = true;
            this.chkMayonesa.Location = new System.Drawing.Point(6, 42);
            this.chkMayonesa.Name = "chkMayonesa";
            this.chkMayonesa.Size = new System.Drawing.Size(75, 17);
            this.chkMayonesa.TabIndex = 7;
            this.chkMayonesa.Text = "Mayonesa";
            this.chkMayonesa.UseVisualStyleBackColor = true;
            // 
            // chkPicante
            // 
            this.chkPicante.AutoSize = true;
            this.chkPicante.Location = new System.Drawing.Point(6, 19);
            this.chkPicante.Name = "chkPicante";
            this.chkPicante.Size = new System.Drawing.Size(62, 17);
            this.chkPicante.TabIndex = 6;
            this.chkPicante.Text = "Picante";
            this.chkPicante.UseVisualStyleBackColor = true;
            this.chkPicante.CheckedChanged += new System.EventHandler(this.chkPicante_CheckedChanged);
            // 
            // lblEscribir
            // 
            this.lblEscribir.AutoSize = true;
            this.lblEscribir.Location = new System.Drawing.Point(159, 280);
            this.lblEscribir.Name = "lblEscribir";
            this.lblEscribir.Size = new System.Drawing.Size(41, 13);
            this.lblEscribir.TabIndex = 9;
            this.lblEscribir.Text = "Escribir";
            this.lblEscribir.Click += new System.EventHandler(this.lblEscribir_Click);
            // 
            // cmdSeleccionar
            // 
            this.cmdSeleccionar.Location = new System.Drawing.Point(12, 275);
            this.cmdSeleccionar.Name = "cmdSeleccionar";
            this.cmdSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.cmdSeleccionar.TabIndex = 10;
            this.cmdSeleccionar.Text = "Seleccionar";
            this.cmdSeleccionar.UseVisualStyleBackColor = true;
            this.cmdSeleccionar.Click += new System.EventHandler(this.cmdSeleccionar_Click);
            // 
            // cboAdiciona
            // 
            this.cboAdiciona.FormattingEnabled = true;
            this.cboAdiciona.Location = new System.Drawing.Point(12, 304);
            this.cboAdiciona.Name = "cboAdiciona";
            this.cboAdiciona.Size = new System.Drawing.Size(130, 21);
            this.cboAdiciona.TabIndex = 12;
            this.cboAdiciona.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // fmrInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 367);
            this.Controls.Add(this.cboAdiciona);
            this.Controls.Add(this.cmdSeleccionar);
            this.Controls.Add(this.lblEscribir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.optRojo);
            this.Controls.Add(this.optAzul);
            this.Controls.Add(this.cmdAsignar);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Name = "fmrInicio";
            this.Text = "fmrInicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fmrInicio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button cmdAsignar;
        private System.Windows.Forms.RadioButton optAzul;
        private System.Windows.Forms.RadioButton optRojo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkMostaza;
        private System.Windows.Forms.CheckBox chkMayonesa;
        private System.Windows.Forms.CheckBox chkPicante;
        private System.Windows.Forms.Label lblEscribir;
        private System.Windows.Forms.Button cmdSeleccionar;
        private System.Windows.Forms.ComboBox cboAdiciona;
    }
}