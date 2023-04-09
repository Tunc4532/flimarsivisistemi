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
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;

namespace _25prjeflimarsivi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=25ucuncuproje;Integrated Security=True");
        void flimler()
        {
            SqlDataAdapter dt = new SqlDataAdapter("Select ID,AD,LİNK FROM tbl_flimasiv",baglanti);
            DataTable da = new DataTable();
            dt.Fill(da);
            dataGridView1.DataSource= da;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            flimler();
        }
        
        private void btnkayıt_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_flimasiv (AD,KATAGORİ,LİNK) values (@t1,@t2,@t3) ", baglanti);
            komut.Parameters.AddWithValue("@t1", txtad.Text);
            komut.Parameters.AddWithValue("@t2", txtkatagori.Text);
            komut.Parameters.AddWithValue("@t3", txtlink.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Flim kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //veri taşıma işlemi 
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtad.Text = row.Cells[0].Value.ToString();
                txtkatagori.Text = row.Cells[1].Value.ToString();
                txtlink.Text = row.Cells[2].Value.ToString();

            }
            //tıklanan değeri açsın web de

            //int seçilen = dataGridView1.SelectedCells[0].RowIndex;
            //string link = dataGridView1.Rows[seçilen].Cells[3].Value.ToString();
            //webBrowser1.Navigate(link);


            

            web();
        }
        public void web()
        {
           webBrowser1.Navigate("https://www.youtube.com/results?search_query=sinister+trailer");
        }
        private void btnhakkımızda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje Tunç Çindaş tarafından 09.04.2023 tarihinde oluşturuldu","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnrenk_Click(object sender, EventArgs e)
        {
            DialogResult tus;
            tus = colorDialog1.ShowDialog();
            if (tus == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }

        private void btntamekran_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.getir = txtlink.Text;
            form.Show();
            this.Hide();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
