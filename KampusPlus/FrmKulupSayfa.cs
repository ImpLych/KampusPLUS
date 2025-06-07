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
    public partial class FrmKulupSayfa: Form
    {
        public FrmKulupSayfa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnkayıtol_Click(object sender, EventArgs e)
        {
            FrmKulupKayit fr = new FrmKulupKayit();
            fr.Show();
            this.Hide();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmKulupSayfa_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select BaskanAd from Tbl_Kulup where KulupID=2", bgl.baglanti());
            
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblbaskan.Text = dr[0].ToString();
            }

            lbldanısman.Text = "Nur Kuban Torun";


            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from Tbl_Etkinlik ", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray;

        }

        private void picnext_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
        }

        private void picback_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
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

        private void picGeri_Click(object sender, EventArgs e)
        {
            FrmKulupler fr = new FrmKulupler();
            fr.Show();
            this.Hide();

        }
    }
}
