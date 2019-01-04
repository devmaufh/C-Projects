namespace Aprende
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
            this.btnLoggout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnTABperfil = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTABsubir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTabHome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelAccount = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.cbVideosSubidos = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblEscuela = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCorreo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblNombre = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.p_gaugeClificacionVideo = new Bunifu.Framework.UI.BunifuGauge();
            this.P_lblDescric = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.p_lblDescripcionVideo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.p_lblCalificacion = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnContraseña = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnManualUso = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panelAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.btnLoggout);
            this.panel1.Controls.Add(this.bunifuTileButton1);
            this.panel1.Controls.Add(this.btnTABperfil);
            this.panel1.Controls.Add(this.btnTABsubir);
            this.panel1.Controls.Add(this.btnTabHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 454);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnLoggout
            // 
            this.btnLoggout.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnLoggout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnLoggout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoggout.BorderRadius = 0;
            this.btnLoggout.ButtonText = "Cerrar sesion";
            this.btnLoggout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoggout.DisabledColor = System.Drawing.Color.Gray;
            this.btnLoggout.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoggout.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLoggout.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLoggout.Iconimage")));
            this.btnLoggout.Iconimage_right = null;
            this.btnLoggout.Iconimage_right_Selected = null;
            this.btnLoggout.Iconimage_Selected = null;
            this.btnLoggout.IconMarginLeft = 0;
            this.btnLoggout.IconMarginRight = 0;
            this.btnLoggout.IconRightVisible = true;
            this.btnLoggout.IconRightZoom = 0D;
            this.btnLoggout.IconVisible = true;
            this.btnLoggout.IconZoom = 90D;
            this.btnLoggout.IsTab = true;
            this.btnLoggout.Location = new System.Drawing.Point(0, 317);
            this.btnLoggout.Name = "btnLoggout";
            this.btnLoggout.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnLoggout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnLoggout.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLoggout.selected = false;
            this.btnLoggout.Size = new System.Drawing.Size(162, 68);
            this.btnLoggout.TabIndex = 5;
            this.btnLoggout.Text = "Cerrar sesion";
            this.btnLoggout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLoggout.Textcolor = System.Drawing.Color.White;
            this.btnLoggout.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoggout.Click += new System.EventHandler(this.btnLoggout_Click);
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.bunifuTileButton1.color = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.bunifuTileButton1.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 20;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 41;
            this.bunifuTileButton1.LabelText = "Apren-D";
            this.bunifuTileButton1.Location = new System.Drawing.Point(0, 0);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(162, 128);
            this.bunifuTileButton1.TabIndex = 1;
            this.bunifuTileButton1.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // btnTABperfil
            // 
            this.btnTABperfil.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnTABperfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnTABperfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTABperfil.BorderRadius = 0;
            this.btnTABperfil.ButtonText = "Perfil";
            this.btnTABperfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTABperfil.DisabledColor = System.Drawing.Color.Gray;
            this.btnTABperfil.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTABperfil.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTABperfil.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTABperfil.Iconimage")));
            this.btnTABperfil.Iconimage_right = null;
            this.btnTABperfil.Iconimage_right_Selected = null;
            this.btnTABperfil.Iconimage_Selected = null;
            this.btnTABperfil.IconMarginLeft = 0;
            this.btnTABperfil.IconMarginRight = 0;
            this.btnTABperfil.IconRightVisible = true;
            this.btnTABperfil.IconRightZoom = 0D;
            this.btnTABperfil.IconVisible = true;
            this.btnTABperfil.IconZoom = 90D;
            this.btnTABperfil.IsTab = true;
            this.btnTABperfil.Location = new System.Drawing.Point(0, 252);
            this.btnTABperfil.Name = "btnTABperfil";
            this.btnTABperfil.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnTABperfil.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnTABperfil.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTABperfil.selected = false;
            this.btnTABperfil.Size = new System.Drawing.Size(162, 68);
            this.btnTABperfil.TabIndex = 4;
            this.btnTABperfil.Text = "Perfil";
            this.btnTABperfil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTABperfil.Textcolor = System.Drawing.Color.White;
            this.btnTABperfil.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTABperfil.Click += new System.EventHandler(this.btnTABperfil_Click);
            // 
            // btnTABsubir
            // 
            this.btnTABsubir.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnTABsubir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnTABsubir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTABsubir.BorderRadius = 0;
            this.btnTABsubir.ButtonText = "Subir";
            this.btnTABsubir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTABsubir.DisabledColor = System.Drawing.Color.Gray;
            this.btnTABsubir.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTABsubir.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTABsubir.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTABsubir.Iconimage")));
            this.btnTABsubir.Iconimage_right = null;
            this.btnTABsubir.Iconimage_right_Selected = null;
            this.btnTABsubir.Iconimage_Selected = null;
            this.btnTABsubir.IconMarginLeft = 0;
            this.btnTABsubir.IconMarginRight = 0;
            this.btnTABsubir.IconRightVisible = true;
            this.btnTABsubir.IconRightZoom = 0D;
            this.btnTABsubir.IconVisible = true;
            this.btnTABsubir.IconZoom = 90D;
            this.btnTABsubir.IsTab = true;
            this.btnTABsubir.Location = new System.Drawing.Point(0, 188);
            this.btnTABsubir.Name = "btnTABsubir";
            this.btnTABsubir.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnTABsubir.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnTABsubir.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTABsubir.selected = false;
            this.btnTABsubir.Size = new System.Drawing.Size(162, 68);
            this.btnTABsubir.TabIndex = 3;
            this.btnTABsubir.Text = "Subir";
            this.btnTABsubir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTABsubir.Textcolor = System.Drawing.Color.White;
            this.btnTABsubir.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTABsubir.Click += new System.EventHandler(this.btnTABsubir_Click);
            // 
            // btnTabHome
            // 
            this.btnTabHome.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnTabHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnTabHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTabHome.BorderRadius = 0;
            this.btnTabHome.ButtonText = "Home";
            this.btnTabHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTabHome.DisabledColor = System.Drawing.Color.Gray;
            this.btnTabHome.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabHome.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTabHome.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTabHome.Iconimage")));
            this.btnTabHome.Iconimage_right = null;
            this.btnTabHome.Iconimage_right_Selected = null;
            this.btnTabHome.Iconimage_Selected = null;
            this.btnTabHome.IconMarginLeft = 0;
            this.btnTabHome.IconMarginRight = 0;
            this.btnTabHome.IconRightVisible = true;
            this.btnTabHome.IconRightZoom = 0D;
            this.btnTabHome.IconVisible = true;
            this.btnTabHome.IconZoom = 90D;
            this.btnTabHome.IsTab = true;
            this.btnTabHome.Location = new System.Drawing.Point(0, 127);
            this.btnTabHome.Name = "btnTabHome";
            this.btnTabHome.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnTabHome.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnTabHome.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTabHome.selected = false;
            this.btnTabHome.Size = new System.Drawing.Size(162, 64);
            this.btnTabHome.TabIndex = 2;
            this.btnTabHome.Text = "Home";
            this.btnTabHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTabHome.Textcolor = System.Drawing.Color.White;
            this.btnTabHome.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabHome.Click += new System.EventHandler(this.btnTabHome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.btnMinimize);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(156, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(642, 34);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.Location = new System.Drawing.Point(563, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(38, 33);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(598, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 33);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // panelAccount
            // 
            this.panelAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.panelAccount.Controls.Add(this.btnManualUso);
            this.panelAccount.Controls.Add(this.btnContraseña);
            this.panelAccount.Controls.Add(this.p_lblCalificacion);
            this.panelAccount.Controls.Add(this.P_lblDescric);
            this.panelAccount.Controls.Add(this.p_lblDescripcionVideo);
            this.panelAccount.Controls.Add(this.p_gaugeClificacionVideo);
            this.panelAccount.Controls.Add(this.bunifuCustomLabel3);
            this.panelAccount.Controls.Add(this.bunifuSeparator1);
            this.panelAccount.Controls.Add(this.cbVideosSubidos);
            this.panelAccount.Controls.Add(this.bunifuCustomLabel4);
            this.panelAccount.Controls.Add(this.lblEscuela);
            this.panelAccount.Controls.Add(this.bunifuCustomLabel2);
            this.panelAccount.Controls.Add(this.lblCorreo);
            this.panelAccount.Controls.Add(this.bunifuCustomLabel1);
            this.panelAccount.Controls.Add(this.lblNombre);
            this.panelAccount.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAccount.Location = new System.Drawing.Point(156, 34);
            this.panelAccount.Name = "panelAccount";
            this.panelAccount.Size = new System.Drawing.Size(642, 420);
            this.panelAccount.TabIndex = 12;
            this.panelAccount.Visible = false;
            this.panelAccount.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAccount_Paint);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(390, 17);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(158, 24);
            this.bunifuCustomLabel3.TabIndex = 17;
            this.bunifuCustomLabel3.Text = "Videos subidos";
            this.bunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(298, 3);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(17, 414);
            this.bunifuSeparator1.TabIndex = 16;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // cbVideosSubidos
            // 
            this.cbVideosSubidos.BackColor = System.Drawing.Color.Transparent;
            this.cbVideosSubidos.BorderRadius = 1;
            this.cbVideosSubidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbVideosSubidos.DisabledColor = System.Drawing.Color.Gray;
            this.cbVideosSubidos.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.cbVideosSubidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.cbVideosSubidos.Items = new string[0];
            this.cbVideosSubidos.Location = new System.Drawing.Point(315, 45);
            this.cbVideosSubidos.Margin = new System.Windows.Forms.Padding(4);
            this.cbVideosSubidos.Name = "cbVideosSubidos";
            this.cbVideosSubidos.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.cbVideosSubidos.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.cbVideosSubidos.selectedIndex = -1;
            this.cbVideosSubidos.Size = new System.Drawing.Size(314, 35);
            this.cbVideosSubidos.TabIndex = 15;
            this.cbVideosSubidos.onItemSelected += new System.EventHandler(this.cbVideosSubidos_onItemSelected);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(108, 180);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(90, 25);
            this.bunifuCustomLabel4.TabIndex = 14;
            this.bunifuCustomLabel4.Text = "Escuela";
            // 
            // lblEscuela
            // 
            this.lblEscuela.AutoSize = true;
            this.lblEscuela.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscuela.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.lblEscuela.Location = new System.Drawing.Point(12, 207);
            this.lblEscuela.Name = "lblEscuela";
            this.lblEscuela.Size = new System.Drawing.Size(287, 22);
            this.lblEscuela.TabIndex = 13;
            this.lblEscuela.Text = "Instituto tecnologico de roque";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(108, 100);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(81, 25);
            this.bunifuCustomLabel2.TabIndex = 12;
            this.bunifuCustomLabel2.Text = "Correo";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.lblCorreo.Location = new System.Drawing.Point(15, 134);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(240, 22);
            this.lblCorreo.TabIndex = 11;
            this.lblCorreo.Text = "mau1361317@gmail.com";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(108, 32);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(95, 25);
            this.bunifuCustomLabel1.TabIndex = 10;
            this.bunifuCustomLabel1.Text = "Nombre";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.lblNombre.Location = new System.Drawing.Point(15, 61);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(248, 22);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Mauricio Flores Hernandez";
            // 
            // p_gaugeClificacionVideo
            // 
            this.p_gaugeClificacionVideo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p_gaugeClificacionVideo.BackgroundImage")));
            this.p_gaugeClificacionVideo.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.p_gaugeClificacionVideo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.p_gaugeClificacionVideo.Location = new System.Drawing.Point(364, 257);
            this.p_gaugeClificacionVideo.Margin = new System.Windows.Forms.Padding(6);
            this.p_gaugeClificacionVideo.Name = "p_gaugeClificacionVideo";
            this.p_gaugeClificacionVideo.ProgressBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.p_gaugeClificacionVideo.ProgressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.p_gaugeClificacionVideo.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.p_gaugeClificacionVideo.Size = new System.Drawing.Size(219, 157);
            this.p_gaugeClificacionVideo.Suffix = "";
            this.p_gaugeClificacionVideo.TabIndex = 18;
            this.p_gaugeClificacionVideo.Tag = "";
            this.p_gaugeClificacionVideo.Thickness = 30;
            this.p_gaugeClificacionVideo.Value = 40;
            this.p_gaugeClificacionVideo.Visible = false;
            // 
            // P_lblDescric
            // 
            this.P_lblDescric.AutoSize = true;
            this.P_lblDescric.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P_lblDescric.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.P_lblDescric.Location = new System.Drawing.Point(412, 102);
            this.P_lblDescric.Name = "P_lblDescric";
            this.P_lblDescric.Size = new System.Drawing.Size(116, 22);
            this.P_lblDescric.TabIndex = 21;
            this.P_lblDescric.Text = "Descripcion";
            this.P_lblDescric.Visible = false;
            // 
            // p_lblDescripcionVideo
            // 
            this.p_lblDescripcionVideo.AutoSize = true;
            this.p_lblDescripcionVideo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_lblDescripcionVideo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.p_lblDescripcionVideo.Location = new System.Drawing.Point(321, 127);
            this.p_lblDescripcionVideo.Name = "p_lblDescripcionVideo";
            this.p_lblDescripcionVideo.Size = new System.Drawing.Size(294, 17);
            this.p_lblDescripcionVideo.TabIndex = 20;
            this.p_lblDescripcionVideo.Text = "MMMMMMMMMMMMMMMMMMMMMMMMMM";
            this.p_lblDescripcionVideo.Visible = false;
            // 
            // p_lblCalificacion
            // 
            this.p_lblCalificacion.AutoSize = true;
            this.p_lblCalificacion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_lblCalificacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.p_lblCalificacion.Location = new System.Drawing.Point(411, 224);
            this.p_lblCalificacion.Name = "p_lblCalificacion";
            this.p_lblCalificacion.Size = new System.Drawing.Size(117, 22);
            this.p_lblCalificacion.TabIndex = 22;
            this.p_lblCalificacion.Text = "Calificacion";
            this.p_lblCalificacion.Visible = false;
            // 
            // btnContraseña
            // 
            this.btnContraseña.ActiveBorderThickness = 1;
            this.btnContraseña.ActiveCornerRadius = 20;
            this.btnContraseña.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnContraseña.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btnContraseña.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btnContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnContraseña.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnContraseña.BackgroundImage")));
            this.btnContraseña.ButtonText = "Recuperar contraseña";
            this.btnContraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnContraseña.IdleBorderThickness = 1;
            this.btnContraseña.IdleCornerRadius = 20;
            this.btnContraseña.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btnContraseña.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnContraseña.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnContraseña.Location = new System.Drawing.Point(8, 269);
            this.btnContraseña.Margin = new System.Windows.Forms.Padding(5);
            this.btnContraseña.Name = "btnContraseña";
            this.btnContraseña.Size = new System.Drawing.Size(291, 60);
            this.btnContraseña.TabIndex = 23;
            this.btnContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnManualUso
            // 
            this.btnManualUso.ActiveBorderThickness = 1;
            this.btnManualUso.ActiveCornerRadius = 20;
            this.btnManualUso.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnManualUso.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btnManualUso.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btnManualUso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnManualUso.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnManualUso.BackgroundImage")));
            this.btnManualUso.ButtonText = "Manual de uso";
            this.btnManualUso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManualUso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManualUso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnManualUso.IdleBorderThickness = 1;
            this.btnManualUso.IdleCornerRadius = 20;
            this.btnManualUso.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btnManualUso.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnManualUso.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnManualUso.Location = new System.Drawing.Point(8, 339);
            this.btnManualUso.Margin = new System.Windows.Forms.Padding(5);
            this.btnManualUso.Name = "btnManualUso";
            this.btnManualUso.Size = new System.Drawing.Size(291, 60);
            this.btnManualUso.TabIndex = 24;
            this.btnManualUso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(798, 454);
            this.Controls.Add(this.panelAccount);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panelAccount.ResumeLayout(false);
            this.panelAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnTABsubir;
        private Bunifu.Framework.UI.BunifuFlatButton btnTabHome;
        private Bunifu.Framework.UI.BunifuFlatButton btnTABperfil;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private Bunifu.Framework.UI.BunifuFlatButton btnLoggout;
        private System.Windows.Forms.Panel panelAccount;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEscuela;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCorreo;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNombre;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuDropdown cbVideosSubidos;
        private Bunifu.Framework.UI.BunifuGauge p_gaugeClificacionVideo;
        private Bunifu.Framework.UI.BunifuCustomLabel P_lblDescric;
        private Bunifu.Framework.UI.BunifuCustomLabel p_lblDescripcionVideo;
        private Bunifu.Framework.UI.BunifuCustomLabel p_lblCalificacion;
        private Bunifu.Framework.UI.BunifuThinButton2 btnManualUso;
        private Bunifu.Framework.UI.BunifuThinButton2 btnContraseña;
        // private DatosUser datosUser1;
    }
}

