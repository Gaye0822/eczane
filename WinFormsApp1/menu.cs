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
    public partial class menu : Form
    {
        SqlCommand cmd;
        SqlDataReader oku;
        public menu()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection("Data Source = MOONSTAR\\SQLEXPRESS; Initial Catalog = eczaneOtomasyonu1; Integrated Security = True; Trust Server Certificate=True");
    
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into ilac(resim)values(@resim)");
            //cmd.Parameters.AddWithValues("@resim",pictureBox1.ImageLocation);
            bag.Open();
            cmd.ExecuteNonQuery();
            //biraz eksik
        }
    }
}
