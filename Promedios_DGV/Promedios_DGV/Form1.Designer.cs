namespace Promedios_DGV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_test = new System.Windows.Forms.Button();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgvDatos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calificaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCalificacion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_promedio = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.gauge_Promedio = new Bunifu.Framework.UI.BunifuGauge();
            this.lbl_NO1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dEst = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMax = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnProm = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_Desviaci = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnGrafico2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbl_Desv_Estandar = new System.Windows.Forms.Label();
            this.btnPercent = new Bunifu.Framework.UI.BunifuFlatButton();
            this.G_Desv_Est = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel_Min = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblMin_name = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_No4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.gauge_Min = new Bunifu.Framework.UI.BunifuGauge();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel_Max = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblMax_Name = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_No3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Gauge_Max = new Bunifu.Framework.UI.BunifuGauge();
            this.lbl_NO2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel_promedio.SuspendLayout();
            this.panel_Desviaci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.G_Desv_Est)).BeginInit();
            this.panel_Min.SuspendLayout();
            this.panel_Max.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.panel1.Controls.Add(this.btn_test);
            this.panel1.Controls.Add(this.bunifuFlatButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 39);
            this.panel1.TabIndex = 0;
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(4, 4);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(75, 23);
            this.btn_test.TabIndex = 7;
            this.btn_test.Text = "button1";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::Promedios_DGV.Properties.Resources.icons8_Delete_96px;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(1110, 0);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(40, 39);
            this.bunifuFlatButton1.TabIndex = 6;
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // dgvDatos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.calificaciones});
            this.dgvDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvDatos.DoubleBuffered = true;
            this.dgvDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDatos.EnableHeadersVisualStyles = false;
            this.dgvDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.dgvDatos.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.dgvDatos.HeaderForeColor = System.Drawing.Color.White;
            this.dgvDatos.Location = new System.Drawing.Point(12, 98);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDatos.RowHeadersWidth = 70;
            this.dgvDatos.Size = new System.Drawing.Size(593, 330);
            this.dgvDatos.TabIndex = 1;
            // 
            // name
            // 
            this.name.HeaderText = "Nombres";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.ToolTipText = "Nombres";
            this.name.Width = 400;
            // 
            // calificaciones
            // 
            this.calificaciones.HeaderText = "Calificaciones";
            this.calificaciones.Name = "calificaciones";
            this.calificaciones.ReadOnly = true;
            this.calificaciones.Width = 130;
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Silver;
            this.txtName.HintForeColor = System.Drawing.Color.Empty;
            this.txtName.HintText = "Nombre";
            this.txtName.isPassword = false;
            this.txtName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.txtName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.txtName.LineThickness = 3;
            this.txtName.Location = new System.Drawing.Point(13, 56);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(295, 34);
            this.txtName.TabIndex = 2;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCalificacion
            // 
            this.txtCalificacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCalificacion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalificacion.ForeColor = System.Drawing.Color.Silver;
            this.txtCalificacion.HintForeColor = System.Drawing.Color.Empty;
            this.txtCalificacion.HintText = "Calificación";
            this.txtCalificacion.isPassword = false;
            this.txtCalificacion.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.txtCalificacion.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCalificacion.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.txtCalificacion.LineThickness = 3;
            this.txtCalificacion.Location = new System.Drawing.Point(338, 56);
            this.txtCalificacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCalificacion.Name = "txtCalificacion";
            this.txtCalificacion.Size = new System.Drawing.Size(104, 34);
            this.txtCalificacion.TabIndex = 3;
            this.txtCalificacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAdd
            // 
            this.btnAdd.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.BorderRadius = 0;
            this.btnAdd.ButtonText = "Agregar";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdd.Iconimage = null;
            this.btnAdd.Iconimage_right = null;
            this.btnAdd.Iconimage_right_Selected = null;
            this.btnAdd.Iconimage_Selected = null;
            this.btnAdd.IconMarginLeft = 0;
            this.btnAdd.IconMarginRight = 0;
            this.btnAdd.IconRightVisible = true;
            this.btnAdd.IconRightZoom = 0D;
            this.btnAdd.IconVisible = true;
            this.btnAdd.IconZoom = 90D;
            this.btnAdd.IsTab = false;
            this.btnAdd.Location = new System.Drawing.Point(458, 56);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.btnAdd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.btnAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAdd.selected = false;
            this.btnAdd.Size = new System.Drawing.Size(159, 34);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Textcolor = System.Drawing.Color.White;
            this.btnAdd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel_promedio);
            this.panel2.Controls.Add(this.dEst);
            this.panel2.Controls.Add(this.btnMin);
            this.panel2.Controls.Add(this.btnMax);
            this.panel2.Controls.Add(this.btnProm);
            this.panel2.Location = new System.Drawing.Point(623, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(503, 372);
            this.panel2.TabIndex = 5;
            // 
            // panel_promedio
            // 
            this.panel_promedio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_promedio.BackgroundImage")));
            this.panel_promedio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_promedio.Controls.Add(this.gauge_Promedio);
            this.panel_promedio.Controls.Add(this.lbl_NO1);
            this.panel_promedio.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.panel_promedio.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.panel_promedio.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.panel_promedio.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.panel_promedio.Location = new System.Drawing.Point(0, 30);
            this.panel_promedio.Name = "panel_promedio";
            this.panel_promedio.Quality = 10;
            this.panel_promedio.Size = new System.Drawing.Size(503, 339);
            this.panel_promedio.TabIndex = 9;
            this.panel_promedio.Visible = false;
            // 
            // gauge_Promedio
            // 
            this.gauge_Promedio.BackColor = System.Drawing.Color.Transparent;
            this.gauge_Promedio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gauge_Promedio.BackgroundImage")));
            this.gauge_Promedio.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gauge_Promedio.ForeColor = System.Drawing.Color.White;
            this.gauge_Promedio.Location = new System.Drawing.Point(57, 50);
            this.gauge_Promedio.Margin = new System.Windows.Forms.Padding(7);
            this.gauge_Promedio.Name = "gauge_Promedio";
            this.gauge_Promedio.ProgressBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(54)))), ((int)(((byte)(89)))));
            this.gauge_Promedio.ProgressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.gauge_Promedio.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.gauge_Promedio.Size = new System.Drawing.Size(398, 272);
            this.gauge_Promedio.Suffix = "";
            this.gauge_Promedio.TabIndex = 3;
            this.gauge_Promedio.Thickness = 30;
            this.gauge_Promedio.Value = 0;
            // 
            // lbl_NO1
            // 
            this.lbl_NO1.AutoSize = true;
            this.lbl_NO1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NO1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NO1.ForeColor = System.Drawing.Color.White;
            this.lbl_NO1.Location = new System.Drawing.Point(173, 23);
            this.lbl_NO1.Name = "lbl_NO1";
            this.lbl_NO1.Size = new System.Drawing.Size(189, 30);
            this.lbl_NO1.TabIndex = 2;
            this.lbl_NO1.Text = "Promedio total";
            // 
            // dEst
            // 
            this.dEst.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(71)))), ((int)(((byte)(136)))));
            this.dEst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.dEst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dEst.BorderRadius = 0;
            this.dEst.ButtonText = "D. Estandar";
            this.dEst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dEst.DisabledColor = System.Drawing.Color.Gray;
            this.dEst.Iconcolor = System.Drawing.Color.Transparent;
            this.dEst.Iconimage = null;
            this.dEst.Iconimage_right = null;
            this.dEst.Iconimage_right_Selected = null;
            this.dEst.Iconimage_Selected = null;
            this.dEst.IconMarginLeft = 0;
            this.dEst.IconMarginRight = 0;
            this.dEst.IconRightVisible = true;
            this.dEst.IconRightZoom = 0D;
            this.dEst.IconVisible = true;
            this.dEst.IconZoom = 90D;
            this.dEst.IsTab = true;
            this.dEst.Location = new System.Drawing.Point(373, 0);
            this.dEst.Name = "dEst";
            this.dEst.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.dEst.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(71)))), ((int)(((byte)(136)))));
            this.dEst.OnHoverTextColor = System.Drawing.Color.White;
            this.dEst.selected = false;
            this.dEst.Size = new System.Drawing.Size(142, 34);
            this.dEst.TabIndex = 8;
            this.dEst.Text = "D. Estandar";
            this.dEst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dEst.Textcolor = System.Drawing.Color.White;
            this.dEst.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dEst.Click += new System.EventHandler(this.dEst_Click);
            // 
            // btnMin
            // 
            this.btnMin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(71)))), ((int)(((byte)(136)))));
            this.btnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMin.BorderRadius = 0;
            this.btnMin.ButtonText = "Mínima";
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.DisabledColor = System.Drawing.Color.Gray;
            this.btnMin.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMin.Iconimage = null;
            this.btnMin.Iconimage_right = null;
            this.btnMin.Iconimage_right_Selected = null;
            this.btnMin.Iconimage_Selected = null;
            this.btnMin.IconMarginLeft = 0;
            this.btnMin.IconMarginRight = 0;
            this.btnMin.IconRightVisible = true;
            this.btnMin.IconRightZoom = 0D;
            this.btnMin.IconVisible = true;
            this.btnMin.IconZoom = 90D;
            this.btnMin.IsTab = true;
            this.btnMin.Location = new System.Drawing.Point(252, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.btnMin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(71)))), ((int)(((byte)(136)))));
            this.btnMin.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMin.selected = false;
            this.btnMin.Size = new System.Drawing.Size(130, 34);
            this.btnMin.TabIndex = 7;
            this.btnMin.Text = "Mínima";
            this.btnMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMin.Textcolor = System.Drawing.Color.White;
            this.btnMin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(71)))), ((int)(((byte)(136)))));
            this.btnMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.btnMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMax.BorderRadius = 0;
            this.btnMax.ButtonText = "Máxima";
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMax.DisabledColor = System.Drawing.Color.Gray;
            this.btnMax.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMax.Iconimage = null;
            this.btnMax.Iconimage_right = null;
            this.btnMax.Iconimage_right_Selected = null;
            this.btnMax.Iconimage_Selected = null;
            this.btnMax.IconMarginLeft = 0;
            this.btnMax.IconMarginRight = 0;
            this.btnMax.IconRightVisible = true;
            this.btnMax.IconRightZoom = 0D;
            this.btnMax.IconVisible = true;
            this.btnMax.IconZoom = 90D;
            this.btnMax.IsTab = true;
            this.btnMax.Location = new System.Drawing.Point(126, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.btnMax.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(71)))), ((int)(((byte)(136)))));
            this.btnMax.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMax.selected = false;
            this.btnMax.Size = new System.Drawing.Size(130, 34);
            this.btnMax.TabIndex = 6;
            this.btnMax.Text = "Máxima";
            this.btnMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMax.Textcolor = System.Drawing.Color.White;
            this.btnMax.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnProm
            // 
            this.btnProm.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(71)))), ((int)(((byte)(136)))));
            this.btnProm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.btnProm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProm.BorderRadius = 0;
            this.btnProm.ButtonText = "Promedio";
            this.btnProm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProm.DisabledColor = System.Drawing.Color.Gray;
            this.btnProm.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProm.Iconimage = null;
            this.btnProm.Iconimage_right = null;
            this.btnProm.Iconimage_right_Selected = null;
            this.btnProm.Iconimage_Selected = null;
            this.btnProm.IconMarginLeft = 0;
            this.btnProm.IconMarginRight = 0;
            this.btnProm.IconRightVisible = true;
            this.btnProm.IconRightZoom = 0D;
            this.btnProm.IconVisible = true;
            this.btnProm.IconZoom = 90D;
            this.btnProm.IsTab = true;
            this.btnProm.Location = new System.Drawing.Point(0, 0);
            this.btnProm.Name = "btnProm";
            this.btnProm.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.btnProm.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(71)))), ((int)(((byte)(136)))));
            this.btnProm.OnHoverTextColor = System.Drawing.Color.White;
            this.btnProm.selected = false;
            this.btnProm.Size = new System.Drawing.Size(130, 34);
            this.btnProm.TabIndex = 5;
            this.btnProm.Text = "Promedio";
            this.btnProm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProm.Textcolor = System.Drawing.Color.White;
            this.btnProm.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProm.Click += new System.EventHandler(this.btnProm_Click);
            // 
            // panel_Desviaci
            // 
            this.panel_Desviaci.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Desviaci.BackgroundImage")));
            this.panel_Desviaci.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Desviaci.Controls.Add(this.btnGrafico2);
            this.panel_Desviaci.Controls.Add(this.lbl_Desv_Estandar);
            this.panel_Desviaci.Controls.Add(this.btnPercent);
            this.panel_Desviaci.Controls.Add(this.G_Desv_Est);
            this.panel_Desviaci.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.panel_Desviaci.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.panel_Desviaci.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.panel_Desviaci.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.panel_Desviaci.Location = new System.Drawing.Point(623, 89);
            this.panel_Desviaci.Name = "panel_Desviaci";
            this.panel_Desviaci.Quality = 10;
            this.panel_Desviaci.Size = new System.Drawing.Size(503, 342);
            this.panel_Desviaci.TabIndex = 12;
            this.panel_Desviaci.Visible = false;
            this.panel_Desviaci.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Desviaci_Paint);
            // 
            // btnGrafico2
            // 
            this.btnGrafico2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.btnGrafico2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.btnGrafico2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGrafico2.BorderRadius = 0;
            this.btnGrafico2.ButtonText = "Gráfico 2";
            this.btnGrafico2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrafico2.DisabledColor = System.Drawing.Color.Gray;
            this.btnGrafico2.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGrafico2.Iconimage = null;
            this.btnGrafico2.Iconimage_right = null;
            this.btnGrafico2.Iconimage_right_Selected = null;
            this.btnGrafico2.Iconimage_Selected = null;
            this.btnGrafico2.IconMarginLeft = 0;
            this.btnGrafico2.IconMarginRight = 0;
            this.btnGrafico2.IconRightVisible = true;
            this.btnGrafico2.IconRightZoom = 0D;
            this.btnGrafico2.IconVisible = true;
            this.btnGrafico2.IconZoom = 90D;
            this.btnGrafico2.IsTab = false;
            this.btnGrafico2.Location = new System.Drawing.Point(232, 310);
            this.btnGrafico2.Name = "btnGrafico2";
            this.btnGrafico2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.btnGrafico2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.btnGrafico2.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGrafico2.selected = false;
            this.btnGrafico2.Size = new System.Drawing.Size(134, 26);
            this.btnGrafico2.TabIndex = 15;
            this.btnGrafico2.Text = "Gráfico 2";
            this.btnGrafico2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGrafico2.Textcolor = System.Drawing.Color.White;
            this.btnGrafico2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrafico2.Click += new System.EventHandler(this.btnGrafico2_Click);
            // 
            // lbl_Desv_Estandar
            // 
            this.lbl_Desv_Estandar.AutoSize = true;
            this.lbl_Desv_Estandar.Location = new System.Drawing.Point(4, 310);
            this.lbl_Desv_Estandar.Name = "lbl_Desv_Estandar";
            this.lbl_Desv_Estandar.Size = new System.Drawing.Size(21, 13);
            this.lbl_Desv_Estandar.TabIndex = 14;
            this.lbl_Desv_Estandar.Text = "De";
            this.lbl_Desv_Estandar.Click += new System.EventHandler(this.lbl_Desv_Estandar_Click);
            // 
            // btnPercent
            // 
            this.btnPercent.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.btnPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.btnPercent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPercent.BorderRadius = 0;
            this.btnPercent.ButtonText = "Porcentajes";
            this.btnPercent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPercent.DisabledColor = System.Drawing.Color.Gray;
            this.btnPercent.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPercent.Iconimage = null;
            this.btnPercent.Iconimage_right = null;
            this.btnPercent.Iconimage_right_Selected = null;
            this.btnPercent.Iconimage_Selected = null;
            this.btnPercent.IconMarginLeft = 0;
            this.btnPercent.IconMarginRight = 0;
            this.btnPercent.IconRightVisible = true;
            this.btnPercent.IconRightZoom = 0D;
            this.btnPercent.IconVisible = true;
            this.btnPercent.IconZoom = 90D;
            this.btnPercent.IsTab = false;
            this.btnPercent.Location = new System.Drawing.Point(372, 310);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.btnPercent.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.btnPercent.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPercent.selected = false;
            this.btnPercent.Size = new System.Drawing.Size(128, 26);
            this.btnPercent.TabIndex = 13;
            this.btnPercent.Text = "Porcentajes";
            this.btnPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPercent.Textcolor = System.Drawing.Color.White;
            this.btnPercent.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPercent.Click += new System.EventHandler(this.btnGraficoCompleto_Click);
            // 
            // G_Desv_Est
            // 
            this.G_Desv_Est.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(71)))), ((int)(((byte)(136)))));
            this.G_Desv_Est.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.ScaleView.MinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisY.ScaleView.Size = 100D;
            chartArea1.AxisY.ScrollBar.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.ScrollBar.ButtonColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.ScrollBar.ButtonStyle = System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonStyles.None;
            chartArea1.AxisY.ScrollBar.Enabled = false;
            chartArea1.AxisY.ScrollBar.IsPositionedInside = false;
            chartArea1.AxisY.ScrollBar.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.ScrollBar.Size = 5D;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.G_Desv_Est.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.G_Desv_Est.Legends.Add(legend1);
            this.G_Desv_Est.Location = new System.Drawing.Point(0, 3);
            this.G_Desv_Est.Name = "G_Desv_Est";
            this.G_Desv_Est.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.G_Desv_Est.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(71)))), ((int)(((byte)(136))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(195))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(194))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(194))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(195))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(195))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(1)))), ((int)(((byte)(194))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(194))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(194))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(0)))), ((int)(((byte)(194))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(0)))), ((int)(((byte)(194)))))};
            this.G_Desv_Est.Size = new System.Drawing.Size(500, 301);
            this.G_Desv_Est.TabIndex = 0;
            this.G_Desv_Est.Text = "Promedios";
            this.G_Desv_Est.Click += new System.EventHandler(this.G_Desv_Est_Click);
            // 
            // panel_Min
            // 
            this.panel_Min.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Min.BackgroundImage")));
            this.panel_Min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Min.Controls.Add(this.lblMin_name);
            this.panel_Min.Controls.Add(this.lbl_No4);
            this.panel_Min.Controls.Add(this.gauge_Min);
            this.panel_Min.Controls.Add(this.bunifuCustomLabel3);
            this.panel_Min.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.panel_Min.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.panel_Min.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.panel_Min.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.panel_Min.Location = new System.Drawing.Point(623, 86);
            this.panel_Min.Name = "panel_Min";
            this.panel_Min.Quality = 10;
            this.panel_Min.Size = new System.Drawing.Size(503, 342);
            this.panel_Min.TabIndex = 11;
            this.panel_Min.Visible = false;
            // 
            // lblMin_name
            // 
            this.lblMin_name.AutoSize = true;
            this.lblMin_name.BackColor = System.Drawing.Color.Transparent;
            this.lblMin_name.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin_name.ForeColor = System.Drawing.Color.White;
            this.lblMin_name.Location = new System.Drawing.Point(98, 64);
            this.lblMin_name.Name = "lblMin_name";
            this.lblMin_name.Size = new System.Drawing.Size(89, 22);
            this.lblMin_name.TabIndex = 5;
            this.lblMin_name.Text = "Nombre:";
            // 
            // lbl_No4
            // 
            this.lbl_No4.AutoSize = true;
            this.lbl_No4.BackColor = System.Drawing.Color.Transparent;
            this.lbl_No4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_No4.ForeColor = System.Drawing.Color.White;
            this.lbl_No4.Location = new System.Drawing.Point(3, 64);
            this.lbl_No4.Name = "lbl_No4";
            this.lbl_No4.Size = new System.Drawing.Size(89, 22);
            this.lbl_No4.TabIndex = 4;
            this.lbl_No4.Text = "Nombre:";
            // 
            // gauge_Min
            // 
            this.gauge_Min.BackColor = System.Drawing.Color.Transparent;
            this.gauge_Min.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gauge_Min.BackgroundImage")));
            this.gauge_Min.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gauge_Min.ForeColor = System.Drawing.Color.White;
            this.gauge_Min.Location = new System.Drawing.Point(126, 116);
            this.gauge_Min.Margin = new System.Windows.Forms.Padding(7);
            this.gauge_Min.Name = "gauge_Min";
            this.gauge_Min.ProgressBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(54)))), ((int)(((byte)(89)))));
            this.gauge_Min.ProgressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.gauge_Min.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.gauge_Min.Size = new System.Drawing.Size(236, 206);
            this.gauge_Min.Suffix = "";
            this.gauge_Min.TabIndex = 3;
            this.gauge_Min.Thickness = 30;
            this.gauge_Min.Value = 0;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(121, 13);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(258, 30);
            this.bunifuCustomLabel3.TabIndex = 2;
            this.bunifuCustomLabel3.Text = "Calificación mínima";
            // 
            // panel_Max
            // 
            this.panel_Max.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Max.BackgroundImage")));
            this.panel_Max.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Max.Controls.Add(this.lblMax_Name);
            this.panel_Max.Controls.Add(this.lbl_No3);
            this.panel_Max.Controls.Add(this.Gauge_Max);
            this.panel_Max.Controls.Add(this.lbl_NO2);
            this.panel_Max.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.panel_Max.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.panel_Max.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.panel_Max.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.panel_Max.Location = new System.Drawing.Point(623, 86);
            this.panel_Max.Name = "panel_Max";
            this.panel_Max.Quality = 10;
            this.panel_Max.Size = new System.Drawing.Size(503, 339);
            this.panel_Max.TabIndex = 10;
            this.panel_Max.Visible = false;
            // 
            // lblMax_Name
            // 
            this.lblMax_Name.AutoSize = true;
            this.lblMax_Name.BackColor = System.Drawing.Color.Transparent;
            this.lblMax_Name.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax_Name.ForeColor = System.Drawing.Color.White;
            this.lblMax_Name.Location = new System.Drawing.Point(98, 64);
            this.lblMax_Name.Name = "lblMax_Name";
            this.lblMax_Name.Size = new System.Drawing.Size(89, 22);
            this.lblMax_Name.TabIndex = 5;
            this.lblMax_Name.Text = "Nombre:";
            // 
            // lbl_No3
            // 
            this.lbl_No3.AutoSize = true;
            this.lbl_No3.BackColor = System.Drawing.Color.Transparent;
            this.lbl_No3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_No3.ForeColor = System.Drawing.Color.White;
            this.lbl_No3.Location = new System.Drawing.Point(3, 64);
            this.lbl_No3.Name = "lbl_No3";
            this.lbl_No3.Size = new System.Drawing.Size(89, 22);
            this.lbl_No3.TabIndex = 4;
            this.lbl_No3.Text = "Nombre:";
            // 
            // Gauge_Max
            // 
            this.Gauge_Max.BackColor = System.Drawing.Color.Transparent;
            this.Gauge_Max.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Gauge_Max.BackgroundImage")));
            this.Gauge_Max.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gauge_Max.ForeColor = System.Drawing.Color.White;
            this.Gauge_Max.Location = new System.Drawing.Point(126, 116);
            this.Gauge_Max.Margin = new System.Windows.Forms.Padding(7);
            this.Gauge_Max.Name = "Gauge_Max";
            this.Gauge_Max.ProgressBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(54)))), ((int)(((byte)(89)))));
            this.Gauge_Max.ProgressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.Gauge_Max.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.Gauge_Max.Size = new System.Drawing.Size(236, 206);
            this.Gauge_Max.Suffix = "";
            this.Gauge_Max.TabIndex = 3;
            this.Gauge_Max.Thickness = 30;
            this.Gauge_Max.Value = 0;
            // 
            // lbl_NO2
            // 
            this.lbl_NO2.AutoSize = true;
            this.lbl_NO2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NO2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NO2.ForeColor = System.Drawing.Color.White;
            this.lbl_NO2.Location = new System.Drawing.Point(121, 13);
            this.lbl_NO2.Name = "lbl_NO2";
            this.lbl_NO2.Size = new System.Drawing.Size(265, 30);
            this.lbl_NO2.TabIndex = 2;
            this.lbl_NO2.Text = "Calificación máxima";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1150, 440);
            this.Controls.Add(this.panel_Desviaci);
            this.Controls.Add(this.panel_Min);
            this.Controls.Add(this.panel_Max);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCalificacion);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel_promedio.ResumeLayout(false);
            this.panel_promedio.PerformLayout();
            this.panel_Desviaci.ResumeLayout(false);
            this.panel_Desviaci.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.G_Desv_Est)).EndInit();
            this.panel_Min.ResumeLayout(false);
            this.panel_Min.PerformLayout();
            this.panel_Max.ResumeLayout(false);
            this.panel_Max.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvDatos;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdd;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCalificacion;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtName;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton dEst;
        private Bunifu.Framework.UI.BunifuFlatButton btnMin;
        private Bunifu.Framework.UI.BunifuFlatButton btnMax;
        private Bunifu.Framework.UI.BunifuFlatButton btnProm;
        private Bunifu.Framework.UI.BunifuGradientPanel panel_promedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn calificaciones;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_NO1;
        private Bunifu.Framework.UI.BunifuGauge gauge_Promedio;
        private Bunifu.Framework.UI.BunifuGradientPanel panel_Max;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMax_Name;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_No3;
        private Bunifu.Framework.UI.BunifuGauge Gauge_Max;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_NO2;
        private Bunifu.Framework.UI.BunifuGradientPanel panel_Min;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMin_name;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_No4;
        private Bunifu.Framework.UI.BunifuGauge gauge_Min;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuGradientPanel panel_Desviaci;
        private System.Windows.Forms.DataVisualization.Charting.Chart G_Desv_Est;
        private Bunifu.Framework.UI.BunifuFlatButton btnPercent;
        private System.Windows.Forms.Label lbl_Desv_Estandar;
        private Bunifu.Framework.UI.BunifuFlatButton btnGrafico2;
        private System.Windows.Forms.Button btn_test;
    }
}

