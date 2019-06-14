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
    public partial class Detay : Form
    {
        public Detay()
        {
            InitializeComponent();
        }
        
        public void listele()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ProjeServer;Integrated Security=True");
            SqlDataAdapter adp = new SqlDataAdapter("Select ID,Ad,Soyad,Telefon from Telefon order by Ad", conn);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds.Tables.Add(dt);
            adp.Fill(ds.Tables[0]);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].Visible = false;
        }
        
        private void Detay_Load(object sender, EventArgs e)
        {
            listele();
            btnBilgi.Hide();
            rdbtnAd.Checked = true;
        }
        String cmd;
        DataTable dt;
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ProjeServer;Integrated Security=True");
            if (txtAra.Text == "")
            {
                cmd = "Select ID,Ad,Soyad,Telefon from Telefon order by Ad";
            }
            else
            {
                if (rdbtnAd.Checked)
                {
                    cmd = "Select ID,Ad,Soyad,Telefon from Telefon where Ad like'%" + txtAra.Text + "%' order by Ad";
                }
                else if (rdbtnTel.Checked)
                {
                    cmd = "Select ID,Ad,Soyad,Telefon from Telefon where Telefon like'%" + txtAra.Text + "%' order by Ad";
                }
                
            }
            SqlDataAdapter adp = new SqlDataAdapter(cmd, conn);
            dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
        }
        Kişi_Ekle ekle;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (ekle==null || ekle.IsDisposed)
            {
                ekle = new Kişi_Ekle();
                ekle.Show();
            }
        }
        Bilgi bil;
        string id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch (Exception)
            {
                
            } 
        }
        private void btnBilgi_Click(object sender, EventArgs e)
        {
            if (bil == null || bil.IsDisposed)
            {
                
                bil = new Bilgi();
                bil.datagridid(id);
                bil.Show();
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult sor = new System.Windows.Forms.DialogResult();
            sor = MessageBox.Show("Kişi Silinsin mi?", "Dikkat", MessageBoxButtons.YesNo);
            if (sor == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ProjeServer;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("Delete from Telefon where ID = '" + id + "'", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                listele();
            }
        }

        private void txtAra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rdbtnAd.Checked)
            {
                e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
            }
            else if (rdbtnTel.Checked)
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listele();
            txtAra.Clear();
        }

        private void rdbtnAd_CheckedChanged(object sender, EventArgs e)
        {
            txtAra.Clear();
        }

        private void rdbtnTel_CheckedChanged(object sender, EventArgs e)
        {
            txtAra.Clear();
        }
        




        

        

       

       

        

       
        
        

        

    }
}
