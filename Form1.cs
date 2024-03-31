using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hasta2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("data source=DESKTOP-27Q30VL\\SQLEXPRESS; Initial Catalog=hastalistesi; Integrated Security= true");// TEK TERS \ OLAB�L�R

        private void verilerig�r�nt�le()
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
                ekle.SubItems.Add(oku["ila�ad�"].ToString());
                ekle.SubItems.Add(oku["Adet"].ToString());
                listView1.Items.Add(ekle);


            }
            baglan.Close();



        }
        private void button1_Click(object sender, EventArgs e)
        {
            verilerig�r�nt�le();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Insert into hasta (id,Hastaadsoyad,HastaT.C,�la�ad�,Adet)values(' " + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "'", baglan);

            komut.ExecuteNonQuery();
            baglan.Close();
            verilerig�r�nt�le();

            textBox1.Clear(); // textboxlar�n i�ini temizlemek i�in
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

        }
    }
}
