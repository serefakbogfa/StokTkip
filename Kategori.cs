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
    public partial class Kategori : Form
    {
        public Kategori()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-POJFHO5;Initial Catalog=StokTKP;Integrated Security=True";
        SqlConnection baglantı = new SqlConnection(conString);
        bool durum;
        private void kategoriengele()

        {
            //kategori eklenirken var olan bir kategoriyi ekleme durumunu engeleyen metot
            durum = true;
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select *form kategoribilgileri", baglantı);
            SqlDataReader read = komut.ExecuteReader();
           
            
                if (textBox1.Text==read["kategori"].ToString() || textBox1.Text=="")
                {
                    durum = false;
                }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (durum == true)
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("insert into kategoribilgiler(kategori) values('" + textBox1.Text + "' )", baglantı);
                komut.ExecuteNonQuery();
                baglantı.Close();
                
                MessageBox.Show("kategori eklendi");
            }
            else {
                MessageBox.Show("böyle bir kategori var","uyarı  ");
            }textBox1.Text = "";
         }

        private void Kategori_Load(object sender, EventArgs e)
        {

        }
    }
}
