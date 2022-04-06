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
    public partial class Marka : Form
    {
        public Marka()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-POJFHO5;Initial Catalog=StokTKP;Integrated Security=True";
        SqlConnection baglantı = new SqlConnection(conString);
        bool durum;

        private void Markaengele()

        {
            //marka eklenirken var olan bir kategoriyi ekleme durumunu engeleyen metot
            durum = true;
            baglantı.Open();
            SqlCommand cmd = new SqlCommand("select *form markabilgileri", baglantı);
            SqlDataReader read = cmd.ExecuteReader();


            if (comboBox1.Text==read["kategori"].ToString() && textBox1.Text == read["marka"].ToString() || comboBox1.Text == "" || textBox1.Text == "")
            {
                durum = false;
            }
        }

            private void button1_Click(object sender, EventArgs e)
            {
            //sql baglantısı ile marka bilgisi ekleme işlemi 
            Markaengele();
            if (durum == true)
            {

                baglantı.Open();
                SqlCommand komut = new SqlCommand("insert into markabilgileri(marka) values('" + textBox1.Text + "' )", baglantı);
                komut.ExecuteNonQuery();
                baglantı.Close();
               
                MessageBox.Show("marka eklendi");
            }
            else {
                MessageBox.Show("böyle bir kategori ve marka var");
            
            } 
            comboBox1.Text = "";
             textBox1.Text = "";
            }
            private void kategori_getir() {
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
            private void Marka_Load(object sender, EventArgs e)
            {
                kategori_getir();
            }
        }
    } 

