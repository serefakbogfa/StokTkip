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
    public partial class ÜrünListeleme : Form
    {
        public ÜrünListeleme()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-POJFHO5;Initial Catalog=StokTKP;Integrated Security=True";
        SqlConnection baglantı = new SqlConnection(conString);
        DataSet dset = new DataSet();

        private void kategori_getir()
        {
            //kategorileri comboxa çekme
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select *form kategoribilgiler", baglantı);
            SqlDataReader dtr = komut.ExecuteReader();
            while (dtr.Read())
            {
                comboBox1.Items.Add(dtr["katergori"].ToString());
            }
            baglantı.Close();
        }

        private void Ürünlistelet()
        {
            baglantı.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from urun ", baglantı);
            dataGridView1.DataSource = dset.Tables["urun"];
            baglantı.Close();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ÜrünListeleme_Load(object sender, EventArgs e)
        {
            Ürünlistelet();
            kategori_getir();


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bartxt.Text = dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString();
            katetxt.Text = dataGridView1.CurrentRow.Cells["kategori"].Value.ToString();
            markatxt.Text = dataGridView1.CurrentRow.Cells["marka"].Value.ToString();
            uruntxt.Text = dataGridView1.CurrentRow.Cells["urunadı"].Value.ToString();
            miktxt.Text = dataGridView1.CurrentRow.Cells["miktarı "].Value.ToString();
            alistxt.Text = dataGridView1.CurrentRow.Cells["alısfiyatı"].Value.ToString();
            satistxt.Text = dataGridView1.CurrentRow.Cells["satısfiyati"].Value.ToString();
        }

        private void btn_mark_Click(object sender, EventArgs e)
        {
            //ürün güncelleme işlemi db üzerinden yapıldı 
            baglantı.Open();
            SqlCommand komut = new SqlCommand("update urun set urunadı=@urunadı,miktarı_@miktarı,alısfiyatı_@alısfiyatı,satısfiyati=@satısfiyati where barkodno=@barkodnu", baglantı);
            komut.Parameters.AddWithValue("@barkodno", bartxt.Text);
            komut.Parameters.AddWithValue("@urunadı", uruntxt.Text);
            komut.Parameters.AddWithValue("@miktarı", miktxt.Text);
            komut.Parameters.AddWithValue("@alısfiyatı", alistxt.Text);
            komut.Parameters.AddWithValue("@satısfiyati", satistxt.Text);
            komut.ExecuteNonQuery();
            baglantı.Close();
            dset.Tables["urun"].Clear();
            Ürünlistelet();
            MessageBox.Show("Güncelleme yapıldu");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }


            }
        }

        private void btnmarkagüncelle_Click(object sender, EventArgs e)
        {
            //kategori ve marka barkodno üzerinden güncelleme yapıldıu 
            if (bartxt.Text == "")
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("update urun set kategori=@kategori,marka=@marka where barkodno=@barkodnu", baglantı);
                komut.Parameters.AddWithValue("@barkodno", bartxt.Text);
                komut.Parameters.AddWithValue("@kategori", comboBox1.Text);
                komut.Parameters.AddWithValue("@marka", comboBox2.Text);

                komut.ExecuteNonQuery();
                baglantı.Close();
                dset.Tables["urun"].Clear();
                Ürünlistelet();
                MessageBox.Show("Güncelleme yapıldu");
            }
            else
            {
                MessageBox.Show("barkodno seçili değil ");
            }

            
            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "";//textin içini temizler
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select kategori , marka form markabilgiler where kategori ='" + comboBox2.SelectedItem + "'");
            SqlDataReader dtr = komut.ExecuteReader();
            while (dtr.Read())
            {
                comboBox2.Items.Add(dtr["marka"].ToString());
            }
            baglantı.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("delete form musteri where tc= '" + dataGridView1.CurrentRow.Cells["tc"].Value.ToString() + "'", baglantı);

            komut.ExecuteNonQuery();
            baglantı.Close();
            dset.Tables.Clear();
            Ürünlistelet();
            MessageBox.Show("kayıt silindi");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //arama işlemi(datatable ile geçici bir tablo yapıp onun üzerinden aram işlemi gerçekleştirme)
            DataTable tablo = new DataTable();
            baglantı.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from  urun where tc like  '%" + textBox1.Text + "%'", baglantı);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglantı.Close();
        }
    }
 }

