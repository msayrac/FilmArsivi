namespace FilmArsivi
{
	partial class form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.TxtFilmAd = new System.Windows.Forms.TextBox();
			this.TxtKategori = new System.Windows.Forms.TextBox();
			this.TxtLink = new System.Windows.Forms.TextBox();
			this.BtnKaydet = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.BtnTamEkran = new System.Windows.Forms.Button();
			this.BtnHakkimizda = new System.Windows.Forms.Button();
			this.BtnRenkDegistir = new System.Windows.Forms.Button();
			this.BtnCikis = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(13, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1182, 65);
			this.panel1.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.groupBox3);
			this.groupBox1.Controls.Add(this.BtnKaydet);
			this.groupBox1.Controls.Add(this.TxtLink);
			this.groupBox1.Controls.Add(this.TxtKategori);
			this.groupBox1.Controls.Add(this.TxtFilmAd);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(13, 93);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(302, 499);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Yeni Film";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.webBrowser1);
			this.groupBox2.Location = new System.Drawing.Point(647, 83);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(548, 512);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Ekran";
			// 
			// webBrowser1
			// 
			this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser1.Location = new System.Drawing.Point(3, 26);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(542, 483);
			this.webBrowser1.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(1100, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(74, 54);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(355, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(440, 50);
			this.label1.TabIndex = 1;
			this.label1.Text = "SİNEMA KOLTUK YAZILIM";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.dataGridView1);
			this.groupBox4.Location = new System.Drawing.Point(337, 93);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(304, 499);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Film Listesi";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(2, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 25);
			this.label2.TabIndex = 0;
			this.label2.Text = "Film Ad :";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(2, 82);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(91, 25);
			this.label3.TabIndex = 1;
			this.label3.Text = "Kategori:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(34, 119);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 25);
			this.label4.TabIndex = 2;
			this.label4.Text = "Link:";
			// 
			// TxtFilmAd
			// 
			this.TxtFilmAd.Location = new System.Drawing.Point(89, 41);
			this.TxtFilmAd.Name = "TxtFilmAd";
			this.TxtFilmAd.Size = new System.Drawing.Size(207, 30);
			this.TxtFilmAd.TabIndex = 3;
			// 
			// TxtKategori
			// 
			this.TxtKategori.Location = new System.Drawing.Point(89, 77);
			this.TxtKategori.Name = "TxtKategori";
			this.TxtKategori.Size = new System.Drawing.Size(207, 30);
			this.TxtKategori.TabIndex = 4;
			// 
			// TxtLink
			// 
			this.TxtLink.Location = new System.Drawing.Point(89, 113);
			this.TxtLink.Name = "TxtLink";
			this.TxtLink.Size = new System.Drawing.Size(207, 30);
			this.TxtLink.TabIndex = 5;
			// 
			// BtnKaydet
			// 
			this.BtnKaydet.Location = new System.Drawing.Point(89, 149);
			this.BtnKaydet.Name = "BtnKaydet";
			this.BtnKaydet.Size = new System.Drawing.Size(207, 36);
			this.BtnKaydet.TabIndex = 6;
			this.BtnKaydet.Text = "Kaydet";
			this.BtnKaydet.UseVisualStyleBackColor = true;
			this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.BtnCikis);
			this.groupBox3.Controls.Add(this.BtnRenkDegistir);
			this.groupBox3.Controls.Add(this.BtnHakkimizda);
			this.groupBox3.Controls.Add(this.BtnTamEkran);
			this.groupBox3.Location = new System.Drawing.Point(7, 187);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(289, 306);
			this.groupBox3.TabIndex = 7;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "İşlemler";
			// 
			// BtnTamEkran
			// 
			this.BtnTamEkran.Location = new System.Drawing.Point(0, 29);
			this.BtnTamEkran.Name = "BtnTamEkran";
			this.BtnTamEkran.Size = new System.Drawing.Size(289, 36);
			this.BtnTamEkran.TabIndex = 8;
			this.BtnTamEkran.Text = "Tam Ekran";
			this.BtnTamEkran.UseVisualStyleBackColor = true;
			this.BtnTamEkran.Click += new System.EventHandler(this.BtnTamEkran_Click);
			// 
			// BtnHakkimizda
			// 
			this.BtnHakkimizda.Location = new System.Drawing.Point(0, 71);
			this.BtnHakkimizda.Name = "BtnHakkimizda";
			this.BtnHakkimizda.Size = new System.Drawing.Size(289, 36);
			this.BtnHakkimizda.TabIndex = 9;
			this.BtnHakkimizda.Text = "Hakkımızda";
			this.BtnHakkimizda.UseVisualStyleBackColor = true;
			this.BtnHakkimizda.Click += new System.EventHandler(this.BtnHakkimizda_Click);
			// 
			// BtnRenkDegistir
			// 
			this.BtnRenkDegistir.Location = new System.Drawing.Point(0, 113);
			this.BtnRenkDegistir.Name = "BtnRenkDegistir";
			this.BtnRenkDegistir.Size = new System.Drawing.Size(289, 36);
			this.BtnRenkDegistir.TabIndex = 10;
			this.BtnRenkDegistir.Text = "Renk Değiştir";
			this.BtnRenkDegistir.UseVisualStyleBackColor = true;
			this.BtnRenkDegistir.Click += new System.EventHandler(this.BtnRenkDegistir_Click);
			// 
			// BtnCikis
			// 
			this.BtnCikis.Location = new System.Drawing.Point(0, 155);
			this.BtnCikis.Name = "BtnCikis";
			this.BtnCikis.Size = new System.Drawing.Size(289, 36);
			this.BtnCikis.TabIndex = 11;
			this.BtnCikis.Text = "Çıkış";
			this.BtnCikis.UseVisualStyleBackColor = true;
			this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(3, 26);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(298, 470);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			// 
			// form1
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.RosyBrown;
			this.ClientSize = new System.Drawing.Size(1199, 607);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Name = "form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox TxtLink;
		private System.Windows.Forms.TextBox TxtKategori;
		private System.Windows.Forms.TextBox TxtFilmAd;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button BtnCikis;
		private System.Windows.Forms.Button BtnRenkDegistir;
		private System.Windows.Forms.Button BtnHakkimizda;
		private System.Windows.Forms.Button BtnTamEkran;
		private System.Windows.Forms.Button BtnKaydet;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}

