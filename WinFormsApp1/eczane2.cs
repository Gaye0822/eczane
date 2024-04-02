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


namespace WinFormsApp1
{
    internal class listView2
    {
        public static object Items { get; internal set; }
    }
  
    public partial class eczane2 : Form
    {
        public eczane2()
        {
            InitializeComponent();
        }


        SqlConnection Baglan = new SqlConnection("Data Source = MOONSTAR\\SQLEXPRESS; Initial Catalog = eczaneOtomasyonu2; Integrated Security = True; Trust Server Certificate=True");
        private void verileriGoruntule()
        {
            listView2.Items.Clear();

            Baglan.Open();
            SqlCommand komut = new SqlCommand("Select *from ilac2", Baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();

                ekle.Text = oku["Barkod_NO"].ToString();

                ekle.SubItems.Add(oku["İlaç_Adı"].ToString());
                ekle.SubItems.Add(oku["Barkod_NO"].ToString());
                ekle.SubItems.Add(oku["Stok_Adedi"].ToString());
                ekle.SubItems.Add(oku["Fiyat"].ToString());

                object value = listView2.Items.Add(ekle);
            }
            Baglan.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            verileriGoruntule();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Baglan.Open();
            SqlCommand komut = new SqlCommand("Insert into ilac2(İlaç_Adı,Barkod_NO,Stok_Adeti,Fiyat)values('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString()"'", Baglan);
            komut.ExecuteNonQuery();
            Baglan.Close() ;    
            verileriGoruntule() ;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Barkod_NO = int.Parse(listWiew2.SelectedItems[1].SubItems[1].text);
            textBox1.Text = listWiew2.SelectedItems[1].SubItems[1].text;
            textBox2.Text = listWiew2.SelectedItems[1].SubItems[1].text;
            textBox3.Text = listWiew2.SelectedItems[1].SubItems[1].text;
            textBox4.Text = listWiew2.SelectedItems[1].SubItems[1].text;
        }
    }
}

    