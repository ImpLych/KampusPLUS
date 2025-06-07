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
    public partial class FrmKulupler : Form
    {
        public FrmKulupler()
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

        private void BtnKulup1_Click(object sender, EventArgs e)
        {
            FrmKulupSayfa frm = new FrmKulupSayfa();
            frm.Show();
            this.Hide();

        }


        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmKulupler_Load(object sender, EventArgs e)
        {
            
            SqlCommand komut = new SqlCommand("select KulupAdi from Tbl_Kulup", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbTumKulupler.Items.Add(dr[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void CmbTumKulupler_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
    }
}
