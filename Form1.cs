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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-POJFHO5;Initial Catalog=StokTKP;Integrated Security=True";
        SqlConnection baglantı = new SqlConnection(conString);
        DataSet dsat = new DataSet();

        private void hesapla()
        {
            //toplam fiyat 
            try
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("select sum(toplamfiyati) from sepet ", baglantı);
                lblgeneltop.Text = komut.ExecuteScalar() + "TL";
                baglantı.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void sepetlistelem()
        {
            //kayıt yenileme için
            baglantı.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from sepet", baglantı);
            adtr.Fill(dsat, "sepet");
            dataGridView1.Columns[0].Visible = false;//ilk üç sutunu gizlemek için kullanıldı
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.DataSource = dsat.Tables["sepet"];

            baglantı.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmMusteriEkle ekle = new frmMusteriEkle();
            ekle.ShowDialog();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            sepetlistelem();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MusteriListeleme LİSTE = new MusteriListeleme();
            LİSTE.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Kategori ktg = new Kategori();
            ktg.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Marka mrk = new Marka();
            mrk.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ÜrünListeleme asda = new ÜrünListeleme();
            asda.ShowDialog();
        }

        private void txttc_TextChanged(object sender, EventArgs e)
        {
            //tc  ye göre arama yaptırıp müşteri  bilgileri almak 
            if (txttc.Text == "")
            {
                txtadsyd.Text = "";
                txttel.Text = "";

            }
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select *from musteri where tc like '" + txttc.Text + "'", baglantı);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtadsyd.Text = read["adsoyad"].ToString();
                txttel.Text = read["telefon"].ToString();
            }
        }

        private void txtbarkod_TextChanged(object sender, EventArgs e)
        {
            //barkod no ya bağlı olarak ürün bilgisi çekme
            //eğere girilen değer txtmktr değilse diğerlerini temizlet
            temizle();
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select *from urun where tc like '" + txtbarkod.Text + "'", baglantı);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txturn.Text = read["ürünadı"].ToString();
                txtsts.Text = read["satısfiyati"].ToString();
            }
        }

        private void temizle()
        {
            //
            if (txtbarkod.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item != txtmktr)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            //sepetten ürün çıkarma 
            baglantı.Open();
            SqlCommand komut = new SqlCommand("delete from sepet", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("ürünler sepeten çıkarıldı");
            dsat.Tables["sepet"].Clear();
            sepetlistelem();
            hesapla();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //sepete veri ekleme 
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into sepet(tc, adsoyad,barkodno,urunadı,miktarı,satısfiyati,toplamfiyati,tarih) values(@tc, @adsoyad,@barkodno,@urunadı,@miktarı,@satısfiyati,@toplamfiyati,@tarih)", baglantı);
            komut.Parameters.AddWithValue("@tc", txttc.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtadsyd.Text);
            komut.Parameters.AddWithValue("@barkodno", txtbarkod.Text);
            komut.Parameters.AddWithValue("@urunadı", txturn.Text);
            komut.Parameters.AddWithValue("@miktarı", int.Parse(txtmktr.Text));
            komut.Parameters.AddWithValue("@satısfiyati", int.Parse(txtsts.Text));
            komut.Parameters.AddWithValue("@toplamfiyati", int.Parse(txttpl.Text));
            komut.Parameters.AddWithValue("@telefon", DateTime.Now.ToString());
            komut.ExecuteNonQuery();
            baglantı.Close();
            hesapla();
            dsat.Tables["tables"].Clear();
            sepetlistelem();
            temizle();
        }

        private void txtmktr_TextChanged(object sender, EventArgs e)
        {//miktarı ve satış fiyatı çarpma toplam fiyatı vermesi için
            try
            {
                txttpl.Text = (double.Parse(txtmktr.Text) * double.Parse(txtsts.Text)).ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtsts_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txttpl.Text = (double.Parse(txtmktr.Text) * double.Parse(txtsts.Text)).ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //kayıt silme işlemi
            baglantı.Open();
            SqlCommand komut = new SqlCommand("delete from sepet  where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("kayıt silindi");
            hesapla();
            dsat.Tables["sepet"].Clear();
            sepetlistelem();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Satıslisteleme st = new Satıslisteleme();
            st.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {// satış işlemi aynı zamanda stoktan düşmede yapılıyor
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("insert into satıs(tc, adsoyad,barkodno,urunadı,miktarı,satısfiyati,toplamfiyati,tarih) values(@tc, @adsoyad,@barkodno,@urunadı,@miktarı,@satısfiyati,@toplamfiyati,@tarih)", baglantı);
                komut.Parameters.AddWithValue("@tc", txttc.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtadsyd.Text);
                komut.Parameters.AddWithValue("@barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());//kaç kayıt varsa aktarmak için
                komut.Parameters.AddWithValue("@urunadı", dataGridView1.Rows[i].Cells["urunadı"].Value.ToString());
                komut.Parameters.AddWithValue("@miktarı", int.Parse(dataGridView1.Rows[i].Cells["miktarı"].Value.ToString()));
                komut.Parameters.AddWithValue("@satısfiyati", int.Parse(dataGridView1.Rows[i].Cells["satısfiyati"].Value.ToString()));
                komut.Parameters.AddWithValue("@toplamfiyati", int.Parse(dataGridView1.Rows[i].Cells["toplamfiyati  "].Value.ToString()));
                komut.Parameters.AddWithValue("@telefon", DateTime.Now.ToString());
                komut.ExecuteNonQuery();               
                SqlCommand komut2 = new SqlCommand("update urun set mikarı=mikarı-'" + int.Parse(dataGridView1.Rows[i].Cells["miktarı"].Value.ToString()) + "' where barkodno'" + dataGridView1.Rows[i].Cells["barkodno"].Value.ToString() + "'", baglantı);
                komut2.ExecuteNonQuery();
                baglantı.Close();
            }
            //bütün kayıtları silip hesap, sepetlistesinin güncel halini çağırıyor
            baglantı.Open();
            SqlCommand komut3 = new SqlCommand("delete from sepet", baglantı);
            komut3.ExecuteNonQuery();
            baglantı.Close();
            hesapla();
            dsat.Tables["tables"].Clear();
            sepetlistelem();
        }
    }
}
