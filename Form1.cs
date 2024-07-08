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
using CefSharp.WinForms;
namespace FilmİzlemeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-BC3LOP2\SQLEXPRESS;Initial Catalog=FilmArsivies;Integrated Security=True;");

        void filmler()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select AD,KATEGORİ,LINK,DURUM from TBLFİLMLER ",baglanti);   
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        Color[] renkler = { Color.LawnGreen, Color.LightBlue, Color.Orange, Color.Pink, Color.SandyBrown, Color.Yellow, Color.Purple, Color.Violet, Color.Gray, Color.Honeydew };

        Random rand = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            filmler();


       
        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLFİLMLER (AD,KATEGORİ,LINK) values(@P1,@P2,@P3)",baglanti);
            komut.Parameters.AddWithValue("@P1", TxtFilmAd.Text);
            komut.Parameters.AddWithValue("@P2", TxtFilmKategori.Text);
            komut.Parameters.AddWithValue("@P3", TxtLink.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Film listenize eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            filmler();
            TxtFilmAd.Text = "";
            TxtFilmKategori.Text = "";
            TxtLink.Text = "";
        }
       


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int satirNo = dataGridView1.SelectedCells[0].RowIndex;
            string link = dataGridView1.Rows[satirNo].Cells[2].Value.ToString();
           
            chromiumWebBrowser1.Load(link);

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Btn_hakkımızda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu film yazılımı Selim Çınar tarafından 2024'de yapılmıştır");
        }

        private void Btn_renkdegistir_Click(object sender, EventArgs e)
        {
            int sayi = rand.Next(0, 10);

            this.BackColor = renkler[sayi];



            int red = rand.Next(0, 255);
            int green = rand.Next(0, 255);
            int blue = rand.Next(0, 255);

            this.BackColor = Color.FromArgb(red, green, blue);
        }

        private void Btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Sil_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(Txt_filmid.Text, out int filmId))
            {
                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("DELETE FROM TBLFİLMLER WHERE ID = @P1", baglanti);
                    komut.Parameters.AddWithValue("@P1", filmId);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Film listenizden silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    filmler();
                    Txt_filmid.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Geçerli bir film ID'si girin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_tamEkran_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}
