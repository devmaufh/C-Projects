namespace Deportes
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
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.cbCiudad = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkNinguno = new System.Windows.Forms.CheckBox();
            this.checkGolf = new System.Windows.Forms.CheckBox();
            this.checkTenis = new System.Windows.Forms.CheckBox();
            this.checkCiclismo = new System.Windows.Forms.CheckBox();
            this.checkBasket = new System.Windows.Forms.CheckBox();
            this.checkBeis = new System.Windows.Forms.CheckBox();
            this.checkFutbol = new System.Windows.Forms.CheckBox();
            this.checkNatacion = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_SexFem = new System.Windows.Forms.RadioButton();
            this.rbSex_Masculino = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rb_NivelAvanzado = new System.Windows.Forms.RadioButton();
            this.rbMedio = new System.Windows.Forms.RadioButton();
            this.rbNivel = new System.Windows.Forms.RadioButton();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.Color.White;
            this.txtCliente.Location = new System.Drawing.Point(63, 28);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCliente.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Edad";
            // 
            // txtEdad
            // 
            this.txtEdad.BackColor = System.Drawing.Color.White;
            this.txtEdad.Location = new System.Drawing.Point(63, 92);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 2;
            // 
            // cbCiudad
            // 
            this.cbCiudad.BackColor = System.Drawing.Color.White;
            this.cbCiudad.FormattingEnabled = true;
            this.cbCiudad.Location = new System.Drawing.Point(63, 152);
            this.cbCiudad.Name = "cbCiudad";
            this.cbCiudad.Size = new System.Drawing.Size(100, 21);
            this.cbCiudad.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ciudad:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox1.Controls.Add(this.checkNinguno);
            this.groupBox1.Controls.Add(this.checkGolf);
            this.groupBox1.Controls.Add(this.checkTenis);
            this.groupBox1.Controls.Add(this.checkCiclismo);
            this.groupBox1.Controls.Add(this.checkBasket);
            this.groupBox1.Controls.Add(this.checkBeis);
            this.groupBox1.Controls.Add(this.checkFutbol);
            this.groupBox1.Controls.Add(this.checkNatacion);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(184, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 145);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deportes";
            // 
            // checkNinguno
            // 
            this.checkNinguno.AutoSize = true;
            this.checkNinguno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkNinguno.Location = new System.Drawing.Point(111, 108);
            this.checkNinguno.Name = "checkNinguno";
            this.checkNinguno.Size = new System.Drawing.Size(73, 19);
            this.checkNinguno.TabIndex = 8;
            this.checkNinguno.Text = "Ninguno";
            this.checkNinguno.UseVisualStyleBackColor = true;
            this.checkNinguno.CheckedChanged += new System.EventHandler(this.checkNinguno_CheckedChanged);
            // 
            // checkGolf
            // 
            this.checkGolf.AutoSize = true;
            this.checkGolf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkGolf.Location = new System.Drawing.Point(111, 83);
            this.checkGolf.Name = "checkGolf";
            this.checkGolf.Size = new System.Drawing.Size(48, 19);
            this.checkGolf.TabIndex = 7;
            this.checkGolf.Text = "Golf";
            this.checkGolf.UseVisualStyleBackColor = true;
            // 
            // checkTenis
            // 
            this.checkTenis.AutoSize = true;
            this.checkTenis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTenis.Location = new System.Drawing.Point(111, 56);
            this.checkTenis.Name = "checkTenis";
            this.checkTenis.Size = new System.Drawing.Size(56, 19);
            this.checkTenis.TabIndex = 6;
            this.checkTenis.Text = "Tenis";
            this.checkTenis.UseVisualStyleBackColor = true;
            // 
            // checkCiclismo
            // 
            this.checkCiclismo.AutoSize = true;
            this.checkCiclismo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCiclismo.Location = new System.Drawing.Point(111, 30);
            this.checkCiclismo.Name = "checkCiclismo";
            this.checkCiclismo.Size = new System.Drawing.Size(73, 19);
            this.checkCiclismo.TabIndex = 4;
            this.checkCiclismo.Text = "Ciclismo";
            this.checkCiclismo.UseVisualStyleBackColor = true;
            // 
            // checkBasket
            // 
            this.checkBasket.AutoSize = true;
            this.checkBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBasket.Location = new System.Drawing.Point(5, 108);
            this.checkBasket.Name = "checkBasket";
            this.checkBasket.Size = new System.Drawing.Size(88, 19);
            this.checkBasket.TabIndex = 3;
            this.checkBasket.Text = "Basquetbol";
            this.checkBasket.UseVisualStyleBackColor = true;
            // 
            // checkBeis
            // 
            this.checkBeis.AutoSize = true;
            this.checkBeis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBeis.Location = new System.Drawing.Point(5, 83);
            this.checkBeis.Name = "checkBeis";
            this.checkBeis.Size = new System.Drawing.Size(68, 19);
            this.checkBeis.TabIndex = 2;
            this.checkBeis.Text = "BeisBol";
            this.checkBeis.UseVisualStyleBackColor = true;
            // 
            // checkFutbol
            // 
            this.checkFutbol.AutoSize = true;
            this.checkFutbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkFutbol.Location = new System.Drawing.Point(5, 56);
            this.checkFutbol.Name = "checkFutbol";
            this.checkFutbol.Size = new System.Drawing.Size(60, 19);
            this.checkFutbol.TabIndex = 1;
            this.checkFutbol.Text = "Fútbol";
            this.checkFutbol.UseVisualStyleBackColor = true;
            // 
            // checkNatacion
            // 
            this.checkNatacion.AutoSize = true;
            this.checkNatacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkNatacion.Location = new System.Drawing.Point(6, 30);
            this.checkNatacion.Name = "checkNatacion";
            this.checkNatacion.Size = new System.Drawing.Size(75, 19);
            this.checkNatacion.TabIndex = 0;
            this.checkNatacion.Text = "Natación";
            this.checkNatacion.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox2.Controls.Add(this.rb_SexFem);
            this.groupBox2.Controls.Add(this.rbSex_Masculino);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(387, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 49);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sexo";
            // 
            // rb_SexFem
            // 
            this.rb_SexFem.AutoSize = true;
            this.rb_SexFem.Location = new System.Drawing.Point(97, 19);
            this.rb_SexFem.Name = "rb_SexFem";
            this.rb_SexFem.Size = new System.Drawing.Size(71, 17);
            this.rb_SexFem.TabIndex = 1;
            this.rb_SexFem.TabStop = true;
            this.rb_SexFem.Text = "Femenino";
            this.rb_SexFem.UseVisualStyleBackColor = true;
            // 
            // rbSex_Masculino
            // 
            this.rbSex_Masculino.AutoSize = true;
            this.rbSex_Masculino.Location = new System.Drawing.Point(18, 19);
            this.rbSex_Masculino.Name = "rbSex_Masculino";
            this.rbSex_Masculino.Size = new System.Drawing.Size(73, 17);
            this.rbSex_Masculino.TabIndex = 0;
            this.rbSex_Masculino.TabStop = true;
            this.rbSex_Masculino.Text = "Masculino";
            this.rbSex_Masculino.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox3.Controls.Add(this.rb_NivelAvanzado);
            this.groupBox3.Controls.Add(this.rbMedio);
            this.groupBox3.Controls.Add(this.rbNivel);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(387, 83);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 90);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nivel";
            // 
            // rb_NivelAvanzado
            // 
            this.rb_NivelAvanzado.AutoSize = true;
            this.rb_NivelAvanzado.Location = new System.Drawing.Point(18, 67);
            this.rb_NivelAvanzado.Name = "rb_NivelAvanzado";
            this.rb_NivelAvanzado.Size = new System.Drawing.Size(73, 17);
            this.rb_NivelAvanzado.TabIndex = 4;
            this.rb_NivelAvanzado.TabStop = true;
            this.rb_NivelAvanzado.Text = "Avanzado";
            this.rb_NivelAvanzado.UseVisualStyleBackColor = true;
            // 
            // rbMedio
            // 
            this.rbMedio.AutoSize = true;
            this.rbMedio.Location = new System.Drawing.Point(18, 42);
            this.rbMedio.Name = "rbMedio";
            this.rbMedio.Size = new System.Drawing.Size(74, 17);
            this.rbMedio.TabIndex = 3;
            this.rbMedio.TabStop = true;
            this.rbMedio.Text = "Intermedio";
            this.rbMedio.UseVisualStyleBackColor = true;
            // 
            // rbNivel
            // 
            this.rbNivel.AutoSize = true;
            this.rbNivel.Location = new System.Drawing.Point(18, 19);
            this.rbNivel.Name = "rbNivel";
            this.rbNivel.Size = new System.Drawing.Size(80, 17);
            this.rbNivel.TabIndex = 2;
            this.rbNivel.TabStop = true;
            this.rbNivel.Text = "Principiante";
            this.rbNivel.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevo.Location = new System.Drawing.Point(512, 189);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegister.Location = new System.Drawing.Point(431, 189);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "Registrar";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(606, 225);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCiudad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deportics";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.ComboBox cbCiudad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkNinguno;
        private System.Windows.Forms.CheckBox checkGolf;
        private System.Windows.Forms.CheckBox checkTenis;
        private System.Windows.Forms.CheckBox checkCiclismo;
        private System.Windows.Forms.CheckBox checkBasket;
        private System.Windows.Forms.CheckBox checkBeis;
        private System.Windows.Forms.CheckBox checkFutbol;
        private System.Windows.Forms.CheckBox checkNatacion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_SexFem;
        private System.Windows.Forms.RadioButton rbSex_Masculino;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rb_NivelAvanzado;
        private System.Windows.Forms.RadioButton rbMedio;
        private System.Windows.Forms.RadioButton rbNivel;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnRegister;
    }
}

