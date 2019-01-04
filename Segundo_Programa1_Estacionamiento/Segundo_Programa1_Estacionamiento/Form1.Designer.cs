namespace Segundo_Programa1_Estacionamiento
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
            this.Barra = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtEn = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtS = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnAceptar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblEstancia = new System.Windows.Forms.Label();
            this.lblSalida = new System.Windows.Forms.Label();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.lblPPagar = new System.Windows.Forms.Label();
            this.lblResul = new System.Windows.Forms.Label();
            this.btnNuevo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Barra
            // 
            this.Barra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.Barra.Controls.Add(this.label1);
            this.Barra.Controls.Add(this.bunifuImageButton1);
            this.Barra.Controls.Add(this.btnClose);
            this.Barra.Dock = System.Windows.Forms.DockStyle.Top;
            this.Barra.Location = new System.Drawing.Point(0, 0);
            this.Barra.Name = "Barra";
            this.Barra.Size = new System.Drawing.Size(655, 32);
            this.Barra.TabIndex = 0;
            this.Barra.Paint += new System.Windows.Forms.PaintEventHandler(this.Barra_Paint);
            this.Barra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Barra_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Estacionamiento";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.bunifuImageButton1.Image = global::Segundo_Programa1_Estacionamiento.Properties.Resources.icons8_Car_32px;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(3, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(32, 24);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 20;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(617, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 24);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 30;
            this.btnClose.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // txtEn
            // 
            this.txtEn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEn.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEn.HintForeColor = System.Drawing.Color.Empty;
            this.txtEn.HintText = "Entrada ";
            this.txtEn.isPassword = false;
            this.txtEn.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.txtEn.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.txtEn.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.txtEn.LineThickness = 3;
            this.txtEn.Location = new System.Drawing.Point(13, 55);
            this.txtEn.Margin = new System.Windows.Forms.Padding(4);
            this.txtEn.Name = "txtEn";
            this.txtEn.Size = new System.Drawing.Size(159, 33);
            this.txtEn.TabIndex = 1;
            this.txtEn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtS
            // 
            this.txtS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtS.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtS.HintForeColor = System.Drawing.Color.Empty;
            this.txtS.HintText = "Salida";
            this.txtS.isPassword = false;
            this.txtS.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.txtS.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.txtS.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.txtS.LineThickness = 3;
            this.txtS.Location = new System.Drawing.Point(13, 121);
            this.txtS.Margin = new System.Windows.Forms.Padding(4);
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(159, 33);
            this.txtS.TabIndex = 2;
            this.txtS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
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
            this.btnAceptar.Location = new System.Drawing.Point(12, 195);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnAceptar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnAceptar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAceptar.selected = false;
            this.btnAceptar.Size = new System.Drawing.Size(159, 48);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Calcular";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAceptar.Textcolor = System.Drawing.Color.White;
            this.btnAceptar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Controls.Add(this.lblEstancia);
            this.panel1.Controls.Add(this.lblSalida);
            this.panel1.Controls.Add(this.lblEntrada);
            this.panel1.Controls.Add(this.lblPPagar);
            this.panel1.Controls.Add(this.lblResul);
            this.panel1.Location = new System.Drawing.Point(201, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 197);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblFecha.Location = new System.Drawing.Point(336, 170);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(97, 18);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "30/10/2014";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFecha.Visible = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(3, 114);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(430, 12);
            this.bunifuSeparator1.TabIndex = 5;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // lblEstancia
            // 
            this.lblEstancia.AutoSize = true;
            this.lblEstancia.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstancia.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblEstancia.Location = new System.Drawing.Point(3, 129);
            this.lblEstancia.Name = "lblEstancia";
            this.lblEstancia.Size = new System.Drawing.Size(373, 29);
            this.lblEstancia.TabIndex = 4;
            this.lblEstancia.Text = "Duracion 3 Horas con 30 minutos";
            this.lblEstancia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEstancia.Visible = false;
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalida.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblSalida.Location = new System.Drawing.Point(176, 54);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(57, 25);
            this.lblSalida.TabIndex = 3;
            this.lblSalida.Text = "Hola";
            this.lblSalida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSalida.Visible = false;
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrada.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblEntrada.Location = new System.Drawing.Point(6, 52);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(164, 25);
            this.lblEntrada.TabIndex = 2;
            this.lblEntrada.Text = "Hora de entrada";
            this.lblEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEntrada.Visible = false;
            // 
            // lblPPagar
            // 
            this.lblPPagar.AutoSize = true;
            this.lblPPagar.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPPagar.ForeColor = System.Drawing.Color.Black;
            this.lblPPagar.Location = new System.Drawing.Point(3, 9);
            this.lblPPagar.Name = "lblPPagar";
            this.lblPPagar.Size = new System.Drawing.Size(237, 43);
            this.lblPPagar.TabIndex = 1;
            this.lblPPagar.Text = "Pase a pagar:";
            this.lblPPagar.Visible = false;
            // 
            // lblResul
            // 
            this.lblResul.AutoSize = true;
            this.lblResul.Font = new System.Drawing.Font("Georgia", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResul.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblResul.Location = new System.Drawing.Point(244, 14);
            this.lblResul.Name = "lblResul";
            this.lblResul.Size = new System.Drawing.Size(189, 72);
            this.lblResul.TabIndex = 0;
            this.lblResul.Text = "Hola";
            this.lblResul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResul.Visible = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.BorderRadius = 0;
            this.btnNuevo.ButtonText = "Nuevo";
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.DisabledColor = System.Drawing.Color.Gray;
            this.btnNuevo.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNuevo.Iconimage = null;
            this.btnNuevo.Iconimage_right = null;
            this.btnNuevo.Iconimage_right_Selected = null;
            this.btnNuevo.Iconimage_Selected = null;
            this.btnNuevo.IconMarginLeft = 0;
            this.btnNuevo.IconMarginRight = 0;
            this.btnNuevo.IconRightVisible = true;
            this.btnNuevo.IconRightZoom = 0D;
            this.btnNuevo.IconVisible = true;
            this.btnNuevo.IconZoom = 90D;
            this.btnNuevo.IsTab = false;
            this.btnNuevo.Location = new System.Drawing.Point(13, 195);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnNuevo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnNuevo.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNuevo.selected = false;
            this.btnNuevo.Size = new System.Drawing.Size(158, 48);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNuevo.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btnNuevo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Visible = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(655, 266);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtS);
            this.Controls.Add(this.txtEn);
            this.Controls.Add(this.Barra);
            this.ForeColor = System.Drawing.Color.Gold;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Barra.ResumeLayout(false);
            this.Barra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Panel Barra;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEn;
        private Bunifu.Framework.UI.BunifuFlatButton btnAceptar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblResul;
        private System.Windows.Forms.Label lblPPagar;
        private Bunifu.Framework.UI.BunifuFlatButton btnNuevo;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Label lblEstancia;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label lblFecha;
    }
}

