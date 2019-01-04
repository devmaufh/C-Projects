namespace Forms_programa2_Saludo
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
            this.btnSaludar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLimpiar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblMostrar = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
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
            // btnSaludar
            // 
            this.btnSaludar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSaludar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.btnSaludar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaludar.BorderRadius = 0;
            this.btnSaludar.ButtonText = "Saludar";
            this.btnSaludar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaludar.DisabledColor = System.Drawing.Color.Gray;
            this.btnSaludar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSaludar.Iconimage = null;
            this.btnSaludar.Iconimage_right = null;
            this.btnSaludar.Iconimage_right_Selected = null;
            this.btnSaludar.Iconimage_Selected = null;
            this.btnSaludar.IconMarginLeft = 0;
            this.btnSaludar.IconMarginRight = 0;
            this.btnSaludar.IconRightVisible = true;
            this.btnSaludar.IconRightZoom = 0D;
            this.btnSaludar.IconVisible = true;
            this.btnSaludar.IconZoom = 90D;
            this.btnSaludar.IsTab = false;
            this.btnSaludar.Location = new System.Drawing.Point(12, 236);
            this.btnSaludar.Name = "btnSaludar";
            this.btnSaludar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.btnSaludar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(60)))), ((int)(((byte)(83)))));
            this.btnSaludar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSaludar.selected = false;
            this.btnSaludar.Size = new System.Drawing.Size(103, 29);
            this.btnSaludar.TabIndex = 0;
            this.btnSaludar.Text = "Saludar";
            this.btnSaludar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaludar.Textcolor = System.Drawing.Color.White;
            this.btnSaludar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaludar.Click += new System.EventHandler(this.btnSaludar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
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
            this.btnLimpiar.Location = new System.Drawing.Point(121, 236);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.btnLimpiar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(60)))), ((int)(((byte)(83)))));
            this.btnLimpiar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLimpiar.selected = false;
            this.btnLimpiar.Size = new System.Drawing.Size(103, 29);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLimpiar.Textcolor = System.Drawing.Color.White;
            this.btnLimpiar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(68, 50);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(103, 20);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "¡Hola Mundo!\r\n";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(38, 83);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(156, 20);
            this.bunifuCustomLabel2.TabIndex = 3;
            this.bunifuCustomLabel2.Text = "¿Cuál es tu nombre?";
            this.bunifuCustomLabel2.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
            // 
            // lblMostrar
            // 
            this.lblMostrar.AutoSize = true;
            this.lblMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMostrar.Location = new System.Drawing.Point(22, 174);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(0, 16);
            this.lblMostrar.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtName.Location = new System.Drawing.Point(42, 131);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(152, 20);
            this.txtName.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 34);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(3, 9);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(59, 20);
            this.bunifuCustomLabel3.TabIndex = 7;
            this.bunifuCustomLabel3.Text = "Saludo";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(211, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(32, 34);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 7;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(243, 327);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblMostrar);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSaludar);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnLimpiar;
        private Bunifu.Framework.UI.BunifuFlatButton btnSaludar;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtName;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMostrar;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
    }
}

