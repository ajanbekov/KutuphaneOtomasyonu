namespace Kütüphane_Otomasyonu
{
    partial class AnaSayfafrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfafrm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUyeListele = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnUyeEkle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnKitapListele = new System.Windows.Forms.Button();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEmanetİade = new System.Windows.Forms.Button();
            this.btnEmanetListele = new System.Windows.Forms.Button();
            this.btnEmanetVer = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGrafik = new System.Windows.Forms.Button();
            this.btnSirala = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.btnUyeListele);
            this.groupBox1.Controls.Add(this.btnUyeEkle);
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(40, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 231);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye İşlemleri";
            // 
            // btnUyeListele
            // 
            this.btnUyeListele.Font = new System.Drawing.Font("STZhongsong", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyeListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUyeListele.ImageIndex = 1;
            this.btnUyeListele.ImageList = this.ımageList1;
            this.btnUyeListele.Location = new System.Drawing.Point(44, 131);
            this.btnUyeListele.Name = "btnUyeListele";
            this.btnUyeListele.Size = new System.Drawing.Size(248, 76);
            this.btnUyeListele.TabIndex = 1;
            this.btnUyeListele.Text = "Üye Listeleme";
            this.btnUyeListele.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUyeListele.UseVisualStyleBackColor = true;
            this.btnUyeListele.Click += new System.EventHandler(this.btnUyeListele_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Üye Ekleme.png");
            this.ımageList1.Images.SetKeyName(1, "Kütühane Otomasyonu Üye Listeleme Butonu Resmi.png");
            this.ımageList1.Images.SetKeyName(2, "Teslim Al.png");
            this.ımageList1.Images.SetKeyName(3, "Emanet Kitap Listeleme.png");
            this.ımageList1.Images.SetKeyName(4, "Emanet Kitap İade.png");
            this.ımageList1.Images.SetKeyName(5, "Kitap Ekleme İşlemleri.png");
            this.ımageList1.Images.SetKeyName(6, "Kitap Listeleme İşlemleri.png");
            this.ımageList1.Images.SetKeyName(7, "Sıralama.png");
            this.ımageList1.Images.SetKeyName(8, "Grafik.png");
            // 
            // btnUyeEkle
            // 
            this.btnUyeEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUyeEkle.Font = new System.Drawing.Font("STZhongsong", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyeEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUyeEkle.ImageIndex = 0;
            this.btnUyeEkle.ImageList = this.ımageList1;
            this.btnUyeEkle.Location = new System.Drawing.Point(44, 36);
            this.btnUyeEkle.Name = "btnUyeEkle";
            this.btnUyeEkle.Size = new System.Drawing.Size(223, 76);
            this.btnUyeEkle.TabIndex = 0;
            this.btnUyeEkle.Text = "Üye Ekleme";
            this.btnUyeEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUyeEkle.UseVisualStyleBackColor = true;
            this.btnUyeEkle.Click += new System.EventHandler(this.btnUyeEkle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnKitapListele);
            this.groupBox2.Controls.Add(this.btnKitapEkle);
            this.groupBox2.Location = new System.Drawing.Point(763, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 231);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap İşlemleri";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("STZhongsong", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(-631, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(432, 76);
            this.button1.TabIndex = 1;
            this.button1.Text = "Üye Listeleme İşlemleri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnUyeListele_Click);
            // 
            // btnKitapListele
            // 
            this.btnKitapListele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKitapListele.Font = new System.Drawing.Font("STZhongsong", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKitapListele.ImageIndex = 6;
            this.btnKitapListele.ImageList = this.ımageList1;
            this.btnKitapListele.Location = new System.Drawing.Point(48, 131);
            this.btnKitapListele.Name = "btnKitapListele";
            this.btnKitapListele.Size = new System.Drawing.Size(279, 76);
            this.btnKitapListele.TabIndex = 1;
            this.btnKitapListele.Text = "Kitap Listeleme";
            this.btnKitapListele.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKitapListele.UseVisualStyleBackColor = true;
            this.btnKitapListele.Click += new System.EventHandler(this.btnKitapListele_Click);
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKitapEkle.Font = new System.Drawing.Font("STZhongsong", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKitapEkle.ImageIndex = 5;
            this.btnKitapEkle.ImageList = this.ımageList1;
            this.btnKitapEkle.Location = new System.Drawing.Point(48, 36);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(253, 76);
            this.btnKitapEkle.TabIndex = 0;
            this.btnKitapEkle.Text = "Kitap Ekleme";
            this.btnKitapEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Silver;
            this.groupBox3.Controls.Add(this.btnEmanetİade);
            this.groupBox3.Controls.Add(this.btnEmanetListele);
            this.groupBox3.Controls.Add(this.btnEmanetVer);
            this.groupBox3.Location = new System.Drawing.Point(40, 381);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(455, 323);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Emanet Kitap İşlemleri";
            // 
            // btnEmanetİade
            // 
            this.btnEmanetİade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmanetİade.Font = new System.Drawing.Font("STZhongsong", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmanetİade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmanetİade.ImageIndex = 4;
            this.btnEmanetİade.ImageList = this.ımageList1;
            this.btnEmanetİade.Location = new System.Drawing.Point(44, 223);
            this.btnEmanetİade.Name = "btnEmanetİade";
            this.btnEmanetİade.Size = new System.Drawing.Size(309, 77);
            this.btnEmanetİade.TabIndex = 2;
            this.btnEmanetİade.Text = "Emanet Kitap İade";
            this.btnEmanetİade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmanetİade.UseVisualStyleBackColor = true;
            this.btnEmanetİade.Click += new System.EventHandler(this.btnEmanetİade_Click);
            // 
            // btnEmanetListele
            // 
            this.btnEmanetListele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmanetListele.Font = new System.Drawing.Font("STZhongsong", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmanetListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmanetListele.ImageIndex = 3;
            this.btnEmanetListele.ImageList = this.ımageList1;
            this.btnEmanetListele.Location = new System.Drawing.Point(44, 129);
            this.btnEmanetListele.Name = "btnEmanetListele";
            this.btnEmanetListele.Size = new System.Drawing.Size(369, 76);
            this.btnEmanetListele.TabIndex = 1;
            this.btnEmanetListele.Text = "Emanet Kitap Listeleme";
            this.btnEmanetListele.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmanetListele.UseVisualStyleBackColor = true;
            this.btnEmanetListele.Click += new System.EventHandler(this.btnEmanetListele_Click);
            // 
            // btnEmanetVer
            // 
            this.btnEmanetVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmanetVer.Font = new System.Drawing.Font("STZhongsong", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmanetVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmanetVer.ImageIndex = 2;
            this.btnEmanetVer.ImageList = this.ımageList1;
            this.btnEmanetVer.Location = new System.Drawing.Point(44, 33);
            this.btnEmanetVer.Name = "btnEmanetVer";
            this.btnEmanetVer.Size = new System.Drawing.Size(330, 77);
            this.btnEmanetVer.TabIndex = 0;
            this.btnEmanetVer.Text = "Emanet Kitap Verme";
            this.btnEmanetVer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmanetVer.UseVisualStyleBackColor = true;
            this.btnEmanetVer.Click += new System.EventHandler(this.btnEmanetVer_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Silver;
            this.groupBox4.Controls.Add(this.btnGrafik);
            this.groupBox4.Controls.Add(this.btnSirala);
            this.groupBox4.Location = new System.Drawing.Point(853, 464);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(277, 231);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sıralama Ve Grafikler";
            // 
            // btnGrafik
            // 
            this.btnGrafik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrafik.Font = new System.Drawing.Font("STZhongsong", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGrafik.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrafik.ImageIndex = 8;
            this.btnGrafik.ImageList = this.ımageList1;
            this.btnGrafik.Location = new System.Drawing.Point(46, 131);
            this.btnGrafik.Name = "btnGrafik";
            this.btnGrafik.Size = new System.Drawing.Size(189, 76);
            this.btnGrafik.TabIndex = 1;
            this.btnGrafik.Text = "Grafiker";
            this.btnGrafik.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrafik.UseVisualStyleBackColor = true;
            this.btnGrafik.Click += new System.EventHandler(this.btnGrafik_Click);
            // 
            // btnSirala
            // 
            this.btnSirala.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSirala.Font = new System.Drawing.Font("STZhongsong", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSirala.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSirala.ImageIndex = 7;
            this.btnSirala.ImageList = this.ımageList1;
            this.btnSirala.Location = new System.Drawing.Point(47, 36);
            this.btnSirala.Name = "btnSirala";
            this.btnSirala.Size = new System.Drawing.Size(189, 76);
            this.btnSirala.TabIndex = 0;
            this.btnSirala.Text = "Sıralama";
            this.btnSirala.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSirala.UseVisualStyleBackColor = true;
            this.btnSirala.Click += new System.EventHandler(this.btnSirala_Click);
            // 
            // AnaSayfafrm
            // 
            this.AcceptButton = this.btnUyeEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.BackgroundImage = global::Kütüphane_Otomasyonu.Properties.Resources.Kütühane_Otomasyonu_İçin_Kütühane_Resmi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1175, 734);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AnaSayfafrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnUyeListele;
        private System.Windows.Forms.Button btnUyeEkle;
        private System.Windows.Forms.Button btnKitapListele;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.Button btnEmanetİade;
        private System.Windows.Forms.Button btnEmanetListele;
        private System.Windows.Forms.Button btnEmanetVer;
        private System.Windows.Forms.Button btnGrafik;
        private System.Windows.Forms.Button btnSirala;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList ımageList1;
    }
}

