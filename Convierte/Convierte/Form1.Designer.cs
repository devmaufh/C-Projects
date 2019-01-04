namespace Convierte
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
            this.txtTasaEuro = new System.Windows.Forms.TextBox();
            this.txtTasaDolar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPesos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTasaEuro
            // 
            this.txtTasaEuro.Location = new System.Drawing.Point(15, 25);
            this.txtTasaEuro.Name = "txtTasaEuro";
            this.txtTasaEuro.Size = new System.Drawing.Size(56, 20);
            this.txtTasaEuro.TabIndex = 0;
            // 
            // txtTasaDolar
            // 
            this.txtTasaDolar.Location = new System.Drawing.Point(88, 25);
            this.txtTasaDolar.Name = "txtTasaDolar";
            this.txtTasaDolar.Size = new System.Drawing.Size(56, 20);
            this.txtTasaDolar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tasa Dolar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tasa Euro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pesos:";
            // 
            // txtPesos
            // 
            this.txtPesos.Location = new System.Drawing.Point(57, 68);
            this.txtPesos.Name = "txtPesos";
            this.txtPesos.Size = new System.Drawing.Size(87, 20);
            this.txtPesos.TabIndex = 4;
            this.txtPesos.TextChanged += new System.EventHandler(this.txtPesos_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dolar";
            // 
            // txtDolar
            // 
            this.txtDolar.Location = new System.Drawing.Point(57, 108);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(87, 20);
            this.txtDolar.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Euro";
            // 
            // txtEuro
            // 
            this.txtEuro.Location = new System.Drawing.Point(57, 148);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(87, 20);
            this.txtEuro.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 261);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPesos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTasaDolar);
            this.Controls.Add(this.txtTasaEuro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTasaEuro;
        private System.Windows.Forms.TextBox txtTasaDolar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPesos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEuro;
    }
}

