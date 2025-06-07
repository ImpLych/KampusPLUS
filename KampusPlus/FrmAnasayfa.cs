using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace KampusPlus
{
    public partial class FrmAnasayfa: Form
    {
        sqlbaglantisi bgl = new sqlbaglantisi();
    
        public FrmAnasayfa()
        {
            InitializeComponent();
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

        private void LblYaklasanEtkinlik_Click(object sender, EventArgs e)
        {
            FrmYaklasanEtkinlikler fr = new FrmYaklasanEtkinlikler();
            fr.Show();
            this.Hide();

        }
        
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            FrmAnasayfa2 fr = new FrmAnasayfa2();
            fr.Show();
            this.Hide();
        }

        private void FrmAnasayfa_Load(object sender, EventArgs e)
        {
            sqlbaglantisi bgl = new sqlbaglantisi();

            SqlCommand komut1 = new SqlCommand("Select EtkinlikAdi from Tbl_Etkinlik where etkinlikID=1",bgl.baglanti());
            SqlDataReader dr = komut1.ExecuteReader();
            if (dr.Read())
            {
                TxtYaklasan1.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();

            SqlCommand komut2 = new SqlCommand("Select EtkinlikAdi from Tbl_Etkinlik where etkinlikID=2", bgl.baglanti());
            SqlDataReader dr1 = komut2.ExecuteReader();
            if (dr1.Read())
            {
                TxtYaklasan2.Text = dr1[0].ToString();
            }
            bgl.baglanti().Close();

            SqlCommand komut3 = new SqlCommand("Select EtkinlikAdi from Tbl_Etkinlik where etkinlikID=3", bgl.baglanti());
            SqlDataReader dr2 = komut3.ExecuteReader();
            if (dr2.Read())
            {
                TxtYaklasan3.Text = dr2[0].ToString();
            }
            bgl.baglanti().Close();

        }


        private void picCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAktif1_Click(object sender, EventArgs e)
        {
            KulupYaklasanEtkinlik fr = new KulupYaklasanEtkinlik();
            fr.Show();
            this.Hide();
            
        }

        private void PnlYaklasanEtkinlik_Click(object sender, EventArgs e)
        {
            FrmYaklasanEtkinlikler fr = new FrmYaklasanEtkinlikler();
            fr.Show();
            this.Hide();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            FrmKulupler fr = new FrmKulupler();
            fr.Show();
            this.Hide();
        }

        private void BtnKulupBasvuru_Click(object sender, EventArgs e)
        {
            FrmKulupBasvuru fr = new FrmKulupBasvuru();
            fr.Show();
            this.Hide();

        }
    }
    }

