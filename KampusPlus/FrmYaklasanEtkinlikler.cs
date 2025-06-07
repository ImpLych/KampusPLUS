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
using System.Windows.Controls;
namespace KampusPlus
{
    public partial class FrmYaklasanEtkinlikler : Form
    {
        sqlbaglantisi bgl = new sqlbaglantisi();
        public FrmYaklasanEtkinlikler()
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

        private void FrmYaklasanEtkinlikler_Load(object sender, EventArgs e)
        {
            //SqlCommand cmd = new SqlCommand("select * from Tbl_Etkinlik", bgl.baglanti());
            //SqlDataReader dr = cmd.ExecuteReader();
            //if (dr.Read())
            //{
            //    richTextBox1.Text = dr[2].ToString();  // EtkinlikAdi
            //    bgl.baglanti().Close();
            //}


            SqlCommand cmd2 = new SqlCommand("SELECT * FROM Tbl_Etkinlik WHERE EtkinlikAdi = 'hAsanla Tour'", bgl.baglanti());

            SqlDataReader dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                txt2.Text = dr2[2].ToString();  // EtkinlikAdi
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