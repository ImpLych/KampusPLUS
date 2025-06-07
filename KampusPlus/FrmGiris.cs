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
    public partial class FrmGiris : Form
    {
        sqlbaglantisi bgl = new sqlbaglantisi();

        public FrmGiris()
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

        private void PicCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Danisman where KullaniciAdi=@p1 and KullaniciSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtKullaniciAdi2.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre2.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmYonetimPaneli frm = new FrmYonetimPaneli();
                frm.KullaniciAdi = TxtKullaniciAdi2.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Numara ya da Şifre Girişi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Obs where OgrenciNo=@p1 and OgrenciSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmKullaniciProfil frm = new FrmKullaniciProfil();
                frm.no = TxtKullaniciAdi.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Numara ya da Şifre Girişi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bgl.baglanti().Close();
        }

        private void picGeri_Click(object sender, EventArgs e)
        {
            FrmAnasayfa fr = new FrmAnasayfa();
            fr.Show();
            this.Hide();

        }

    }
}