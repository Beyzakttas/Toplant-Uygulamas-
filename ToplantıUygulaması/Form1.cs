using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace ToplantıUygulaması
{
    public partial class Form1 : Form
    {
        private List<Toplanti> toplantilar = new List<Toplanti>();
        private string dosyaYolu = "tarih.txt";
        private const string dosyaAdi = "tarih.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void YeniToplantiOlusturButton_Click(object sender, EventArgs e)
        {
            string adsoyad = textBox1.Text;
            string baslik = BaslikTextBox.Text;
            DateTime baslangicTarihi = BaslangicDateTimePicker.Value;
            DateTime bitisTarihi = BitisDateTimePicker.Value;

            Toplanti yeniToplanti = new Toplanti(adsoyad, baslik, baslangicTarihi, bitisTarihi);
            toplantilar.Add(yeniToplanti);

            MessageBox.Show($"Toplanti Kodu: {yeniToplanti.Kod}\nToplantiyi paylaşmak için bu kodu kullanabilirsiniz.");

            // Toplanti verilerini dosyaya kaydet
            SaveMeetingsToFile();

            // Toplantıları listele
            ListeleToplantilar();
        }
        private void ListeleToplantilar()
        {
            ToplantilarListBox.Items.Clear();
            foreach (Toplanti toplanti in toplantilar)
            {

                ToplantilarListBox.Items.Add($"{toplanti.Kod} - {toplanti.Baslik} ({toplanti.BaslangicTarihi.ToShortDateString()} - {toplanti.BitisTarihi.ToShortDateString()})");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde toplantı verilerini yükle
            LoadMeetingsFromFile();
            listView1.Columns.Add("ADI SOYADI", 100);
            listView1.Columns.Add("BAŞ TARİH ", 100);
            listView1.Columns.Add("SON TARİH ", 100);

            BaslangicDateTimePicker.MinDate = new DateTime(2023, 11, 1);
            BitisDateTimePicker.MaxDate = new DateTime(2023, 12, 30);

        }
        private void SaveMeetingsToFile()
        {
            using (StreamWriter writer = new StreamWriter(dosyaYolu, false))
            {
                foreach (Toplanti toplanti in toplantilar)
                {
                    writer.WriteLine($"{toplanti.Kod}:{toplanti.Baslik}:{toplanti.BaslangicTarihi}:{toplanti.BitisTarihi}");
                }
            }
        }
        private void LoadMeetingsFromFile()
        {
            if (File.Exists(dosyaYolu))
            {
                using (StreamReader reader = new StreamReader(dosyaYolu))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(':');
                        string kod = parts[0];
                        string baslik = parts[1];
                        DateTime baslangicTarihi = DateTime.Parse(parts[2]);
                        DateTime bitisTarihi = DateTime.Parse(parts[3]);

                        toplantilar.Add(new Toplanti(baslik, baslangicTarihi, bitisTarihi));
                    }
                }
            }

            // Toplantıları listele
            ListeleToplantilar();
        }

        private void KatilButton_Click(object sender, EventArgs e)
        {
            string girilenKod = Interaction.InputBox("Toplanti Kodunu Giriniz:", "Toplanti Katılım", "", -1, -1);

            Toplanti katililanToplanti = toplantilar.Find(t => t.Kod == girilenKod);

            if (katililanToplanti != null)
            {
                MessageBox.Show($"Toplanti Bilgileri:\n{katililanToplanti.Baslik}\nBaşlangıç: {katililanToplanti.BaslangicTarihi}\nBitiş: {katililanToplanti.BitisTarihi}");
            }
            else
            {
                MessageBox.Show("Geçersiz toplanti kodu. Lütfen tekrar deneyin.");
            }
        }

        private void KAYDET_Click(object sender, EventArgs e)
        {
            string adsoyad = textBox1.Text;
            string basTarihi = BaslangicDateTimePicker.Value.ToShortDateString();
            string SonTarihi = BitisDateTimePicker.Value.ToShortDateString();
            string[] bilgiler = { adsoyad, basTarihi, SonTarihi };
            ListViewItem kayıt = new ListViewItem(bilgiler);
            listView1.Items.Add(kayıt);
            listBox1.Items.Add(textBox1.Text + "" + BaslangicDateTimePicker.Text + "" + BitisDateTimePicker);
            using (StreamWriter writer = File.AppendText(dosyaAdi))
            {
                writer.WriteLine($"{adsoyad} - {basTarihi}-{SonTarihi} ");
            }

            MessageBox.Show("Toplantı başarıyla kaydedildi.");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            BaslangicDateTimePicker.Text = "";
            BitisDateTimePicker.Text = "";
            listView1.Items.Clear();
            ToplantilarListBox.Items.Clear();
        }
        public class Toplanti
        {
            public string Kod { get; }
            public string Baslik { get; }
            public DateTime BaslangicTarihi { get; }
            public DateTime BitisTarihi { get; }

            public Toplanti(string baslik, string baslik1, DateTime baslangicTarihi, DateTime bitisTarihi)
            {
                Kod = Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper();
                Baslik = baslik;
                BaslangicTarihi = baslangicTarihi;
                BitisTarihi = bitisTarihi;
            }

            public Toplanti(string baslik, DateTime baslangicTarihi, DateTime bitisTarihi)
            {
                Baslik = baslik;
                BaslangicTarihi = baslangicTarihi;
                BitisTarihi = bitisTarihi;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            Process.Start("https://calendar.google.com/calendar/u/0/r");
        }
    }
}
   
