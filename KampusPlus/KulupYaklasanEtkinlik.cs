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

namespace KampusPlus
{
    public partial class KulupYaklasanEtkinlik : Form
    {

        sqlbaglantisi bgl = new sqlbaglantisi();
        public KulupYaklasanEtkinlik()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void KulupYaklasanEtkinlik_Load(object sender, EventArgs e)
        {
            //SqlCommand komut = new SqlCommand("Select EtkinlikAdi from Tbl_Etkinlik ", bgl.baglanti());
            //komut.Parameters.AddWithValue("@p1", label1.Text);
            //SqlDataReader dr = komut.ExecuteReader();
            //if (dr.Read())
            //{
            //    richTextBox1.Text = dr[0].ToString();


            //}
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM Tbl_Etkinlik WHERE EtkinlikAdi = 'hAsanla Tour'", bgl.baglanti());

            SqlDataReader dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                richTextBox2.Text = dr2[2].ToString();  // EtkinlikAdi
                bgl.baglanti().Close();
            }

            //! ettkinlik ıdye göre transformation et ?
            SqlCommand cmd3 = new SqlCommand("SELECT * FROM Tbl_Etkinlik WHERE EtkinlikAdi = 'Meryemle Ok atma'", bgl.baglanti()); //Etkinlik Adiyla çektin sonra dçn
            SqlDataReader dr3 = cmd3.ExecuteReader();
            if (dr3.Read())
            {
                richTextBox3.Text = dr3[2].ToString();  // EtkinlikAdi
                bgl.baglanti().Close();
            }

            //SqlCommand komut2 = new SqlCommand("Select KulupAdi from Tbl_Kulup where KulupID=@p1 ", bgl.baglanti());
            //komut2.Parameters.AddWithValue("@p1", label1.Text);
            //SqlDataReader dr4 = komut2.ExecuteReader();
            //if (dr4.Read())
            //{
            //    lbl1.Text = dr4[0].ToString();
            //    lbl2.Text = dr4[0].ToString();
            //    lbl3.Text = dr4[0].ToString();
            //}
            {

            }

        }

        private void picCikis_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void picGeri_Click(object sender, EventArgs e)
        {
            FrmAnasayfa fr = new FrmAnasayfa();
            fr.Show();
            this.Hide();

        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            FrmKulupler fr = new FrmKulupler();
            fr.Show();
            this.Hide();
        }

        private void BtnAnasayfa_Click(object sender, EventArgs e)
        {
            FrmAnasayfa fr = new FrmAnasayfa();
            fr.Show();
            this.Hide();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            FrmGiris fr = new FrmGiris();
            fr.Show();
            this.Hide();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}