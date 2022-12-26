namespace KutuphaneOtomasyonFinalProjem
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adGiristxt = new System.Windows.Forms.TextBox();
            this.sifreGiristxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PersonelGirisbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // adGiristxt
            // 
            this.adGiristxt.Location = new System.Drawing.Point(104, 227);
            this.adGiristxt.Name = "adGiristxt";
            this.adGiristxt.Size = new System.Drawing.Size(187, 20);
            this.adGiristxt.TabIndex = 2;
            // 
            // sifreGiristxt
            // 
            this.sifreGiristxt.Location = new System.Drawing.Point(99, 278);
            this.sifreGiristxt.Name = "sifreGiristxt";
            this.sifreGiristxt.Size = new System.Drawing.Size(192, 20);
            this.sifreGiristxt.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(140, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // PersonelGirisbtn
            // 
            this.PersonelGirisbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.PersonelGirisbtn.FlatAppearance.BorderSize = 0;
            this.PersonelGirisbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PersonelGirisbtn.Location = new System.Drawing.Point(99, 329);
            this.PersonelGirisbtn.Name = "PersonelGirisbtn";
            this.PersonelGirisbtn.Size = new System.Drawing.Size(192, 31);
            this.PersonelGirisbtn.TabIndex = 5;
            this.PersonelGirisbtn.Text = "Giriş";
            this.PersonelGirisbtn.UseVisualStyleBackColor = false;
            this.PersonelGirisbtn.Click += new System.EventHandler(this.PersonelGirisbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(196)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(408, 465);
            this.Controls.Add(this.PersonelGirisbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sifreGiristxt);
            this.Controls.Add(this.adGiristxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adGiristxt;
        private System.Windows.Forms.TextBox sifreGiristxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button PersonelGirisbtn;
    }
}

