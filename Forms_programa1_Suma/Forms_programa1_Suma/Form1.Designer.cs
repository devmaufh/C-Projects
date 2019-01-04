namespace Forms_programa1_Suma
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
            this.txtNum1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtNum2 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtResul = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnSuma = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnResta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMultiplicacion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDivision = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimiza = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimiza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txtNum1
            // 
            this.txtNum1.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(88)))), ((int)(((byte)(76)))));
            this.txtNum1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(14)))), ((int)(((byte)(0)))));
            this.txtNum1.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(88)))), ((int)(((byte)(76)))));
            this.txtNum1.BorderThickness = 3;
            this.txtNum1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNum1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNum1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNum1.isPassword = false;
            this.txtNum1.Location = new System.Drawing.Point(13, 58);
            this.txtNum1.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(80, 44);
            this.txtNum1.TabIndex = 14;
            this.txtNum1.Text = "Número 1";
            this.txtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNum2
            // 
            this.txtNum2.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(88)))), ((int)(((byte)(76)))));
            this.txtNum2.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(14)))), ((int)(((byte)(0)))));
            this.txtNum2.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(88)))), ((int)(((byte)(76)))));
            this.txtNum2.BorderThickness = 3;
            this.txtNum2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNum2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNum2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNum2.isPassword = false;
            this.txtNum2.Location = new System.Drawing.Point(101, 58);
            this.txtNum2.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(79, 44);
            this.txtNum2.TabIndex = 15;
            this.txtNum2.Text = "Número 2";
            this.txtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtResul
            // 
            this.txtResul.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(88)))), ((int)(((byte)(76)))));
            this.txtResul.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(14)))), ((int)(((byte)(0)))));
            this.txtResul.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(88)))), ((int)(((byte)(76)))));
            this.txtResul.BorderThickness = 3;
            this.txtResul.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtResul.Enabled = false;
            this.txtResul.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtResul.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtResul.isPassword = false;
            this.txtResul.Location = new System.Drawing.Point(188, 58);
            this.txtResul.Margin = new System.Windows.Forms.Padding(4);
            this.txtResul.Name = "txtResul";
            this.txtResul.Size = new System.Drawing.Size(83, 44);
            this.txtResul.TabIndex = 16;
            this.txtResul.Text = "Respuesta";
            this.txtResul.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSuma
            // 
            this.btnSuma.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(88)))), ((int)(((byte)(76)))));
            this.btnSuma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(14)))), ((int)(((byte)(0)))));
            this.btnSuma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuma.BorderRadius = 0;
            this.btnSuma.ButtonText = "+";
            this.btnSuma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuma.DisabledColor = System.Drawing.Color.Gray;
            this.btnSuma.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSuma.Iconimage = null;
            this.btnSuma.Iconimage_right = null;
            this.btnSuma.Iconimage_right_Selected = null;
            this.btnSuma.Iconimage_Selected = null;
            this.btnSuma.IconMarginLeft = 0;
            this.btnSuma.IconMarginRight = 0;
            this.btnSuma.IconRightVisible = true;
            this.btnSuma.IconRightZoom = 0D;
            this.btnSuma.IconVisible = true;
            this.btnSuma.IconZoom = 90D;
            this.btnSuma.IsTab = false;
            this.btnSuma.Location = new System.Drawing.Point(13, 119);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(14)))), ((int)(((byte)(0)))));
            this.btnSuma.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(88)))), ((int)(((byte)(76)))));
            this.btnSuma.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSuma.selected = false;
            this.btnSuma.Size = new System.Drawing.Size(61, 48);
            this.btnSuma.TabIndex = 17;
            this.btnSuma.Text = "+";
            this.btnSuma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSuma.Textcolor = System.Drawing.Color.White;
            this.btnSuma.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click_1);
            // 
            // btnResta
            // 
            this.btnResta.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(88)))), ((int)(((byte)(76)))));
            this.btnResta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(14)))), ((int)(((byte)(0)))));
            this.btnResta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnResta.BorderRadius = 0;
            this.btnResta.ButtonText = "-";
            this.btnResta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResta.DisabledColor = System.Drawing.Color.Gray;
            this.btnResta.Iconcolor = System.Drawing.Color.Transparent;
            this.btnResta.Iconimage = null;
            this.btnResta.Iconimage_right = null;
            this.btnResta.Iconimage_right_Selected = null;
            this.btnResta.Iconimage_Selected = null;
            this.btnResta.IconMarginLeft = 0;
            this.btnResta.IconMarginRight = 0;
            this.btnResta.IconRightVisible = true;
            this.btnResta.IconRightZoom = 0D;
            this.btnResta.IconVisible = true;
            this.btnResta.IconZoom = 90D;
            this.btnResta.IsTab = false;
            this.btnResta.Location = new System.Drawing.Point(80, 119);
            this.btnResta.Name = "btnResta";
            this.btnResta.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(14)))), ((int)(((byte)(0)))));
            this.btnResta.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(88)))), ((int)(((byte)(76)))));
            this.btnResta.OnHoverTextColor = System.Drawing.Color.White;
            this.btnResta.selected = false;
            this.btnResta.Size = new System.Drawing.Size(61, 48);
            this.btnResta.TabIndex = 18;
            this.btnResta.Text = "-";
            this.btnResta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnResta.Textcolor = System.Drawing.Color.White;
            this.btnResta.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click_1);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(88)))), ((int)(((byte)(76)))));
            this.btnMultiplicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(14)))), ((int)(((byte)(0)))));
            this.btnMultiplicacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMultiplicacion.BorderRadius = 0;
            this.btnMultiplicacion.ButtonText = "*";
            this.btnMultiplicacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMultiplicacion.DisabledColor = System.Drawing.Color.Gray;
            this.btnMultiplicacion.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMultiplicacion.Iconimage = null;
            this.btnMultiplicacion.Iconimage_right = null;
            this.btnMultiplicacion.Iconimage_right_Selected = null;
            this.btnMultiplicacion.Iconimage_Selected = null;
            this.btnMultiplicacion.IconMarginLeft = 0;
            this.btnMultiplicacion.IconMarginRight = 0;
            this.btnMultiplicacion.IconRightVisible = true;
            this.btnMultiplicacion.IconRightZoom = 0D;
            this.btnMultiplicacion.IconVisible = true;
            this.btnMultiplicacion.IconZoom = 90D;
            this.btnMultiplicacion.IsTab = false;
            this.btnMultiplicacion.Location = new System.Drawing.Point(147, 119);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(14)))), ((int)(((byte)(0)))));
            this.btnMultiplicacion.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(88)))), ((int)(((byte)(76)))));
            this.btnMultiplicacion.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMultiplicacion.selected = false;
            this.btnMultiplicacion.Size = new System.Drawing.Size(61, 48);
            this.btnMultiplicacion.TabIndex = 19;
            this.btnMultiplicacion.Text = "*";
            this.btnMultiplicacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMultiplicacion.Textcolor = System.Drawing.Color.White;
            this.btnMultiplicacion.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicacion.Click += new System.EventHandler(this.btnMultiplicacion_Click_1);
            // 
            // btnDivision
            // 
            this.btnDivision.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(88)))), ((int)(((byte)(76)))));
            this.btnDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(14)))), ((int)(((byte)(0)))));
            this.btnDivision.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDivision.BorderRadius = 0;
            this.btnDivision.ButtonText = "/";
            this.btnDivision.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDivision.DisabledColor = System.Drawing.Color.Gray;
            this.btnDivision.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDivision.Iconimage = null;
            this.btnDivision.Iconimage_right = null;
            this.btnDivision.Iconimage_right_Selected = null;
            this.btnDivision.Iconimage_Selected = null;
            this.btnDivision.IconMarginLeft = 0;
            this.btnDivision.IconMarginRight = 0;
            this.btnDivision.IconRightVisible = true;
            this.btnDivision.IconRightZoom = 0D;
            this.btnDivision.IconVisible = true;
            this.btnDivision.IconZoom = 90D;
            this.btnDivision.IsTab = false;
            this.btnDivision.Location = new System.Drawing.Point(213, 119);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(14)))), ((int)(((byte)(0)))));
            this.btnDivision.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(88)))), ((int)(((byte)(76)))));
            this.btnDivision.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDivision.selected = false;
            this.btnDivision.Size = new System.Drawing.Size(58, 48);
            this.btnDivision.TabIndex = 20;
            this.btnDivision.Text = "/";
            this.btnDivision.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDivision.Textcolor = System.Drawing.Color.White;
            this.btnDivision.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(14)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.btnMinimiza);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 35);
            this.panel1.TabIndex = 21;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(14)))), ((int)(((byte)(0)))));
            this.bunifuImageButton1.Enabled = false;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(0, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(33, 33);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 22;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // btnMinimiza
            // 
            this.btnMinimiza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(14)))), ((int)(((byte)(0)))));
            this.btnMinimiza.Image = global::Forms_programa1_Suma.Properties.Resources.icons8_Subtract_64px;
            this.btnMinimiza.ImageActive = null;
            this.btnMinimiza.Location = new System.Drawing.Point(205, 0);
            this.btnMinimiza.Name = "btnMinimiza";
            this.btnMinimiza.Size = new System.Drawing.Size(37, 28);
            this.btnMinimiza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimiza.TabIndex = 23;
            this.btnMinimiza.TabStop = false;
            this.btnMinimiza.Zoom = 10;
            this.btnMinimiza.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(14)))), ((int)(((byte)(0)))));
            this.btnClose.Image = global::Forms_programa1_Suma.Properties.Resources.icons8_Delete_64px;
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(239, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 28);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 22;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 183);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.txtResul);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimiza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton btnDivision;
        private Bunifu.Framework.UI.BunifuFlatButton btnMultiplicacion;
        private Bunifu.Framework.UI.BunifuFlatButton btnResta;
        private Bunifu.Framework.UI.BunifuFlatButton btnSuma;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtResul;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNum2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNum1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimiza;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}

