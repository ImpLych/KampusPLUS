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

namespace KampusPlus
{
    public partial class FrmAnasayfa2: Form
    {
        public FrmAnasayfa2()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            FrmAnasayfa2 fr = new FrmAnasayfa2();
            fr.Show();
            this.Hide();
        }

        private void PicCikis_Click(object sender, EventArgs e)
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

        private void PnlYaklasanEtkinlik_Paint(object sender, PaintEventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("Select SponsorAd+' / '+FirmaSahibi from Tbl_sponsor where SponsorID=1", bgl.baglanti());

            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                TxtSponsor1.Text = dr[0].ToString();

            }
            bgl.baglanti().Close();

            //------------
            SqlCommand komut2 = new SqlCommand("Select SponsorAd +' / '+ FirmaSahibi from Tbl_sponsor where SponsorID=2", bgl.baglanti());

            SqlDataReader dr1 = komut2.ExecuteReader();
            while (dr1.Read())
            {
                TxtSponsor2.Text = dr1[0].ToString();

            }
            bgl.baglanti().Close();

            //------------
            SqlCommand komut3 = new SqlCommand("Select SponsorAd +' / '+ FirmaSahibi from Tbl_sponsor where SponsorID=3", bgl.baglanti());

            SqlDataReader dr2 = komut3.ExecuteReader();
            while (dr2.Read())
            {
                TxtSponsor3.Text = dr2[0].ToString();

            }
            bgl.baglanti().Close();


            //------------
            SqlCommand komut4 = new SqlCommand("Select SponsorAd+ ' / '+ FirmaSahibi from Tbl_sponsor where SponsorID=4", bgl.baglanti());

            SqlDataReader dr3 = komut4.ExecuteReader();
            while (dr3.Read())
            {
                TxtSponsor4.Text = dr3[0].ToString();

            }
            bgl.baglanti().Close();

            //------------
            SqlCommand komut5 = new SqlCommand("Select SponsorAd + ' / '+FirmaSahibi from Tbl_sponsor where SponsorID=5", bgl.baglanti());

            SqlDataReader dr4 = komut5.ExecuteReader();
            while (dr4.Read())
            {
                TxtSponsor5.Text = dr4[0].ToString();

            }
            bgl.baglanti().Close();

            //------------
            SqlCommand komut6 = new SqlCommand("Select SponsorAd + ' / '+FirmaSahibi from Tbl_sponsor where SponsorID=6", bgl.baglanti());

            SqlDataReader dr5 = komut6.ExecuteReader();
            while (dr5.Read())
            {
                TxtSponsor6.Text = dr5[0].ToString();

            }
            bgl.baglanti().Close();

            //------------
            SqlCommand komut7 = new SqlCommand("Select SponsorAd + ' / '+FirmaSahibi from Tbl_sponsor where SponsorID=7", bgl.baglanti());

            SqlDataReader dr6 = komut7.ExecuteReader();
            while (dr6.Read())
            {
                TxtSponsor7.Text = dr6[0].ToString();

            }
            bgl.baglanti().Close();


            //------------
            SqlCommand komut8 = new SqlCommand("Select SponsorAd + ' / '+FirmaSahibi from Tbl_sponsor where SponsorID=8", bgl.baglanti());

            SqlDataReader dr7 = komut8.ExecuteReader();
            while (dr7.Read())
            {
                TxtSponsor8.Text = dr7[0].ToString();

            }
            bgl.baglanti().Close();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            FrmAnasayfa fr = new FrmAnasayfa();
            fr.Show();
            this.Hide();
        }

        private void TxtSponsor1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSponsorBasvur_Click(object sender, EventArgs e)
        {
            FrmSponsorBasvuru fr = new FrmSponsorBasvuru();
            fr.Show();
            this.Hide();
        }
    }
}
