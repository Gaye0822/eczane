using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class hastakayıt : Form
    {
        public hastakayıt()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("data source=DESKTOP-27Q30VL\\SQLEXPRESS; Initial Catalog=hastalistesi; Integrated Security= true");// TEK TERS \ OLABİLİR
        private void verilerigörüntüle()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select *from hasta ", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["Hastaadsoyad"].ToString());
                ekle.SubItems.Add(oku["HastaT.C"].ToString());
                ekle.SubItems.Add(oku["ilaçadı"].ToString());
                ekle.SubItems.Add(oku["Adet"].ToString());
                listView1.Items.Add(ekle);


            }
            baglan.Close();



        }
        private void button1_Click(object sender, EventArgs e)
        {
            verilerigörüntüle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Insert into hasta ( id ,Hastaadsoyad ,HastaT.C ,İlaçadı ,Adet)values(' " + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "'", baglan);

            komut.ExecuteNonQuery();
            baglan.Close();
            verilerigörüntüle();
        }
    }
}
