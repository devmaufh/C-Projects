namespace LibSoft
{
    partial class Search
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtNombre = new Bunifu.Framework.UI.BunifuTextbox();
            this.dgvLibros = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtAutor = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnSaveCHanges = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(8)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 37);
            this.panel1.TabIndex = 0;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(8)))), ((int)(((byte)(37)))));
            this.btnClose.Image = global::LibSoft.Properties.Resources.icons8_Delete_96px_3;
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(583, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 32);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(250, 37);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Busqueda avanzada";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtNombre.BackgroundImage")));
            this.txtNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(8)))), ((int)(((byte)(37)))));
            this.txtNombre.Icon = ((System.Drawing.Image)(resources.GetObject("txtNombre.Icon")));
            this.txtNombre.Location = new System.Drawing.Point(8, 43);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(246, 29);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.text = "Titulo";
            this.txtNombre.OnTextChange += new System.EventHandler(this.txtNombre_OnTextChange);
            this.txtNombre.Click += new System.EventHandler(this.txtNombre_Click);
            // 
            // dgvLibros
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvLibros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLibros.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvLibros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLibros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvLibros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(8)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLibros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.DoubleBuffered = true;
            this.dgvLibros.EnableHeadersVisualStyles = false;
            this.dgvLibros.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(8)))), ((int)(((byte)(37)))));
            this.dgvLibros.HeaderForeColor = System.Drawing.Color.White;
            this.dgvLibros.Location = new System.Drawing.Point(8, 90);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLibros.Size = new System.Drawing.Size(594, 169);
            this.dgvLibros.TabIndex = 2;
            // 
            // txtAutor
            // 
            this.txtAutor.BackColor = System.Drawing.SystemColors.Control;
            this.txtAutor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtAutor.BackgroundImage")));
            this.txtAutor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtAutor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(8)))), ((int)(((byte)(37)))));
            this.txtAutor.Icon = ((System.Drawing.Image)(resources.GetObject("txtAutor.Icon")));
            this.txtAutor.Location = new System.Drawing.Point(372, 43);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(230, 29);
            this.txtAutor.TabIndex = 3;
            this.txtAutor.text = "Autor";
            this.txtAutor.OnTextChange += new System.EventHandler(this.txtAutor_OnTextChange);
            this.txtAutor.Click += new System.EventHandler(this.txtAutor_Click);
            // 
            // btnSaveCHanges
            // 
            this.btnSaveCHanges.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSaveCHanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSaveCHanges.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveCHanges.BorderRadius = 0;
            this.btnSaveCHanges.ButtonText = "Guardar cambios";
            this.btnSaveCHanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveCHanges.DisabledColor = System.Drawing.Color.Gray;
            this.btnSaveCHanges.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSaveCHanges.Iconimage = null;
            this.btnSaveCHanges.Iconimage_right = null;
            this.btnSaveCHanges.Iconimage_right_Selected = null;
            this.btnSaveCHanges.Iconimage_Selected = null;
            this.btnSaveCHanges.IconMarginLeft = 0;
            this.btnSaveCHanges.IconMarginRight = 0;
            this.btnSaveCHanges.IconRightVisible = true;
            this.btnSaveCHanges.IconRightZoom = 0D;
            this.btnSaveCHanges.IconVisible = true;
            this.btnSaveCHanges.IconZoom = 90D;
            this.btnSaveCHanges.IsTab = false;
            this.btnSaveCHanges.Location = new System.Drawing.Point(447, 265);
            this.btnSaveCHanges.Name = "btnSaveCHanges";
            this.btnSaveCHanges.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSaveCHanges.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSaveCHanges.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSaveCHanges.selected = false;
            this.btnSaveCHanges.Size = new System.Drawing.Size(158, 30);
            this.btnSaveCHanges.TabIndex = 4;
            this.btnSaveCHanges.Text = "Guardar cambios";
            this.btnSaveCHanges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveCHanges.Textcolor = System.Drawing.Color.White;
            this.btnSaveCHanges.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCHanges.Click += new System.EventHandler(this.btnSaveCHanges_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 300);
            this.Controls.Add(this.btnSaveCHanges);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.dgvLibros);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuTextbox txtNombre;
        private Bunifu.Framework.UI.BunifuTextbox txtAutor;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvLibros;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuFlatButton btnSaveCHanges;
    }
}