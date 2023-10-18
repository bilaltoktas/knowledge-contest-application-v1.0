namespace bilgi_yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soru = 0, dogru = 0, yanlis = 0;

        private void btnb_Click(object sender, EventArgs e)
        {
            scnk.Text = btnb.Text;
            if (dgrcvp.Text == scnk.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                panel1.Visible = true;
                panel2.Visible = false;
            }
            else
            {
                yanlis++;
                lblyanlıs.Text = yanlis.ToString();
                panel1.Visible = false;
                panel2.Visible = true;
            }
            btnsoru.Visible = true;
            btna.Visible = false;
            btnb.Visible = false;
            btnc.Visible = false;
            btnd.Visible = false;
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            scnk.Text = btnc.Text;
            if (dgrcvp.Text == scnk.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                panel1.Visible = true;
                panel2.Visible = false;
            }
            else
            {
                yanlis++;
                lblyanlıs.Text = yanlis.ToString();
                panel1.Visible=false;
                panel2.Visible=true;
            }
            btnsoru.Visible = true;
            btna.Visible = false;
            btnb.Visible = false;
            btnc.Visible = false;
            btnd.Visible = false;
        }

        private void btnd_Click(object sender, EventArgs e)
        {
            scnk.Text = btnd.Text;
            if (dgrcvp.Text == scnk.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                panel1.Visible = true;
                panel2.Visible = false;

            }
            else
            {
                yanlis++;
                lblyanlıs.Text = yanlis.ToString();
                panel1.Visible = false;
                panel2.Visible = true;
            }
            btnsoru.Visible = true;
            btna.Visible = false;
            btnb.Visible = false;
            btnc.Visible = false;
            btnd.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            soru = 0;
            dogru= 0;
            yanlis = 0;
            lbldogru.Text = dogru.ToString();
            lblyanlıs.Text= yanlis.ToString();
            lblsoru.Text = soru.ToString();   
            btnsoru.Visible = true;
            label2.Visible = false;
            btnsoru.Text = "BASLA";
        }

        private void btna_Click(object sender, EventArgs e)
        {
            scnk.Text = btna.Text;
            if (dgrcvp.Text==scnk.Text)
            {
                dogru++;
                lbldogru.Text=dogru.ToString();
                panel1.Visible = true;
                panel2.Visible = false;
            }
            else
            {
                yanlis++;
                lblyanlıs.Text=yanlis.ToString();
                panel1.Visible = false;
                panel2.Visible = true;
            }
            btnsoru.Visible= true;
            btna.Visible = false;
            btnb.Visible = false;
            btnc.Visible = false;
            btnd.Visible = false;
        }

        private void btnsoru_Click(object sender, EventArgs e)
        {
           btnsoru.Visible = false;
            soru++;
            lblsoru.Text = soru.ToString();
            if (soru <= 4)
            {
                btna.Visible = true;
                btnb.Visible = true;
                btnc.Visible = true;
                btnd.Visible = true;
            }
            if (soru == 1)
            {
                richTextBox1.Text = "SİNEKLİ BAKKAL ROMANININ YAZARI KİMDİR?";
                btna.Text = "REŞAT NURİ GÜNTEKİN";
                btnb.Text = "HALİDE EDİP ADIVAR";
                btnc.Text = "ZİYA GÖKALP";
                btnd.Text = "ÖMER SEYFETTİN";
                dgrcvp.Text = "HALİDE EDİP ADIVAR";
                btnsoru.Text = "İLERLE";
            }
            if (soru == 2)
            {
                richTextBox1.Text = "2003 EURO VİZYON ŞARKI PROGRAMINDA ÜLKEMİZİ TEMSİL EDİP YARIŞMAYI KAZANAN SANATÇIMIZ KİMDİR";
                btna.Text = "GRUP ATHENA";
                btnb.Text = "SERTAP ERENER";
                btnc.Text = "ŞEBNEM PEKER";
                btnd.Text = "AJDA PEKKAN";
                dgrcvp.Text = "SERTAP ERENER";
            }
            if (soru == 3)
            {
                richTextBox1.Text = "MUSTAFA KEMAL ATATÜRKÜN NÜFUSA KAYITLI OLDUĞU İL HANGİSİDİR?";
                btna.Text = "BURSA";
                btnb.Text = "ANKARA";
                btnc.Text = "İSTANBUL";
                btnd.Text = "GAZİANTEP";
                dgrcvp.Text = "GAZİANTEP";
            }
            if (soru == 4)
            {
                richTextBox1.Text = "DÜNYA SAĞLIK ÖRGÜTÜNÜN KISALTILMIŞ HALİ AŞAĞIDAKİLERDEN HANGİSİDİR?";
                btna.Text = "UHW";
                btnb.Text = "UNICEF";
                btnc.Text = "WHO";
                btnd.Text = "NATO";
                dgrcvp.Text = "WHO";
                btnsoru.Text = "SONUÇ";
            }
            if (soru >= 5)
            {
                btnsoru.Visible = false;
                btna.Visible = false;
                btnb.Visible = false;
                btnc.Visible = false;
                btnd.Visible = false;
                panel1.Visible = false;
                panel2.Visible = false;
                label2.Visible = true;
                MessageBox.Show("DOGRU CEVAP SAYISI: " + lbldogru.Text + "\nYANLIŞ CEVAP SAYISI: " + lblyanlıs.Text);
            }
            panel1.Visible = false;
            panel2.Visible = false;

        }
    }
}