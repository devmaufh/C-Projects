namespace Convierte
{
    partial class Convert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Convert));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDolar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.txtConversion = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtTasaEuro = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtTasaDolar = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuCards1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.bunifuCards2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(101)))));
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(101)))));
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.Controls.Add(this.lblDolar);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(49, 145);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(148, 105);
            this.bunifuCards1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(61)))));
            this.label1.Location = new System.Drawing.Point(21, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dolares";
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(61)))));
            this.lblDolar.Location = new System.Drawing.Point(3, 11);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(0, 24);
            this.lblDolar.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(101)))));
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 49);
            this.panel1.TabIndex = 4;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(101)))));
            this.bunifuImageButton1.Image = global::Convierte.Properties.Resources.icons8_Delete_64px;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(496, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(52, 49);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(101)))));
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(101)))));
            this.bunifuCards2.Controls.Add(this.label2);
            this.bunifuCards2.Controls.Add(this.lblEuro);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(345, 145);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(148, 105);
            this.bunifuCards2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(61)))));
            this.label2.Location = new System.Drawing.Point(29, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "Euros";
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(61)))));
            this.lblEuro.Location = new System.Drawing.Point(3, 11);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(0, 24);
            this.lblEuro.TabIndex = 6;
            // 
            // txtConversion
            // 
            this.txtConversion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(61)))));
            this.txtConversion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtConversion.BackgroundImage")));
            this.txtConversion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtConversion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(101)))));
            this.txtConversion.Icon = ((System.Drawing.Image)(resources.GetObject("txtConversion.Icon")));
            this.txtConversion.Location = new System.Drawing.Point(383, 76);
            this.txtConversion.Name = "txtConversion";
            this.txtConversion.Size = new System.Drawing.Size(153, 42);
            this.txtConversion.TabIndex = 5;
            this.txtConversion.text = "Valor del Euro";
            this.txtConversion.OnTextChange += new System.EventHandler(this.txtConversion_OnTextChange);
            // 
            // txtTasaEuro
            // 
            this.txtTasaEuro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(61)))));
            this.txtTasaEuro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtTasaEuro.BackgroundImage")));
            this.txtTasaEuro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtTasaEuro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(101)))));
            this.txtTasaEuro.Icon = ((System.Drawing.Image)(resources.GetObject("txtTasaEuro.Icon")));
            this.txtTasaEuro.Location = new System.Drawing.Point(197, 76);
            this.txtTasaEuro.Name = "txtTasaEuro";
            this.txtTasaEuro.Size = new System.Drawing.Size(153, 42);
            this.txtTasaEuro.TabIndex = 3;
            this.txtTasaEuro.text = "Valor del Euro";
            // 
            // txtTasaDolar
            // 
            this.txtTasaDolar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(61)))));
            this.txtTasaDolar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtTasaDolar.BackgroundImage")));
            this.txtTasaDolar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtTasaDolar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(101)))));
            this.txtTasaDolar.Icon = ((System.Drawing.Image)(resources.GetObject("txtTasaDolar.Icon")));
            this.txtTasaDolar.Location = new System.Drawing.Point(12, 76);
            this.txtTasaDolar.Name = "txtTasaDolar";
            this.txtTasaDolar.Size = new System.Drawing.Size(153, 42);
            this.txtTasaDolar.TabIndex = 2;
            this.txtTasaDolar.text = "Valor del Dolar";
            // 
            // Convert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(548, 278);
            this.Controls.Add(this.bunifuCards2);
            this.Controls.Add(this.txtConversion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTasaEuro);
            this.Controls.Add(this.txtTasaDolar);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Convert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Convert";
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEuro;
        private Bunifu.Framework.UI.BunifuTextbox txtConversion;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuTextbox txtTasaEuro;
        private Bunifu.Framework.UI.BunifuTextbox txtTasaDolar;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDolar;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}