using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmarterThing
{
    public partial class AyarPaneli : Form
    {
        public AyarPaneli()
        {
            InitializeComponent();
        }
        string ProgramAdi = "SmarterThing";
        Form1 frm = new Form1();
        OpenFileDialog file = new OpenFileDialog();
        private void btnMailAyarlari_Click(object sender, EventArgs e)
        {
            frm.kullaniciAdi = txtKullanici.Text + "@gmail.com";
            frm.sifre = txtSifre.Text;
            btnMailAyarlari.Text = "Kayıt Başarılı";

        }
        private void btnHavaDurumuKaydet_Click(object sender, EventArgs e)
        {
            switch (cmbSehir.Text)
            {

                case "01 Adana": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX0061:1:TU"; break;
                case "02 Adıyaman": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX6469:1:TU"; break;
                case "03 Afyon": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX0046:1:TU"; break;
                case "04 Ağrı": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX1447:1:TU"; break;
                case "05 Amasya": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX1447:1:TU"; break;
                case "06 Ankara": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX1447:1:TU"; break;
                case "07 Antalya": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX0004:1:TU"; break;
                case "08 Artvin": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX5851:1:TU"; break;
                case "09 Aydın": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX0051:1:TU"; break;
                case "10 Balıkesir": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX0041:1:TU"; break;
                case "11 Bilecik": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX7589:1:TU"; break;
                case "12 Bingöl": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX7894:1:TU"; break;
                case "13 Bitlis": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX9164:1:TU"; break;
                case "14 Bolu": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX0032:1:TU"; break;
                case "15 Burdur": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX7352:1:TU"; break;
                case "16 Bursa": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX0039:1:TU"; break;
                case "17 Çanakkale": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX0037:1:TU"; break;
                case "18 Çankırı": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX0797:1:TU"; break;
                case "19 Çorum": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX0033:1:TU"; break;
                case "20 Denizli": frm.SehirLink = "https://weather.com/weather/5day/l/TUDI0132:1:TU"; break;
                case "21 Diyarbakır": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX0010:1:TU"; break;
                case "22 Edirne": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX0030:1:TU"; break;
                case "23 Elazığ": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX0049:1:TU"; break;
                case "24 Erzincan": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX0035:1:TU"; break;
                case "25 Erzurum": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX0013:1:TU"; break;
                case "26 Eskişehir": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX0040:1:TU"; break;
                case "27 Gaziantep": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX0055:1:TU"; break;
                case "28 Giresun": frm.SehirLink = "https://weather.com/weather/5day/l/TUGE0190:1:TU"; break;
                case "29 Gümüşhane": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX5979:1:TU"; break;
                case "30 Hakkari": frm.SehirLink = "https://weather.com/weather/5day/l/TUHK0239:1:TU"; break;
                case "31 Hatay": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX0451:1:TU"; break;
                case "32 Isparta": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX0052:1:TU"; break;
                case "33 İçel (Mersin)": frm.SehirLink = "https://weather.com/weather/5day/l/TUML0382:1:TU"; break;
                case "34 İstanbul": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX0014:1:TU"; break;
                case "35 İzmir": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX0015:1:TU"; break;
                case "36 Kars": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX0036:1:TU"; break;
                case "37 Kastamonu": frm.SehirLink = "https://weather.com/weather/5day/l/TUKT0762:1:TU"; break;
                case "38 Kayseri": frm.SehirLink = ""; break;
                case "39 Kırklareli": frm.SehirLink = ""; break;
                case "40 Kırşehir": frm.SehirLink = ""; break;
                case "41 Kocaeli": frm.SehirLink = ""; break;
                case "42 Konya": frm.SehirLink = ""; break;
                case "43 Kütahya": frm.SehirLink = ""; break;
                case "44 Malatya": frm.SehirLink = ""; break;
                case "45 Manisa": frm.SehirLink = ""; break;
                case "46 K.maraş": frm.SehirLink = ""; break;
                case "47 Mardin": frm.SehirLink = ""; break;
                case "48 Muğla": frm.SehirLink = ""; break;
                case "49 Muş": frm.SehirLink = ""; break;
                case "50 Nevşehir": frm.SehirLink = ""; break;
                case "51 Niğde": frm.SehirLink = ""; break;
                case "52 Ordu": frm.SehirLink = ""; break;
                case "53 Rize": frm.SehirLink = ""; break;
                case "54 Sakarya": frm.SehirLink = ""; break;
                case "55 Samsun": frm.SehirLink = ""; break;
                case "56 Siirt": frm.SehirLink = ""; break;
                case "57 Sinop": frm.SehirLink = ""; break;
                case "58 Sivas": frm.SehirLink = ""; break;
                case "59 Tekirdağ": frm.SehirLink = ""; break;
                case "60 Tokat": frm.SehirLink = ""; break;
                case "61 Trabzon": frm.SehirLink = ""; break;
                case "62 Tunceli": frm.SehirLink = ""; break;
                case "63 Şanlıurfa": frm.SehirLink = ""; break;
                case "64 Uşak": frm.SehirLink = ""; break;
                case "65 Van": frm.SehirLink = ""; break;
                case "66 Yozgat": frm.SehirLink = ""; break;
                case "67 Zonguldak": frm.SehirLink = ""; break;
                case "68 Aksaray": frm.SehirLink = ""; break;
                case "69 Bayburt": frm.SehirLink = ""; break;
                case "70 Karaman": frm.SehirLink = ""; break;
                case "71 Kırıkkale": frm.SehirLink = ""; break;
                case "72 Batman": frm.SehirLink = ""; break;
                case "73 Şırnak": frm.SehirLink = ""; break;
                case "74 Bartın": frm.SehirLink = ""; break;
                case "75 Ardahan": frm.SehirLink = ""; break;
                case "76 Iğdır": frm.SehirLink = ""; break;
                case "77 Yalova": frm.SehirLink = ""; break;
                case "78 Karabük": frm.SehirLink = ""; break;
                case "79 Kilis": frm.SehirLink = ""; break;
                case "80 Osmaniye": frm.SehirLink = ""; break;
                case "81 Düzce": frm.SehirLink = ""; break;
            }
            btnHavaDurumuKaydet.Text = "Kayıt Başarılı";
        }
        private void btnZamanlayici_Click(object sender, EventArgs e)
        {
            frm.DevreyeGirisZamani = txtEkranKoruyucuZamani.Text;
            frm.HaberAkisHizi = txtHaberAkisHizi.Text;
            btnZamanlayici.Text = "Kayıt Başarılı";
        }
        #region CheckBox Settings
        private void chkSeffaf_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSeffaf.Checked == true)
            {
                btnRenkKaydet.Enabled = false;
                btnResimSec.Enabled = false;
                txtR.Enabled = false;
                txtG.Enabled = false;
                txtB.Enabled = false;
                chkResim.Enabled = false;
                chkRenk.Enabled = false;
            }
            else
            {
                btnRenkKaydet.Enabled = true;
                btnResimSec.Enabled = true;
                txtR.Enabled = true;
                txtG.Enabled = true;
                txtB.Enabled = true;
                chkResim.Enabled = true;
                chkRenk.Enabled = true;
            }
        }

        private void chkResim_CheckedChanged(object sender, EventArgs e)
        {
            if (chkResim.Checked == true)
            {
                btnRenkKaydet.Enabled = false;
                txtR.Enabled = false;
                txtG.Enabled = false;
                txtB.Enabled = false;
                chkSeffaf.Enabled = false;
                chkRenk.Enabled = false;
            }
            else
            {
                btnRenkKaydet.Enabled = true;
                txtR.Enabled = true;
                txtG.Enabled = true;
                txtB.Enabled = true;
                chkRenk.Enabled = true;
                chkSeffaf.Enabled = true;
            }
        }

        private void chkRenk_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRenk.Checked == true)
            {
                btnResimSec.Enabled = false;
                chkSeffaf.Enabled = false;
                chkResim.Enabled = false;
            }
            else
            {
                btnResimSec.Enabled = true;
                chkResim.Enabled = true;
                chkSeffaf.Enabled = true;
            }
        }
        #endregion
        private void btnResimSec_Click(object sender, EventArgs e)
        {
            file.Filter = "Fotograf Dosyası |*.jpg";
            file.ShowDialog();

            if (file.ShowDialog() == DialogResult.OK)
            {
                frm.ArkaPlanResmi = file.FileName;
                btnResimSec.Text = "Resim Seçildi";
                btnResimSec.Enabled = false;
            }
        }
        private void btnRenkKaydet_Click(object sender, EventArgs e)
        {

            frm.ArkaPlanRengiR = txtR.Text;
            frm.ArkaPlanRengiG = txtG.Text;
            frm.ArkaPlanRengiB = txtB.Text;
            btnRenkKaydet.Text = "Kayıt Başarılı";
        }

        private void AyarPaneli_Load(object sender, EventArgs e)
        {
            btnResimSec.Enabled = false;
            btnRenkKaydet.Enabled = false;
            txtR.Enabled = false;
            txtG.Enabled = false;
            txtB.Enabled = false;
            cmbSehir.SelectedIndex = 34;
            comboBox1.SelectedIndex = 0;
            MyIcon.Icon = new Icon(@"C:\Users\mkaan\source\repos\SmarterThing\SmarterThing\favicon.ico");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyIcon.Visible = true;
            MyIcon.Text = "SmarterThing - Kapatma Paneli";
            MyIcon.BalloonTipTitle = "SmarterThing'i Kapatın";
            MyIcon.BalloonTipText = "SmarterThing Aşağıda Aktif Eğer Kapatmak İsterseniz Çift Tıklamanız Yeterlidir.";
            MyIcon.BalloonTipIcon = ToolTipIcon.Info;
            MyIcon.ShowBalloonTip(30000);
            switch (cmbSehir.Text)
            {

                case "01 Adana": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX0061:1:TU"; break;
                case "02 Adıyaman": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX6469:1:TU"; break;
                case "03 Afyon": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX0046:1:TU"; break;
                case "04 Ağrı": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX1447:1:TU"; break;
                case "05 Amasya": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX1447:1:TU"; break;
                case "06 Ankara": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX1447:1:TU"; break;
                case "07 Antalya": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX0004:1:TU"; break;
                case "08 Artvin": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX5851:1:TU"; break;
                case "09 Aydın": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX0051:1:TU"; break;
                case "10 Balıkesir": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX0041:1:TU"; break;
                case "11 Bilecik": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX7589:1:TU"; break;
                case "12 Bingöl": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX7894:1:TU"; break;
                case "13 Bitlis": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX9164:1:TU"; break;
                case "14 Bolu": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX0032:1:TU"; break;
                case "15 Burdur": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX7352:1:TU"; break;
                case "16 Bursa": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX0039:1:TU"; break;
                case "17 Çanakkale": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX0037:1:TU"; break;
                case "18 Çankırı": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX0797:1:TU"; break;
                case "19 Çorum": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX0033:1:TU"; break;
                case "20 Denizli": frm.SehirLink = "https://weather.com/weather/5day/l/TUDI0132:1:TU"; break;
                case "21 Diyarbakır": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX0010:1:TU"; break;
                case "22 Edirne": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX0030:1:TU"; break;
                case "23 Elazığ": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX0049:1:TU"; break;
                case "24 Erzincan": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX0035:1:TU"; break;
                case "25 Erzurum": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX0013:1:TU"; break;
                case "26 Eskişehir": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX0040:1:TU"; break;
                case "27 Gaziantep": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX0055:1:TU"; break;
                case "28 Giresun": frm.SehirLink = "https://weather.com/weather/5day/l/TUGE0190:1:TU"; break;
                case "29 Gümüşhane": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX5979:1:TU"; break;
                case "30 Hakkari": frm.SehirLink = "https://weather.com/weather/5day/l/TUHK0239:1:TU"; break;
                case "31 Hatay": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX0451:1:TU"; break;
                case "32 Isparta": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX0052:1:TU"; break;
                case "33 İçel (Mersin)": frm.SehirLink = "https://weather.com/weather/5day/l/TUML0382:1:TU"; break;
                case "34 İstanbul": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX0014:1:TU"; break;
                case "35 İzmir": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX0015:1:TU"; break;
                case "36 Kars": frm.SehirLink = "https://weather.com/weather/5day/l/TUXX0036:1:TU"; break;
                case "37 Kastamonu": frm.SehirLink = "https://weather.com/weather/5day/l/TUKT0762:1:TU"; break;
                case "38 Kayseri": frm.SehirLink = ""; break;
                case "39 Kırklareli": frm.SehirLink = ""; break;
                case "40 Kırşehir": frm.SehirLink = ""; break;
                case "41 Kocaeli": frm.SehirLink = ""; break;
                case "42 Konya": frm.SehirLink = ""; break;
                case "43 Kütahya": frm.SehirLink = ""; break;
                case "44 Malatya": frm.SehirLink = ""; break;
                case "45 Manisa": frm.SehirLink = ""; break;
                case "46 K.maraş": frm.SehirLink = ""; break;
                case "47 Mardin": frm.SehirLink = ""; break;
                case "48 Muğla": frm.SehirLink = ""; break;
                case "49 Muş": frm.SehirLink = ""; break;
                case "50 Nevşehir": frm.SehirLink = ""; break;
                case "51 Niğde": frm.SehirLink = ""; break;
                case "52 Ordu": frm.SehirLink = ""; break;
                case "53 Rize": frm.SehirLink = ""; break;
                case "54 Sakarya": frm.SehirLink = ""; break;
                case "55 Samsun": frm.SehirLink = ""; break;
                case "56 Siirt": frm.SehirLink = ""; break;
                case "57 Sinop": frm.SehirLink = ""; break;
                case "58 Sivas": frm.SehirLink = ""; break;
                case "59 Tekirdağ": frm.SehirLink = ""; break;
                case "60 Tokat": frm.SehirLink = ""; break;
                case "61 Trabzon": frm.SehirLink = ""; break;
                case "62 Tunceli": frm.SehirLink = ""; break;
                case "63 Şanlıurfa": frm.SehirLink = ""; break;
                case "64 Uşak": frm.SehirLink = ""; break;
                case "65 Van": frm.SehirLink = ""; break;
                case "66 Yozgat": frm.SehirLink = ""; break;
                case "67 Zonguldak": frm.SehirLink = ""; break;
                case "68 Aksaray": frm.SehirLink = ""; break;
                case "69 Bayburt": frm.SehirLink = ""; break;
                case "70 Karaman": frm.SehirLink = ""; break;
                case "71 Kırıkkale": frm.SehirLink = ""; break;
                case "72 Batman": frm.SehirLink = ""; break;
                case "73 Şırnak": frm.SehirLink = ""; break;
                case "74 Bartın": frm.SehirLink = ""; break;
                case "75 Ardahan": frm.SehirLink = ""; break;
                case "76 Iğdır": frm.SehirLink = ""; break;
                case "77 Yalova": frm.SehirLink = ""; break;
                case "78 Karabük": frm.SehirLink = ""; break;
                case "79 Kilis": frm.SehirLink = ""; break;
                case "80 Osmaniye": frm.SehirLink = ""; break;
                case "81 Düzce": frm.SehirLink = ""; break;
            }
            if (txtKullanici.Text == "" || txtSifre.Text == "" || txtEkranKoruyucuZamani.Text == "" || txtHaberAkisHizi.Text == "")
            {
                MessageBox.Show("Email, Şifre, Zamanlayıcı veya Haber Akış Hızı kutucuğu boş olamaz. Lütfen verileri kontrol edin", "SmarterThing - Hata Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frm.ArkaPlanResmi = file.FileName;
                frm.DevreyeGirisZamani = txtEkranKoruyucuZamani.Text;
                frm.HaberAkisHizi = txtHaberAkisHizi.Text;
                frm.kullaniciAdi = txtKullanici.Text;
                frm.ArkaPlanRengiR = txtR.Text;
                frm.ArkaPlanRengiG = txtG.Text;
                frm.ArkaPlanRengiB = txtB.Text;
                if (chkSeffaf.Checked == true)
                {
                    frm.ArkaPlanSeffaf = "LightSalmon";
                }
                else
                {
                    frm.ArkaPlanSeffaf = "bosbu";
                }
                frm.sifre = txtSifre.Text;
                frm.Show();
                Hide();
            }
        }

        private void btnbaslangictacalistir_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Çalıştır")
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.SetValue(ProgramAdi, "\"" + Application.ExecutablePath + "\"");
            }
            else if (comboBox1.Text == "Çalıştırma")
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.DeleteValue(ProgramAdi);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                btnbaslangictacalistir.Text = "Başlangıçta Çalıştır";
            }
            else
            {
                btnbaslangictacalistir.Text = "Başlangıçta Çalıştırma";
            }
        }

        private void AyarPaneli_Resize(object sender, EventArgs e)
        {

            Hide();


        }

        private void MyIcon_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            frmKapanis frm = new frmKapanis();
            frm.Show();

            MyIcon.Visible = false;
        }

    }
}
