namespace lirusisa
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.checkSalami = new Bunifu.Framework.UI.BunifuCheckbox();
            this.checkChampi = new Bunifu.Framework.UI.BunifuCheckbox();
            this.checkJamon = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.checkPeperoni = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.checkQuesoExtra = new Bunifu.Framework.UI.BunifuCheckbox();
            this.checkMorron = new Bunifu.Framework.UI.BunifuCheckbox();
            this.checkAjo = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.checkCebolla = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.rbGrande = new System.Windows.Forms.RadioButton();
            this.rbMediana = new System.Windows.Forms.RadioButton();
            this.rbChica = new System.Windows.Forms.RadioButton();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            this.rbpan_crujiente = new System.Windows.Forms.RadioButton();
            this.rbpan_delgado = new System.Windows.Forms.RadioButton();
            this.rbpan_OrillaQueso = new System.Windows.Forms.RadioButton();
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCards4 = new Bunifu.Framework.UI.BunifuCards();
            this.rbserv_ComerAqui = new System.Windows.Forms.RadioButton();
            this.rbser_Llevar = new System.Windows.Forms.RadioButton();
            this.bunifuCustomLabel14 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCards1.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            this.bunifuCards3.SuspendLayout();
            this.bunifuCards4.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 37);
            this.panel1.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtName.Location = new System.Drawing.Point(65, 65);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(189, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 68);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(47, 13);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Nombre:";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(280, 68);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(52, 13);
            this.bunifuCustomLabel2.TabIndex = 4;
            this.bunifuCustomLabel2.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(333, 65);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(75, 20);
            this.txtCantidad.TabIndex = 3;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.DarkSeaGreen;
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel11);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel7);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel8);
            this.bunifuCards1.Controls.Add(this.checkSalami);
            this.bunifuCards1.Controls.Add(this.checkChampi);
            this.bunifuCards1.Controls.Add(this.checkJamon);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel9);
            this.bunifuCards1.Controls.Add(this.checkPeperoni);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel10);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel6);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel5);
            this.bunifuCards1.Controls.Add(this.checkQuesoExtra);
            this.bunifuCards1.Controls.Add(this.checkMorron);
            this.bunifuCards1.Controls.Add(this.checkAjo);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel4);
            this.bunifuCards1.Controls.Add(this.checkCebolla);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel3);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(15, 125);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(239, 179);
            this.bunifuCards1.TabIndex = 5;
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(57, 14);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(119, 18);
            this.bunifuCustomLabel11.TabIndex = 6;
            this.bunifuCustomLabel11.Text = "INGREDIENTES";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(157, 142);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(50, 16);
            this.bunifuCustomLabel7.TabIndex = 20;
            this.bunifuCustomLabel7.Text = "Salami";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(157, 116);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(76, 16);
            this.bunifuCustomLabel8.TabIndex = 19;
            this.bunifuCustomLabel8.Text = "Champiñón";
            // 
            // checkSalami
            // 
            this.checkSalami.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkSalami.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkSalami.Checked = false;
            this.checkSalami.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkSalami.ForeColor = System.Drawing.Color.White;
            this.checkSalami.Location = new System.Drawing.Point(131, 142);
            this.checkSalami.Name = "checkSalami";
            this.checkSalami.Size = new System.Drawing.Size(20, 20);
            this.checkSalami.TabIndex = 18;
            // 
            // checkChampi
            // 
            this.checkChampi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkChampi.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkChampi.Checked = false;
            this.checkChampi.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkChampi.ForeColor = System.Drawing.Color.White;
            this.checkChampi.Location = new System.Drawing.Point(131, 116);
            this.checkChampi.Name = "checkChampi";
            this.checkChampi.Size = new System.Drawing.Size(20, 20);
            this.checkChampi.TabIndex = 17;
            // 
            // checkJamon
            // 
            this.checkJamon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkJamon.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkJamon.Checked = false;
            this.checkJamon.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkJamon.ForeColor = System.Drawing.Color.White;
            this.checkJamon.Location = new System.Drawing.Point(131, 90);
            this.checkJamon.Name = "checkJamon";
            this.checkJamon.Size = new System.Drawing.Size(20, 20);
            this.checkJamon.TabIndex = 16;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(157, 90);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(49, 16);
            this.bunifuCustomLabel9.TabIndex = 15;
            this.bunifuCustomLabel9.Text = "Jamón";
            // 
            // checkPeperoni
            // 
            this.checkPeperoni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkPeperoni.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkPeperoni.Checked = false;
            this.checkPeperoni.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkPeperoni.ForeColor = System.Drawing.Color.White;
            this.checkPeperoni.Location = new System.Drawing.Point(131, 65);
            this.checkPeperoni.Name = "checkPeperoni";
            this.checkPeperoni.Size = new System.Drawing.Size(20, 20);
            this.checkPeperoni.TabIndex = 13;
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(157, 65);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(63, 16);
            this.bunifuCustomLabel10.TabIndex = 14;
            this.bunifuCustomLabel10.Text = "Peperoni";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(35, 142);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(80, 16);
            this.bunifuCustomLabel6.TabIndex = 12;
            this.bunifuCustomLabel6.Text = "Queso extra";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(35, 116);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(50, 16);
            this.bunifuCustomLabel5.TabIndex = 11;
            this.bunifuCustomLabel5.Text = "Morrón";
            // 
            // checkQuesoExtra
            // 
            this.checkQuesoExtra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkQuesoExtra.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkQuesoExtra.Checked = false;
            this.checkQuesoExtra.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkQuesoExtra.ForeColor = System.Drawing.Color.White;
            this.checkQuesoExtra.Location = new System.Drawing.Point(9, 142);
            this.checkQuesoExtra.Name = "checkQuesoExtra";
            this.checkQuesoExtra.Size = new System.Drawing.Size(20, 20);
            this.checkQuesoExtra.TabIndex = 10;
            // 
            // checkMorron
            // 
            this.checkMorron.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkMorron.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkMorron.Checked = false;
            this.checkMorron.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkMorron.ForeColor = System.Drawing.Color.White;
            this.checkMorron.Location = new System.Drawing.Point(9, 116);
            this.checkMorron.Name = "checkMorron";
            this.checkMorron.Size = new System.Drawing.Size(20, 20);
            this.checkMorron.TabIndex = 9;
            // 
            // checkAjo
            // 
            this.checkAjo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkAjo.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkAjo.Checked = false;
            this.checkAjo.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkAjo.ForeColor = System.Drawing.Color.White;
            this.checkAjo.Location = new System.Drawing.Point(9, 90);
            this.checkAjo.Name = "checkAjo";
            this.checkAjo.Size = new System.Drawing.Size(20, 20);
            this.checkAjo.TabIndex = 8;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(35, 90);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(28, 16);
            this.bunifuCustomLabel4.TabIndex = 7;
            this.bunifuCustomLabel4.Text = "Ajo";
            // 
            // checkCebolla
            // 
            this.checkCebolla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkCebolla.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkCebolla.Checked = false;
            this.checkCebolla.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkCebolla.ForeColor = System.Drawing.Color.White;
            this.checkCebolla.Location = new System.Drawing.Point(9, 65);
            this.checkCebolla.Name = "checkCebolla";
            this.checkCebolla.Size = new System.Drawing.Size(20, 20);
            this.checkCebolla.TabIndex = 6;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(35, 65);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(55, 16);
            this.bunifuCustomLabel3.TabIndex = 6;
            this.bunifuCustomLabel3.Text = "Cebolla";
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.DarkSeaGreen;
            this.bunifuCards2.Controls.Add(this.rbGrande);
            this.bunifuCards2.Controls.Add(this.rbMediana);
            this.bunifuCards2.Controls.Add(this.rbChica);
            this.bunifuCards2.Controls.Add(this.bunifuCustomLabel12);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(283, 125);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(168, 179);
            this.bunifuCards2.TabIndex = 6;
            // 
            // rbGrande
            // 
            this.rbGrande.AutoSize = true;
            this.rbGrande.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGrande.Location = new System.Drawing.Point(44, 138);
            this.rbGrande.Name = "rbGrande";
            this.rbGrande.Size = new System.Drawing.Size(115, 22);
            this.rbGrande.TabIndex = 9;
            this.rbGrande.Text = "Grande  $150";
            this.rbGrande.UseVisualStyleBackColor = true;
            // 
            // rbMediana
            // 
            this.rbMediana.AutoSize = true;
            this.rbMediana.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMediana.Location = new System.Drawing.Point(44, 90);
            this.rbMediana.Name = "rbMediana";
            this.rbMediana.Size = new System.Drawing.Size(122, 22);
            this.rbMediana.TabIndex = 8;
            this.rbMediana.Text = "Mediana  $100";
            this.rbMediana.UseVisualStyleBackColor = true;
            // 
            // rbChica
            // 
            this.rbChica.AutoSize = true;
            this.rbChica.Checked = true;
            this.rbChica.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbChica.Location = new System.Drawing.Point(44, 42);
            this.rbChica.Name = "rbChica";
            this.rbChica.Size = new System.Drawing.Size(96, 22);
            this.rbChica.TabIndex = 7;
            this.rbChica.TabStop = true;
            this.rbChica.Text = "Chica  $80";
            this.rbChica.UseVisualStyleBackColor = true;
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(52, 14);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(63, 18);
            this.bunifuCustomLabel12.TabIndex = 6;
            this.bunifuCustomLabel12.Text = "Tamaño";
            // 
            // bunifuCards3
            // 
            this.bunifuCards3.BackColor = System.Drawing.Color.White;
            this.bunifuCards3.BorderRadius = 5;
            this.bunifuCards3.BottomSahddow = true;
            this.bunifuCards3.color = System.Drawing.Color.DarkSeaGreen;
            this.bunifuCards3.Controls.Add(this.rbpan_crujiente);
            this.bunifuCards3.Controls.Add(this.rbpan_delgado);
            this.bunifuCards3.Controls.Add(this.rbpan_OrillaQueso);
            this.bunifuCards3.Controls.Add(this.bunifuCustomLabel13);
            this.bunifuCards3.LeftSahddow = false;
            this.bunifuCards3.Location = new System.Drawing.Point(15, 310);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = true;
            this.bunifuCards3.ShadowDepth = 20;
            this.bunifuCards3.Size = new System.Drawing.Size(233, 129);
            this.bunifuCards3.TabIndex = 10;
            // 
            // rbpan_crujiente
            // 
            this.rbpan_crujiente.AutoSize = true;
            this.rbpan_crujiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbpan_crujiente.Location = new System.Drawing.Point(61, 98);
            this.rbpan_crujiente.Name = "rbpan_crujiente";
            this.rbpan_crujiente.Size = new System.Drawing.Size(84, 22);
            this.rbpan_crujiente.TabIndex = 9;
            this.rbpan_crujiente.Text = "Crujiente";
            this.rbpan_crujiente.UseVisualStyleBackColor = true;
            // 
            // rbpan_delgado
            // 
            this.rbpan_delgado.AutoSize = true;
            this.rbpan_delgado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbpan_delgado.Location = new System.Drawing.Point(61, 70);
            this.rbpan_delgado.Name = "rbpan_delgado";
            this.rbpan_delgado.Size = new System.Drawing.Size(81, 22);
            this.rbpan_delgado.TabIndex = 8;
            this.rbpan_delgado.Text = "Delgado";
            this.rbpan_delgado.UseVisualStyleBackColor = true;
            // 
            // rbpan_OrillaQueso
            // 
            this.rbpan_OrillaQueso.AutoSize = true;
            this.rbpan_OrillaQueso.Checked = true;
            this.rbpan_OrillaQueso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbpan_OrillaQueso.Location = new System.Drawing.Point(61, 42);
            this.rbpan_OrillaQueso.Name = "rbpan_OrillaQueso";
            this.rbpan_OrillaQueso.Size = new System.Drawing.Size(125, 22);
            this.rbpan_OrillaQueso.TabIndex = 7;
            this.rbpan_OrillaQueso.TabStop = true;
            this.rbpan_OrillaQueso.Text = "Orilla de queso";
            this.rbpan_OrillaQueso.UseVisualStyleBackColor = true;
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuCustomLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(77, 9);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(85, 18);
            this.bunifuCustomLabel13.TabIndex = 6;
            this.bunifuCustomLabel13.Text = "Tipo de pan";
            // 
            // bunifuCards4
            // 
            this.bunifuCards4.BackColor = System.Drawing.Color.White;
            this.bunifuCards4.BorderRadius = 5;
            this.bunifuCards4.BottomSahddow = true;
            this.bunifuCards4.color = System.Drawing.Color.DarkSeaGreen;
            this.bunifuCards4.Controls.Add(this.rbserv_ComerAqui);
            this.bunifuCards4.Controls.Add(this.rbser_Llevar);
            this.bunifuCards4.Controls.Add(this.bunifuCustomLabel14);
            this.bunifuCards4.LeftSahddow = false;
            this.bunifuCards4.Location = new System.Drawing.Point(283, 310);
            this.bunifuCards4.Name = "bunifuCards4";
            this.bunifuCards4.RightSahddow = true;
            this.bunifuCards4.ShadowDepth = 20;
            this.bunifuCards4.Size = new System.Drawing.Size(168, 129);
            this.bunifuCards4.TabIndex = 11;
            // 
            // rbserv_ComerAqui
            // 
            this.rbserv_ComerAqui.AutoSize = true;
            this.rbserv_ComerAqui.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbserv_ComerAqui.Location = new System.Drawing.Point(24, 88);
            this.rbserv_ComerAqui.Name = "rbserv_ComerAqui";
            this.rbserv_ComerAqui.Size = new System.Drawing.Size(135, 22);
            this.rbserv_ComerAqui.TabIndex = 8;
            this.rbserv_ComerAqui.Text = "Para comer aquí";
            this.rbserv_ComerAqui.UseVisualStyleBackColor = true;
            // 
            // rbser_Llevar
            // 
            this.rbser_Llevar.AutoSize = true;
            this.rbser_Llevar.Checked = true;
            this.rbser_Llevar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbser_Llevar.Location = new System.Drawing.Point(24, 42);
            this.rbser_Llevar.Name = "rbser_Llevar";
            this.rbser_Llevar.Size = new System.Drawing.Size(95, 22);
            this.rbser_Llevar.TabIndex = 7;
            this.rbser_Llevar.TabStop = true;
            this.rbser_Llevar.Text = "Para llevar";
            this.rbser_Llevar.UseVisualStyleBackColor = true;
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuCustomLabel14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(28, 9);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(112, 18);
            this.bunifuCustomLabel14.TabIndex = 6;
            this.bunifuCustomLabel14.Text = "Tipo de servicio";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.BorderRadius = 0;
            this.btnGuardar.ButtonText = "Ordenar";
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.DisabledColor = System.Drawing.Color.Gray;
            this.btnGuardar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGuardar.Iconimage = null;
            this.btnGuardar.Iconimage_right = null;
            this.btnGuardar.Iconimage_right_Selected = null;
            this.btnGuardar.Iconimage_Selected = null;
            this.btnGuardar.IconMarginLeft = 0;
            this.btnGuardar.IconMarginRight = 0;
            this.btnGuardar.IconRightVisible = true;
            this.btnGuardar.IconRightZoom = 0D;
            this.btnGuardar.IconVisible = true;
            this.btnGuardar.IconZoom = 90D;
            this.btnGuardar.IsTab = false;
            this.btnGuardar.Location = new System.Drawing.Point(283, 452);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGuardar.OnHovercolor = System.Drawing.Color.DarkSeaGreen;
            this.btnGuardar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGuardar.selected = false;
            this.btnGuardar.Size = new System.Drawing.Size(168, 37);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Ordenar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar.Textcolor = System.Drawing.Color.White;
            this.btnGuardar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 501);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.bunifuCards4);
            this.Controls.Add(this.bunifuCards3);
            this.Controls.Add(this.bunifuCards2);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            this.bunifuCards3.ResumeLayout(false);
            this.bunifuCards3.PerformLayout();
            this.bunifuCards4.ResumeLayout(false);
            this.bunifuCards4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuardar;
        private Bunifu.Framework.UI.BunifuCards bunifuCards4;
        private System.Windows.Forms.RadioButton rbserv_ComerAqui;
        private System.Windows.Forms.RadioButton rbser_Llevar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
        private System.Windows.Forms.RadioButton rbpan_crujiente;
        private System.Windows.Forms.RadioButton rbpan_delgado;
        private System.Windows.Forms.RadioButton rbpan_OrillaQueso;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private System.Windows.Forms.RadioButton rbGrande;
        private System.Windows.Forms.RadioButton rbMediana;
        private System.Windows.Forms.RadioButton rbChica;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCheckbox checkSalami;
        private Bunifu.Framework.UI.BunifuCheckbox checkChampi;
        private Bunifu.Framework.UI.BunifuCheckbox checkJamon;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuCheckbox checkPeperoni;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCheckbox checkQuesoExtra;
        private Bunifu.Framework.UI.BunifuCheckbox checkMorron;
        private Bunifu.Framework.UI.BunifuCheckbox checkAjo;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCheckbox checkCebolla;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.TextBox txtCantidad;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel panel1;
    }
}

