namespace Forms_Programa3_Saludo
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
            this.checkPermiso = new Bunifu.Framework.UI.BunifuCheckbox();
            this.txtEdad = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblPermiso = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnVerifica = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // checkPermiso
            // 
            this.checkPermiso.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.checkPermiso.ChechedOffColor = System.Drawing.SystemColors.WindowFrame;
            this.checkPermiso.Checked = false;
            this.checkPermiso.CheckedOnColor = System.Drawing.Color.SeaGreen;
            this.checkPermiso.ForeColor = System.Drawing.Color.White;
            this.checkPermiso.Location = new System.Drawing.Point(176, 168);
            this.checkPermiso.Name = "checkPermiso";
            this.checkPermiso.Size = new System.Drawing.Size(20, 20);
            this.checkPermiso.TabIndex = 1;
            this.checkPermiso.Visible = false;
            // 
            // txtEdad
            // 
            this.txtEdad.BorderColorFocused = System.Drawing.Color.MediumSeaGreen;
            this.txtEdad.BorderColorIdle = System.Drawing.Color.SeaGreen;
            this.txtEdad.BorderColorMouseHover = System.Drawing.Color.MediumSeaGreen;
            this.txtEdad.BorderThickness = 3;
            this.txtEdad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEdad.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEdad.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtEdad.isPassword = false;
            this.txtEdad.Location = new System.Drawing.Point(13, 126);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(4);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(183, 35);
            this.txtEdad.TabIndex = 2;
            this.txtEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEdad.OnValueChanged += new System.EventHandler(this.txtEdad_OnValueChanged_1);
            // 
            // lblPermiso
            // 
            this.lblPermiso.AutoSize = true;
            this.lblPermiso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPermiso.Location = new System.Drawing.Point(54, 175);
            this.lblPermiso.Name = "lblPermiso";
            this.lblPermiso.Size = new System.Drawing.Size(113, 13);
            this.lblPermiso.TabIndex = 3;
            this.lblPermiso.Text = "Permiso de sus tutores";
            this.lblPermiso.Visible = false;
            this.lblPermiso.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // btnVerifica
            // 
            this.btnVerifica.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnVerifica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnVerifica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerifica.BorderRadius = 0;
            this.btnVerifica.ButtonText = "Verificar";
            this.btnVerifica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerifica.DisabledColor = System.Drawing.Color.Gray;
            this.btnVerifica.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVerifica.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnVerifica.Iconimage")));
            this.btnVerifica.Iconimage_right = null;
            this.btnVerifica.Iconimage_right_Selected = null;
            this.btnVerifica.Iconimage_Selected = null;
            this.btnVerifica.IconMarginLeft = 0;
            this.btnVerifica.IconMarginRight = 0;
            this.btnVerifica.IconRightVisible = true;
            this.btnVerifica.IconRightZoom = 0D;
            this.btnVerifica.IconVisible = true;
            this.btnVerifica.IconZoom = 90D;
            this.btnVerifica.IsTab = false;
            this.btnVerifica.Location = new System.Drawing.Point(57, 204);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnVerifica.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnVerifica.OnHoverTextColor = System.Drawing.Color.White;
            this.btnVerifica.selected = false;
            this.btnVerifica.Size = new System.Drawing.Size(139, 38);
            this.btnVerifica.TabIndex = 4;
            this.btnVerifica.Text = "Verificar";
            this.btnVerifica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerifica.Textcolor = System.Drawing.Color.White;
            this.btnVerifica.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerifica.Click += new System.EventHandler(this.btnVerifica_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(14, 109);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(32, 13);
            this.bunifuCustomLabel2.TabIndex = 5;
            this.bunifuCustomLabel2.Text = "Edad";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(14, 53);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(90, 13);
            this.bunifuCustomLabel3.TabIndex = 7;
            this.bunifuCustomLabel3.Text = "Nombre completo";
            // 
            // txtName
            // 
            this.txtName.BorderColorFocused = System.Drawing.Color.MediumSeaGreen;
            this.txtName.BorderColorIdle = System.Drawing.Color.SeaGreen;
            this.txtName.BorderColorMouseHover = System.Drawing.Color.MediumSeaGreen;
            this.txtName.BorderThickness = 3;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtName.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtName.isPassword = false;
            this.txtName.Location = new System.Drawing.Point(13, 70);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(183, 35);
            this.txtName.TabIndex = 6;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton2);
            this.bunifuGradientPanel1.Controls.Add(this.btnClose);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.SeaGreen;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.SeaGreen;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.SeaGreen;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.SeaGreen;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(213, 37);
            this.bunifuGradientPanel1.TabIndex = 8;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(148, 0);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(34, 37);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 1;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.SeaGreen;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(179, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 37);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 261);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.btnVerifica);
            this.Controls.Add(this.lblPermiso);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.checkPermiso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCheckbox checkPermiso;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtEdad;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPermiso;
        private Bunifu.Framework.UI.BunifuFlatButton btnVerifica;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
    }
}

