namespace WindowsFormFlores_Mauricio
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
            this.txtA = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtC = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtB = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnCalcular = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtX1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtX2 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txtA
            // 
            this.txtA.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.txtA.BorderColorIdle = System.Drawing.Color.SeaGreen;
            this.txtA.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txtA.BorderThickness = 3;
            this.txtA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtA.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtA.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtA.isPassword = false;
            this.txtA.Location = new System.Drawing.Point(11, 70);
            this.txtA.Margin = new System.Windows.Forms.Padding(4);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(49, 44);
            this.txtA.TabIndex = 0;
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtC
            // 
            this.txtC.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.txtC.BorderColorIdle = System.Drawing.Color.SeaGreen;
            this.txtC.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txtC.BorderThickness = 3;
            this.txtC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtC.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtC.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtC.isPassword = false;
            this.txtC.Location = new System.Drawing.Point(125, 70);
            this.txtC.Margin = new System.Windows.Forms.Padding(4);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(49, 44);
            this.txtC.TabIndex = 1;
            this.txtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtB
            // 
            this.txtB.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.txtB.BorderColorIdle = System.Drawing.Color.SeaGreen;
            this.txtB.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txtB.BorderThickness = 3;
            this.txtB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtB.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtB.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtB.isPassword = false;
            this.txtB.Location = new System.Drawing.Point(68, 70);
            this.txtB.Margin = new System.Windows.Forms.Padding(4);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(49, 44);
            this.txtB.TabIndex = 2;
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalcular.BorderRadius = 0;
            this.btnCalcular.ButtonText = "Calcular";
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.DisabledColor = System.Drawing.Color.Gray;
            this.btnCalcular.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCalcular.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Iconimage")));
            this.btnCalcular.Iconimage_right = null;
            this.btnCalcular.Iconimage_right_Selected = null;
            this.btnCalcular.Iconimage_Selected = null;
            this.btnCalcular.IconMarginLeft = 0;
            this.btnCalcular.IconMarginRight = 0;
            this.btnCalcular.IconRightVisible = true;
            this.btnCalcular.IconRightZoom = 0D;
            this.btnCalcular.IconVisible = true;
            this.btnCalcular.IconZoom = 90D;
            this.btnCalcular.IsTab = false;
            this.btnCalcular.Location = new System.Drawing.Point(16, 131);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCalcular.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCalcular.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCalcular.selected = false;
            this.btnCalcular.Size = new System.Drawing.Size(158, 53);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.Textcolor = System.Drawing.Color.White;
            this.btnCalcular.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtX1
            // 
            this.txtX1.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.txtX1.BorderColorIdle = System.Drawing.Color.SeaGreen;
            this.txtX1.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txtX1.BorderThickness = 3;
            this.txtX1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtX1.Enabled = false;
            this.txtX1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtX1.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtX1.isPassword = false;
            this.txtX1.Location = new System.Drawing.Point(197, 70);
            this.txtX1.Margin = new System.Windows.Forms.Padding(4);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(107, 44);
            this.txtX1.TabIndex = 6;
            this.txtX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtX2
            // 
            this.txtX2.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.txtX2.BorderColorIdle = System.Drawing.Color.SeaGreen;
            this.txtX2.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txtX2.BorderThickness = 3;
            this.txtX2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtX2.Enabled = false;
            this.txtX2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtX2.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtX2.isPassword = false;
            this.txtX2.Location = new System.Drawing.Point(200, 140);
            this.txtX2.Margin = new System.Windows.Forms.Padding(4);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(104, 44);
            this.txtX2.TabIndex = 7;
            this.txtX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 46);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(41, 20);
            this.bunifuCustomLabel1.TabIndex = 5;
            this.bunifuCustomLabel1.Text = "ax^2";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(81, 46);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(25, 20);
            this.bunifuCustomLabel2.TabIndex = 8;
            this.bunifuCustomLabel2.Text = "bx";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(135, 46);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(17, 20);
            this.bunifuCustomLabel3.TabIndex = 9;
            this.bunifuCustomLabel3.Text = "c";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(239, 50);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(29, 20);
            this.bunifuCustomLabel4.TabIndex = 10;
            this.bunifuCustomLabel4.Text = "X1";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(235, 120);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(29, 20);
            this.bunifuCustomLabel5.TabIndex = 11;
            this.bunifuCustomLabel5.Text = "X2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 43);
            this.panel1.TabIndex = 12;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.DimGray;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(180, 50);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(13, 134);
            this.bunifuSeparator1.TabIndex = 13;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(289, 4);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(44, 36);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 217);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.txtX1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtB;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtC;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtA;
        private Bunifu.Framework.UI.BunifuFlatButton btnCalcular;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtX2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtX1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}

