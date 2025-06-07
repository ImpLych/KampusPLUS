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
    public partial class FrmKulupKayit : Form
    {
        public FrmKulupKayit()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void BtnUyeOl_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_KulüpUyelik (OgrenciID,KulupID,OgrenciMail,OgrenciTelefon) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p2", label3.Text);
            komut.Parameters.AddWithValue("@p3", TxtMail.Text);
            komut.Parameters.AddWithValue("@p4", MskTelefon.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız Başarıyla Oluşturulmuştur.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TxtMail.Clear();
            MskTelefon.Clear();

        }




        private void FrmKulupKayit_Load(object sender, EventArgs e)
        {
           // TxtKulupAdi.Text = "2";

        }

        private void FrmKulupKayit_Load_1(object sender, EventArgs e)
        {
            //TxtKulupAdi.Text = "2";
            TxtKullaniciAdi.Text = "20";
        }

        private void picGeri_Click(object sender, EventArgs e)
        {
            FrmKulupSayfa fr = new FrmKulupSayfa();
            fr.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

