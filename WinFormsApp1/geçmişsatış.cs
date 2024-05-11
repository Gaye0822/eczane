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
    public partial class geçmişsatış : Form
    {
        public geçmişsatış()
        {
            InitializeComponent();
        }
        //SqlConnection baglan = new SqlConnection("Data Source = MOONSTAR\\SQLEXPRESS; Initial Catalog = eczaneOtomasyonu1; Integrated Security = True; Trust Server Certificate=True");
        
        /*
        public void verileriGoruntule()
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("Select *from ilac", baglan);
            SqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();

                ekle.SubItems.Add(oku["İsim Soyisim"].ToString());
                ekle.SubItems.Add(oku["T.C"].ToString());
                ekle.SubItems.Add(oku["İlaç Adı"].ToString());
                ekle.SubItems.Add(oku["Adet"].ToString());

                listView1.Items.Add(ekle);
            }
            baglan.Close();
        }
        */

        private void geçmişsatış_Load(object sender, EventArgs e)
        {
            //verileriGoruntule();
        }
    
    }
}