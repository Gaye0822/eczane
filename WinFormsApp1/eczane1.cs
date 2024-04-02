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
    internal class listView1
    {
        public static object Items { get; internal set; }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source = MOONSTAR\\SQLEXPRESS; Initial Catalog = eczaneOtomasyonu1; Integrated Security = True; Trust Server Certificate=True");

        private void verileriGoruntule()
        {
            object value1 = listView1.Items.Clear();

            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *from ilac", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();

                ekle.Text = oku["Barkod_NO"].ToString();

                ekle.SubItems.Add(oku["İlaç_Adı"].ToString());
                ekle.SubItems.Add(oku["Barkod_NO"].ToString());
                ekle.SubItems.Add(oku["Stok_Adedi"].ToString());
                ekle.SubItems.Add(oku["Fiyat"].ToString());

                object value = listView1.Items.Add(ekle);
            }
            baglan.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            verileriGoruntule();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Insert into ilac2(İlaç_Adı,Barkod_NO,Stok_Adeti,Fiyat)values('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString()"'", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verileriGoruntule();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
        private void listWiew1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Barkod_NO = int.Parse(listWiew1.SelectedItems[1].SubItems[1].text);
            textBox1.Text = listWiew1.SelectedItems[1].SubItems[1].text;
            textBox2.Text = listWiew1.SelectedItems[1].SubItems[1].text;
            textBox3.Text = listWiew1.SelectedItems[1].SubItems[1].text;
            textBox4.Text = listWiew1.SelectedItems[1].SubItems[1].text;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("update ilac set İlaç_Ad='" + textBox1.Text.ToString() + '",Barkod_NO='"+textBox2.Text.ToString()+'", Stok_Adeti = '"+textBox3.Text.ToString()+'",Fiyat='" + textBox4.Text.ToString() + "'where Barkod_NO=" + Barkod_NO + "", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verileriGoruntule();
        }
    }
}