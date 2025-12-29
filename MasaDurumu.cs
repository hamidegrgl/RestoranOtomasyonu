using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;

namespace Otomasyon_1
{
    public partial class MasaDurumu : Form
    {
        public MasaDurumu()
        {
            InitializeComponent();
        } 

        private Dictionary<string, string> mevcutRezervasyonlar = new Dictionary<string, string>();

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaSayfa anasayfa = new AnaSayfa();
            anasayfa.Show();
            this.Hide();
        }

        IFirebaseClient client;
        private void MasaDurumu_Load(object sender, EventArgs e)
        {
            IFirebaseConfig Config = new FirebaseConfig
            {
                AuthSecret = "nHoGy6Hclb0Zf7MwDvtn8vHC1ZTarfAO8s9CEPHJ ",
                BasePath = "https://otomasyon-1-1c607-default-rtdb.firebaseio.com/"
            };

            client = new FirebaseClient(Config);
            FirebaseService.Connect();
            TumMasalariYukle();
        }
        private void TumMasalariYukle()
        {
            for (int i = 1; i <= 15; i++)
            {
                var response = client.Get($"Tables/{i}/status");
                if (response.Body == "null")
                    continue;

                string status = response.Body.Replace("\"", "").Trim();
               

                Button bt = this.Controls.Find($"btMasa{i}", true).FirstOrDefault() as Button;

                if (bt == null) continue;

                if (status == "empty")
                    bt.BackColor = Color.LightGreen;
                else if (status == "occupied")
                    bt.BackColor = Color.LightCoral;
                else if (status == "reserved" || status == "reservation")
                    bt.BackColor = Color.Khaki;
            }

        }
        private int seciliMasaNo = 0;

        private void Masa_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            seciliMasaNo = Convert.ToInt32(bt.Text.Replace("MASA", "").Trim());

            label4.Text = seciliMasaNo.ToString();

            var response = client.Get($"Tables/{seciliMasaNo}/status");


            string status = response.Body.Replace("\"", "");
           

            label6.Text = status.ToUpper();

            RezervasyonlariListele(seciliMasaNo);
        }

        private void btrezerveet_Click(object sender, EventArgs e)
        {
            if (seciliMasaNo == 0)
            {
                MessageBox.Show("Lütfen masa seçiniz");
                return;
            }

            string tarih = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            dateTimePicker1.MinDate = DateTime.Now;
            if (listBox1.Items.Contains(tarih))
            {
                MessageBox.Show("Bu Tarihte Zaten Rezerve Edilmiş.");
                return;
            }

            var reservation = new
            {
                date = tarih
            };

            client.Push($"Tables/{seciliMasaNo}/reservations", reservation);
            client.Set($"Tables/{seciliMasaNo}/status", reservation);

            MessageBox.Show("Masa rezerve edildi");

            TumMasalariYukle();
            RezervasyonlariListele(seciliMasaNo);



        }
        private void RezervasyonlariListele(int masaNo)
        {
            listBox1.Items.Clear();
            if (mevcutRezervasyonlar != null) mevcutRezervasyonlar.Clear(); 

            var response = client.Get($"Tables/{masaNo}/reservations");

           
            if (response == null || response.Body == "null") return;

            try
            {
                
                var reservations = response.ResultAs<Dictionary<string, Reservation>>();

                
                if (reservations != null)
                {
                    foreach (var item in reservations)
                    {
                        string tarihBilgisi = item.Value.date;
                        listBox1.Items.Add(tarihBilgisi);

                       
                        if (mevcutRezervasyonlar != null && !mevcutRezervasyonlar.ContainsKey(tarihBilgisi))
                        {
                            mevcutRezervasyonlar.Add(tarihBilgisi, item.Key);
                        }
                    }
                }
            }
            catch (Exception)
            {
                
            }
            //mevcutRezervasyonlar.Clear();

            //var response = client.Get($"Tables/{masaNo}/reservations");

            //if (response.Body == "null") return;

            //var reservations = response.ResultAs<Dictionary<string, Reservation>>();

            //foreach (var item in reservations)
            //{
            //    string tarihBilgisi = item.Value.date;
            //    listBox1.Items.Add(tarihBilgisi);


            //    if (!mevcutRezervasyonlar.ContainsKey(tarihBilgisi))
            //        mevcutRezervasyonlar.Add(tarihBilgisi, item.Key);
            //}


        }

        public class Reservation
        {
            public string date { get; set; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Lütfen iptal etmek istediğiniz tarihi seçin.");
                return;
            }

            string secilenTarih = listBox1.SelectedItem.ToString();

            if (mevcutRezervasyonlar.ContainsKey(secilenTarih))
            {
                string firebaseId = mevcutRezervasyonlar[secilenTarih];

                // Delete işlemi response döner
                var response = client.Delete($"Tables/{seciliMasaNo}/reservations/{firebaseId}");

                
                if (response != null)
                {
                    MessageBox.Show("Rezervasyon başarıyla iptal edildi.");

                   
                    RezervasyonlariListele(seciliMasaNo);

                    
                    if (listBox1.Items.Count == 0)
                    {
                        client.Set($"Tables/{seciliMasaNo}/status", "empty");
                        TumMasalariYukle(); 
                    }
                }
                else
                {
                    MessageBox.Show("Silme işlemi sırasında bir hata oluştu.");
                }
            }
        }
    }
    }




