
namespace KutuphaneOtomasyonFinalProjem
{
    partial class KaynakSilForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.KaynakSilbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(110)))), ((int)(((byte)(113)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1171, 580);
            this.dataGridView1.TabIndex = 3;
            // 
            // KaynakSilbtn
            // 
            this.KaynakSilbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.KaynakSilbtn.FlatAppearance.BorderSize = 0;
            this.KaynakSilbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KaynakSilbtn.Location = new System.Drawing.Point(12, 40);
            this.KaynakSilbtn.Name = "KaynakSilbtn";
            this.KaynakSilbtn.Size = new System.Drawing.Size(248, 86);
            this.KaynakSilbtn.TabIndex = 4;
            this.KaynakSilbtn.Text = "Sil";
            this.KaynakSilbtn.UseVisualStyleBackColor = false;
            this.KaynakSilbtn.Click += new System.EventHandler(this.KaynakSilbtn_Click);
            // 
            // KaynakSilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(110)))), ((int)(((byte)(113)))));
            this.ClientSize = new System.Drawing.Size(1171, 750);
            this.Controls.Add(this.KaynakSilbtn);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KaynakSilForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KaynakSilForm";
            this.Load += new System.EventHandler(this.KaynakSilForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button KaynakSilbtn;
    }
}