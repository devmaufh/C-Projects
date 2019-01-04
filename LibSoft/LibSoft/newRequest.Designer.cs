namespace LibSoft
{
    partial class newRequest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newRequest));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cbLibros = new System.Windows.Forms.ComboBox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnRegister = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // cbLibros
            // 
            this.cbLibros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(8)))), ((int)(((byte)(37)))));
            this.cbLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLibros.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cbLibros.ForeColor = System.Drawing.Color.White;
            this.cbLibros.FormattingEnabled = true;
            this.cbLibros.Location = new System.Drawing.Point(426, 69);
            this.cbLibros.Name = "cbLibros";
            this.cbLibros.Size = new System.Drawing.Size(187, 25);
            this.cbLibros.TabIndex = 0;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Crimson;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(8)))), ((int)(((byte)(37)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(8)))), ((int)(((byte)(37)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(625, 40);
            this.bunifuGradientPanel1.TabIndex = 1;
            this.bunifuGradientPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bunifuGradientPanel1_MouseMove);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.BackgroundImage = global::LibSoft.Properties.Resources.backButtonm7;
            this.bunifuImageButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuImageButton1.Image = global::LibSoft.Properties.Resources.icons8_Delete_96px_3;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(589, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(36, 40);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(423, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione el libro de la lista";
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.HintForeColor = System.Drawing.Color.Empty;
            this.txtName.HintText = "Nombre del solicitante";
            this.txtName.isPassword = false;
            this.txtName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(8)))), ((int)(((byte)(37)))));
            this.txtName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(8)))), ((int)(((byte)(37)))));
            this.txtName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(8)))), ((int)(((byte)(37)))));
            this.txtName.LineThickness = 3;
            this.txtName.Location = new System.Drawing.Point(13, 57);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(379, 37);
            this.txtName.TabIndex = 3;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRegister
            // 
            this.btnRegister.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegister.BorderRadius = 0;
            this.btnRegister.ButtonText = "Registrar";
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.DisabledColor = System.Drawing.Color.Gray;
            this.btnRegister.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRegister.Iconimage = null;
            this.btnRegister.Iconimage_right = null;
            this.btnRegister.Iconimage_right_Selected = null;
            this.btnRegister.Iconimage_Selected = null;
            this.btnRegister.IconMarginLeft = 0;
            this.btnRegister.IconMarginRight = 0;
            this.btnRegister.IconRightVisible = true;
            this.btnRegister.IconRightZoom = 0D;
            this.btnRegister.IconVisible = true;
            this.btnRegister.IconZoom = 90D;
            this.btnRegister.IsTab = false;
            this.btnRegister.Location = new System.Drawing.Point(426, 109);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRegister.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnRegister.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRegister.selected = false;
            this.btnRegister.Size = new System.Drawing.Size(187, 30);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Registrar";
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegister.Textcolor = System.Drawing.Color.White;
            this.btnRegister.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(3, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(250, 37);
            this.bunifuCustomLabel1.TabIndex = 6;
            this.bunifuCustomLabel1.Text = "Nueva petición";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // newRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 151);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.cbLibros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "newRequest";
            this.Text = "newRequest";
            this.Load += new System.EventHandler(this.newRequest_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ComboBox cbLibros;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtName;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnRegister;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}