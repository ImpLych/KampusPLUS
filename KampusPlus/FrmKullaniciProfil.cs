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
    public partial class FrmKullaniciProfil : Form
    {
        public FrmKullaniciProfil()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        public string no;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmKullaniciProfil_Load(object sender, EventArgs e)
        {
            lbldeneme.Text = no.ToString();
            //ID cekme
            SqlCommand cmd = new SqlCommand("select OgrenciID from Tbl_Obs where OgrenciNo=@p1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", lbldeneme.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblID.Text = dr[0].ToString();
            }

            //kulüp id cekme lbl1
            SqlCommand cmds = new SqlCommand("select KulupID from Tbl_OgrenciKulup where OgrenciID=@p1", bgl.baglanti());
            cmds.Parameters.AddWithValue("@p1", lblID.Text);
            SqlDataReader drs = cmds.ExecuteReader();
            while (drs.Read())
            {
                lblıd1.Text = drs[0].ToString();
            }


            //kulüp isim cekme lbla
            SqlCommand cmd3 = new SqlCommand("select KulupAdi from Tbl_Kulup where KulupID=@p1", bgl.baglanti());
            cmd3.Parameters.AddWithValue("@p1", lblıd1.Text);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                lblUyeKulup1.Text = dr3[0].ToString();

            }
            //etkinlik id cekme lbla
            SqlCommand cmd4 = new SqlCommand("select EtkinlikID from Tbl_OgrenciEtkinlik where OgrenciID=@p1", bgl.baglanti());
            cmd4.Parameters.AddWithValue("@p1", lblID.Text);
            SqlDataReader dr4 = cmd4.ExecuteReader();
            while (dr4.Read())
            {
                lbletld1.Text = dr4[0].ToString();

            }
            //etkinlik isim cekme lbla
            SqlCommand cmd5 = new SqlCommand("select EtkinlikAdi from Tbl_Etkinlik where EtkinlikID=@p1", bgl.baglanti());
            cmd5.Parameters.AddWithValue("@p1", lbletld1.Text);
            SqlDataReader dr5 = cmd5.ExecuteReader();
            while (dr5.Read())
            {
                lblEtkinlik1.Text = dr5[0].ToString();

            }

        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            FrmKulupler frm = new FrmKulupler();
            frm.Show();
            this.Hide();
        }

        private void picGeri_Click(object sender, EventArgs e)
        {
            FrmAnasayfa fr = new FrmAnasayfa();
            fr.Show();
            this.Hide();
        }

        private void picCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAra_Click_1(object sender, EventArgs e)
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
            FrmKullaniciProfil fr = new FrmKullaniciProfil();
            fr.Show();
            this.Hide();
        }
    }
}