using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

using System.Net.NetworkInformation;
using System.Net;




namespace Otomasyon_1
{
    public partial class Giris : Form 
    {
        IFirebaseClient client;
        

        public Giris() 
        {
            InitializeComponent();
        }

        static bool baglantikontrol()
        {
            try
            {
                return new System.Net.NetworkInformation.Ping().Send("www.google.com", 1000).Status == System.Net.NetworkInformation.IPStatus.Success;
            }
            catch (Exception)
            {

                return false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        //    if (baglantikontrol() == true)
        //    {
        //        MessageBox.Show("Ýnternet baðlantýnýzý kontrol ediniz.");
        //        this.Close();
        //    }
        //    else
        //    {

        //        client = new FireSharp.FirebaseClient(Config);

        //        if (client != null)
        //        {
        //            MessageBox.Show("Baðlantý baþarýlý.");
        //        }
        //        else
        //        {
        //            MessageBox.Show("Baðlantý baþarýsýz.");
        //        }
        //    }


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            kullanicitxt.Text = "";
            sifretxt.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {  

            if (kullanicitxt.Text == "" || sifretxt.Text == "")
            {
                MessageBox.Show("Eksik bilgi girdiniz.");
                return;
            }

            User user = new User()
            {
                Id = 1,
                Name = "vera",
                Password = "1234",
                Role = Role.Admin 
            };
            
            if (kullanicitxt.Text == "vera" && sifretxt.Text == "1234")
            {
                AnaSayfa anasayfa = new AnaSayfa();
                anasayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalý Kullanýcý Adý Veya Þifre Girdiniz.");
            }



        }

private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
