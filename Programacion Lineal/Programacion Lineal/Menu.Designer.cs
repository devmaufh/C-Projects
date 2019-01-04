namespace Programacion_Lineal
{
    partial class Menu
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
            BunifuAnimatorNS.Animation animation5 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            BunifuAnimatorNS.Animation animation6 = new BunifuAnimatorNS.Animation();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.sideMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.animaPanel = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.animalogo = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bbbbb = new Bunifu.Framework.UI.BunifuImageButton();
            this.sideMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbbbb)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // sideMenu
            // 
            this.sideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.sideMenu.Controls.Add(this.bbbbb);
            this.sideMenu.Controls.Add(this.logo);
            this.animalogo.SetDecoration(this.sideMenu, BunifuAnimatorNS.DecorationType.None);
            this.animaPanel.SetDecoration(this.sideMenu, BunifuAnimatorNS.DecorationType.None);
            this.sideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenu.Location = new System.Drawing.Point(0, 33);
            this.sideMenu.Name = "sideMenu";
            this.sideMenu.Size = new System.Drawing.Size(185, 432);
            this.sideMenu.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.bunifuImageButton2);
            this.animalogo.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.animaPanel.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(876, 33);
            this.panel2.TabIndex = 1;
            // 
            // logo
            // 
            this.animaPanel.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.animalogo.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logo.Location = new System.Drawing.Point(40, 6);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(104, 53);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuImageButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.animalogo.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.animaPanel.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.ErrorImage")));
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(846, 0);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(30, 33);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 2;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // panel3
            // 
            this.animalogo.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.animaPanel.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(185, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(691, 432);
            this.panel3.TabIndex = 2;
            // 
            // animaPanel
            // 
            this.animaPanel.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.animaPanel.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 0F;
            this.animaPanel.DefaultAnimation = animation5;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // animalogo
            // 
            this.animalogo.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.animalogo.Cursor = null;
            animation6.AnimateOnlyDifferences = true;
            animation6.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 0F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 20;
            animation6.Padding = new System.Windows.Forms.Padding(30);
            animation6.RotateCoeff = 0F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 0F;
            animation6.TransparencyCoeff = 0F;
            this.animalogo.DefaultAnimation = animation6;
            // 
            // bbbbb
            // 
            this.bbbbb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bbbbb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.animalogo.SetDecoration(this.bbbbb, BunifuAnimatorNS.DecorationType.None);
            this.animaPanel.SetDecoration(this.bbbbb, BunifuAnimatorNS.DecorationType.None);
            this.bbbbb.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bbbbb.ErrorImage")));
            this.bbbbb.Image = ((System.Drawing.Image)(resources.GetObject("bbbbb.Image")));
            this.bbbbb.ImageActive = null;
            this.bbbbb.Location = new System.Drawing.Point(0, 0);
            this.bbbbb.Name = "bbbbb";
            this.bbbbb.Size = new System.Drawing.Size(32, 34);
            this.bbbbb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bbbbb.TabIndex = 2;
            this.bbbbb.TabStop = false;
            this.bbbbb.Zoom = 10;
            this.bbbbb.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(876, 465);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.sideMenu);
            this.Controls.Add(this.panel2);
            this.animaPanel.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.animalogo.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Menu";
            this.sideMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbbbb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel sideMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox logo;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.Panel panel3;
        private BunifuAnimatorNS.BunifuTransition animaPanel;
        private BunifuAnimatorNS.BunifuTransition animalogo;
        private Bunifu.Framework.UI.BunifuImageButton bbbbb;
        public Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}