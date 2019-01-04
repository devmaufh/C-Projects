namespace Segundo_Programa3_Orak
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
            this.Barra = new System.Windows.Forms.Panel();
            this.lbl1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnCierra = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.ListaResul = new System.Windows.Forms.ListBox();
            this.txtEntrada = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnCalcula = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblResul = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTema = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Temas = new Bunifu.Framework.UI.BunifuDropdown();
            this.Barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCierra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Barra
            // 
            this.Barra.BackColor = System.Drawing.Color.Brown;
            this.Barra.Controls.Add(this.lbl1);
            this.Barra.Controls.Add(this.btnCierra);
            this.Barra.Controls.Add(this.bunifuImageButton1);
            this.Barra.Dock = System.Windows.Forms.DockStyle.Top;
            this.Barra.ForeColor = System.Drawing.Color.Coral;
            this.Barra.Location = new System.Drawing.Point(0, 0);
            this.Barra.Name = "Barra";
            this.Barra.Size = new System.Drawing.Size(211, 44);
            this.Barra.TabIndex = 0;
            this.Barra.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.Barra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl1.Location = new System.Drawing.Point(3, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(124, 20);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Números primos";
            this.lbl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bunifuCustomLabel1_MouseMove);
            // 
            // btnCierra
            // 
            this.btnCierra.BackColor = System.Drawing.Color.Brown;
            this.btnCierra.Image = global::Segundo_Programa3_Orak.Properties.Resources.icons8_Delete_64px;
            this.btnCierra.ImageActive = null;
            this.btnCierra.Location = new System.Drawing.Point(167, 3);
            this.btnCierra.Name = "btnCierra";
            this.btnCierra.Size = new System.Drawing.Size(41, 37);
            this.btnCierra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCierra.TabIndex = 2;
            this.btnCierra.TabStop = false;
            this.btnCierra.Zoom = 20;
            this.btnCierra.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Brown;
            this.bunifuImageButton1.Image = global::Segundo_Programa3_Orak.Properties.Resources.icons8_Delete_64px;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(638, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(37, 37);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // ListaResul
            // 
            this.ListaResul.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaResul.ForeColor = System.Drawing.Color.Brown;
            this.ListaResul.FormattingEnabled = true;
            this.ListaResul.ItemHeight = 25;
            this.ListaResul.Location = new System.Drawing.Point(12, 197);
            this.ListaResul.Name = "ListaResul";
            this.ListaResul.Size = new System.Drawing.Size(186, 179);
            this.ListaResul.TabIndex = 1;
            // 
            // txtEntrada
            // 
            this.txtEntrada.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEntrada.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEntrada.ForeColor = System.Drawing.Color.Brown;
            this.txtEntrada.HintForeColor = System.Drawing.Color.Empty;
            this.txtEntrada.HintText = "Número";
            this.txtEntrada.isPassword = false;
            this.txtEntrada.LineFocusedColor = System.Drawing.Color.Brown;
            this.txtEntrada.LineIdleColor = System.Drawing.Color.Brown;
            this.txtEntrada.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.txtEntrada.LineThickness = 3;
            this.txtEntrada.Location = new System.Drawing.Point(12, 117);
            this.txtEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(186, 33);
            this.txtEntrada.TabIndex = 2;
            this.txtEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalcula
            // 
            this.btnCalcula.Activecolor = System.Drawing.Color.Brown;
            this.btnCalcula.BackColor = System.Drawing.Color.Brown;
            this.btnCalcula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalcula.BorderRadius = 0;
            this.btnCalcula.ButtonText = "Calcular";
            this.btnCalcula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcula.DisabledColor = System.Drawing.Color.Gray;
            this.btnCalcula.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCalcula.Iconimage = null;
            this.btnCalcula.Iconimage_right = null;
            this.btnCalcula.Iconimage_right_Selected = null;
            this.btnCalcula.Iconimage_Selected = null;
            this.btnCalcula.IconMarginLeft = 0;
            this.btnCalcula.IconMarginRight = 0;
            this.btnCalcula.IconRightVisible = true;
            this.btnCalcula.IconRightZoom = 0D;
            this.btnCalcula.IconVisible = true;
            this.btnCalcula.IconZoom = 90D;
            this.btnCalcula.IsTab = false;
            this.btnCalcula.Location = new System.Drawing.Point(12, 157);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Normalcolor = System.Drawing.Color.Brown;
            this.btnCalcula.OnHovercolor = System.Drawing.Color.Brown;
            this.btnCalcula.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCalcula.selected = false;
            this.btnCalcula.Size = new System.Drawing.Size(186, 34);
            this.btnCalcula.TabIndex = 3;
            this.btnCalcula.Text = "Calcular";
            this.btnCalcula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCalcula.Textcolor = System.Drawing.Color.White;
            this.btnCalcula.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcula.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // lblResul
            // 
            this.lblResul.AutoSize = true;
            this.lblResul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResul.ForeColor = System.Drawing.Color.Brown;
            this.lblResul.Location = new System.Drawing.Point(63, 379);
            this.lblResul.Name = "lblResul";
            this.lblResul.Size = new System.Drawing.Size(79, 16);
            this.lblResul.TabIndex = 4;
            this.lblResul.Text = "Numero par";
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTema.ForeColor = System.Drawing.Color.Brown;
            this.lblTema.Location = new System.Drawing.Point(83, 47);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(44, 16);
            this.lblTema.TabIndex = 6;
            this.lblTema.Text = "Tema";
            // 
            // Temas
            // 
            this.Temas.BackColor = System.Drawing.Color.Transparent;
            this.Temas.BorderRadius = 3;
            this.Temas.DisabledColor = System.Drawing.Color.Gray;
            this.Temas.ForeColor = System.Drawing.Color.White;
            this.Temas.Items = new string[] {
        "Brown",
        "SeaGreen",
        "Teal",
        "Indigo"};
            this.Temas.Location = new System.Drawing.Point(12, 66);
            this.Temas.Name = "Temas";
            this.Temas.NomalColor = System.Drawing.Color.Brown;
            this.Temas.onHoverColor = System.Drawing.Color.Brown;
            this.Temas.selectedIndex = 0;
            this.Temas.Size = new System.Drawing.Size(187, 31);
            this.Temas.TabIndex = 7;
            this.Temas.onItemSelected += new System.EventHandler(this.Temas_onItemSelected);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 437);
            this.Controls.Add(this.Temas);
            this.Controls.Add(this.lblTema);
            this.Controls.Add(this.lblResul);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.ListaResul);
            this.Controls.Add(this.Barra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Barra.ResumeLayout(false);
            this.Barra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCierra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel Barra;
        private Bunifu.Framework.UI.BunifuFlatButton btnCalcula;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEntrada;
        private System.Windows.Forms.ListBox ListaResul;
        private Bunifu.Framework.UI.BunifuImageButton btnCierra;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblResul;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTema;
        private Bunifu.Framework.UI.BunifuDropdown Temas;
    }
}

