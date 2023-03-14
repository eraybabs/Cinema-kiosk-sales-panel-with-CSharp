
namespace Sinema_Bufe
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblSu = new System.Windows.Forms.Label();
            this.LblCay = new System.Windows.Forms.Label();
            this.LblMisir = new System.Windows.Forms.Label();
            this.LblBilet = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LblToplam = new System.Windows.Forms.Label();
            this.TxtSu = new System.Windows.Forms.TextBox();
            this.TxtCay = new System.Windows.Forms.TextBox();
            this.TxtMisir = new System.Windows.Forms.TextBox();
            this.TxtBilet = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblKasa = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(119, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sinema Büfe Satış Paneli";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Controls.Add(this.TxtBilet);
            this.groupBox1.Controls.Add(this.TxtMisir);
            this.groupBox1.Controls.Add(this.TxtCay);
            this.groupBox1.Controls.Add(this.TxtSu);
            this.groupBox1.Controls.Add(this.LblBilet);
            this.groupBox1.Controls.Add(this.LblMisir);
            this.groupBox1.Controls.Add(this.LblCay);
            this.groupBox1.Controls.Add(this.LblSu);
            this.groupBox1.Location = new System.Drawing.Point(12, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 352);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Miktarı";
            // 
            // LblSu
            // 
            this.LblSu.AutoSize = true;
            this.LblSu.Location = new System.Drawing.Point(67, 51);
            this.LblSu.Name = "LblSu";
            this.LblSu.Size = new System.Drawing.Size(43, 25);
            this.LblSu.TabIndex = 0;
            this.LblSu.Text = "Su:";
            // 
            // LblCay
            // 
            this.LblCay.AutoSize = true;
            this.LblCay.Location = new System.Drawing.Point(56, 87);
            this.LblCay.Name = "LblCay";
            this.LblCay.Size = new System.Drawing.Size(54, 25);
            this.LblCay.TabIndex = 1;
            this.LblCay.Text = "Çay:";
            // 
            // LblMisir
            // 
            this.LblMisir.AutoSize = true;
            this.LblMisir.Location = new System.Drawing.Point(51, 123);
            this.LblMisir.Name = "LblMisir";
            this.LblMisir.Size = new System.Drawing.Size(59, 25);
            this.LblMisir.TabIndex = 2;
            this.LblMisir.Text = "Mısır:";
            // 
            // LblBilet
            // 
            this.LblBilet.AutoSize = true;
            this.LblBilet.Location = new System.Drawing.Point(55, 159);
            this.LblBilet.Name = "LblBilet";
            this.LblBilet.Size = new System.Drawing.Size(55, 25);
            this.LblBilet.TabIndex = 3;
            this.LblBilet.Text = "Bilet:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Red;
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(339, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 352);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fiyat Tablosu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Su: 3₺";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Çay: 6₺";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Mısır: 12₺";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Bilet: 24₺";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Yellow;
            this.groupBox3.Controls.Add(this.LblKasa);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.LblToplam);
            this.groupBox3.Location = new System.Drawing.Point(581, 122);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(270, 352);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kasa";
            // 
            // LblToplam
            // 
            this.LblToplam.AutoSize = true;
            this.LblToplam.Location = new System.Drawing.Point(77, 128);
            this.LblToplam.Name = "LblToplam";
            this.LblToplam.Size = new System.Drawing.Size(122, 25);
            this.LblToplam.TabIndex = 3;
            this.LblToplam.Text = "Toplam: 00₺";
            // 
            // TxtSu
            // 
            this.TxtSu.Location = new System.Drawing.Point(116, 51);
            this.TxtSu.Name = "TxtSu";
            this.TxtSu.Size = new System.Drawing.Size(100, 30);
            this.TxtSu.TabIndex = 4;
            // 
            // TxtCay
            // 
            this.TxtCay.Location = new System.Drawing.Point(116, 87);
            this.TxtCay.Name = "TxtCay";
            this.TxtCay.Size = new System.Drawing.Size(100, 30);
            this.TxtCay.TabIndex = 5;
            // 
            // TxtMisir
            // 
            this.TxtMisir.Location = new System.Drawing.Point(116, 123);
            this.TxtMisir.Name = "TxtMisir";
            this.TxtMisir.Size = new System.Drawing.Size(100, 30);
            this.TxtMisir.TabIndex = 6;
            // 
            // TxtBilet
            // 
            this.TxtBilet.Location = new System.Drawing.Point(116, 159);
            this.TxtBilet.Name = "TxtBilet";
            this.TxtBilet.Size = new System.Drawing.Size(100, 30);
            this.TxtBilet.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(663, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // LblKasa
            // 
            this.LblKasa.AutoSize = true;
            this.LblKasa.Location = new System.Drawing.Point(77, 290);
            this.LblKasa.Name = "LblKasa";
            this.LblKasa.Size = new System.Drawing.Size(102, 25);
            this.LblKasa.TabIndex = 5;
            this.LblKasa.Text = "Kasa: 00₺";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 703);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Büfe";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtBilet;
        private System.Windows.Forms.TextBox TxtMisir;
        private System.Windows.Forms.TextBox TxtCay;
        private System.Windows.Forms.TextBox TxtSu;
        private System.Windows.Forms.Label LblBilet;
        private System.Windows.Forms.Label LblMisir;
        private System.Windows.Forms.Label LblCay;
        private System.Windows.Forms.Label LblSu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label LblKasa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LblToplam;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

