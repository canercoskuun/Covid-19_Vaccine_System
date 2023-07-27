using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Data.SqlClient;
namespace Covid_19_Vaccine_System
{
    public partial class Form2 : Form
    {
        private void Form2_Load(object sender, EventArgs e)
        {
            

        }
        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-6BUOG84U\\SQLEXPRESS;Initial Catalog=Vaccine;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO [dbo].[Vaccine] " +
                                   "([TC], [Ad], [Soyad], [Yas], [Sehir], [Asi Turu], [Asi Tarihi], [Doz sayisi]) " +
                                   "VALUES (@p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7)", connection);

            //SqlCommand komut = new SqlCommand("insert into Tbl_Vaccine (TC,Ad,Soyad,Yas,Sehir,[Asi Turu],[Asi Tarihi],[Doz sayisi]) values (@p0,@p1,@p2,@p3,@p4,@p5,@p6,@p7)", connection);
            komut.Parameters.AddWithValue("p0", maskedTextBoxTC.Text);
            komut.Parameters.AddWithValue("p1", textBoxAd.Text);
            komut.Parameters.AddWithValue("p2", textBoxSoyad.Text);
            komut.Parameters.AddWithValue("p3", maskedTextBoxYas.Text);
            komut.Parameters.AddWithValue("p4", comboBoxSehir.Text);
            komut.Parameters.AddWithValue("@p5","NULL");
            komut.Parameters.AddWithValue("@p6", "05.05.2020");
            komut.Parameters.AddWithValue("@p7", "0");
            komut.ExecuteNonQuery();
            MessageBox.Show("Kaydedildi!!");
            connection.Close();
        }

      
    }
}
