namespace KampusPlus
{
    partial class FrmKulupKayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKulupKayit));
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.picCikis = new System.Windows.Forms.PictureBox();
            this.picGeri = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.BtnUyeOl = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BtnGiris = new System.Windows.Forms.Button();
            this.BtnAra = new System.Windows.Forms.Button();
            this.BtnAnasayfa = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCikis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGeri)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(70, -67);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(247, 208);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.panel4.Controls.Add(this.picCikis);
            this.panel4.Controls.Add(this.picGeri);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Location = new System.Drawing.Point(0, -2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(379, 75);
            this.panel4.TabIndex = 8;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // picCikis
            // 
            this.picCikis.Image = ((System.Drawing.Image)(resources.GetObject("picCikis.Image")));
            this.picCikis.Location = new System.Drawing.Point(333, 0);
            this.picCikis.Name = "picCikis";
            this.picCikis.Size = new System.Drawing.Size(43, 42);
            this.picCikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCikis.TabIndex = 13;
            this.picCikis.TabStop = false;
            // 
            // picGeri
            // 
            this.picGeri.Image = ((System.Drawing.Image)(resources.GetObject("picGeri.Image")));
            this.picGeri.Location = new System.Drawing.Point(0, 0);
            this.picGeri.Name = "picGeri";
            this.picGeri.Size = new System.Drawing.Size(38, 35);
            this.picGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGeri.TabIndex = 12;
            this.picGeri.TabStop = false;
            this.picGeri.Click += new System.EventHandler(this.picGeri_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.MskTelefon);
            this.panel1.Controls.Add(this.BtnUyeOl);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TxtMail);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtKullaniciAdi);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.panel1.Location = new System.Drawing.Point(30, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 328);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // MskTelefon
            // 
            this.MskTelefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(143)))), ((int)(((byte)(128)))));
            this.MskTelefon.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTelefon.Location = new System.Drawing.Point(8, 204);
            this.MskTelefon.Mask = "00000000000";
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(282, 27);
            this.MskTelefon.TabIndex = 22;
            this.MskTelefon.ValidatingType = typeof(int);
            // 
            // BtnUyeOl
            // 
            this.BtnUyeOl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(143)))), ((int)(((byte)(128)))));
            this.BtnUyeOl.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUyeOl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.BtnUyeOl.Location = new System.Drawing.Point(93, 277);
            this.BtnUyeOl.Name = "BtnUyeOl";
            this.BtnUyeOl.Size = new System.Drawing.Size(111, 39);
            this.BtnUyeOl.TabIndex = 17;
            this.BtnUyeOl.Text = "ÜYE OL";
            this.BtnUyeOl.UseVisualStyleBackColor = false;
            this.BtnUyeOl.Click += new System.EventHandler(this.BtnUyeOl_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.label6.Location = new System.Drawing.Point(3, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Telefon No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.label5.Location = new System.Drawing.Point(3, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Mail Adresi:";
            // 
            // TxtMail
            // 
            this.TxtMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(143)))), ((int)(((byte)(128)))));
            this.TxtMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtMail.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMail.Location = new System.Drawing.Point(8, 123);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(282, 33);
            this.TxtMail.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Kullanıcı Adı:";
            // 
            // TxtKullaniciAdi
            // 
            this.TxtKullaniciAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(143)))), ((int)(((byte)(128)))));
            this.TxtKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtKullaniciAdi.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKullaniciAdi.Location = new System.Drawing.Point(8, 43);
            this.TxtKullaniciAdi.Name = "TxtKullaniciAdi";
            this.TxtKullaniciAdi.Size = new System.Drawing.Size(282, 33);
            this.TxtKullaniciAdi.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(116)))), ((int)(((byte)(111)))));
            this.label1.Location = new System.Drawing.Point(31, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 38);
            this.label1.TabIndex = 10;
            this.label1.Text = "KULÜP ÜYELİK";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.panel6.Controls.Add(this.BtnGiris);
            this.panel6.Controls.Add(this.BtnAra);
            this.panel6.Controls.Add(this.BtnAnasayfa);
            this.panel6.Location = new System.Drawing.Point(0, 610);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(379, 60);
            this.panel6.TabIndex = 11;
            // 
            // BtnGiris
            // 
            this.BtnGiris.BackColor = System.Drawing.Color.Transparent;
            this.BtnGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnGiris.BackgroundImage")));
            this.BtnGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGiris.FlatAppearance.BorderSize = 0;
            this.BtnGiris.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnGiris.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGiris.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnGiris.Image = ((System.Drawing.Image)(resources.GetObject("BtnGiris.Image")));
            this.BtnGiris.Location = new System.Drawing.Point(290, 10);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(44, 41);
            this.BtnGiris.TabIndex = 5;
            this.BtnGiris.UseVisualStyleBackColor = false;
            // 
            // BtnAra
            // 
            this.BtnAra.BackColor = System.Drawing.Color.Transparent;
            this.BtnAra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAra.BackgroundImage")));
            this.BtnAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAra.FlatAppearance.BorderSize = 0;
            this.BtnAra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtnAra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnAra.Image = ((System.Drawing.Image)(resources.GetObject("BtnAra.Image")));
            this.BtnAra.Location = new System.Drawing.Point(30, 10);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(44, 41);
            this.BtnAra.TabIndex = 4;
            this.BtnAra.UseVisualStyleBackColor = false;
            // 
            // BtnAnasayfa
            // 
            this.BtnAnasayfa.BackColor = System.Drawing.Color.Transparent;
            this.BtnAnasayfa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAnasayfa.BackgroundImage")));
            this.BtnAnasayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAnasayfa.FlatAppearance.BorderSize = 0;
            this.BtnAnasayfa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnAnasayfa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnAnasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnasayfa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnAnasayfa.Image = ((System.Drawing.Image)(resources.GetObject("BtnAnasayfa.Image")));
            this.BtnAnasayfa.Location = new System.Drawing.Point(160, 10);
            this.BtnAnasayfa.Name = "BtnAnasayfa";
            this.BtnAnasayfa.Size = new System.Drawing.Size(44, 41);
            this.BtnAnasayfa.TabIndex = 3;
            this.BtnAnasayfa.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(282, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "2";
            // 
            // FrmKulupKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(375, 667);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmKulupKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKulupKayit";
            this.Load += new System.EventHandler(this.FrmKulupKayit_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCikis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGeri)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button BtnGiris;
        private System.Windows.Forms.Button BtnAra;
        private System.Windows.Forms.Button BtnAnasayfa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnUyeOl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.MaskedTextBox MskTelefon;
        private System.Windows.Forms.PictureBox picCikis;
        private System.Windows.Forms.PictureBox picGeri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtKullaniciAdi;
        private System.Windows.Forms.Label label3;
    }
}