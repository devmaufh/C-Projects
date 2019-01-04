namespace WindowsFormsgGrados_Flores_Mauricio
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
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.celsiusFahrenheitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtGrado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.celsiusFahrenheitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.yhBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.DarkRed;
            this.bunifuImageButton1.Image = global::WindowsFormsgGrados_Flores_Mauricio.Properties.Resources.icons8_Delete_96px;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(292, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(34, 24);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkRed;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.celsiusFahrenheitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(326, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // celsiusFahrenheitToolStripMenuItem
            // 
            this.celsiusFahrenheitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.celsiusFahrenheitToolStripMenuItem1,
            this.salirToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.celsiusFahrenheitToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.celsiusFahrenheitToolStripMenuItem.Name = "celsiusFahrenheitToolStripMenuItem";
            this.celsiusFahrenheitToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.celsiusFahrenheitToolStripMenuItem.Text = "Opciones";
            this.celsiusFahrenheitToolStripMenuItem.Click += new System.EventHandler(this.celsiusFahrenheitToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.salirToolStripMenuItem.Text = "Limpiar";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // txtGrado
            // 
            this.txtGrado.BackColor = System.Drawing.SystemColors.Control;
            this.txtGrado.ForeColor = System.Drawing.Color.DarkRed;
            this.txtGrado.Location = new System.Drawing.Point(175, 71);
            this.txtGrado.Name = "txtGrado";
            this.txtGrado.Size = new System.Drawing.Size(95, 20);
            this.txtGrado.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese los grados celsius";
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.Control;
            this.txtResult.Enabled = false;
            this.txtResult.ForeColor = System.Drawing.Color.DarkRed;
            this.txtResult.Location = new System.Drawing.Point(175, 116);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(95, 20);
            this.txtResult.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(75, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Grados Fahrenheit";
            // 
            // celsiusFahrenheitToolStripMenuItem1
            // 
            this.celsiusFahrenheitToolStripMenuItem1.Name = "celsiusFahrenheitToolStripMenuItem1";
            this.celsiusFahrenheitToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.celsiusFahrenheitToolStripMenuItem1.Text = "Celsius - Fahrenheit";
            this.celsiusFahrenheitToolStripMenuItem1.Click += new System.EventHandler(this.celsiusFahrenheitToolStripMenuItem1_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yhBToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(326, 24);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // yhBToolStripMenuItem
            // 
            this.yhBToolStripMenuItem.Name = "yhBToolStripMenuItem";
            this.yhBToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.yhBToolStripMenuItem.Text = "yh b ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 213);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGrado);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem celsiusFahrenheitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.TextBox txtGrado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem celsiusFahrenheitToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem yhBToolStripMenuItem;
    }
}

