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
using System.Net.NetworkInformation;

namespace KampusPlus
{
    public partial class FrmYonetimPaneli : Form
    {
        sqlbaglantisi bgl = new sqlbaglantisi();
        public FrmYonetimPaneli()
        {
            InitializeComponent();
        }
        public string KullaniciAdi;
        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        //Yönetim giriş kısmına kodları yaz sonra buraya veri çektik
        private void FrmYonetimPaneli_Load(object sender, EventArgs e)
        {
            label8.Text = KullaniciAdi.ToString();
            SqlCommand komut = new SqlCommand("select DanismanAdi from Tbl_Danisman where KullaniciAdi=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", long.Parse(label8.Text));
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                label9.Text = dr[0].ToString();
            }

            SqlCommand komut2 = new SqlCommand("select KulupID from Tbl_Danisman where KullaniciAdi=@p1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", long.Parse(label8.Text));
            SqlDataReader dr2 = komut2.ExecuteReader();
            if (dr2.Read())
            {
                label10.Text = dr2[0].ToString();


                SqlCommand komut3 = new SqlCommand("select BaskanAd from Tbl_Kulup where KulupID=@p1", bgl.baglanti());
                komut3.Parameters.AddWithValue("@p1", label10.Text);
                SqlDataReader dr3 = komut3.ExecuteReader();
                if (dr3.Read())
                {
                    label5.Text = dr3[0].ToString();
                }
            }


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_KulüpUyelik where KulupID='" + label10.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from Tbl_Sponsor ", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;


        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update Tbl_Kulup set KulupAdi=@p1,KulupMail=@p2,KulupTelefon=@p3 where KulupID=@p4", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtisim.Text);
            cmd.Parameters.AddWithValue("@p2", txtmail.Text);
            cmd.Parameters.AddWithValue("@p3", msktelefon.Text);
            cmd.Parameters.AddWithValue("@p4", label10.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgiler Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void picGeri_Click(object sender, EventArgs e)
        {
            FrmGiris fr = new FrmGiris();
            fr.Show();
            this.Hide();

        }

        private void picCikis_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}