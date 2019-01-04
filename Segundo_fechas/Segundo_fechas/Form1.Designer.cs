namespace Segundo_fechas
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
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFecha = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.dateP1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtHora = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtNuevaFecha = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtDia = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Día = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dateP2 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 43);
            this.panel1.TabIndex = 0;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.LightGray;
            this.lblFecha.Location = new System.Drawing.Point(3, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(95, 18);
            this.lblFecha.TabIndex = 10;
            this.lblFecha.Text = "Nueva fecha";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(9, 9);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(0, 18);
            this.bunifuCustomLabel3.TabIndex = 10;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Navy;
            this.bunifuImageButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuImageButton1.Image = global::Segundo_fechas.Properties.Resources.icons8_Delete_64px;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(221, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(35, 43);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // dateP1
            // 
            this.dateP1.BackColor = System.Drawing.Color.Navy;
            this.dateP1.BorderRadius = 0;
            this.dateP1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateP1.ForeColor = System.Drawing.Color.White;
            this.dateP1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateP1.FormatCustom = null;
            this.dateP1.Location = new System.Drawing.Point(6, 49);
            this.dateP1.Name = "dateP1";
            this.dateP1.Size = new System.Drawing.Size(244, 34);
            this.dateP1.TabIndex = 1;
            this.dateP1.Value = new System.DateTime(2018, 3, 5, 11, 26, 36, 797);
            this.dateP1.onValueChanged += new System.EventHandler(this.dateP1_onValueChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(14, 91);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(43, 18);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Hora";
            // 
            // txtHora
            // 
            this.txtHora.BorderColor = System.Drawing.Color.Navy;
            this.txtHora.Cursor = System.Windows.Forms.Cursors.No;
            this.txtHora.Enabled = false;
            this.txtHora.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtHora.Location = new System.Drawing.Point(132, 89);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(95, 20);
            this.txtHora.TabIndex = 4;
            // 
            // txtNuevaFecha
            // 
            this.txtNuevaFecha.BorderColor = System.Drawing.Color.Navy;
            this.txtNuevaFecha.Cursor = System.Windows.Forms.Cursors.No;
            this.txtNuevaFecha.Enabled = false;
            this.txtNuevaFecha.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNuevaFecha.Location = new System.Drawing.Point(126, 294);
            this.txtNuevaFecha.Multiline = true;
            this.txtNuevaFecha.Name = "txtNuevaFecha";
            this.txtNuevaFecha.Size = new System.Drawing.Size(101, 36);
            this.txtNuevaFecha.TabIndex = 5;
            this.txtNuevaFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDia
            // 
            this.txtDia.BorderColor = System.Drawing.Color.Navy;
            this.txtDia.Cursor = System.Windows.Forms.Cursors.No;
            this.txtDia.Enabled = false;
            this.txtDia.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtDia.Location = new System.Drawing.Point(132, 115);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(95, 20);
            this.txtDia.TabIndex = 6;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(14, 117);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(31, 18);
            this.bunifuCustomLabel2.TabIndex = 7;
            this.bunifuCustomLabel2.Text = "Día";
            // 
            // Día
            // 
            this.Día.AutoSize = true;
            this.Día.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Día.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Día.Location = new System.Drawing.Point(14, 296);
            this.Día.Name = "Día";
            this.Día.Size = new System.Drawing.Size(95, 18);
            this.Día.TabIndex = 8;
            this.Día.Text = "Nueva fecha";
            // 
            // dateP2
            // 
            this.dateP2.BackColor = System.Drawing.Color.Navy;
            this.dateP2.BorderRadius = 0;
            this.dateP2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateP2.ForeColor = System.Drawing.Color.White;
            this.dateP2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateP2.FormatCustom = null;
            this.dateP2.Location = new System.Drawing.Point(6, 226);
            this.dateP2.Name = "dateP2";
            this.dateP2.Size = new System.Drawing.Size(244, 34);
            this.dateP2.TabIndex = 9;
            this.dateP2.Value = new System.DateTime(2018, 3, 5, 11, 26, 36, 797);
            this.dateP2.onValueChanged += new System.EventHandler(this.dateP2_onValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(256, 365);
            this.Controls.Add(this.dateP2);
            this.Controls.Add(this.Día);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.txtNuevaFecha);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.dateP1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDatepicker dateP1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuDatepicker dateP2;
        private Bunifu.Framework.UI.BunifuCustomLabel Día;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtDia;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtNuevaFecha;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtHora;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel lblFecha;
    }
}

