
namespace Segundo_Programa4_Factorial
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
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbTema = new Bunifu.Framework.UI.BunifuDropdown();
            this.cierrfac = new Bunifu.Framework.UI.BunifuImageButton();
            this.lista = new System.Windows.Forms.ListBox();
            this.txtFact = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnAcepta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cierrfac)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.cbTema);
            this.panel1.Controls.Add(this.cierrfac);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 42);
            this.panel1.TabIndex = 0;
            // 
            // cbTema
            // 
            this.cbTema.BackColor = System.Drawing.Color.SlateGray;
            this.cbTema.BorderRadius = 3;
            this.cbTema.DisabledColor = System.Drawing.Color.Gray;
            this.cbTema.ForeColor = System.Drawing.Color.White;
            this.cbTema.Items = new string[] {
        "Seleccione el tema",
        "DarkSlateBlue",
        "SeaGreen",
        "Teal"};
            this.cbTema.Location = new System.Drawing.Point(3, 4);
            this.cbTema.Name = "cbTema";
            this.cbTema.NomalColor = System.Drawing.Color.DarkSlateBlue;
            this.cbTema.onHoverColor = System.Drawing.Color.DarkSlateBlue;
            this.cbTema.selectedIndex = 0;
            this.cbTema.Size = new System.Drawing.Size(173, 35);
            this.cbTema.TabIndex = 1;
            this.cbTema.onItemSelected += new System.EventHandler(this.cbTema_onItemSelected);
            // 
            // cierrfac
            // 
            this.cierrfac.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.cierrfac.Image = global::Segundo_Programa4_Factorial.Properties.Resources.icons8_Delete_64px;
            this.cierrfac.ImageActive = null;
            this.cierrfac.Location = new System.Drawing.Point(302, 3);
            this.cierrfac.Name = "cierrfac";
            this.cierrfac.Size = new System.Drawing.Size(39, 36);
            this.cierrfac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cierrfac.TabIndex = 1;
            this.cierrfac.TabStop = false;
            this.cierrfac.Zoom = 20;
            this.cierrfac.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // lista
            // 
            this.lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lista.FormattingEnabled = true;
            this.lista.HorizontalScrollbar = true;
            this.lista.ItemHeight = 18;
            this.lista.Location = new System.Drawing.Point(13, 106);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(314, 202);
            this.lista.TabIndex = 1;
            this.lista.SelectedIndexChanged += new System.EventHandler(this.lista_SelectedIndexChanged);
            // 
            // txtFact
            // 
            this.txtFact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFact.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFact.HintForeColor = System.Drawing.Color.Empty;
            this.txtFact.HintText = "Número";
            this.txtFact.isPassword = false;
            this.txtFact.LineFocusedColor = System.Drawing.Color.DarkSlateBlue;
            this.txtFact.LineIdleColor = System.Drawing.Color.Gray;
            this.txtFact.LineMouseHoverColor = System.Drawing.Color.DarkSlateBlue;
            this.txtFact.LineThickness = 3;
            this.txtFact.Location = new System.Drawing.Point(13, 49);
            this.txtFact.Margin = new System.Windows.Forms.Padding(4);
            this.txtFact.Name = "txtFact";
            this.txtFact.Size = new System.Drawing.Size(163, 33);
            this.txtFact.TabIndex = 2;
            this.txtFact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFact.OnValueChanged += new System.EventHandler(this.txtFact_OnValueChanged);
            // 
            // btnAcepta
            // 
            this.btnAcepta.Activecolor = System.Drawing.Color.DarkSlateBlue;
            this.btnAcepta.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAcepta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAcepta.BorderRadius = 0;
            this.btnAcepta.ButtonText = "Aceptar";
            this.btnAcepta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcepta.DisabledColor = System.Drawing.Color.Gray;
            this.btnAcepta.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAcepta.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAcepta.Iconimage")));
            this.btnAcepta.Iconimage_right = null;
            this.btnAcepta.Iconimage_right_Selected = null;
            this.btnAcepta.Iconimage_Selected = null;
            this.btnAcepta.IconMarginLeft = 0;
            this.btnAcepta.IconMarginRight = 0;
            this.btnAcepta.IconRightVisible = true;
            this.btnAcepta.IconRightZoom = 0D;
            this.btnAcepta.IconVisible = true;
            this.btnAcepta.IconZoom = 90D;
            this.btnAcepta.IsTab = false;
            this.btnAcepta.Location = new System.Drawing.Point(183, 49);
            this.btnAcepta.Name = "btnAcepta";
            this.btnAcepta.Normalcolor = System.Drawing.Color.DarkSlateBlue;
            this.btnAcepta.OnHovercolor = System.Drawing.Color.DarkSlateBlue;
            this.btnAcepta.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAcepta.selected = false;
            this.btnAcepta.Size = new System.Drawing.Size(144, 33);
            this.btnAcepta.TabIndex = 3;
            this.btnAcepta.Text = "Aceptar";
            this.btnAcepta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcepta.Textcolor = System.Drawing.Color.White;
            this.btnAcepta.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcepta.Click += new System.EventHandler(this.btnAcepta_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(341, 330);
            this.Controls.Add(this.btnAcepta);
            this.Controls.Add(this.txtFact);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cierrfac)).EndInit();
            this.ResumeLayout(false);

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
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton cierrfac;
        private Bunifu.Framework.UI.BunifuDropdown cbTema;
        private System.Windows.Forms.ListBox lista;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFact;
        private Bunifu.Framework.UI.BunifuFlatButton btnAcepta;
    }
}

