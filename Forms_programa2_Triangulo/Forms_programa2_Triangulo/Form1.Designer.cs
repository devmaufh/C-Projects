namespace Forms_programa2_Triangulo
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
            this.txtBase = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtAltura = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnCalcular = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblArea = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblPerimetro = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnLimpiar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblError = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblP = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblA = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Separador = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txtBase
            // 
            this.txtBase.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBase.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBase.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtBase.HintForeColor = System.Drawing.Color.Empty;
            this.txtBase.HintText = "Base";
            this.txtBase.isPassword = false;
            this.txtBase.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.txtBase.LineIdleColor = System.Drawing.Color.SeaGreen;
            this.txtBase.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.txtBase.LineThickness = 3;
            this.txtBase.Location = new System.Drawing.Point(13, 85);
            this.txtBase.Margin = new System.Windows.Forms.Padding(4);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(116, 33);
            this.txtBase.TabIndex = 0;
            this.txtBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAltura
            // 
            this.txtAltura.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAltura.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAltura.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtAltura.HintForeColor = System.Drawing.Color.Empty;
            this.txtAltura.HintText = "Altura";
            this.txtAltura.isPassword = false;
            this.txtAltura.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.txtAltura.LineIdleColor = System.Drawing.Color.SeaGreen;
            this.txtAltura.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.txtAltura.LineThickness = 3;
            this.txtAltura.Location = new System.Drawing.Point(150, 85);
            this.txtAltura.Margin = new System.Windows.Forms.Padding(4);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(116, 33);
            this.txtAltura.TabIndex = 1;
            this.txtAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.bunifuImageButton3);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 32);
            this.panel1.TabIndex = 2;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuImageButton3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.ErrorImage")));
            this.bunifuImageButton3.Image = global::Forms_programa2_Triangulo.Properties.Resources.icons8_Trigonometry_52px;
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(3, 3);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(32, 26);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 13;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(41, 9);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(92, 13);
            this.bunifuCustomLabel2.TabIndex = 12;
            this.bunifuCustomLabel2.Text = "Area de triangulos";
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuImageButton2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.ErrorImage")));
            this.bunifuImageButton2.Image = global::Forms_programa2_Triangulo.Properties.Resources.icons8_Subtract_64px;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(507, 0);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(37, 33);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 11;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.Image = global::Forms_programa2_Triangulo.Properties.Resources.icons8_Delete_64px;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(550, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(37, 33);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 10;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
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
            this.btnCalcular.Iconimage = null;
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
            this.btnCalcular.Location = new System.Drawing.Point(12, 167);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCalcular.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCalcular.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCalcular.selected = false;
            this.btnCalcular.Size = new System.Drawing.Size(116, 46);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCalcular.Textcolor = System.Drawing.Color.White;
            this.btnCalcular.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblArea.Location = new System.Drawing.Point(475, 54);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(0, 16);
            this.lblArea.TabIndex = 4;
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimetro.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblPerimetro.Location = new System.Drawing.Point(345, 54);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(0, 16);
            this.lblPerimetro.TabIndex = 5;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiar.BorderRadius = 0;
            this.btnLimpiar.ButtonText = "Limpiar";
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.DisabledColor = System.Drawing.Color.Gray;
            this.btnLimpiar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLimpiar.Iconimage = null;
            this.btnLimpiar.Iconimage_right = null;
            this.btnLimpiar.Iconimage_right_Selected = null;
            this.btnLimpiar.Iconimage_Selected = null;
            this.btnLimpiar.IconMarginLeft = 0;
            this.btnLimpiar.IconMarginRight = 0;
            this.btnLimpiar.IconRightVisible = true;
            this.btnLimpiar.IconRightZoom = 0D;
            this.btnLimpiar.IconVisible = true;
            this.btnLimpiar.IconZoom = 90D;
            this.btnLimpiar.IsTab = false;
            this.btnLimpiar.Location = new System.Drawing.Point(150, 167);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLimpiar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnLimpiar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLimpiar.selected = false;
            this.btnLimpiar.Size = new System.Drawing.Size(116, 46);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLimpiar.Textcolor = System.Drawing.Color.White;
            this.btnLimpiar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblError.Location = new System.Drawing.Point(9, 216);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(129, 16);
            this.lblError.TabIndex = 7;
            this.lblError.Text = "bunifuCustomLabel1";
            this.lblError.Visible = false;
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP.Location = new System.Drawing.Point(273, 54);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(66, 16);
            this.lblP.TabIndex = 8;
            this.lblP.Text = "Perimetro";
            this.lblP.Visible = false;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(432, 54);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(37, 16);
            this.lblA.TabIndex = 9;
            this.lblA.Text = "Area";
            this.lblA.Visible = false;
            // 
            // pbImagen
            // 
            this.pbImagen.InitialImage = null;
            this.pbImagen.Location = new System.Drawing.Point(273, 85);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(300, 200);
            this.pbImagen.TabIndex = 10;
            this.pbImagen.TabStop = false;
            this.pbImagen.Click += new System.EventHandler(this.pbImagen_Click);
            this.pbImagen.Paint += new System.Windows.Forms.PaintEventHandler(this.pbImagen_Paint);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(92, 288);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(396, 15);
            this.bunifuCustomLabel1.TabIndex = 11;
            this.bunifuCustomLabel1.Text = "Nota: Asegurese de limpiar los datos antes de realizar un nuevo calculo";
            // 
            // Separador
            // 
            this.Separador.BackColor = System.Drawing.Color.Transparent;
            this.Separador.LineColor = System.Drawing.Color.SeaGreen;
            this.Separador.LineThickness = 2;
            this.Separador.Location = new System.Drawing.Point(273, 73);
            this.Separador.Name = "Separador";
            this.Separador.Size = new System.Drawing.Size(299, 10);
            this.Separador.TabIndex = 12;
            this.Separador.Transparency = 255;
            this.Separador.Vertical = false;
            this.Separador.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 309);
            this.Controls.Add(this.Separador);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBase;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAltura;
        private Bunifu.Framework.UI.BunifuFlatButton btnCalcular;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPerimetro;
        private Bunifu.Framework.UI.BunifuCustomLabel lblArea;
        private Bunifu.Framework.UI.BunifuFlatButton btnLimpiar;
        private Bunifu.Framework.UI.BunifuCustomLabel lblA;
        private Bunifu.Framework.UI.BunifuCustomLabel lblP;
        private Bunifu.Framework.UI.BunifuCustomLabel lblError;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.PictureBox pbImagen;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuSeparator Separador;
    }
}

