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
    public partial class MusteriListeleme : Form
    {
        public MusteriListeleme()
        {
            InitializeComponent();
        }
            static string conString = "Data Source=DESKTOP-POJFHO5;Initial Catalog=StokTKP;Integrated Security=True";
            SqlConnection baglantı = new SqlConnection(conString);
             DataSet dta = new DataSet();

        private void kayıt_goster() {
            baglantı.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from  musteri" , baglantı);
            adtr.Fill(dta ,"musteri");
            dataGridView1.DataSource = dta.Tables["musteri"];
            baglantı.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("delete form musteri where tc= '" + dataGridView1.CurrentRow.Cells["tc"].Value.ToString() + "'",baglantı);

            komut.ExecuteNonQuery();
            baglantı.Close();
            dta.Tables.Clear();
            kayıt_goster();
            MessageBox.Show("kayıt silindi");
                
                }

        private void MusteriListeleme_Load(object sender, EventArgs e)
        {
            kayıt_goster();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTC.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
            txtadsoyad.Text = dataGridView1.CurrentRow.Cells["adsoyad"].Value.ToString();
            txttelefon.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
            txtadres.Text = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
            txtemail.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
        }

        private void txtadsoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut5 = new SqlCommand("update  musteri set adsoyad=@adsoyad , yas=@yas , cinsiyet=@cinsiyet , telefon=@telefon , adress=@adress , email=@email where tc=@tc", baglantı);
            komut5.Parameters.AddWithValue("@tc", txtTC.Text);
            komut5.Parameters.AddWithValue("@adsoyad", txtadsoyad.Text);           
            komut5.Parameters.AddWithValue("@telefon", txttelefon.Text);
            komut5.Parameters.AddWithValue("@adress", txtadres.Text);
            komut5.Parameters.AddWithValue("@email", txtemail.Text);          
            komut5.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("kayıt güncellendi");
            dta.Tables.Clear();
           kayıt_goster();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglantı.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from  musteri where tc like  '%"+txttcara.Text+ "%'" , baglantı);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglantı.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
