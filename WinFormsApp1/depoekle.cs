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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class depoekle : Form
    {
        SqlDataReader oku ;
        public depoekle()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection("Data Source = MOONSTAR\\SQLEXPRESS; Initial Catalog = eczaneOtomasyonu1; Integrated Security = True; Trust Server Certificate=True");

        public void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("lütfen tüm alanları doldurunuz.Eksik Giriş Hatası.");
            }
            else
            {
                bag.Open();
                SqlCommand cmd = new SqlCommand("insert into ilac(Ilaç_Adı,Barkod_NO,Stok_Adeti,Eklenecek_Stok_Adeti)values('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "'", bag);
                cmd.ExecuteNonQuery();
                bag.Close();
                temizle();
            }
        }

    }
}
