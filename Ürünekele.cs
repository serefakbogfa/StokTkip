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

namespace StokTkip
{
    public partial class Ürünekele : Form
    {
        public Ürünekele()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-POJFHO5;Initial Catalog=StokTKP;Integrated Security=True";
        SqlConnection baglantı = new SqlConnection(conString);
        bool durum;
        private void barkodkontrol()

        {
            //barkodkontrol eklenirken var olan bir kategoriyi ekleme durumunu engeleyen metot
            durum = true;
            baglantı.Open();
            SqlCommand cmd = new SqlCommand("select *form urun", baglantı);
            SqlDataReader read = cmd.ExecuteReader();


            if (txtbarkodno.Text == read["barkodno"].ToString() || txtbarkodno.Text == "") 
            {
                durum = false;
            }
        }


        private void kategori_getir()
        {
            //kategorileri comboxa çekme
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select *form kategoribilgiler", baglantı);
            SqlDataReader dtr = komut.ExecuteReader();
            while (dtr.Read())
            {
                combokate.Items.Add(dtr["katergori"].ToString());
            }
            baglantı.Close();
        }
        private void Ürünekele_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ürün ekleme işlemi
            barkodkontrol();
            if (durum == true)
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("insert into urun(barkodno,kategori,marka,urunadı,miktarı,alısfiyatı,satısfiyati,tarih) values(@barkodno,@kategori,@marka,@urunadı,@miktarı,@alısfiyatı,@satısfiyati,@tarih)", baglantı);
                komut.Parameters.AddWithValue("@barkodno", txtbarkodno.Text);
                komut.Parameters.AddWithValue("@kategori", combokate.Text);
                komut.Parameters.AddWithValue("@marka", combomarka.Text);
                komut.Parameters.AddWithValue("@miktari", int.Parse(txtmiktr.Text));
                komut.Parameters.AddWithValue("@urunadı", txtmiktr.Text);
                komut.Parameters.AddWithValue("@alısfiyatı", double.Parse(txtalis.Text));
                komut.Parameters.AddWithValue("@satısfiyati", double.Parse(txtsatis.Text));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());

                komut.ExecuteNonQuery();
                baglantı.Close();
                MessageBox.Show("ürün eklendi");
            }
            else 
            {
                MessageBox.Show("böyle bir barkod no bulunmakta");
            }
          

            //texboxları ve comboxları temizler
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox) {
                    item.Text = "";
                }
            }

        }

        private void combokate_SelectedIndexChanged(object sender, EventArgs e)
        {
            //kategoriye bağlı markaları çeker
            combomarka.Items.Clear();
            combomarka.Text = "";//textin içini temizler
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select kategori , marka form markabilgiler where kategori ='"+combokate.SelectedItem+"'");
            SqlDataReader dtr = komut.ExecuteReader();
            while (dtr.Read())
            {
              combomarka.Items.Add(dtr["marka"].ToString());
            }
            baglantı.Close();
        }

        private void bartxt_TextChanged(object sender, EventArgs e)
        {
            //temizler
            if (bartxt.Text=="" )
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                   

                }

            }
            //barkod no girildiğinde var olan ürünler textlere getiren işlem
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select *from urun where barkodno like '"+txtbarkodno+"'", baglantı);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                bartxt.Text = read["kategori"].ToString();
                bartxt.Text = read["marka"].ToString();
                bartxt.Text = read["urunadı"].ToString();
                bartxt.Text = read["miktarı"].ToString();
                bartxt.Text = read["alısfiyatı"].ToString();
                bartxt.Text = read["satısfiyati"].ToString();
                bartxt.Text = read["tarih"].ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //var olan ürün miktarında eklem (güncelleme ) yapar
            baglantı.Open();
            SqlCommand komut = new SqlCommand("update urun set mikarı=mikarı'"+int.Parse(miktxt.Text)+"' where barkodno'"+bartxt.Text+"'",baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }


            }
            MessageBox.Show("var olan ürüne ekleme yapıldı ");
        }

        private void txtbarkodno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
