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
namespace Covid_19_Vaccine_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-6BUOG84U\\SQLEXPRESS;Initial Catalog=Vaccine;Integrated Security=True");
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button_kayit_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int selected = dataGrid.SelectedCells[0].RowIndex;
                Form3 frm3 = new Form3();
                if (dataGrid.Rows[selected].Cells[0].Value != null)
                {
                    frm3.maskedTextTC.Text = dataGrid.Rows[selected].Cells[0].Value.ToString();
                    frm3.textBoxAd.Text = dataGrid.Rows[selected].Cells[1].Value.ToString();
                    frm3.textBoxSoyad.Text = dataGrid.Rows[selected].Cells[2].Value.ToString();
                    frm3.maskedTextBoxYas.Text = dataGrid.Rows[selected].Cells[3].Value.ToString();
                    frm3.comboBoxSehir.Text = dataGrid.Rows[selected].Cells[4].Value.ToString();
                    if (dataGrid.Rows[selected].Cells[5].Value.ToString() == "Biontech")
                    {
                        frm3.radioButtonBiontech.Checked = true;
                    }
                    else if (dataGrid.Rows[selected].Cells[5].Value.ToString() == "Sinovac")
                    {
                        frm3.radioButtonSinovac.Checked = true;
                    }
                    else 
                    {
                        frm3.radioButtonSinovac.Checked = false;
                        frm3.radioButtonBiontech.Checked = false;
                    }
                    frm3.dateTimePicker1.Text = dataGrid.Rows[selected].Cells[6].Value.ToString();
                    
                    frm3.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Lutfen guncellemek istediginiz kisiyi seciniz!");
                }
            }
            catch
            {
                MessageBox.Show("Guncelleme basarisiz!");
            }
           

        }
     

        private void buttonAsiKaydi_Click(object sender, EventArgs e)
        {
            try
            {
                int selected = dataGrid.SelectedCells[0].RowIndex;
                Form3 frm3 = new Form3();
                if (dataGrid.Rows[selected].Cells[0].Value != null)
                {
                    frm3.maskedTextTC.Text = dataGrid.Rows[selected].Cells[0].Value.ToString();
                    frm3.textBoxAd.Text = dataGrid.Rows[selected].Cells[1].Value.ToString();
                    frm3.textBoxSoyad.Text = dataGrid.Rows[selected].Cells[2].Value.ToString();
                    frm3.maskedTextBoxYas.Text = dataGrid.Rows[selected].Cells[3].Value.ToString();
                    frm3.comboBoxSehir.Text = dataGrid.Rows[selected].Cells[4].Value.ToString();
                    if (dataGrid.Rows[selected].Cells[5].Value.ToString() == "Biontech")
                    {
                        frm3.radioButtonBiontech.Checked = true;
                        frm3.radioButtonBiontech.Enabled = true;
                        frm3.radioButtonSinovac.Enabled=false;
                    }
                    else if (dataGrid.Rows[selected].Cells[5].Value.ToString() == "Sinovac")
                    {
                        frm3.radioButtonSinovac.Checked = true;
                        frm3.radioButtonSinovac.Enabled = true;
                        frm3.radioButtonBiontech.Enabled = false;
                    }
                    else
                    {
                        frm3.radioButtonBiontech.Checked = false;
                        frm3.radioButtonSinovac.Checked = false;
                        frm3.radioButtonSinovac.Enabled = true;
                        frm3.radioButtonBiontech.Enabled = true;
                        frm3.asituru = null;

                    }
                    frm3.dateTimePicker1.Text = dataGrid.Rows[selected].Cells[6].Value.ToString();
                    frm3.tarih1 = frm3.dateTimePicker1.Value.ToString("dd/MM/yyyy");
                    frm3.dozsayisi =dataGrid.Rows[selected].Cells[7].Value.ToString();
                  
                    frm3.dateTimePicker1.Enabled = true;
                    frm3.comboBoxSehir.Enabled = false;
                    frm3.textBoxAd.Enabled = false;
                    frm3.textBoxSoyad.Enabled = false;
                    frm3.maskedTextTC.Enabled = false;
                    frm3.maskedTextBoxYas.Enabled = false;
                    frm3.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Lutfen asi kaydi yapmak istediginiz kisiyi seciniz!");
                }
            }
            catch
            {
                MessageBox.Show("Asi kaydi basarisiz!");
            }



        }

        private void buttonListele_Click(object sender, EventArgs e)
        {
            this.vaccineTableAdapter.Fill(this.vaccineDataSet5.Vaccine);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand check = new SqlCommand("SELECT COUNT(*) FROM [dbo].[Vaccine] WHERE TC=@k1", connection);
                check.Parameters.AddWithValue("k1", textBox1.Text);
                int count = (int)check.ExecuteScalar();

                if (count > 0)
                {
                    SqlCommand delete = new SqlCommand("DELETE FROM [dbo].[Vaccine] WHERE TC=@k1", connection);
                    delete.Parameters.AddWithValue("k1", textBox1.Text);
                    delete.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Kayıt Silindi!. Lütfen tekrar listeleyiniz!");
                }
                else
                {
                    connection.Close();
                    MessageBox.Show("Kayıt bulunamadı!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                connection.Close();
            }
            
        }
    }
}
