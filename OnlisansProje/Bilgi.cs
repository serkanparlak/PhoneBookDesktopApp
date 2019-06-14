using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlisansProje
{
    public partial class Bilgi : Form
    {
        
        public Bilgi()
        {
            InitializeComponent();
        }
        String id;
        public void datagridid(String id)
        {
            this.id = id;
        }
        
        private void Bilgi_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ProjeServer;Integrated Security=True");
            conn.Open();
            SqlCommand komut = new SqlCommand("Select * from Telefon where ID ='" + id.ToString() + "'", conn);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                try
                {
                    pictureBox1.BackgroundImage = null;
                    byte[] Pic = (byte[])oku["Resim"];
                    MemoryStream Resim1 = new MemoryStream(Pic);
                    Image img = Image.FromStream(Resim1);
                    pictureBox1.Image = img;
                    txtAdBilgi.Text = oku["Ad"].ToString();
                    txtSoyBilgi.Text = oku["Soyad"].ToString();
                    txtTelBilgi.Text = oku["Telefon"].ToString();
                    txtAdres.Text = oku["Adres"].ToString();
                    txtEmail.Text = oku["Email"].ToString();
                    lblID.Text = oku["ID"].ToString();
                }
                catch (Exception ex)
                {
                    this.Close();
                    MessageBox.Show(ex.Message, "HATA");
                }
                lblTel.Hide();

            }
            conn.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAdBilgi.Text == "" || txtAdres.Text == "" || txtEmail.Text == "" || txtSoyBilgi.Text == "")
                {
                    MessageBox.Show("Lütfen alanları boş bırakmayın", "Uyarı");
                }
                else if (txtTelBilgi.TextLength != 11)
                    MessageBox.Show("Numarayı kontrol edip tekrar deneyin", "Uyarı");
                else
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ProjeServer;Integrated Security=True");
                    conn.Open();
                    SqlCommand komut = new SqlCommand("Update Telefon set Ad='" + txtAdBilgi.Text.Trim() + "', Soyad = '" + txtSoyBilgi.Text.Trim() + "', Telefon = '" + txtTelBilgi.Text.Trim() + "', Email = '" + txtEmail.Text.Trim() + "', Adres = '" + txtAdres.Text.Trim() + "' Where ID ='" + id + "'", conn);
                    komut.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Güncelleme başarılı", "Başarılı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),"HATA");
            }
            
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAdBilgi.Clear();
            txtSoyBilgi.Clear();
            txtTelBilgi.Clear();
            txtEmail.Clear();
            txtAdres.Clear();
        }

        private void txtAdBilgi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txtSoyBilgi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void lblTel_MouseMove(object sender, MouseEventArgs e)
        {
            lblTel.Hide();
        }

        private void txtTelBilgi_Enter(object sender, EventArgs e)
        {
            lblTel.Hide();
        }

        private void txtTelBilgi_Leave(object sender, EventArgs e)
        {
            if (txtTelBilgi.Text == "")
                lblTel.Show();
        }

        private void txtTelBilgi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        
    }
}
