namespace Deportes
{
    partial class Ticket
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
            this.lblName_Age = new System.Windows.Forms.Label();
            this.lblLives = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.l_depo = new System.Windows.Forms.ListView();
            this.lblNivel = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName_Age
            // 
            this.lblName_Age.AutoSize = true;
            this.lblName_Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName_Age.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblName_Age.Location = new System.Drawing.Point(12, 52);
            this.lblName_Age.Name = "lblName_Age";
            this.lblName_Age.Size = new System.Drawing.Size(0, 15);
            this.lblName_Age.TabIndex = 0;
            // 
            // lblLives
            // 
            this.lblLives.AutoSize = true;
            this.lblLives.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLives.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLives.Location = new System.Drawing.Point(12, 79);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(0, 15);
            this.lblLives.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Practica:";
            // 
            // l_depo
            // 
            this.l_depo.BackColor = System.Drawing.Color.RosyBrown;
            this.l_depo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.l_depo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.l_depo.Location = new System.Drawing.Point(88, 109);
            this.l_depo.Name = "l_depo";
            this.l_depo.Size = new System.Drawing.Size(108, 137);
            this.l_depo.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.l_depo.TabIndex = 3;
            this.l_depo.UseCompatibleStateImageBehavior = false;
            this.l_depo.View = System.Windows.Forms.View.List;
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNivel.Location = new System.Drawing.Point(12, 259);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(0, 15);
            this.lblNivel.TabIndex = 4;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegister.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegister.Location = new System.Drawing.Point(0, 311);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(224, 23);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "Aceptar";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(84, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Datos";
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(224, 334);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.l_depo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLives);
            this.Controls.Add(this.lblName_Age);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ticket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.Ticket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName_Age;
        private System.Windows.Forms.Label lblLives;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView l_depo;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label2;
    }
}