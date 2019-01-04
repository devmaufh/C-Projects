namespace WindowsFormsApp1xd
{
    partial class Libros
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtName_libro = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNuevo = new System.Windows.Forms.RadioButton();
            this.rbExistente = new System.Windows.Forms.RadioButton();
            this.txtNameAutor = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbAutores = new System.Windows.Forms.ComboBox();
            this.txtApellidos_Autor = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnImagePicture = new System.Windows.Forms.Button();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pbImage_libro = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbEstantes = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtDescripcion_libro = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage_libro)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName_libro
            // 
            this.txtName_libro.Location = new System.Drawing.Point(131, 84);
            this.txtName_libro.Name = "txtName_libro";
            this.txtName_libro.Size = new System.Drawing.Size(173, 20);
            this.txtName_libro.TabIndex = 0;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuCustomLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(748, 36);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Registrar nuevo libro";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuCustomLabel10);
            this.panel1.Controls.Add(this.cbCategoria);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Controls.Add(this.btnImagePicture);
            this.panel1.Controls.Add(this.bunifuCustomLabel7);
            this.panel1.Controls.Add(this.pbImage_libro);
            this.panel1.Controls.Add(this.bunifuCustomLabel6);
            this.panel1.Controls.Add(this.bunifuCustomLabel5);
            this.panel1.Controls.Add(this.bunifuCustomLabel4);
            this.panel1.Controls.Add(this.cbEstantes);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.txtDescripcion_libro);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.txtName_libro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 495);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel10.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(3, 143);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(119, 26);
            this.bunifuCustomLabel10.TabIndex = 24;
            this.bunifuCustomLabel10.Text = "Categoría";
            this.bunifuCustomLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbCategoria
            // 
            this.cbCategoria.BackColor = System.Drawing.Color.Gray;
            this.cbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(131, 148);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(173, 21);
            this.cbCategoria.TabIndex = 23;
            this.cbCategoria.Text = "Seleccione una categoría";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNuevo);
            this.groupBox1.Controls.Add(this.rbExistente);
            this.groupBox1.Controls.Add(this.txtNameAutor);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel9);
            this.groupBox1.Controls.Add(this.cbAutores);
            this.groupBox1.Controls.Add(this.txtApellidos_Autor);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel8);
            this.groupBox1.Location = new System.Drawing.Point(462, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 244);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // rbNuevo
            // 
            this.rbNuevo.AutoSize = true;
            this.rbNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbNuevo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.rbNuevo.ForeColor = System.Drawing.Color.Gray;
            this.rbNuevo.Location = new System.Drawing.Point(64, 18);
            this.rbNuevo.Name = "rbNuevo";
            this.rbNuevo.Size = new System.Drawing.Size(84, 26);
            this.rbNuevo.TabIndex = 23;
            this.rbNuevo.TabStop = true;
            this.rbNuevo.Text = "Nuevo";
            this.rbNuevo.UseVisualStyleBackColor = true;
            this.rbNuevo.CheckedChanged += new System.EventHandler(this.rbNuevo_CheckedChanged);
            // 
            // rbExistente
            // 
            this.rbExistente.AutoSize = true;
            this.rbExistente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbExistente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.rbExistente.ForeColor = System.Drawing.Color.Gray;
            this.rbExistente.Location = new System.Drawing.Point(64, 152);
            this.rbExistente.Name = "rbExistente";
            this.rbExistente.Size = new System.Drawing.Size(112, 26);
            this.rbExistente.TabIndex = 24;
            this.rbExistente.TabStop = true;
            this.rbExistente.Text = "Existente";
            this.rbExistente.UseVisualStyleBackColor = true;
            this.rbExistente.CheckedChanged += new System.EventHandler(this.rbExistente_CheckedChanged);
            // 
            // txtNameAutor
            // 
            this.txtNameAutor.Location = new System.Drawing.Point(114, 58);
            this.txtNameAutor.Name = "txtNameAutor";
            this.txtNameAutor.Size = new System.Drawing.Size(84, 20);
            this.txtNameAutor.TabIndex = 8;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel9.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(9, 54);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(99, 25);
            this.bunifuCustomLabel9.TabIndex = 9;
            this.bunifuCustomLabel9.Text = "Nombre: ";
            this.bunifuCustomLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbAutores
            // 
            this.cbAutores.BackColor = System.Drawing.Color.Gray;
            this.cbAutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAutores.FormattingEnabled = true;
            this.cbAutores.Location = new System.Drawing.Point(12, 189);
            this.cbAutores.Name = "cbAutores";
            this.cbAutores.Size = new System.Drawing.Size(218, 21);
            this.cbAutores.TabIndex = 19;
            this.cbAutores.Text = "Seleccione un autor";
            // 
            // txtApellidos_Autor
            // 
            this.txtApellidos_Autor.Location = new System.Drawing.Point(114, 103);
            this.txtApellidos_Autor.Name = "txtApellidos_Autor";
            this.txtApellidos_Autor.Size = new System.Drawing.Size(84, 20);
            this.txtApellidos_Autor.TabIndex = 10;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel8.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(9, 99);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(99, 25);
            this.bunifuCustomLabel8.TabIndex = 11;
            this.bunifuCustomLabel8.Text = "Apellidos";
            this.bunifuCustomLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(462, 439);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(236, 32);
            this.btnRegistrar.TabIndex = 18;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnImagePicture
            // 
            this.btnImagePicture.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImagePicture.Location = new System.Drawing.Point(247, 217);
            this.btnImagePicture.Name = "btnImagePicture";
            this.btnImagePicture.Size = new System.Drawing.Size(57, 22);
            this.btnImagePicture.TabIndex = 17;
            this.btnImagePicture.Text = "Buscar...";
            this.btnImagePicture.UseVisualStyleBackColor = true;
            this.btnImagePicture.Click += new System.EventHandler(this.button1_Click);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel7.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(6, 217);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(247, 21);
            this.bunifuCustomLabel7.TabIndex = 16;
            this.bunifuCustomLabel7.Text = "Seleccione una imagen del libro";
            this.bunifuCustomLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbImage_libro
            // 
            this.pbImage_libro.InitialImage = global::WindowsFormsApp1xd.Properties.Resources.icons8_Book_520px_1;
            this.pbImage_libro.Location = new System.Drawing.Point(90, 245);
            this.pbImage_libro.Name = "pbImage_libro";
            this.pbImage_libro.Size = new System.Drawing.Size(214, 245);
            this.pbImage_libro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage_libro.TabIndex = 15;
            this.pbImage_libro.TabStop = false;
            this.pbImage_libro.Click += new System.EventHandler(this.pbImage_libro_Click);
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel6.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(387, 36);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(358, 21);
            this.bunifuCustomLabel6.TabIndex = 14;
            this.bunifuCustomLabel6.Text = "Información del autor";
            this.bunifuCustomLabel6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(3, 38);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(301, 21);
            this.bunifuCustomLabel5.TabIndex = 7;
            this.bunifuCustomLabel5.Text = "Información del libro";
            this.bunifuCustomLabel5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(3, 174);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(119, 37);
            this.bunifuCustomLabel4.TabIndex = 6;
            this.bunifuCustomLabel4.Text = "Número de estante:";
            this.bunifuCustomLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbEstantes
            // 
            this.cbEstantes.BackColor = System.Drawing.Color.Gray;
            this.cbEstantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEstantes.FormattingEnabled = true;
            this.cbEstantes.Location = new System.Drawing.Point(131, 190);
            this.cbEstantes.Name = "cbEstantes";
            this.cbEstantes.Size = new System.Drawing.Size(173, 21);
            this.cbEstantes.TabIndex = 5;
            this.cbEstantes.Text = "Seleccione un estante";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(6, 114);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(119, 25);
            this.bunifuCustomLabel3.TabIndex = 4;
            this.bunifuCustomLabel3.Text = "Descripción:";
            this.bunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDescripcion_libro
            // 
            this.txtDescripcion_libro.Location = new System.Drawing.Point(131, 118);
            this.txtDescripcion_libro.Name = "txtDescripcion_libro";
            this.txtDescripcion_libro.Size = new System.Drawing.Size(173, 20);
            this.txtDescripcion_libro.TabIndex = 3;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(6, 80);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(119, 25);
            this.bunifuCustomLabel2.TabIndex = 2;
            this.bunifuCustomLabel2.Text = "Nombre: ";
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Libros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Libros";
            this.Size = new System.Drawing.Size(748, 511);
            this.Load += new System.EventHandler(this.Libros_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage_libro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtName_libro;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private System.Windows.Forms.PictureBox pbImage_libro;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private System.Windows.Forms.TextBox txtApellidos_Autor;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private System.Windows.Forms.TextBox txtNameAutor;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.ComboBox cbEstantes;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.TextBox txtDescripcion_libro;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Button btnImagePicture;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNuevo;
        private System.Windows.Forms.RadioButton rbExistente;
        private System.Windows.Forms.ComboBox cbAutores;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private System.Windows.Forms.ComboBox cbCategoria;
    }
}
