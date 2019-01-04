namespace Forms_programa_Residui
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
            this.txtCantidad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnCalcular = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lvResultado = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantidad.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCantidad.ForeColor = System.Drawing.Color.DimGray;
            this.txtCantidad.HintForeColor = System.Drawing.Color.Empty;
            this.txtCantidad.HintText = "Cantidad";
            this.txtCantidad.isPassword = false;
            this.txtCantidad.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.txtCantidad.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.txtCantidad.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.txtCantidad.LineThickness = 3;
            this.txtCantidad.Location = new System.Drawing.Point(26, 77);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(146, 33);
            this.txtCantidad.TabIndex = 0;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCantidad.OnValueChanged += new System.EventHandler(this.txtCantidad_OnValueChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
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
            this.btnCalcular.Location = new System.Drawing.Point(26, 117);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.btnCalcular.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(57)))), ((int)(((byte)(78)))));
            this.btnCalcular.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCalcular.selected = false;
            this.btnCalcular.Size = new System.Drawing.Size(146, 31);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCalcular.Textcolor = System.Drawing.Color.White;
            this.btnCalcular.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lvResultado
            // 
            this.lvResultado.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lvResultado.ForeColor = System.Drawing.Color.DimGray;
            this.lvResultado.GridLines = true;
            this.lvResultado.Location = new System.Drawing.Point(26, 154);
            this.lvResultado.Name = "lvResultado";
            this.lvResultado.Size = new System.Drawing.Size(146, 203);
            this.lvResultado.TabIndex = 2;
            this.lvResultado.UseCompatibleStateImageBehavior = false;
            this.lvResultado.View = System.Windows.Forms.View.List;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 40);
            this.panel1.TabIndex = 3;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(175, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(35, 37);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 4;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(3, 9);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(68, 20);
            this.bunifuCustomLabel3.TabIndex = 8;
            this.bunifuCustomLabel3.Text = "Residuo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(213, 386);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lvResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtCantidad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCantidad;
        private Bunifu.Framework.UI.BunifuFlatButton btnCalcular;
        private System.Windows.Forms.ListView lvResultado;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
    }
}

