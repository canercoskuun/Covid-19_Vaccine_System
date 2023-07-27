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
using System.Globalization;

namespace Covid_19_Vaccine_System
{
    public partial class Form3 : Form
    {
        public Form3()
        {
          
            InitializeComponent();
        }
        public string tarih1=null;
        public string dozsayisi;
        public string asituru;
        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-6BUOG84U\\SQLEXPRESS;Initial Catalog=Vaccine;Integrated Security=True");
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
         
            
                connection.Open();
            SqlCommand Update = new SqlCommand("UPDATE [dbo].[Vaccine] " +
                                   "SET TC=@p0, Ad=@p1, Soyad=@p2, Yas=@p3, Sehir=@p4, [Asi Turu]=@p5, [Asi Tarihi]=@p6, [Doz sayisi]=@p7 " +
                                   "WHERE TC=@p8", connection);
            //SqlCommand Update = new SqlCommand("Update Tbl_Vaccine set TC=@p0,Ad=@p1,Soyad=@p2,Yas=@p3,Sehir=@p4,[Asi Turu]=@p5,[Asi Tarihi]=@p6 where TC=@p7 ", connection);
                Update.Parameters.AddWithValue("@p0", maskedTextTC.Text);
                Update.Parameters.AddWithValue("@p1", textBoxAd.Text);
                Update.Parameters.AddWithValue("@p2", textBoxSoyad.Text);
                Update.Parameters.AddWithValue("@p3", maskedTextBoxYas.Text);
                Update.Parameters.AddWithValue("@p4", comboBoxSehir.Text);
     
                if (radioButtonBiontech.Checked == true)
                {
                    Update.Parameters.AddWithValue("@p5", "Biontech");
                }
                else if (radioButtonSinovac.Checked == true)
                {
                    Update.Parameters.AddWithValue("@p5", "Sinovac");
                }
                else
                {
                    Update.Parameters.AddWithValue("@p5", "NULL");
                }
                string tarih2 = dateTimePicker1.Value.ToString("dd/MM/yyyy");

                if (tarih1 != null)
                {

                if (int.Parse(dozsayisi) < 2)
                {
                    DateTime dt1 = DateTime.ParseExact(tarih1, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                    DateTime dt2 = DateTime.ParseExact(tarih2, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                    TimeSpan fark = dt2.Subtract(dt1);
                    int gunFarki = fark.Days;
                    if (gunFarki >= 30)
                    {
                        int x = int.Parse(dozsayisi);
                        x++;
                        Update.Parameters.AddWithValue("@p7",x);
                        Update.Parameters.AddWithValue("@p6", dateTimePicker1.Value.ToString("dd/MM/yyyy"));
                        MessageBox.Show("Asi kaydi Basarili!");

                    }
                    else
                    {
                        Update.Parameters.AddWithValue("@P6", tarih1);
                        MessageBox.Show("Asilar arasinda en az 30 gun bulunmalidir!");
                    }
                }
                else
                {
                    MessageBox.Show("Maksimum doz sayisina ulasilmistir!");
                }
                }
                else
                {
                    Update.Parameters.AddWithValue("@p6", dateTimePicker1.Value.ToString("dd/MM/yyyy"));
                    Update.Parameters.AddWithValue("@p7", "0");
                    MessageBox.Show("Güncellenme Basarili!");
                }

                
                Update.Parameters.AddWithValue("@p8", maskedTextTC.Text);
                Update.ExecuteNonQuery();
                connection.Close();
            
           
            
        }

        private void textBoxSoyad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
