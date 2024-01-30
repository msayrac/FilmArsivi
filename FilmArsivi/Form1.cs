using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FilmArsivi
{
	public partial class form1 : Form
	{
		public form1()
		{
			InitializeComponent();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		SqlConnection baglanti = new SqlConnection(@"Data Source = msyc; Initial Catalog = FilmArsivi; Integrated Security = True");

		void filmler()
		{
			SqlDataAdapter da = new SqlDataAdapter("Select* from TBLFILMLER",baglanti);
			DataTable dt = new DataTable();

			da.Fill(dt);			
			dataGridView1.DataSource = dt;
		}


		private void Form1_Load(object sender, EventArgs e)
		{
			filmler();		



		}

		private void BtnKaydet_Click(object sender, EventArgs e)
		{

			baglanti.Open();
			SqlCommand komut = new SqlCommand("insert into TBLFILMLER (AD, KATEGORI, LINK) values (@P1,@P2,@P3)",baglanti);

			komut.Parameters.AddWithValue("@P1", TxtFilmAd.Text);
			komut.Parameters.AddWithValue("@P2", TxtKategori.Text);
			komut.Parameters.AddWithValue("@P3", TxtLink.Text);

			komut.ExecuteNonQuery();
			baglanti.Close();

			MessageBox.Show("Film Listenize Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			filmler();



		}

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int secilen = dataGridView1.SelectedCells[0].RowIndex;

			string link = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

			webBrowser1.Navigate(link);
		}

		private void BtnHakkimizda_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Bu proje MSayrac tarafından 30 Ocak 2024 tarihinde kodlandı.", "Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Warning);
		}

		private void BtnCikis_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		Color ColorChange()
		{
			Random rnd =new Random();

			int red = rnd.Next(0, 255);
			int green = rnd.Next(0, 255);
			int blue = rnd.Next(0, 255);

			Color color = Color.FromArgb(red, green, blue);

			return color;

		}
		private void BtnRenkDegistir_Click(object sender, EventArgs e)
		{
			//formun arka rengini degistir
			this.BackColor = ColorChange();

			
		}

		private void BtnTamEkran_Click(object sender, EventArgs e)
		{
			
		}
	}
}
