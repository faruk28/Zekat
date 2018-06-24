using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
//using Newtonsoft.Json;
//using Newtonsoft.Json.Linq;
using HtmlAgilityPack;

namespace Zekat
{
    public partial class Zekat : Form
    {
        public Zekat()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // sahip olduklarınız toplam
            double st1, st2, st3, st4, st5, st6, /*st7,*/ st8, st9, st10, sv1, sv2, sv3, sv4, sv5, sv6, sv7, sv8, sv9, sv10, st1Toplam, st2Toplam, st3Toplam, st4Toplam, st5Toplam, st6Toplam, st7Toplam, st8Toplam, st9Toplam, st10Toplam;
            st1 = Convert.ToDouble(textBox1.Text);
            st2 = Convert.ToDouble(textBox4.Text);
            st3 = Convert.ToDouble(textBox6.Text);
            st4 = Convert.ToDouble(textBox8.Text);
            st5 = Convert.ToDouble(textBox10.Text);
            st6 = Convert.ToDouble(textBox12.Text);
            /*st7 = Convert.ToDouble(textBox14.Text);*/
            st8 = Convert.ToDouble(textBox16.Text);
            st9 = Convert.ToDouble(textBox18.Text);
            st10 = Convert.ToDouble(textBox20.Text);

            sv1 = Convert.ToDouble(textBox60.Text);
            sv2 = Convert.ToDouble(textBox58.Text);
            sv3 = Convert.ToDouble(textBox56.Text);
            sv4 = Convert.ToDouble(textBox54.Text);
            sv5 = Convert.ToDouble(textBox52.Text);
            sv6 = Convert.ToDouble(textBox50.Text);
            //sv7 = Convert.ToDouble(textBox48.Text);
            sv8 = Convert.ToDouble(textBox46.Text);
            sv9 = Convert.ToDouble(textBox44.Text);
            sv10 = Convert.ToDouble(textBox42.Text);

            st1Toplam = Math.Round((st1 * sv1), 2);
            textBox2.Text = st1Toplam.ToString();

            st2Toplam = Math.Round((st2 * sv2), 2);
            textBox3.Text = st2Toplam.ToString();

            st3Toplam = Math.Round((st3 * sv3), 2);
            textBox5.Text = st3Toplam.ToString();

            st4Toplam = Math.Round((st4 * sv4), 2);
            textBox7.Text = st4Toplam.ToString();

            st5Toplam = Math.Round((st5 * sv5), 2);
            textBox9.Text = st5Toplam.ToString();

            st6Toplam = Math.Round((st6 * sv6), 2);
            textBox11.Text = st6Toplam.ToString();

            //st7Toplam = (st7 * sv7);
            //textBox13.Text = st7Toplam.ToString();

            st8Toplam = Math.Round((st8 * sv8), 2);
            textBox15.Text = st8Toplam.ToString();

            st9Toplam = Math.Round((st9 * sv9), 2);
            textBox17.Text = st9Toplam.ToString();

            st10Toplam = Math.Round((st10 * sv10), 2);
            textBox19.Text = st10Toplam.ToString();
            // sahip olduklarınız toplam

            // sahip olduklarınız
            double s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, sahipToplam;
            s1 = Convert.ToDouble(textBox2.Text);
            s2 = Convert.ToDouble(textBox3.Text);
            s3 = Convert.ToDouble(textBox5.Text);
            s4 = Convert.ToDouble(textBox7.Text);
            s5 = Convert.ToDouble(textBox9.Text);
            s6 = Convert.ToDouble(textBox11.Text);
            //s7 = Convert.ToDouble(textBox14.Text);
            s8 = Convert.ToDouble(textBox15.Text);
            s9 = Convert.ToDouble(textBox17.Text);
            s10 = Convert.ToDouble(textBox19.Text);
            sahipToplam = Math.Round((s1 + s2 + s3 + s4 + s5 + s6 /*+ s7*/ + s8 + s9 + s10), 2);
            textBox49.Text = sahipToplam.ToString();
            // sahip olduklarınız

