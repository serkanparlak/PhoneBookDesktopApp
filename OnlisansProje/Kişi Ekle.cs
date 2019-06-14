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
using System.IO;

namespace OnlisansProje
{
    public partial class Kişi_Ekle : Form
    {
        
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ProjeServer;Integrated Security=True");
        public Kişi_Ekle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string resimPath="";
        int k = 0;
        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Avatar Seç";
            openFileDialog1.Filter = "Png Dosyası (*.png)|*.png|Jpeg Dosyası (*.jpg)|*.jpg|Gif Dosyası (*.gif)|*.gif|Tif Dosyası (*.tif)|*.tif";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                resimPath = openFileDialog1.FileName.ToString();
                pictureBox1.BackgroundImage = null;
            }
            k = 1;
            
        }
        private void btnKisiEkle_Click(object sender, EventArgs e)
        {
            if (k == 1)
            {
                FileStream fs = new FileStream(resimPath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                byte[] resim = br.ReadBytes((int)fs.Length);
                br.Close();
                fs.Close();

                if (txtAdEkle.Text == "" || txtAdres.Text == "" || txtEmail.Text == "" || txtSoyEkle.Text == "")
                {
                    MessageBox.Show("Lütfen alanları doldurun", "Uyarı");
                }
                else if (txtTelEkle.TextLength != 11)
                    MessageBox.Show("Numaranızı kontrol edip tekrar deneyiniz");
                else
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Insert into Telefon(Ad,Soyad,Telefon,Email,Adres,Resim) values(@a,@s,@t,@e,@d,@i)", conn);
                    cmd.Parameters.AddWithValue("@a", txtAdEkle.Text);
                    cmd.Parameters.AddWithValue("@s", txtSoyEkle.Text);
                    cmd.Parameters.AddWithValue("@t", txtTelEkle.Text);
                    cmd.Parameters.AddWithValue("@e", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@d", txtAdres.Text);
                    cmd.Parameters.Add("@i", SqlDbType.Image, resim.Length).Value = resim;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Ekleme işlemi başarılı", "Başarılı");
                }
            }
            else MessageBox.Show("Bir avatar seciniz","Uyarı");
            
        }

        private void txtAdEkle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txtSoyEkle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAdEkle.Clear();
            txtSoyEkle.Clear();
            txtEmail.Clear();
            txtAdres.Clear();
            txtTelEkle.Clear();
        }

        private void lblTel_MouseMove(object sender, MouseEventArgs e)
        {
            lblTel.Hide();
        }

        private void Kişi_Ekle_Load(object sender, EventArgs e)
        {
            lblTel.Show();
        }
        private void txtTelEkle_Leave_1(object sender, EventArgs e)
        {
            if (txtTelEkle.Text == "")
                lblTel.Show();
        }

        private void txtTelEkle_Enter(object sender, EventArgs e)
        {
            lblTel.Hide();
        }

        private void txtTelEkle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }



       

        
        
    }
}
