using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
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
    public partial class Odeme : Form
    {
        public Odeme()
        {
            InitializeComponent();
        }

        int masaNo;
        double toplamTutar = 0;
        double musteriTutari = 0;
        double paraUstu = 0;


        public Odeme(int masa, int toplam)
        {
            InitializeComponent();
            masaNo = masa;
            toplamTutar = toplam;
        }


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

        private void Odeme_Load(object sender, EventArgs e)
        {
            FirebaseService.Connect();

            SiparisleriGetir();

        }

        private void SiparisleriGetir()
        {
            if (FirebaseService.client == null)
            {
                FirebaseService.Connect();
            }


            listBoxOdemeDetay.Items.Clear();
            toplamTutar = 0;

            var response = FirebaseService.client.Get($"Orders/{masaNo}");

            if (response==null  || response.Body == "null")
            {
                txtToplamTutar.Text = "0 ₺";
                return; 
            }

            try
            {
                var orders = response.ResultAs<Dictionary<string, Order>>();

                if (orders != null)
                {
                    foreach (var item in orders)
                    {
                        listBoxOdemeDetay.Items.Add(
                        $"{item.Value.product} - {item.Value.price} ₺");

                        toplamTutar += item.Value.price;

                    }
                }
                txtToplamTutar.Text = toplamTutar + " ₺";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sipariş verisi okunurken bir hata oluştu: " + ex.Message);
            }
        }

        public Odeme(int masa)
        {
            InitializeComponent();
            masaNo = masa;
        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            try
            {
                double musteriTutari = Convert.ToDouble(txtMusteriTutari.Text.Replace(" ₺", ""));
                double toplamTutar = Convert.ToDouble(txtToplamTutar.Text.Replace(" ₺", ""));

                double sonuc = musteriTutari - toplamTutar;

                txtParaustu.Text = sonuc.ToString() + " ₺";

                DialogResult dr = MessageBox.Show(
                    "Ödeme tamamlanacak, emin misiniz?",
                    "Onay",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dr == DialogResult.No) return;

                
            }
            catch (Exception)
            {

            }

            // Siparişleri sil
            FirebaseService.client.Delete($"Orders/{masaNo}");

            // Masa durumunu sıfırla
            FirebaseService.client.Set($"Tables/{masaNo}/status", "empty");

            MessageBox.Show("Ödeme başarıyla tamamlandı");

            AnaSayfa frm = new AnaSayfa();
            frm.Show();
            this.Close();
        }

        private void btnIptalet_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPosCihazi_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
               "Ödeme tamamlanacak, emin misiniz?",
               "Onay",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
           );

            if (dr == DialogResult.No)
                return;

            MessageBox.Show("Pos Cihazına Yönlendiriliyor...");

            // Siparişleri sil
            FirebaseService.client.Delete($"Orders/{masaNo}");

            // Masa durumunu sıfırla
            FirebaseService.client.Set($"Tables/{masaNo}/status", "empty");

            MessageBox.Show("Ödeme başarıyla tamamlandı");

        }


        private void txtMusteriTutari_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtToplamTutar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtParaustu_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxOdemeDetay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

