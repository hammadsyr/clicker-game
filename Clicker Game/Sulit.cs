using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker_Game
{
    public partial class Sulit : Form
    {
        string skor;
        int poin = 0;
        private int waktu = 30;
        public Sulit()
        {
            InitializeComponent();
            timer1.Interval = 300;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
            timer2.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hitung hitung = new Hitung();
            skor = hitung.Jumlah(ref poin).ToString();
            textBox1.Text = (skor);
            button1.BackColor = Color.White;
            if (int.Parse(skor) % 5 == 0)
            {
                button1.BackColor = Color.Red;
            }
        }
        public Random r = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = r.Next(0, 550);
            int y = r.Next(0, 550);
            button1.Top = y;
            button1.Left = x;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            waktu--;
            label3.Text = "Sisa waktu = " + waktu.ToString();

            if (waktu == 0)
            {
                timer2.Stop(); timer1.Stop();
                MessageBox.Show("Skor anda : " + skor, "Waktu Habis", MessageBoxButtons.OK);
                this.Close();

            }
        }

        private void Sulit_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop(); timer2.Stop();
            MessageBox.Show("Skor anda : " + skor, "Anda Menyerah", MessageBoxButtons.OK);
            this.Close();
        }
    }
}