            // borçlu olduklarınız toplam
            double bt1, bt2, bt3, bt4, bt5, bt6, /*bt7,*/ bt8, bt9, bt10, bv1, bv2, bv3, bv4, bv5, bv6, bv7, bv8, bv9, bv10, bt1Toplam, bt2Toplam, bt3Toplam, bt4Toplam, bt5Toplam, bt6Toplam, bt7Toplam, bt8Toplam, bt9Toplam, bt10Toplam;
            bt1 = Convert.ToDouble(textBox40.Text);
            bt2 = Convert.ToDouble(textBox38.Text);
            bt3 = Convert.ToDouble(textBox36.Text);
            bt4 = Convert.ToDouble(textBox34.Text);
            bt5 = Convert.ToDouble(textBox32.Text);
            bt6 = Convert.ToDouble(textBox30.Text);
            //bt7 = Convert.ToDouble(textBox28.Text);
            bt8 = Convert.ToDouble(textBox26.Text);
            bt9 = Convert.ToDouble(textBox24.Text);
            bt10 = Convert.ToDouble(textBox22.Text);

            bv1 = Convert.ToDouble(textBox60.Text);
            bv2 = Convert.ToDouble(textBox58.Text);
            bv3 = Convert.ToDouble(textBox56.Text);
            bv4 = Convert.ToDouble(textBox54.Text);
            bv5 = Convert.ToDouble(textBox52.Text);
            bv6 = Convert.ToDouble(textBox50.Text);
            //bv7 = Convert.ToDouble(textBox48.Text);
            bv8 = Convert.ToDouble(textBox46.Text);
            bv9 = Convert.ToDouble(textBox44.Text);
            bv10 = Convert.ToDouble(textBox42.Text);

            bt1Toplam = Math.Round((bt1 * bv1), 2);
            textBox39.Text = bt1Toplam.ToString();

            bt2Toplam = Math.Round((bt2 * bv2), 2);
            textBox37.Text = bt2Toplam.ToString();

            bt3Toplam = Math.Round((bt3 * bv3), 2);
            textBox35.Text = bt3Toplam.ToString();

            bt4Toplam = Math.Round((bt4 * bv4), 2);
            textBox33.Text = bt4Toplam.ToString();

            bt5Toplam = Math.Round((bt5 * bv5), 2);
            textBox31.Text = bt5Toplam.ToString();

            bt6Toplam = Math.Round((bt6 * bv6), 2);
            textBox29.Text = bt6Toplam.ToString();

            //bt7Toplam = (bt7 * bv7);
            //textBox27.Text = bt7Toplam.ToString();

            bt8Toplam = Math.Round((bt8 * bv8), 2);
            textBox25.Text = bt8Toplam.ToString();

            bt9Toplam = Math.Round((bt9 * bv9), 2);
            textBox23.Text = bt9Toplam.ToString();

            bt10Toplam = Math.Round((bt10 * bv10), 2);
            textBox21.Text = bt10Toplam.ToString();
            // borçlu olduklarınız toplam

            // borçlu olduklarınız başlangıç
            double b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, borcToplam;
            b1 = Convert.ToDouble(textBox39.Text);
            b2 = Convert.ToDouble(textBox37.Text);
            b3 = Convert.ToDouble(textBox35.Text);
            //b4 = Convert.ToDouble(textBox28.Text);
            b5 = Convert.ToDouble(textBox33.Text);
            b6 = Convert.ToDouble(textBox31.Text);
            b7 = Convert.ToDouble(textBox29.Text);
            b8 = Convert.ToDouble(textBox25.Text);
            b9 = Convert.ToDouble(textBox23.Text);
            b10 = Convert.ToDouble(textBox21.Text);
            borcToplam = Math.Round((b1 + b2 + b3 /*+ b4*/ + b5 + b6 + b7 + b8 + b9 + b10), 2);
            textBox47.Text = borcToplam.ToString();
            // borçlu olduklarınız son

