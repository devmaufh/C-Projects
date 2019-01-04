namespace Segundo_Programa_MENU
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.funcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.factorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cubiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.primoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.númeroALetraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seaGreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkSlateBlueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblResultado = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtNum = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.lblAccion = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.menuStrip1.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SeaGreen;
            this.menuStrip1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionesToolStripMenuItem,
            this.temaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(399, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menu";
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseMove);
            // 
            // funcionesToolStripMenuItem
            // 
            this.funcionesToolStripMenuItem.Checked = true;
            this.funcionesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.funcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.factorialToolStripMenuItem,
            this.cubiToolStripMenuItem,
            this.primoToolStripMenuItem,
            this.númeroALetraToolStripMenuItem,
            this.binarioToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.funcionesToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.funcionesToolStripMenuItem.Name = "funcionesToolStripMenuItem";
            this.funcionesToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.funcionesToolStripMenuItem.Text = "Funciones";
            this.funcionesToolStripMenuItem.Click += new System.EventHandler(this.funcionesToolStripMenuItem_Click);
            // 
            // factorialToolStripMenuItem
            // 
            this.factorialToolStripMenuItem.Name = "factorialToolStripMenuItem";
            this.factorialToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.factorialToolStripMenuItem.Text = "Factorial";
            this.factorialToolStripMenuItem.Click += new System.EventHandler(this.factorialToolStripMenuItem_Click);
            // 
            // cubiToolStripMenuItem
            // 
            this.cubiToolStripMenuItem.Name = "cubiToolStripMenuItem";
            this.cubiToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.cubiToolStripMenuItem.Text = "Cubo";
            this.cubiToolStripMenuItem.Click += new System.EventHandler(this.cubiToolStripMenuItem_Click);
            // 
            // primoToolStripMenuItem
            // 
            this.primoToolStripMenuItem.Name = "primoToolStripMenuItem";
            this.primoToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.primoToolStripMenuItem.Text = "Primo";
            this.primoToolStripMenuItem.Click += new System.EventHandler(this.primoToolStripMenuItem_Click);
            // 
            // númeroALetraToolStripMenuItem
            // 
            this.númeroALetraToolStripMenuItem.Name = "númeroALetraToolStripMenuItem";
            this.númeroALetraToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.númeroALetraToolStripMenuItem.Text = "Número a letra";
            this.númeroALetraToolStripMenuItem.Click += new System.EventHandler(this.númeroALetraToolStripMenuItem_Click);
            // 
            // binarioToolStripMenuItem
            // 
            this.binarioToolStripMenuItem.Name = "binarioToolStripMenuItem";
            this.binarioToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.binarioToolStripMenuItem.Text = "Binario";
            this.binarioToolStripMenuItem.Click += new System.EventHandler(this.binarioToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // temaToolStripMenuItem
            // 
            this.temaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seaGreenToolStripMenuItem,
            this.indigoToolStripMenuItem,
            this.darkSlateBlueToolStripMenuItem});
            this.temaToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.temaToolStripMenuItem.Name = "temaToolStripMenuItem";
            this.temaToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.temaToolStripMenuItem.Text = "Tema";
            // 
            // seaGreenToolStripMenuItem
            // 
            this.seaGreenToolStripMenuItem.CheckOnClick = true;
            this.seaGreenToolStripMenuItem.Image = global::Segundo_Programa_MENU.Properties.Resources.icons8_Filled_Circle_50px;
            this.seaGreenToolStripMenuItem.Name = "seaGreenToolStripMenuItem";
            this.seaGreenToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.seaGreenToolStripMenuItem.Text = "SeaGreen";
            this.seaGreenToolStripMenuItem.Click += new System.EventHandler(this.seaGreenToolStripMenuItem_Click);
            // 
            // indigoToolStripMenuItem
            // 
            this.indigoToolStripMenuItem.CheckOnClick = true;
            this.indigoToolStripMenuItem.Image = global::Segundo_Programa_MENU.Properties.Resources.icons8_Filled_Circle_50px_2;
            this.indigoToolStripMenuItem.Name = "indigoToolStripMenuItem";
            this.indigoToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.indigoToolStripMenuItem.Text = "Indigo";
            this.indigoToolStripMenuItem.Click += new System.EventHandler(this.indigoToolStripMenuItem_Click);
            // 
            // darkSlateBlueToolStripMenuItem
            // 
            this.darkSlateBlueToolStripMenuItem.CheckOnClick = true;
            this.darkSlateBlueToolStripMenuItem.Image = global::Segundo_Programa_MENU.Properties.Resources.icons8_Filled_Circle_50px_3;
            this.darkSlateBlueToolStripMenuItem.Name = "darkSlateBlueToolStripMenuItem";
            this.darkSlateBlueToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.darkSlateBlueToolStripMenuItem.Text = "DarkSlateBlue";
            this.darkSlateBlueToolStripMenuItem.Click += new System.EventHandler(this.darkSlateBlueToolStripMenuItem_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblResultado.Location = new System.Drawing.Point(38, 52);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 18);
            this.lblResultado.TabIndex = 3;
            // 
            // txtNum
            // 
            this.txtNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNum.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNum.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtNum.HintForeColor = System.Drawing.Color.Empty;
            this.txtNum.HintText = "Número";
            this.txtNum.isPassword = false;
            this.txtNum.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.txtNum.LineIdleColor = System.Drawing.Color.SeaGreen;
            this.txtNum.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.txtNum.LineThickness = 3;
            this.txtNum.Location = new System.Drawing.Point(13, 76);
            this.txtNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(138, 34);
            this.txtNum.TabIndex = 7;
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.AutoScroll = true;
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.SeaGreen;
            this.bunifuCards1.Controls.Add(this.lblAccion);
            this.bunifuCards1.Controls.Add(this.lblResultado);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(158, 40);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(229, 122);
            this.bunifuCards1.TabIndex = 8;
            // 
            // lblAccion
            // 
            this.lblAccion.AutoSize = true;
            this.lblAccion.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccion.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblAccion.Location = new System.Drawing.Point(3, 15);
            this.lblAccion.Name = "lblAccion";
            this.lblAccion.Size = new System.Drawing.Size(0, 18);
            this.lblAccion.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 178);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem funcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem factorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cubiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem primoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem númeroALetraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuCustomLabel lblResultado;
        private System.Windows.Forms.ToolStripMenuItem temaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seaGreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkSlateBlueToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNum;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblAccion;
        private System.Windows.Forms.ToolStripMenuItem binarioToolStripMenuItem;
    }
}

