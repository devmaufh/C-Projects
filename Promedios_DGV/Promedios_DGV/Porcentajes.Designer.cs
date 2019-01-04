namespace Promedios_DGV
{
    partial class Porcentajes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Porcentajes));
            this.aprobacion = new Bunifu.Framework.UI.BunifuGauge();
            this.reprobacion = new Bunifu.Framework.UI.BunifuGauge();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // aprobacion
            // 
            this.aprobacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aprobacion.BackgroundImage")));
            this.aprobacion.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.aprobacion.Location = new System.Drawing.Point(14, 98);
            this.aprobacion.Margin = new System.Windows.Forms.Padding(6);
            this.aprobacion.Name = "aprobacion";
            this.aprobacion.ProgressBgColor = System.Drawing.SystemColors.GrayText;
            this.aprobacion.ProgressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.aprobacion.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(71)))), ((int)(((byte)(136)))));
            this.aprobacion.Size = new System.Drawing.Size(191, 130);
            this.aprobacion.Suffix = "";
            this.aprobacion.TabIndex = 0;
            this.aprobacion.Thickness = 30;
            this.aprobacion.Value = 50;
            // 
            // reprobacion
            // 
            this.reprobacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reprobacion.BackgroundImage")));
            this.reprobacion.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.reprobacion.Location = new System.Drawing.Point(255, 98);
            this.reprobacion.Margin = new System.Windows.Forms.Padding(6);
            this.reprobacion.Name = "reprobacion";
            this.reprobacion.ProgressBgColor = System.Drawing.SystemColors.GrayText;
            this.reprobacion.ProgressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.reprobacion.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(71)))), ((int)(((byte)(136)))));
            this.reprobacion.Size = new System.Drawing.Size(191, 130);
            this.reprobacion.Suffix = "";
            this.reprobacion.TabIndex = 1;
            this.reprobacion.Thickness = 30;
            this.reprobacion.Value = 50;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(133, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(181, 38);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Porcentajes";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(56, 69);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(109, 23);
            this.bunifuCustomLabel2.TabIndex = 3;
            this.bunifuCustomLabel2.Text = "Aprobación";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(291, 69);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(118, 23);
            this.bunifuCustomLabel3.TabIndex = 4;
            this.bunifuCustomLabel3.Text = "Reprobación";
            // 
            // Porcentajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(455, 243);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.reprobacion);
            this.Controls.Add(this.aprobacion);
            this.Name = "Porcentajes";
            this.Text = "Porcentajes";
            this.Load += new System.EventHandler(this.Porcentajes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGauge aprobacion;
        private Bunifu.Framework.UI.BunifuGauge reprobacion;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
    }
}