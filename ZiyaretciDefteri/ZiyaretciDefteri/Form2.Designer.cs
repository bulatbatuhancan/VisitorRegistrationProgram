namespace ZiyaretciDefteri
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtKullanıcı = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblKullanıcıAdı = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.White;
            this.btnGiris.ForeColor = System.Drawing.Color.Navy;
            this.btnGiris.Location = new System.Drawing.Point(529, 188);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(121, 28);
            this.btnGiris.TabIndex = 0;
            this.btnGiris.Text = "GİRİŞ";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtKullanıcı
            // 
            this.txtKullanıcı.BackColor = System.Drawing.Color.White;
            this.txtKullanıcı.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKullanıcı.ForeColor = System.Drawing.Color.Navy;
            this.txtKullanıcı.Location = new System.Drawing.Point(391, 74);
            this.txtKullanıcı.Multiline = true;
            this.txtKullanıcı.Name = "txtKullanıcı";
            this.txtKullanıcı.Size = new System.Drawing.Size(259, 32);
            this.txtKullanıcı.TabIndex = 1;
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.White;
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSifre.ForeColor = System.Drawing.Color.Navy;
            this.txtSifre.Location = new System.Drawing.Point(391, 126);
            this.txtSifre.Multiline = true;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(259, 32);
            this.txtSifre.TabIndex = 2;
            // 
            // lblKullanıcıAdı
            // 
            this.lblKullanıcıAdı.AutoSize = true;
            this.lblKullanıcıAdı.BackColor = System.Drawing.Color.White;
            this.lblKullanıcıAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKullanıcıAdı.ForeColor = System.Drawing.Color.Navy;
            this.lblKullanıcıAdı.Location = new System.Drawing.Point(253, 80);
            this.lblKullanıcıAdı.Name = "lblKullanıcıAdı";
            this.lblKullanıcıAdı.Size = new System.Drawing.Size(132, 20);
            this.lblKullanıcıAdı.TabIndex = 3;
            this.lblKullanıcıAdı.Text = "KULLANICI ADI :";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.BackColor = System.Drawing.Color.White;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSifre.ForeColor = System.Drawing.Color.Navy;
            this.lblSifre.Location = new System.Drawing.Point(319, 132);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(66, 20);
            this.lblSifre.TabIndex = 4;
            this.lblSifre.Text = "ŞİFRE :";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox1.Location = new System.Drawing.Point(657, 140);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(90, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Parola Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(961, 530);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKullanıcıAdı);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullanıcı);
            this.Controls.Add(this.btnGiris);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox txtKullanıcı;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblKullanıcıAdı;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}