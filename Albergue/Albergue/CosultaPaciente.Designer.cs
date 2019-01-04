namespace Albergue
{
    partial class CosultaPaciente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.txtApellidoMAterno = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtApellidoPaterno = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.btnBuscaCurp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtCurp = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dataGridViewPacientes = new System.Windows.Forms.DataGridView();
            this.btnBuscaApellido = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTodo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCards1.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(3, 11);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(167, 18);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Buscar por nombre:";
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.bunifuCards1.Controls.Add(this.btnBuscaApellido);
            this.bunifuCards1.Controls.Add(this.txtApellidoMAterno);
            this.bunifuCards1.Controls.Add(this.txtApellidoPaterno);
            this.bunifuCards1.Controls.Add(this.txtNombre);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(3, 3);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(546, 83);
            this.bunifuCards1.TabIndex = 1;
            this.bunifuCards1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuCards1_Paint);
            // 
            // txtApellidoMAterno
            // 
            this.txtApellidoMAterno.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtApellidoMAterno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellidoMAterno.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoMAterno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.txtApellidoMAterno.HintForeColor = System.Drawing.Color.Empty;
            this.txtApellidoMAterno.HintText = "";
            this.txtApellidoMAterno.isPassword = false;
            this.txtApellidoMAterno.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.txtApellidoMAterno.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.txtApellidoMAterno.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.txtApellidoMAterno.LineThickness = 2;
            this.txtApellidoMAterno.Location = new System.Drawing.Point(283, 35);
            this.txtApellidoMAterno.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtApellidoMAterno.Name = "txtApellidoMAterno";
            this.txtApellidoMAterno.Size = new System.Drawing.Size(129, 35);
            this.txtApellidoMAterno.TabIndex = 4;
            this.txtApellidoMAterno.Text = "Apellido materno";
            this.txtApellidoMAterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtApellidoPaterno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellidoPaterno.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoPaterno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.txtApellidoPaterno.HintForeColor = System.Drawing.Color.Empty;
            this.txtApellidoPaterno.HintText = "";
            this.txtApellidoPaterno.isPassword = false;
            this.txtApellidoPaterno.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.txtApellidoPaterno.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.txtApellidoPaterno.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.txtApellidoPaterno.LineThickness = 2;
            this.txtApellidoPaterno.Location = new System.Drawing.Point(144, 35);
            this.txtApellidoPaterno.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(129, 35);
            this.txtApellidoPaterno.TabIndex = 3;
            this.txtApellidoPaterno.Text = "Apellido paterno";
            this.txtApellidoPaterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtApellidoPaterno.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.txtNombre.HintForeColor = System.Drawing.Color.Empty;
            this.txtNombre.HintText = "";
            this.txtNombre.isPassword = false;
            this.txtNombre.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.txtNombre.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.txtNombre.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.txtNombre.LineThickness = 2;
            this.txtNombre.Location = new System.Drawing.Point(5, 35);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(129, 35);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombre.OnValueChanged += new System.EventHandler(this.txtNombre_OnValueChanged);
            this.txtNombre.Click += new System.EventHandler(this.txtNombre_Click);
            this.txtNombre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bunifuMaterialTextbox1_MouseClick);
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.bunifuCards2.Controls.Add(this.btnBuscaCurp);
            this.bunifuCards2.Controls.Add(this.txtCurp);
            this.bunifuCards2.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(555, 3);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(263, 83);
            this.bunifuCards2.TabIndex = 2;
            // 
            // btnBuscaCurp
            // 
            this.btnBuscaCurp.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.btnBuscaCurp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.btnBuscaCurp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaCurp.BorderRadius = 0;
            this.btnBuscaCurp.ButtonText = "Buscar";
            this.btnBuscaCurp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscaCurp.DisabledColor = System.Drawing.Color.Gray;
            this.btnBuscaCurp.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBuscaCurp.Iconimage = null;
            this.btnBuscaCurp.Iconimage_right = null;
            this.btnBuscaCurp.Iconimage_right_Selected = null;
            this.btnBuscaCurp.Iconimage_Selected = null;
            this.btnBuscaCurp.IconMarginLeft = 0;
            this.btnBuscaCurp.IconMarginRight = 0;
            this.btnBuscaCurp.IconRightVisible = true;
            this.btnBuscaCurp.IconRightZoom = 0D;
            this.btnBuscaCurp.IconVisible = true;
            this.btnBuscaCurp.IconZoom = 90D;
            this.btnBuscaCurp.IsTab = false;
            this.btnBuscaCurp.Location = new System.Drawing.Point(180, 35);
            this.btnBuscaCurp.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnBuscaCurp.Name = "btnBuscaCurp";
            this.btnBuscaCurp.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.btnBuscaCurp.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(55)))));
            this.btnBuscaCurp.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBuscaCurp.selected = false;
            this.btnBuscaCurp.Size = new System.Drawing.Size(72, 35);
            this.btnBuscaCurp.TabIndex = 5;
            this.btnBuscaCurp.Text = "Buscar";
            this.btnBuscaCurp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscaCurp.Textcolor = System.Drawing.Color.White;
            this.btnBuscaCurp.TextFont = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnBuscaCurp.Click += new System.EventHandler(this.btnBuscaCurp_Click);
            // 
            // txtCurp
            // 
            this.txtCurp.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCurp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCurp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.txtCurp.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.txtCurp.HintText = "Curp";
            this.txtCurp.isPassword = false;
            this.txtCurp.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.txtCurp.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.txtCurp.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.txtCurp.LineThickness = 2;
            this.txtCurp.Location = new System.Drawing.Point(6, 35);
            this.txtCurp.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCurp.Name = "txtCurp";
            this.txtCurp.Size = new System.Drawing.Size(169, 35);
            this.txtCurp.TabIndex = 5;
            this.txtCurp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(3, 11);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(143, 18);
            this.bunifuCustomLabel2.TabIndex = 3;
            this.bunifuCustomLabel2.Text = "Buscar por curp:";
            // 
            // dataGridViewPacientes
            // 
            this.dataGridViewPacientes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewPacientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPacientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPacientes.GridColor = System.Drawing.Color.White;
            this.dataGridViewPacientes.Location = new System.Drawing.Point(9, 92);
            this.dataGridViewPacientes.Name = "dataGridViewPacientes";
            this.dataGridViewPacientes.ReadOnly = true;
            this.dataGridViewPacientes.Size = new System.Drawing.Size(798, 311);
            this.dataGridViewPacientes.TabIndex = 3;
            // 
            // btnBuscaApellido
            // 
            this.btnBuscaApellido.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.btnBuscaApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.btnBuscaApellido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaApellido.BorderRadius = 0;
            this.btnBuscaApellido.ButtonText = "Buscar";
            this.btnBuscaApellido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscaApellido.DisabledColor = System.Drawing.Color.Gray;
            this.btnBuscaApellido.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBuscaApellido.Iconimage = null;
            this.btnBuscaApellido.Iconimage_right = null;
            this.btnBuscaApellido.Iconimage_right_Selected = null;
            this.btnBuscaApellido.Iconimage_Selected = null;
            this.btnBuscaApellido.IconMarginLeft = 0;
            this.btnBuscaApellido.IconMarginRight = 0;
            this.btnBuscaApellido.IconRightVisible = true;
            this.btnBuscaApellido.IconRightZoom = 0D;
            this.btnBuscaApellido.IconVisible = true;
            this.btnBuscaApellido.IconZoom = 90D;
            this.btnBuscaApellido.IsTab = false;
            this.btnBuscaApellido.Location = new System.Drawing.Point(425, 35);
            this.btnBuscaApellido.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnBuscaApellido.Name = "btnBuscaApellido";
            this.btnBuscaApellido.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.btnBuscaApellido.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(55)))));
            this.btnBuscaApellido.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBuscaApellido.selected = false;
            this.btnBuscaApellido.Size = new System.Drawing.Size(100, 35);
            this.btnBuscaApellido.TabIndex = 4;
            this.btnBuscaApellido.Text = "Buscar";
            this.btnBuscaApellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscaApellido.Textcolor = System.Drawing.Color.White;
            this.btnBuscaApellido.TextFont = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnBuscaApellido.Click += new System.EventHandler(this.btnBuscaApellido_Click);
            // 
            // btnTodo
            // 
            this.btnTodo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.btnTodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.btnTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTodo.BorderRadius = 0;
            this.btnTodo.ButtonText = "Refrescar";
            this.btnTodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTodo.DisabledColor = System.Drawing.Color.Gray;
            this.btnTodo.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTodo.Iconimage = null;
            this.btnTodo.Iconimage_right = null;
            this.btnTodo.Iconimage_right_Selected = null;
            this.btnTodo.Iconimage_Selected = null;
            this.btnTodo.IconMarginLeft = 0;
            this.btnTodo.IconMarginRight = 0;
            this.btnTodo.IconRightVisible = true;
            this.btnTodo.IconRightZoom = 0D;
            this.btnTodo.IconVisible = true;
            this.btnTodo.IconZoom = 90D;
            this.btnTodo.IsTab = false;
            this.btnTodo.Location = new System.Drawing.Point(718, 412);
            this.btnTodo.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnTodo.Name = "btnTodo";
            this.btnTodo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.btnTodo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(55)))));
            this.btnTodo.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTodo.selected = false;
            this.btnTodo.Size = new System.Drawing.Size(100, 35);
            this.btnTodo.TabIndex = 5;
            this.btnTodo.Text = "Refrescar";
            this.btnTodo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTodo.Textcolor = System.Drawing.Color.White;
            this.btnTodo.TextFont = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnTodo.Click += new System.EventHandler(this.btnTodo_Click);
            // 
            // CosultaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTodo);
            this.Controls.Add(this.dataGridViewPacientes);
            this.Controls.Add(this.bunifuCards2);
            this.Controls.Add(this.bunifuCards1);
            this.Name = "CosultaPaciente";
            this.Size = new System.Drawing.Size(818, 447);
            this.Load += new System.EventHandler(this.CosultaPaciente_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNombre;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtApellidoPaterno;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtApellidoMAterno;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuFlatButton btnBuscaCurp;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCurp;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.DataGridView dataGridViewPacientes;
        private Bunifu.Framework.UI.BunifuFlatButton btnBuscaApellido;
        private Bunifu.Framework.UI.BunifuFlatButton btnTodo;
    }
}
