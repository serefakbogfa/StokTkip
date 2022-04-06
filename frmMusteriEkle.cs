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
    public partial class frmMusteriEkle : Form
    {
        public frmMusteriEkle()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-POJFHO5;Initial Catalog=StokTKP;Integrated Security=True";
        SqlConnection baglantı = new SqlConnection(conString);
        private void frmMusteriEkle_Load(object sender, EventArgs e)
        {


        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            string kayıt = "insert into musteri(tc ,adsoyad , telefon , adres, email) values(@tc ,@adsoyad , @telefon , @adres, @email)";
            SqlCommand komut = new SqlCommand(kayıt, baglantı);
            komut.Parameters.AddWithValue("@tc", txtTC.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtadsoyad.Text);
            komut.Parameters.AddWithValue("@telefon", txttelefon.Text);
            komut.Parameters.AddWithValue("@adres", txtadres.Text);
            komut.Parameters.AddWithValue("@email", txtemail.Text);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Müşteri eklendi");
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }

            }
        }
    }
}