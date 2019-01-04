namespace LibSoft
{
    partial class Libros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Libros));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.dgvLibros = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.menu_DElete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveCHanges = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHelp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.menu_DElete.SuspendLayout();
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
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 40);
            this.panel1.TabIndex = 0;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(8)))), ((int)(((byte)(37)))));
            this.bunifuImageButton1.Image = global::LibSoft.Properties.Resources.icons8_Delete_96px_3;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(850, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(40, 40);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
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
            this.dgvLibros.ContextMenuStrip = this.menu_DElete;
            this.dgvLibros.DoubleBuffered = true;
            this.dgvLibros.EnableHeadersVisualStyles = false;
            this.dgvLibros.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(8)))), ((int)(((byte)(37)))));
            this.dgvLibros.HeaderForeColor = System.Drawing.Color.White;
            this.dgvLibros.Location = new System.Drawing.Point(12, 97);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLibros.Size = new System.Drawing.Size(866, 319);
            this.dgvLibros.TabIndex = 0;
            // 
            // menu_DElete
            // 
            this.menu_DElete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem});
            this.menu_DElete.Name = "menu_DElete";
            this.menu_DElete.Size = new System.Drawing.Size(118, 26);
            this.menu_DElete.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
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
            this.btnSaveCHanges.Location = new System.Drawing.Point(720, 422);
            this.btnSaveCHanges.Name = "btnSaveCHanges";
            this.btnSaveCHanges.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSaveCHanges.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSaveCHanges.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSaveCHanges.selected = false;
            this.btnSaveCHanges.Size = new System.Drawing.Size(158, 30);
            this.btnSaveCHanges.TabIndex = 1;
            this.btnSaveCHanges.Text = "Guardar cambios";
            this.btnSaveCHanges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveCHanges.Textcolor = System.Drawing.Color.White;
            this.btnSaveCHanges.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCHanges.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelp.BorderRadius = 0;
            this.btnHelp.ButtonText = "Ayuda";
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.DisabledColor = System.Drawing.Color.Gray;
            this.btnHelp.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHelp.Iconimage = null;
            this.btnHelp.Iconimage_right = null;
            this.btnHelp.Iconimage_right_Selected = null;
            this.btnHelp.Iconimage_Selected = null;
            this.btnHelp.IconMarginLeft = 0;
            this.btnHelp.IconMarginRight = 0;
            this.btnHelp.IconRightVisible = true;
            this.btnHelp.IconRightZoom = 0D;
            this.btnHelp.IconVisible = true;
            this.btnHelp.IconZoom = 90D;
            this.btnHelp.IsTab = false;
            this.btnHelp.Location = new System.Drawing.Point(12, 422);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHelp.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnHelp.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHelp.selected = false;
            this.btnHelp.Size = new System.Drawing.Size(75, 30);
            this.btnHelp.TabIndex = 2;
            this.btnHelp.Text = "Ayuda";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHelp.Textcolor = System.Drawing.Color.White;
            this.btnHelp.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.BorderRadius = 0;
            this.btnSearch.ButtonText = "Busqueda personalizada";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.DisabledColor = System.Drawing.Color.Gray;
            this.btnSearch.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSearch.Iconimage = null;
            this.btnSearch.Iconimage_right = null;
            this.btnSearch.Iconimage_right_Selected = null;
            this.btnSearch.Iconimage_Selected = null;
            this.btnSearch.IconMarginLeft = 0;
            this.btnSearch.IconMarginRight = 0;
            this.btnSearch.IconRightVisible = true;
            this.btnSearch.IconRightZoom = 0D;
            this.btnSearch.IconVisible = true;
            this.btnSearch.IconZoom = 90D;
            this.btnSearch.IsTab = false;
            this.btnSearch.Location = new System.Drawing.Point(93, 422);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearch.selected = false;
            this.btnSearch.Size = new System.Drawing.Size(179, 30);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Busqueda personalizada";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.Textcolor = System.Drawing.Color.White;
            this.btnSearch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nota: Para insertar datos no es necesario llenar el campo \"Número\". ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Eras Medium ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(866, 34);
            this.label2.TabIndex = 5;
            this.label2.Text = "Libros";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(3, 3);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(250, 37);
            this.bunifuCustomLabel1.TabIndex = 6;
            this.bunifuCustomLabel1.Text = "Libros";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Libros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 460);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnSaveCHanges);
            this.Controls.Add(this.dgvLibros);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Libros";
            this.Text = "Libros";
            this.Load += new System.EventHandler(this.Libros_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.menu_DElete.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvLibros;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnSaveCHanges;
        private System.Windows.Forms.ContextMenuStrip menu_DElete;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuFlatButton btnHelp;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearch;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}