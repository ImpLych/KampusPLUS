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
    public partial class FrmSponsorBasvuru: Form
    {
        public FrmSponsorBasvuru()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        

        private void btnbasvur_Click(object sender, EventArgs e)
        {
           

        }

        private void picCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picGeri_Click(object sender, EventArgs e)
        {

        }

        private void btnbasvur_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Sponsor (SponsorAd,FirmaSahibi,FirmaMail,FirmaTelefon) values(@sponsorad,@firmasahip,@firmaemail,@firmatel)", bgl.baglanti());
            komut.Parameters.AddWithValue("@sponsorad", txtfirmaad.Text);
            komut.Parameters.AddWithValue("@firmasahip", txtfirmasahibi.Text);
            komut.Parameters.AddWithValue("@firmaemail", txtmail.Text);
            komut.Parameters.AddWithValue("@firmatel", txttelefon.Text.ToString());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Sponsorluk Başvurunuz Alınmıştır  ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void picGeri_Click_1(object sender, EventArgs e)
        {
            FrmAnasayfa2 fr = new FrmAnasayfa2();
            fr.Show();
            this.Hide();
        }
    }
}
