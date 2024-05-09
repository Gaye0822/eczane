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
    public partial class ilacarama : Form
    {
        public ilacarama()
        {
            InitializeComponent();
        }
       
       // int Barkod_NO = 0;

        //SqlConnection bag = new SqlConnection("Data Source = MOONSTAR\\SQLEXPRESS; Initial Catalog = eczaneOtomasyonu1; Integrated Security = True; Trust Server Certificate=True");
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*
            if (Barkod_NO<100) 
            {
                bag.Open();
                SqlCommand cmd = new SqlCommand("select *from ilac where Barkod_NO like ='" + textBox1.Text + "%'", bag);
                cmd.ExecuteNonQuery();
                bag.Close();
            }
            else
            {
                MessageBox.Show("Bulunamadı.");
            }
            */
        }


    }
}
