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
    public partial class Satıslisteleme : Form
    {
        public Satıslisteleme()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-POJFHO5;Initial Catalog=StokTKP;Integrated Security=True";
        SqlConnection baglantı = new SqlConnection(conString);
        DataSet dsat = new DataSet();


      

        private void satıslistelem()
        {
            //kayıt yenileme için
            baglantı.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from satıs", baglantı);
            adtr.Fill(dsat, "satıs");
            
            dataGridView1.DataSource = dsat.Tables["satıs"];

            baglantı.Close();
        }
        private void Satıslisteleme_Load(object sender, EventArgs e)
        {
            satıslistelem();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
