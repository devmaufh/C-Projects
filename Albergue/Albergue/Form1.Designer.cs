namespace Albergue
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Logo = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnRegistro = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPagos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPacientes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cosultaPaciente1 = new Albergue.CosultaPaciente();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 33);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1012, -1);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(32, 34);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.Logo);
            this.panel2.Controls.Add(this.btnRegistro);
            this.panel2.Controls.Add(this.btnPagos);
            this.panel2.Controls.Add(this.btnPacientes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 473);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.Logo.color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.Logo.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.Logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.Logo.ForeColor = System.Drawing.Color.White;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.ImagePosition = 18;
            this.Logo.ImageZoom = 50;
            this.Logo.LabelPosition = 38;
            this.Logo.LabelText = "Clínica";
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Margin = new System.Windows.Forms.Padding(6);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(200, 132);
            this.Logo.TabIndex = 2;
            // 
            // btnRegistro
            // 
            this.btnRegistro.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.btnRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.btnRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistro.BorderRadius = 0;
            this.btnRegistro.ButtonText = "Editar";
            this.btnRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistro.DisabledColor = System.Drawing.Color.Gray;
            this.btnRegistro.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRegistro.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRegistro.Iconimage")));
            this.btnRegistro.Iconimage_right = null;
            this.btnRegistro.Iconimage_right_Selected = null;
            this.btnRegistro.Iconimage_Selected = null;
            this.btnRegistro.IconMarginLeft = 0;
            this.btnRegistro.IconMarginRight = 0;
            this.btnRegistro.IconRightVisible = true;
            this.btnRegistro.IconRightZoom = 0D;
            this.btnRegistro.IconVisible = true;
            this.btnRegistro.IconZoom = 90D;
            this.btnRegistro.IsTab = true;
            this.btnRegistro.Location = new System.Drawing.Point(0, 264);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.btnRegistro.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(55)))));
            this.btnRegistro.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRegistro.selected = false;
            this.btnRegistro.Size = new System.Drawing.Size(200, 66);
            this.btnRegistro.TabIndex = 4;
            this.btnRegistro.Text = "Editar";
            this.btnRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegistro.Textcolor = System.Drawing.Color.White;
            this.btnRegistro.TextFont = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnPagos
            // 
            this.btnPagos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.btnPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.btnPagos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPagos.BorderRadius = 0;
            this.btnPagos.ButtonText = "Pagos";
            this.btnPagos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagos.DisabledColor = System.Drawing.Color.Gray;
            this.btnPagos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPagos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPagos.Iconimage")));
            this.btnPagos.Iconimage_right = null;
            this.btnPagos.Iconimage_right_Selected = null;
            this.btnPagos.Iconimage_Selected = null;
            this.btnPagos.IconMarginLeft = 0;
            this.btnPagos.IconMarginRight = 0;
            this.btnPagos.IconRightVisible = true;
            this.btnPagos.IconRightZoom = 0D;
            this.btnPagos.IconVisible = true;
            this.btnPagos.IconZoom = 90D;
            this.btnPagos.IsTab = true;
            this.btnPagos.Location = new System.Drawing.Point(0, 201);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.btnPagos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(55)))));
            this.btnPagos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPagos.selected = false;
            this.btnPagos.Size = new System.Drawing.Size(200, 66);
            this.btnPagos.TabIndex = 3;
            this.btnPagos.Text = "Pagos";
            this.btnPagos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPagos.Textcolor = System.Drawing.Color.White;
            this.btnPagos.TextFont = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnPacientes
            // 
            this.btnPacientes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.btnPacientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.btnPacientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPacientes.BorderRadius = 0;
            this.btnPacientes.ButtonText = "Pacientes";
            this.btnPacientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPacientes.DisabledColor = System.Drawing.Color.Gray;
            this.btnPacientes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPacientes.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPacientes.Iconimage")));
            this.btnPacientes.Iconimage_right = null;
            this.btnPacientes.Iconimage_right_Selected = null;
            this.btnPacientes.Iconimage_Selected = null;
            this.btnPacientes.IconMarginLeft = 0;
            this.btnPacientes.IconMarginRight = 0;
            this.btnPacientes.IconRightVisible = true;
            this.btnPacientes.IconRightZoom = 0D;
            this.btnPacientes.IconVisible = true;
            this.btnPacientes.IconZoom = 90D;
            this.btnPacientes.IsTab = true;
            this.btnPacientes.Location = new System.Drawing.Point(0, 138);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.btnPacientes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(55)))));
            this.btnPacientes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPacientes.selected = true;
            this.btnPacientes.Size = new System.Drawing.Size(200, 66);
            this.btnPacientes.TabIndex = 2;
            this.btnPacientes.Text = "Pacientes";
            this.btnPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPacientes.Textcolor = System.Drawing.Color.White;
            this.btnPacientes.TextFont = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // cosultaPaciente1
            // 
            this.cosultaPaciente1.Location = new System.Drawing.Point(210, 40);
            this.cosultaPaciente1.Name = "cosultaPaciente1";
            this.cosultaPaciente1.Size = new System.Drawing.Size(818, 447);
            this.cosultaPaciente1.TabIndex = 2;
            this.cosultaPaciente1.Load += new System.EventHandler(this.cosultaPaciente1_Load_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 506);
            this.Controls.Add(this.cosultaPaciente1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuFlatButton btnPacientes;
        private Bunifu.Framework.UI.BunifuFlatButton btnPagos;
        private Bunifu.Framework.UI.BunifuFlatButton btnRegistro;
        private Bunifu.Framework.UI.BunifuTileButton Logo;
        private CosultaPaciente cosultaPaciente1;
    }
}

