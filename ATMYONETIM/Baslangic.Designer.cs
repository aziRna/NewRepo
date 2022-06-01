
namespace ATMYONETIM
{
    partial class Baslangic
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Yuzde = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ilerilemebari = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label1.Font = new System.Drawing.Font("Arial", 21.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(344, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "ATM SISTEMI";
            // 
            // Yuzde
            // 
            this.Yuzde.AutoSize = true;
            this.Yuzde.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Yuzde.Font = new System.Drawing.Font("Arial", 26.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yuzde.ForeColor = System.Drawing.Color.White;
            this.Yuzde.Location = new System.Drawing.Point(465, 546);
            this.Yuzde.Name = "Yuzde";
            this.Yuzde.Size = new System.Drawing.Size(85, 72);
            this.Yuzde.TabIndex = 1;
            this.Yuzde.Text = "%";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ATMYONETIM.Properties.Resources.bank_cartoon_png_favpng_h2YqyP7qWcmXNn688xWsqpHL3;
            this.pictureBox1.Location = new System.Drawing.Point(397, 205);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ilerilemebari
            // 
            this.ilerilemebari.ForeColor = System.Drawing.Color.Honeydew;
            this.ilerilemebari.Location = new System.Drawing.Point(-2, 635);
            this.ilerilemebari.Name = "ilerilemebari";
            this.ilerilemebari.Size = new System.Drawing.Size(1021, 45);
            this.ilerilemebari.TabIndex = 3;
            this.ilerilemebari.Click += new System.EventHandler(this.ilerilemebari_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 16.85714F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(935, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 45);
            this.label6.TabIndex = 10;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Baslangic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1017, 675);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ilerilemebari);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Yuzde);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Baslangic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Baslangic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Yuzde;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar ilerilemebari;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
    }
}

