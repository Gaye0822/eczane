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
    public partial class depoekle : Form
    {
        SqlCommand cmd ;
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
        private void Form7_Load(object sender, EventArgs e)
        {

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
                SqlCommand cmd = new SqlCommand("insert into ilac(Ilaç_Adı,Barkod_NO,Stok_Adeti,Eklenecek_Stok_Adeti)values(@Ilaç_Adı,@Barkod_NO,@Stok_Adeti,@Eklenecek_Stok_Adeti");
                cmd.Parameters.AddWithValue("@Ilac_Adi", textBox1.Text);
                cmd.Parameters.AddWithValue("@Barkod_No",int.Parse(textBox2.Text));
                cmd.Parameters.AddWithValue("@Stok_Adeti", int.Parse(textBox3.Text));
                cmd.Parameters.AddWithValue("@Eklenecek_Stok_Adeti",int.Parse(textBox4.Text));

            
                SqlCommand cmd2 = new SqlCommand("UPDATE ilac SET İlaç_Adı = @IlacAdi, Barkod_NO = @BarkodNo, Stok_Adeti = @StokAdeti WHERE İlac_ID = @IlacID\" , bag");
                cmd.Parameters.AddWithValue("@Ilac_Adi", textBox1.Text);
                cmd.Parameters.AddWithValue("@Barkod_No", textBox2.Text);
                cmd.Parameters.AddWithValue("@Stok_Adeti", textBox3.Text);
                cmd.Parameters.AddWithValue("@Eklenecek_Stok_Adedi", textBox4.Text);
            }
            bag.Open();
            cmd.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Kayıt Yapıldı.");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
