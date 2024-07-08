namespace FilmİzlemeApp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Kaydet = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Btn_cikis = new System.Windows.Forms.Button();
            this.Btn_renkdegistir = new System.Windows.Forms.Button();
            this.Btn_hakkımızda = new System.Windows.Forms.Button();
            this.Btn_tamEkran = new System.Windows.Forms.Button();
            this.TxtLink = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtFilmKategori = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtFilmAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chromiumWebBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser();
            this.Btn_Sil = new System.Windows.Forms.Button();
            this.Txt_filmid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1239, 103);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1014, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(198, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sinema Yazılım";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txt_filmid);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Btn_Sil);
            this.groupBox1.Controls.Add(this.Btn_Kaydet);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.TxtLink);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtFilmKategori);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtFilmAd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(0, 111);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(405, 637);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Film";
            // 
            // Btn_Kaydet
            // 
            this.Btn_Kaydet.Location = new System.Drawing.Point(111, 135);
            this.Btn_Kaydet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Kaydet.Name = "Btn_Kaydet";
            this.Btn_Kaydet.Size = new System.Drawing.Size(262, 32);
            this.Btn_Kaydet.TabIndex = 3;
            this.Btn_Kaydet.Text = "KAYDET";
            this.Btn_Kaydet.UseVisualStyleBackColor = true;
            this.Btn_Kaydet.Click += new System.EventHandler(this.Btn_Kaydet_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Btn_cikis);
            this.groupBox4.Controls.Add(this.Btn_renkdegistir);
            this.groupBox4.Controls.Add(this.Btn_hakkımızda);
            this.groupBox4.Controls.Add(this.Btn_tamEkran);
            this.groupBox4.Location = new System.Drawing.Point(18, 286);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(372, 331);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "İşlemler";
            // 
            // Btn_cikis
            // 
            this.Btn_cikis.Location = new System.Drawing.Point(76, 246);
            this.Btn_cikis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_cikis.Name = "Btn_cikis";
            this.Btn_cikis.Size = new System.Drawing.Size(262, 49);
            this.Btn_cikis.TabIndex = 3;
            this.Btn_cikis.Text = "ÇIKIŞ";
            this.Btn_cikis.UseVisualStyleBackColor = true;
            this.Btn_cikis.Click += new System.EventHandler(this.Btn_cikis_Click);
            // 
            // Btn_renkdegistir
            // 
            this.Btn_renkdegistir.Location = new System.Drawing.Point(76, 180);
            this.Btn_renkdegistir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_renkdegistir.Name = "Btn_renkdegistir";
            this.Btn_renkdegistir.Size = new System.Drawing.Size(262, 49);
            this.Btn_renkdegistir.TabIndex = 3;
            this.Btn_renkdegistir.Text = "RENK DEĞİŞTİR";
            this.Btn_renkdegistir.UseVisualStyleBackColor = true;
            this.Btn_renkdegistir.Click += new System.EventHandler(this.Btn_renkdegistir_Click);
            // 
            // Btn_hakkımızda
            // 
            this.Btn_hakkımızda.Location = new System.Drawing.Point(76, 122);
            this.Btn_hakkımızda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_hakkımızda.Name = "Btn_hakkımızda";
            this.Btn_hakkımızda.Size = new System.Drawing.Size(262, 49);
            this.Btn_hakkımızda.TabIndex = 3;
            this.Btn_hakkımızda.Text = "HAKKIMIZDA";
            this.Btn_hakkımızda.UseVisualStyleBackColor = true;
            this.Btn_hakkımızda.Click += new System.EventHandler(this.Btn_hakkımızda_Click);
            // 
            // Btn_tamEkran
            // 
            this.Btn_tamEkran.Location = new System.Drawing.Point(76, 62);
            this.Btn_tamEkran.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_tamEkran.Name = "Btn_tamEkran";
            this.Btn_tamEkran.Size = new System.Drawing.Size(262, 49);
            this.Btn_tamEkran.TabIndex = 3;
            this.Btn_tamEkran.Text = "TAM EKRAN";
            this.Btn_tamEkran.UseVisualStyleBackColor = true;
            this.Btn_tamEkran.Click += new System.EventHandler(this.Btn_tamEkran_Click);
            // 
            // TxtLink
            // 
            this.TxtLink.Location = new System.Drawing.Point(111, 96);
            this.TxtLink.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtLink.Name = "TxtLink";
            this.TxtLink.Size = new System.Drawing.Size(260, 26);
            this.TxtLink.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Link :";
            // 
            // TxtFilmKategori
            // 
            this.TxtFilmKategori.Location = new System.Drawing.Point(111, 60);
            this.TxtFilmKategori.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtFilmKategori.Name = "TxtFilmKategori";
            this.TxtFilmKategori.Size = new System.Drawing.Size(260, 26);
            this.TxtFilmKategori.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kategori :";
            // 
            // TxtFilmAd
            // 
            this.TxtFilmAd.Location = new System.Drawing.Point(111, 24);
            this.TxtFilmAd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtFilmAd.Name = "TxtFilmAd";
            this.TxtFilmAd.Size = new System.Drawing.Size(260, 26);
            this.TxtFilmAd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Film Adı:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(410, 111);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(437, 637);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Film Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 24);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(429, 608);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chromiumWebBrowser1);
            this.groupBox3.Location = new System.Drawing.Point(855, 111);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(446, 632);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ekran";
            // 
            // chromiumWebBrowser1
            // 
            this.chromiumWebBrowser1.ActivateBrowserOnCreation = false;
            this.chromiumWebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chromiumWebBrowser1.Location = new System.Drawing.Point(4, 24);
            this.chromiumWebBrowser1.Name = "chromiumWebBrowser1";
            this.chromiumWebBrowser1.Size = new System.Drawing.Size(438, 603);
            this.chromiumWebBrowser1.TabIndex = 0;
            // 
            // Btn_Sil
            // 
            this.Btn_Sil.Location = new System.Drawing.Point(111, 255);
            this.Btn_Sil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Sil.Name = "Btn_Sil";
            this.Btn_Sil.Size = new System.Drawing.Size(262, 32);
            this.Btn_Sil.TabIndex = 4;
            this.Btn_Sil.Text = "SİL";
            this.Btn_Sil.UseVisualStyleBackColor = true;
            this.Btn_Sil.Click += new System.EventHandler(this.Btn_Sil_Click_1);
            // 
            // Txt_filmid
            // 
            this.Txt_filmid.Location = new System.Drawing.Point(149, 219);
            this.Txt_filmid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_filmid.Name = "Txt_filmid";
            this.Txt_filmid.Size = new System.Drawing.Size(241, 26);
            this.Txt_filmid.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 225);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Silenecek film id:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 746);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtLink;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtFilmKategori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtFilmAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Kaydet;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Btn_cikis;
        private System.Windows.Forms.Button Btn_renkdegistir;
        private System.Windows.Forms.Button Btn_hakkımızda;
        private System.Windows.Forms.Button Btn_tamEkran;
        private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser1;
        private System.Windows.Forms.Button Btn_Sil;
        private System.Windows.Forms.TextBox Txt_filmid;
        private System.Windows.Forms.Label label5;
    }
}

