using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Net;
using HtmlAgilityPack;
using System.Threading;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;

namespace SmarterThing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Değişkenlerin Tümü
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }
        public string SehirLink { get; set; }
        public string HaberAkisHizi { get; set; }
        public string DevreyeGirisZamani { get; set; }
        public string ArkaPlanResmi { get; set; }
        public string ArkaPlanRengiR { get; set; }
        public string ArkaPlanRengiG { get; set; }
        public string ArkaPlanRengiB { get; set; }
        public string ArkaPlanSeffaf { get; set; }
        public bool K1 { get => K; set => K = value; }
        public bool L1 { get => L; set => L = value; }
        public bool K2 { get => K; set => K = value; }
        public bool L2 { get => L; set => L = value; }

        double bugungunduzfahrenheit;
        string bugungunduz;
        #endregion
        #region userdll import ve lastinputinfo
        [DllImport("User32.dll")]
        private static extern bool
       GetLastInputInfo(ref LASTINPUTINFO plii);
        internal struct LASTINPUTINFO
        {
            public uint cbSize;
            public uint dwTime;
        }
        static uint GetLastInputTime()
        {
            uint idleTime = 0;
            LASTINPUTINFO lastInputInfo = new LASTINPUTINFO();
            lastInputInfo.cbSize = (uint)Marshal.SizeOf(lastInputInfo);
            lastInputInfo.dwTime = 0;

            uint envTicks = (uint)Environment.TickCount;

            if (GetLastInputInfo(ref lastInputInfo))
            {
                uint lastInputTick = lastInputInfo.dwTime;

                idleTime = envTicks - lastInputTick;
            }

            return ((idleTime > 0) ? (idleTime / 1000) : 0);
        }
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            if (ArkaPlanResmi=="")
            {
                if (ArkaPlanRengiR=="R"&&ArkaPlanRengiG=="G" && ArkaPlanRengiB =="B" && ArkaPlanSeffaf == "bosbu")
                {
                    this.BackColor = Color.FromArgb(0,0,0);
                }
                else if (ArkaPlanSeffaf== "LightSalmon")
                {
                    this.BackColor = Color.LightSalmon;
                }
                else if (ArkaPlanRengiR != "R" || ArkaPlanRengiG != "G" || ArkaPlanRengiB != "B")
                {
                    this.BackColor = Color.FromArgb(Convert.ToInt32(ArkaPlanRengiR), Convert.ToInt32(ArkaPlanRengiG), Convert.ToInt32(ArkaPlanRengiB));

                }
            }
            else
            {
                this.BackgroundImage = Image.FromFile(ArkaPlanResmi);
                this.BackgroundImageLayout = ImageLayout.Center;
            }
            Saat.Start();
            graphic.Start();
            ScreenSaver.Start();
            this.Hide();
            timer1.Interval = Convert.ToInt32(HaberAkisHizi);
            lblhaber.Text = "";
            Uri url = new Uri(SehirLink);
            WebClient client = new WebClient();
            string html = client.DownloadString(url);
            HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
            dokuman.LoadHtml(html);

            if (dokuman.DocumentNode.SelectNodes("/html/body/div[1]/div/div/div[12]/div/div[3]/main/div[3]/div/article/div/table/tbody/tr[1]/td[4]/div/span[1]")[0].InnerText=="--")
            {
              bugungunduzfahrenheit = 25;
            }
            else { 
            bugungunduzfahrenheit = Convert.ToDouble(dokuman.DocumentNode.SelectNodes("/html/body/div[1]/div/div/div[12]/div/div[3]/main/div[3]/div/article/div/table/tbody/tr[1]/td[4]/div/span[1]")[0].InnerText.Remove(2, 2)) - 32;

            double bugungunduzhesaplama = bugungunduzfahrenheit / 1.8;
            bugungunduz = bugungunduzhesaplama.ToString().Remove(2, bugungunduzhesaplama.ToString().Length - 2);
            }

            //------//
            double bugungecefahrenheit = Convert.ToDouble(dokuman.DocumentNode.SelectNodes("/html/body/div[1]/div/div/div[12]/div/div[3]/main/div[3]/div/article/div/table/tbody/tr[1]/td[4]/div/span[3]")[0].InnerText.Remove(2, 2)) - 32;
            double bugungecehesaplama = bugungecefahrenheit / 1.8;
            string bugungece = bugungecehesaplama.ToString().Remove(2, bugungecehesaplama.ToString().Length - 2);
            //------//
            double yaringunduzfahrenheit = Convert.ToDouble(dokuman.DocumentNode.SelectNodes("/html/body/div[1]/div/div/div[12]/div/div[3]/main/div[3]/div/article/div/table/tbody/tr[5]/td[4]/div/span[1]")[0].InnerText.Remove(2, 2)) - 32;
            double yaringunduzhesaplama = yaringunduzfahrenheit / 1.8;
            string yaringunduz = yaringunduzhesaplama.ToString().Remove(2, yaringunduzhesaplama.ToString().Length - 2);
            //------//
            double yaringecefahrenheit = Convert.ToDouble(dokuman.DocumentNode.SelectNodes("/html/body/div[1]/div/div/div[12]/div/div[3]/main/div[3]/div/article/div/table/tbody/tr[5]/td[4]/div/span[3]")[0].InnerText.Remove(2, 2)) - 32;
            double yaringecehesaplama = yaringecefahrenheit / 1.8;
            string yaringece = yaringecehesaplama.ToString().Remove(2, yaringecehesaplama.ToString().Length - 2);
            //------//
            TabloBasi();
            BugunHavaDurumu(bugungunduz, bugungece);
            YarinHavaDurumu(yaringunduz, yaringece);
            HaberlerSlider();
            MailCagir();

        }

        private void HaberlerSlider()
        {
            Uri urlhaber = new Uri("https://www.trthaber.com/sitene-ekle/gundem-1/?haberSay=30");
            WebClient clienthaber = new WebClient();

            string htmlhaber = clienthaber.DownloadString(urlhaber);
            HtmlAgilityPack.HtmlDocument dokumanhaber = new HtmlAgilityPack.HtmlDocument();
            dokumanhaber.LoadHtml(htmlhaber);
            timer1.Enabled = true;
            lblhaber.Dock = DockStyle.Bottom;
            lblhaber.AutoSize = false;
            lblhaber.Height = 44;
            lblhaber.Padding = new Padding(10, 10, 10, 10);
            lblhaber.BackColor = Color.FromArgb(139, 35, 35);
            lblhaber.Font = new Font("Arial", 15);
            lblhaber.BringToFront();
            lblhaber.ForeColor = Color.FromArgb(250, 250, 250);
            lblMailDetay.Font = new Font("Arial", 12);

            for (int i = 1; i < 30; i++)
            {
                string haberler = dokumanhaber.DocumentNode.SelectNodes("/html/body/div/a[" + i.ToString() + "]/span[1]")[0].InnerText.Replace("quot;", "");
                byte[] bytes = Encoding.Default.GetBytes(haberler);
                string falan = Encoding.UTF8.GetString(bytes);
                lblhaber.Text += falan + " // ";

            }
        }

        private void YarinHavaDurumu(string yaringunduz, string yaringece)
        {
            lbl2.Dock = DockStyle.Bottom;
            lbl2.Width = 50;
            lbl2.Height = 100;
            lbl2.AutoSize = true;
            lbl2.ForeColor = Color.FromArgb(150, 150, 150);
            lbl2.Font = new Font("Segoe Script", 27);

            lbl2.Text = DateTime.Today.AddDays(1).Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + " - " + yaringunduz + "/" + yaringece + " Derece";
        }

        private void BugunHavaDurumu(string bugungunduz, string bugungece)
        {
            lbl1.Dock = DockStyle.Bottom;
            lbl1.Width = 50;
            lbl1.Height = 100;
            lbl1.AutoSize = true;
            lbl1.ForeColor = Color.FromArgb(200, 200, 200);
            lbl1.Font = new Font("Segoe Script", 27);
            lbl1.Text = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + " - " + bugungunduz + "/" + bugungece + " Derece";
        }

        private void TabloBasi()
        {
            Tablobasi.Dock = DockStyle.Bottom;
            Tablobasi.AutoSize = false;
            Tablobasi.Width = 500;
            Tablobasi.Height = 50;
            Tablobasi.ForeColor = Color.White;
            Tablobasi.Font = new Font("Segoe Script", 25, FontStyle.Underline);
            Tablobasi.Text = "Hava Durumu  Gündüz/Gece            ";
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.Hide();
            lblMail.Text = "Mail Sayısı : ";
            lblMailDetay.Text = "";
            MailCagir();
            lblhaber.Text = "";
            HaberlerSlider();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhaber.Text = lblhaber.Text.Substring(1) + lblhaber.Text.Substring(0, 1);

            lblhaber.Text = lblhaber.Text.Substring(1) + lblhaber.Text.Substring(0, 1);
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            // this.Hide();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

            //this.Hide();

        }

        int i = Screen.PrimaryScreen.Bounds.Width;

        private void graphic_Tick(object sender, EventArgs e)
        {
            if (i == Screen.PrimaryScreen.Bounds.Width - 200)
            {
                graphic.Stop();

            }
            else
            {
                lblMail.Left = i--;
                lblMailDetay.Left = i;
            }
        }

        private void Saat_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
            lblTarih.Text = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;
        }

        private void mailcek_Tick(object sender, EventArgs e)
        {
            MailCagir();
        }

        private void MailCagir()
        {
            try
            {
                System.Net.WebClient objClient = new System.Net.WebClient();
                string response;
                string title;
                string summary;
                
                XmlDocument doc = new XmlDocument();

                objClient.Credentials = new System.Net.NetworkCredential(kullaniciAdi, sifre);
                response = Encoding.UTF8.GetString(
                           objClient.DownloadData(@"https://mail.google.com/mail/feed/atom"));

                response = response.Replace(
                     @"<feed version=""0.3"" xmlns=""http://purl.org/atom/ns#"">", @"<feed>");

                doc.LoadXml(response);

                string nr = doc.SelectSingleNode(@"/feed/fullcount").InnerText;
                lblMail.Text += nr;

                foreach (XmlNode node in doc.SelectNodes(@"/feed/entry"))
                {
                    title = node.SelectSingleNode("title").InnerText;
                    summary = node.SelectSingleNode("summary").InnerText;
                    lblMailDetay.Text += title + Environment.NewLine + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("İnternet Bağlantınızda Ya Da Mail Bilgileriniz de Bir Hata Mevcut." + Environment.NewLine + ex.ToString(), "SmarterThing");
            }


        }

        private void ScreenSaver_Tick(object sender, EventArgs e)
        {
            if (GetLastInputTime() == Convert.ToInt32(DevreyeGirisZamani))
            {
                Show();
                graphic.Start();
            }
        }
        bool K;
        bool L;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.K)
            {
                Application.Exit();
            }
            if (e.KeyCode==Keys.Escape)
            {
                this.Hide();
            }
            
        }   
    }       
}           
            