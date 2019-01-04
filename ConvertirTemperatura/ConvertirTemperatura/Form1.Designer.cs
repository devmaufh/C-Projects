namespace ConvertirTemperatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.vScroll = new Bunifu.Framework.UI.BunifuVTrackbar();
            this.txtCentigrados = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtFare = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
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
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(76)))), ((int)(((byte)(68)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 43);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(251, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(44, 37);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // vScroll
            // 
            this.vScroll.BackColor = System.Drawing.Color.Transparent;
            this.vScroll.BackgroudColor = System.Drawing.Color.DarkGray;
            this.vScroll.BorderRadius = 0;
            this.vScroll.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.vScroll.Location = new System.Drawing.Point(51, 49);
            this.vScroll.MaximumValue = 100;
            this.vScroll.Name = "vScroll";
            this.vScroll.Size = new System.Drawing.Size(30, 257);
            this.vScroll.SliderRadius = 0;
            this.vScroll.TabIndex = 2;
            this.vScroll.Value = 50;
            this.vScroll.ValueChanged += new System.EventHandler(this.vScroll_ValueChanged);
            // 
            // txtCentigrados
            // 
            this.txtCentigrados.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.txtCentigrados.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCentigrados.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.txtCentigrados.BorderThickness = 3;
            this.txtCentigrados.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCentigrados.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCentigrados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.txtCentigrados.isPassword = false;
            this.txtCentigrados.Location = new System.Drawing.Point(151, 103);
            this.txtCentigrados.Margin = new System.Windows.Forms.Padding(4);
            this.txtCentigrados.Name = "txtCentigrados";
            this.txtCentigrados.Size = new System.Drawing.Size(102, 44);
            this.txtCentigrados.TabIndex = 3;
            this.txtCentigrados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(152, 75);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(111, 24);
            this.bunifuCustomLabel1.TabIndex = 4;
            this.bunifuCustomLabel1.Text = "Centígrados";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(152, 172);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(101, 24);
            this.bunifuCustomLabel2.TabIndex = 6;
            this.bunifuCustomLabel2.Text = "Fahrenheit";
            // 
            // txtFare
            // 
            this.txtFare.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.txtFare.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFare.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.txtFare.BorderThickness = 3;
            this.txtFare.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFare.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.txtFare.isPassword = false;
            this.txtFare.Location = new System.Drawing.Point(151, 200);
            this.txtFare.Margin = new System.Windows.Forms.Padding(4);
            this.txtFare.Name = "txtFare";
            this.txtFare.Size = new System.Drawing.Size(102, 44);
            this.txtFare.TabIndex = 5;
            this.txtFare.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(12, 46);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(40, 24);
            this.bunifuCustomLabel3.TabIndex = 7;
            this.bunifuCustomLabel3.Text = "100";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(12, 282);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(46, 24);
            this.bunifuCustomLabel4.TabIndex = 8;
            this.bunifuCustomLabel4.Text = "-100";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 318);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.txtFare);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtCentigrados);
            this.Controls.Add(this.vScroll);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuVTrackbar vScroll;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtFare;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCentigrados;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
    }
}

