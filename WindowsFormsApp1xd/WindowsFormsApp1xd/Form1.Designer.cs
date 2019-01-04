namespace WindowsFormsApp1xd
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnPeticiones = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEstantes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCategorias = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAutores = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLibros = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.libros1 = new WindowsFormsApp1xd.Libros();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Location = new System.Drawing.Point(243, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 42);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel2.Controls.Add(this.btnPeticiones);
            this.panel2.Controls.Add(this.btnEstantes);
            this.panel2.Controls.Add(this.btnCategorias);
            this.panel2.Controls.Add(this.btnAutores);
            this.panel2.Controls.Add(this.btnLibros);
            this.panel2.Controls.Add(this.bunifuTileButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 560);
            this.panel2.TabIndex = 1;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(412, 315);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(428, 59);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "INSTITUTO TECNOLÓGICO DE ROQUE";
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.bunifuImageButton2.Enabled = false;
            this.bunifuImageButton2.ErrorImage = global::WindowsFormsApp1xd.Properties.Resources.icons8_Delete_96px_2;
            this.bunifuImageButton2.Image = global::WindowsFormsApp1xd.Properties.Resources.icons8_Books_512px;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(254, 147);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(734, 165);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 2;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // btnPeticiones
            // 
            this.btnPeticiones.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(77)))), ((int)(((byte)(85)))));
            this.btnPeticiones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnPeticiones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPeticiones.BorderRadius = 0;
            this.btnPeticiones.ButtonText = "Peticiones";
            this.btnPeticiones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPeticiones.DisabledColor = System.Drawing.Color.Gray;
            this.btnPeticiones.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPeticiones.Iconimage = global::WindowsFormsApp1xd.Properties.Resources.icons8_Book_Shelf_500px;
            this.btnPeticiones.Iconimage_right = null;
            this.btnPeticiones.Iconimage_right_Selected = null;
            this.btnPeticiones.Iconimage_Selected = null;
            this.btnPeticiones.IconMarginLeft = 0;
            this.btnPeticiones.IconMarginRight = 0;
            this.btnPeticiones.IconRightVisible = true;
            this.btnPeticiones.IconRightZoom = 0D;
            this.btnPeticiones.IconVisible = true;
            this.btnPeticiones.IconZoom = 90D;
            this.btnPeticiones.IsTab = true;
            this.btnPeticiones.Location = new System.Drawing.Point(6, 464);
            this.btnPeticiones.Name = "btnPeticiones";
            this.btnPeticiones.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnPeticiones.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(77)))), ((int)(((byte)(85)))));
            this.btnPeticiones.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnPeticiones.selected = false;
            this.btnPeticiones.Size = new System.Drawing.Size(224, 63);
            this.btnPeticiones.TabIndex = 5;
            this.btnPeticiones.Text = "Peticiones";
            this.btnPeticiones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPeticiones.Textcolor = System.Drawing.Color.Gray;
            this.btnPeticiones.TextFont = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnEstantes
            // 
            this.btnEstantes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(77)))), ((int)(((byte)(85)))));
            this.btnEstantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnEstantes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEstantes.BorderRadius = 0;
            this.btnEstantes.ButtonText = "Estantes";
            this.btnEstantes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstantes.DisabledColor = System.Drawing.Color.Gray;
            this.btnEstantes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEstantes.Iconimage = global::WindowsFormsApp1xd.Properties.Resources.icons8_Book_Shelf_500px;
            this.btnEstantes.Iconimage_right = null;
            this.btnEstantes.Iconimage_right_Selected = null;
            this.btnEstantes.Iconimage_Selected = null;
            this.btnEstantes.IconMarginLeft = 0;
            this.btnEstantes.IconMarginRight = 0;
            this.btnEstantes.IconRightVisible = true;
            this.btnEstantes.IconRightZoom = 0D;
            this.btnEstantes.IconVisible = true;
            this.btnEstantes.IconZoom = 90D;
            this.btnEstantes.IsTab = true;
            this.btnEstantes.Location = new System.Drawing.Point(12, 395);
            this.btnEstantes.Name = "btnEstantes";
            this.btnEstantes.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnEstantes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(77)))), ((int)(((byte)(85)))));
            this.btnEstantes.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnEstantes.selected = false;
            this.btnEstantes.Size = new System.Drawing.Size(224, 63);
            this.btnEstantes.TabIndex = 4;
            this.btnEstantes.Text = "Estantes";
            this.btnEstantes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEstantes.Textcolor = System.Drawing.Color.Gray;
            this.btnEstantes.TextFont = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnCategorias
            // 
            this.btnCategorias.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(77)))), ((int)(((byte)(85)))));
            this.btnCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnCategorias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCategorias.BorderRadius = 0;
            this.btnCategorias.ButtonText = "Categorias";
            this.btnCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategorias.DisabledColor = System.Drawing.Color.Gray;
            this.btnCategorias.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCategorias.Iconimage = global::WindowsFormsApp1xd.Properties.Resources.icons8_Category_512px;
            this.btnCategorias.Iconimage_right = null;
            this.btnCategorias.Iconimage_right_Selected = null;
            this.btnCategorias.Iconimage_Selected = null;
            this.btnCategorias.IconMarginLeft = 0;
            this.btnCategorias.IconMarginRight = 0;
            this.btnCategorias.IconRightVisible = true;
            this.btnCategorias.IconRightZoom = 0D;
            this.btnCategorias.IconVisible = true;
            this.btnCategorias.IconZoom = 90D;
            this.btnCategorias.IsTab = true;
            this.btnCategorias.Location = new System.Drawing.Point(12, 326);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnCategorias.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(77)))), ((int)(((byte)(85)))));
            this.btnCategorias.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnCategorias.selected = false;
            this.btnCategorias.Size = new System.Drawing.Size(224, 63);
            this.btnCategorias.TabIndex = 3;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCategorias.Textcolor = System.Drawing.Color.Gray;
            this.btnCategorias.TextFont = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnAutores
            // 
            this.btnAutores.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(77)))), ((int)(((byte)(85)))));
            this.btnAutores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnAutores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAutores.BorderRadius = 0;
            this.btnAutores.ButtonText = "Autores";
            this.btnAutores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutores.DisabledColor = System.Drawing.Color.Gray;
            this.btnAutores.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAutores.Iconimage = global::WindowsFormsApp1xd.Properties.Resources.icons8_Add_User_Male_500px;
            this.btnAutores.Iconimage_right = null;
            this.btnAutores.Iconimage_right_Selected = null;
            this.btnAutores.Iconimage_Selected = null;
            this.btnAutores.IconMarginLeft = 0;
            this.btnAutores.IconMarginRight = 0;
            this.btnAutores.IconRightVisible = true;
            this.btnAutores.IconRightZoom = 0D;
            this.btnAutores.IconVisible = true;
            this.btnAutores.IconZoom = 90D;
            this.btnAutores.IsTab = true;
            this.btnAutores.Location = new System.Drawing.Point(12, 257);
            this.btnAutores.Name = "btnAutores";
            this.btnAutores.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnAutores.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(77)))), ((int)(((byte)(85)))));
            this.btnAutores.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnAutores.selected = false;
            this.btnAutores.Size = new System.Drawing.Size(224, 63);
            this.btnAutores.TabIndex = 2;
            this.btnAutores.Text = "Autores";
            this.btnAutores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAutores.Textcolor = System.Drawing.Color.Gray;
            this.btnAutores.TextFont = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutores.Click += new System.EventHandler(this.btnAutores_Click);
            // 
            // btnLibros
            // 
            this.btnLibros.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(77)))), ((int)(((byte)(85)))));
            this.btnLibros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnLibros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLibros.BorderRadius = 0;
            this.btnLibros.ButtonText = "Libros";
            this.btnLibros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLibros.DisabledColor = System.Drawing.Color.Gray;
            this.btnLibros.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLibros.Iconimage = global::WindowsFormsApp1xd.Properties.Resources.icons8_Book_520px_1;
            this.btnLibros.Iconimage_right = null;
            this.btnLibros.Iconimage_right_Selected = null;
            this.btnLibros.Iconimage_Selected = null;
            this.btnLibros.IconMarginLeft = 0;
            this.btnLibros.IconMarginRight = 0;
            this.btnLibros.IconRightVisible = true;
            this.btnLibros.IconRightZoom = 0D;
            this.btnLibros.IconVisible = true;
            this.btnLibros.IconZoom = 90D;
            this.btnLibros.IsTab = true;
            this.btnLibros.Location = new System.Drawing.Point(12, 188);
            this.btnLibros.Name = "btnLibros";
            this.btnLibros.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnLibros.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(77)))), ((int)(((byte)(85)))));
            this.btnLibros.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnLibros.selected = false;
            this.btnLibros.Size = new System.Drawing.Size(224, 63);
            this.btnLibros.TabIndex = 1;
            this.btnLibros.Text = "Libros";
            this.btnLibros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLibros.Textcolor = System.Drawing.Color.Gray;
            this.btnLibros.TextFont = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibros.Click += new System.EventHandler(this.btnLibros_Click);
            this.btnLibros.MouseHover += new System.EventHandler(this.btnRegistroLibros_MouseHover);
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.bunifuTileButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuTileButton1.color = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.bunifuTileButton1.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = global::WindowsFormsApp1xd.Properties.Resources.icons8_Books_512px_5;
            this.bunifuTileButton1.ImagePosition = 20;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 41;
            this.bunifuTileButton1.LabelText = "";
            this.bunifuTileButton1.Location = new System.Drawing.Point(6, 6);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(236, 173);
            this.bunifuTileButton1.TabIndex = 0;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.bunifuImageButton1.ErrorImage = global::WindowsFormsApp1xd.Properties.Resources.icons8_Delete_96px_2;
            this.bunifuImageButton1.Image = global::WindowsFormsApp1xd.Properties.Resources.icons8_Delete_96px_4;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(723, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(32, 39);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 20;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // libros1
            // 
            this.libros1.Location = new System.Drawing.Point(255, 49);
            this.libros1.Name = "libros1";
            this.libros1.Size = new System.Drawing.Size(748, 511);
            this.libros1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1000, 560);
            this.Controls.Add(this.libros1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.Framework.UI.BunifuFlatButton btnLibros;
        private Bunifu.Framework.UI.BunifuFlatButton btnAutores;
        private Bunifu.Framework.UI.BunifuFlatButton btnCategorias;
        private Bunifu.Framework.UI.BunifuFlatButton btnEstantes;
        private Bunifu.Framework.UI.BunifuFlatButton btnPeticiones;
        private Libros libros1;
        // private Autores autores1;
    }
}

