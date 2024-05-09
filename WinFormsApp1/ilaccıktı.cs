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
using System.Diagnostics.Eventing.Reader;

namespace WinFormsApp1
{
    public partial class ilaccıktı : Form
    {
        public ilaccıktı()
        {
            InitializeComponent();
        }
        //SqlConnection bag = new SqlConnection("Data Source = MOONSTAR\\SQLEXPRESS; Initial Catalog = eczaneOtomasyonu1; Integrated Security = True; Trust Server Certificate=True");
        /*
        public void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

        }
        int Barkod_NO=0;
        int Stok_Adeti = 0;
        */
        private void button2_Click(object sender, EventArgs e)
        {
            /*
            if (Stok_Adeti==0)
            {
                MessageBox.Show("Stokta Yok.Satış Yapılamaz.");
            }
            else
            {
                bag.Open();
                SqlCommand cmd = new SqlCommand("delete from ilac where Barkod_NO=(" + Barkod_NO + ")", bag);
                cmd.ExecuteNonQuery();
                bag.Close();
                MessageBox.Show("Satış Yapıldı.");
                temizle();
            }
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
                /*
            bag.Open();
            SqlCommand cmd = new SqlCommand("update ilac set İlaç_Adı='"+textBox1.Text.ToString()+"',Barkod_NO='"+textBox2.Text.ToString()+"',Stok_Durum='"+textBox3.Text.ToString()+"',Raf_NO='"+textBox4.Text.ToString()+"',Fiyat='"+textBox5.Text.ToString()+"' where Barkod_NO="+ Barkod_NO +"", bag);
            cmd.ExecuteNonQuery();
            bag.Close();
            temizle();
                */
        }  

    }
}
