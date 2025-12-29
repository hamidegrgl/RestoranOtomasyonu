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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            FirebaseService.Connect();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MasaDurumu masadurumu = new MasaDurumu();
            masadurumu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuSecimi menusecimi = new MenuSecimi();
            menusecimi.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Odeme odeme = new Odeme(0);
            odeme.Show();
            this.Hide();
        }
    }
}
