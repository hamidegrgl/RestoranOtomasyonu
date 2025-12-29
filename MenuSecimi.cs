using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otomasyon_1
{
    public partial class MenuSecimi : Form
    {
        public MenuSecimi()
        {
            InitializeComponent();
        }


        int seciliMasaNo = 0;
        int toplamTutar = 0;
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

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Masa_Click(object sender, EventArgs e)
        {

            Button btn = sender as Button;
            if (btn == null)
                return;

            seciliMasaNo = Convert.ToInt32(btn.Tag);
       
            MessageBox.Show($"Masa {seciliMasaNo} seçildi");


        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void MenuSecimi_Load(object sender, EventArgs e)
        {
            FirebaseService.Connect();
        } 

        private void Menu_CheckedChanged(object sender, EventArgs e)
        {
            if (seciliMasaNo == 0)
            {
                MessageBox.Show("Önce masa seçiniz");
                ((CheckBox)sender).Checked = false;
                return;
            }
           

            CheckBox chk = sender as CheckBox;
            int fiyat = Convert.ToInt32(chk.Tag);

            if (chk.Checked)
            {
                listBoxSecimler.Items.Add($"{chk.Text} - {fiyat} ₺");
                toplamTutar += fiyat;
            }
            else
            {
                listBoxSecimler.Items.Remove($"{chk.Text} - {fiyat} ₺");
                toplamTutar -= fiyat;
            }

            txtToplamTutar.Text = toplamTutar.ToString() + " ₺";
        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            if (FirebaseService.client == null)
            {
                FirebaseService.Connect();
                if (FirebaseService.client == null)
                {
                    return;
                }
            }

                if (seciliMasaNo == 0 || listBoxSecimler.Items.Count == 0)
                {
                MessageBox.Show("Masa ve ürün seçilmelidir");
                return;
                }

            DialogResult secim = MessageBox.Show("Siparişleri onaylayıp ödeme ekranına geçmek istiyor musunuz?", "Onay", MessageBoxButtons.YesNo);

            if (secim == DialogResult.Yes)
            {
                btnSecimleriKaydet_Click(sender, e);

                Odeme odeme = new Odeme(seciliMasaNo, toplamTutar);
                odeme.Show();
                this.Hide();
            }
       
        }

        private void btnSecimleriKaydet_Click(object sender, EventArgs e)
        {
            if (FirebaseService.client == null)
            {
                FirebaseService.Connect(); // Tekrar bağlanmayı dene
            }

            FirebaseService.client.Delete($"Orders/{seciliMasaNo}"); 

            if (seciliMasaNo == 0 || listBoxSecimler.Items.Count == 0)
            {
                MessageBox.Show("Masa ve ürün seçilmelidir");
                return;
            }


            foreach (string item in listBoxSecimler.Items)
            {
                
                if (!item.Contains("-")) continue;

                string[] parca = item.Split('-');
                string urunAdi = parca[0].Trim();
                int urunfiyati = Convert.ToInt32(parca[1].Replace("₺", "").Trim());

                var order = new
                {
                    product = urunAdi, 
                    price = urunfiyati
                };

                FirebaseService.client.Push($"Orders/{seciliMasaNo}", order);
            }

            FirebaseService.client.Set($"Tables/{seciliMasaNo}/status", "occupied");

            MessageBox.Show("Seçimler kaydedildi"); 
        }
    }
}