            // sahipten borç çıkar
            double c1, c2, sbToplam;
            c1 = Convert.ToDouble(textBox49.Text);
            c2 = Convert.ToDouble(textBox47.Text);
            sbToplam = Math.Round((c1 - c2), 2);
            textBox45.Text = sbToplam.ToString();
            // sahipten borç çıkar

            // zekat sınırı
            double zs1, zs2, zsToplam;
            zs1 = Convert.ToDouble(textBox51.Text);
            zs2 = Convert.ToDouble(textBox58.Text);
            zsToplam = Math.Round((zs1 * zs2), 2);
            textBox43.Text = zsToplam.ToString();
            // zekat sınırı

            // zekat toplamı
            double z1, z2, z3, zToplam;
            z1 = Convert.ToDouble(textBox45.Text);
            z2 = Convert.ToDouble(textBox43.Text);
            z3 = 2.5;

            if (z1 >= z2)
            {
                zToplam = Math.Round((z1 * z3 / 100), 2);
                textBox41.Text = zToplam.ToString();
                MessageBox.Show("Zekat Tutarı: " + zToplam.ToString() + " TL", "Hesaplandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                textBox41.Text = "0";
                MessageBox.Show("Zekat Sınırını Geçemediniz.", "Hesaplandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // zekat toplamı
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://faruki.netne.net");
        }

        private double Euro = 0.0;
        private double Dolar = 0.0;
        private DataSet dsDovizKur;

        public class jsonDATA
        {
            public double selling { get; set; }
            public int update_date { get; set; }
            public object gold { get; set; }
            public object source { get; set; }
            public double buying { get; set; }
            public double change_rate { get; set; }
            public string name { get; set; }
            public string full_name { get; set; }
            public string short_name { get; set; }
            public string source_name { get; set; }
            public string source_full_name { get; set; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // dolar ve euro çek
            dsDovizKur = new DataSet();
            dsDovizKur.ReadXml(@"http://www.tcmb.gov.tr/kurlar/today.xml");
            DataRow dr = dsDovizKur.Tables[1].Rows[0];
            Dolar = Convert.ToDouble(dr[4].ToString().Replace('.', ','));
            dr = dsDovizKur.Tables[1].Rows[3];
            Euro = Convert.ToDouble(dr[4].ToString().Replace('.', ','));
            textBox44.Text = Dolar.ToString();
            textBox42.Text = Euro.ToString();
            // dolar ve euro çek

            // altın ve gümüş çek

            // gram çek
            Uri gramUrl = new Uri("https://altin.doviz.com/gram-altin");
            WebClient gramClient = new WebClient();
            string gramHtml = gramClient.DownloadString(gramUrl);
            HtmlAgilityPack.HtmlDocument gramDokuman = new HtmlAgilityPack.HtmlDocument();
            gramDokuman.LoadHtml(gramHtml);
            HtmlNodeCollection gramBasliklar = gramDokuman.DocumentNode.SelectNodes("/html[1]/body[1]/header[1]/div[1]/div[1]/div[1]/ul[1]/li[1]/a[1]/span[2]/@class[1]"); //("/html[1]/body[1]/section[1]/div[1]/div[3]/ul[1]/li[5]/a[4]/span[1]/@class[1]");
            foreach (var gramBaslik in gramBasliklar)
            {
                //textBox58.Text = gramBaslik.InnerText.ToString();
                textBox58.Text = gramBaslik.InnerText.ToString();
            }
            // gram çek

            // çeyrek çek
            Uri ceyrekUrl = new Uri("https://www.doviz.com/");
            WebClient ceyrekClient = new WebClient();
            string ceyrekHtml = ceyrekClient.DownloadString(ceyrekUrl);
            HtmlAgilityPack.HtmlDocument ceyrekDokuman = new HtmlAgilityPack.HtmlDocument();
            ceyrekDokuman.LoadHtml(ceyrekHtml); 
            HtmlNodeCollection ceyrekBasliklar = ceyrekDokuman.DocumentNode.SelectNodes("/html[1]/body[1]/section[1]/div[1]/div[4]/div[2]/ul[1]/li[2]/div[4]/@class[1]");
            foreach (var ceyrekBaslik in ceyrekBasliklar)
            {
                textBox56.Text = ceyrekBaslik.InnerText.ToString();   
            }
            // çeyrek çek

            // yarım çek
            Uri yarimUrl = new Uri("https://www.doviz.com/");
            WebClient yarimClient = new WebClient();
            string yarimHtml = yarimClient.DownloadString(yarimUrl);
            HtmlAgilityPack.HtmlDocument yarimDokuman = new HtmlAgilityPack.HtmlDocument();
            yarimDokuman.LoadHtml(yarimHtml);
            HtmlNodeCollection yarimBasliklar = yarimDokuman.DocumentNode.SelectNodes("/html[1]/body[1]/section[1]/div[1]/div[4]/div[2]/ul[1]/li[3]/div[4]/@class[1]");
            foreach (var yarimBaslik in yarimBasliklar)
            {
                textBox54.Text = yarimBaslik.InnerText.ToString();
            }
            // yarım çek

            // tam çek
            Uri tamUrl = new Uri("https://www.doviz.com/");
            WebClient tamClient = new WebClient();
            string tamHtml = tamClient.DownloadString(tamUrl);
            HtmlAgilityPack.HtmlDocument tamDokuman = new HtmlAgilityPack.HtmlDocument();
            tamDokuman.LoadHtml(tamHtml);
            HtmlNodeCollection tamBasliklar = tamDokuman.DocumentNode.SelectNodes("/html[1]/body[1]/section[1]/div[1]/div[4]/div[2]/ul[1]/li[4]/div[4]/@class[1]");
            foreach (var tamBaslik in tamBasliklar)
            {
                textBox52.Text = tamBaslik.InnerText.ToString();
            }
            // tam çek

            // cumhuriyet çek
            Uri cumhuriyetUrl = new Uri("https://www.doviz.com/");
            WebClient cumhuriyetClient = new WebClient();
            string cumhuriyetHtml = cumhuriyetClient.DownloadString(cumhuriyetUrl);
            HtmlAgilityPack.HtmlDocument cumhuriyetDokuman = new HtmlAgilityPack.HtmlDocument();
            cumhuriyetDokuman.LoadHtml(cumhuriyetHtml);
            HtmlNodeCollection cumhuriyetBasliklar = cumhuriyetDokuman.DocumentNode.SelectNodes("/html[1]/body[1]/section[1]/div[1]/div[4]/div[2]/ul[1]/li[5]/div[4]/@class[1]");
            foreach (var cumhuriyetBaslik in cumhuriyetBasliklar)
            {
                textBox50.Text = cumhuriyetBaslik.InnerText.ToString();
            }
            // cumhuriyet çek

            // gümüş çek
            Uri gumusUrl = new Uri("https://altin.doviz.com/");
            WebClient gumusClient = new WebClient();
            string gumusHtml = gumusClient.DownloadString(gumusUrl);
            HtmlAgilityPack.HtmlDocument gumusDokuman = new HtmlAgilityPack.HtmlDocument();
            gumusDokuman.LoadHtml(gumusHtml);
            HtmlNodeCollection gumusBasliklar = gumusDokuman.DocumentNode.SelectNodes("/html[1]/body[1]/section[1]/div[1]/div[2]/div[2]/ul[1]/li[18]/div[5]/@class[1]");
            foreach (var gumusBaslik in gumusBasliklar)
            {
                textBox46.Text = gumusBaslik.InnerText.ToString();
                //textBox46.Text = gumusBaslik.Attributes["class"].Value;
            }
            // gümüş çek

            // altın ve gümüş çek
        }
    }
}
