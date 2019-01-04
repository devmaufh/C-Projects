namespace Segundo_Programa2_xd
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtTabla = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblMulti = new System.Windows.Forms.ListBox();
            this.btnAceptar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSalir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.bunifuImageButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 36);
            this.panel2.TabIndex = 1;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuImageButton1.Image = global::Segundo_Programa2_xd.Properties.Resources.icons8_Delete_64px;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(191, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(31, 30);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 30;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // txtTabla
            // 
            this.txtTabla.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTabla.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTabla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTabla.HintForeColor = System.Drawing.Color.Empty;
            this.txtTabla.HintText = "";
            this.txtTabla.isPassword = false;
            this.txtTabla.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtTabla.LineIdleColor = System.Drawing.SystemColors.GrayText;
            this.txtTabla.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtTabla.LineThickness = 3;
            this.txtTabla.Location = new System.Drawing.Point(13, 55);
            this.txtTabla.Margin = new System.Windows.Forms.Padding(4);
            this.txtTabla.Name = "txtTabla";
            this.txtTabla.Size = new System.Drawing.Size(89, 33);
            this.txtTabla.TabIndex = 2;
            this.txtTabla.Text = "Número";
            this.txtTabla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMulti
            // 
            this.lblMulti.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblMulti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMulti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblMulti.FormattingEnabled = true;
            this.lblMulti.ItemHeight = 24;
            this.lblMulti.Location = new System.Drawing.Point(13, 95);
            this.lblMulti.Name = "lblMulti";
            this.lblMulti.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lblMulti.Size = new System.Drawing.Size(209, 216);
            this.lblMulti.TabIndex = 3;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAceptar.AllowDrop = true;
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceptar.BorderRadius = 0;
            this.btnAceptar.ButtonText = "Calcular";
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.DisabledColor = System.Drawing.Color.Gray;
            this.btnAceptar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAceptar.Iconimage = null;
            this.btnAceptar.Iconimage_right = null;
            this.btnAceptar.Iconimage_right_Selected = null;
            this.btnAceptar.Iconimage_Selected = null;
            this.btnAceptar.IconMarginLeft = 0;
            this.btnAceptar.IconMarginRight = 0;
            this.btnAceptar.IconRightVisible = true;
            this.btnAceptar.IconRightZoom = 0D;
            this.btnAceptar.IconVisible = true;
            this.btnAceptar.IconZoom = 90D;
            this.btnAceptar.IsTab = false;
            this.btnAceptar.Location = new System.Drawing.Point(132, 55);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAceptar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnAceptar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAceptar.selected = false;
            this.btnAceptar.Size = new System.Drawing.Size(90, 34);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Calcular";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAceptar.Textcolor = System.Drawing.Color.White;
            this.btnAceptar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSalir.AllowDrop = true;
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.BorderRadius = 0;
            this.btnSalir.ButtonText = "Salir";
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.DisabledColor = System.Drawing.Color.Gray;
            this.btnSalir.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSalir.Iconimage = null;
            this.btnSalir.Iconimage_right = null;
            this.btnSalir.Iconimage_right_Selected = null;
            this.btnSalir.Iconimage_Selected = null;
            this.btnSalir.IconMarginLeft = 0;
            this.btnSalir.IconMarginRight = 0;
            this.btnSalir.IconRightVisible = true;
            this.btnSalir.IconRightZoom = 0D;
            this.btnSalir.IconVisible = true;
            this.btnSalir.IconZoom = 90D;
            this.btnSalir.IsTab = false;
            this.btnSalir.Location = new System.Drawing.Point(132, 321);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSalir.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnSalir.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSalir.selected = false;
            this.btnSalir.Size = new System.Drawing.Size(90, 34);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalir.Textcolor = System.Drawing.Color.White;
            this.btnSalir.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(228, 367);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblMulti);
            this.Controls.Add(this.txtTabla);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTabla;
        private System.Windows.Forms.ListBox lblMulti;
        private Bunifu.Framework.UI.BunifuFlatButton btnAceptar;
        private Bunifu.Framework.UI.BunifuFlatButton btnSalir;
    }
}

