namespace Forms4_Conversión
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbMilimetro = new System.Windows.Forms.RadioButton();
            this.rbKilómetros = new System.Windows.Forms.RadioButton();
            this.rbCen = new System.Windows.Forms.RadioButton();
            this.rbMilla = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtConversión = new System.Windows.Forms.TextBox();
            this.txtR = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSAlir = new System.Windows.Forms.Button();
            this.lblUnidades = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbMilimetro
            // 
            this.rbMilimetro.AutoSize = true;
            this.rbMilimetro.Location = new System.Drawing.Point(6, 19);
            this.rbMilimetro.Name = "rbMilimetro";
            this.rbMilimetro.Size = new System.Drawing.Size(73, 17);
            this.rbMilimetro.TabIndex = 0;
            this.rbMilimetro.TabStop = true;
            this.rbMilimetro.Text = "Milímetros";
            this.rbMilimetro.UseVisualStyleBackColor = true;
            this.rbMilimetro.CheckedChanged += new System.EventHandler(this.rbMilimetro_CheckedChanged);
            this.rbMilimetro.Click += new System.EventHandler(this.rbMilimetro_Click);
            // 
            // rbKilómetros
            // 
            this.rbKilómetros.AutoSize = true;
            this.rbKilómetros.Location = new System.Drawing.Point(6, 65);
            this.rbKilómetros.Name = "rbKilómetros";
            this.rbKilómetros.Size = new System.Drawing.Size(73, 17);
            this.rbKilómetros.TabIndex = 1;
            this.rbKilómetros.TabStop = true;
            this.rbKilómetros.Text = "Kilometros";
            this.rbKilómetros.UseVisualStyleBackColor = true;
            this.rbKilómetros.Click += new System.EventHandler(this.rbKilómetros_Click);
            // 
            // rbCen
            // 
            this.rbCen.AutoSize = true;
            this.rbCen.Location = new System.Drawing.Point(6, 42);
            this.rbCen.Name = "rbCen";
            this.rbCen.Size = new System.Drawing.Size(80, 17);
            this.rbCen.TabIndex = 2;
            this.rbCen.TabStop = true;
            this.rbCen.Text = "Centimetros";
            this.rbCen.UseVisualStyleBackColor = true;
            this.rbCen.Click += new System.EventHandler(this.rbMetros_Click);
            // 
            // rbMilla
            // 
            this.rbMilla.AutoSize = true;
            this.rbMilla.Location = new System.Drawing.Point(6, 88);
            this.rbMilla.Name = "rbMilla";
            this.rbMilla.Size = new System.Drawing.Size(51, 17);
            this.rbMilla.TabIndex = 3;
            this.rbMilla.TabStop = true;
            this.rbMilla.Text = "Millas";
            this.rbMilla.UseVisualStyleBackColor = true;
            this.rbMilla.Click += new System.EventHandler(this.rbMilla_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMilimetro);
            this.groupBox1.Controls.Add(this.rbMilla);
            this.groupBox1.Controls.Add(this.rbKilómetros);
            this.groupBox1.Controls.Add(this.rbCen);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 118);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione una opcion:";
            // 
            // txtConversión
            // 
            this.txtConversión.Location = new System.Drawing.Point(18, 13);
            this.txtConversión.Name = "txtConversión";
            this.txtConversión.Size = new System.Drawing.Size(100, 20);
            this.txtConversión.TabIndex = 5;
            this.txtConversión.TextChanged += new System.EventHandler(this.txtConversión_TextChanged);
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(207, 12);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(141, 20);
            this.txtR.TabIndex = 6;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(207, 67);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(141, 24);
            this.btnConvert.TabIndex = 7;
            this.btnConvert.Text = "Convertir";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(207, 109);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(141, 27);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSAlir
            // 
            this.btnSAlir.Location = new System.Drawing.Point(207, 155);
            this.btnSAlir.Name = "btnSAlir";
            this.btnSAlir.Size = new System.Drawing.Size(141, 30);
            this.btnSAlir.TabIndex = 9;
            this.btnSAlir.Text = "Salir";
            this.btnSAlir.UseVisualStyleBackColor = true;
            this.btnSAlir.Click += new System.EventHandler(this.btnSAlir_Click);
            // 
            // lblUnidades
            // 
            this.lblUnidades.AutoSize = true;
            this.lblUnidades.Location = new System.Drawing.Point(277, 16);
            this.lblUnidades.Name = "lblUnidades";
            this.lblUnidades.Size = new System.Drawing.Size(0, 13);
            this.lblUnidades.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 203);
            this.Controls.Add(this.lblUnidades);
            this.Controls.Add(this.btnSAlir);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.txtConversión);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbMilimetro;
        private System.Windows.Forms.RadioButton rbKilómetros;
        private System.Windows.Forms.RadioButton rbCen;
        private System.Windows.Forms.RadioButton rbMilla;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtConversión;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSAlir;
        private System.Windows.Forms.Label lblUnidades;
    }
}

