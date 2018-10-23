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
    public partial class Mudah : Form
    {
        string skor;
        int poin = 0;
        private int waktu = 30;
        public Mudah()
        {
            InitializeComponent();
            timer1.Start();
                          
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

        private void Mudah_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            waktu--;
            label2.Text = "Sisa waktu = " + waktu.ToString();

            if (waktu==0)
            {
                timer1.Stop();
                MessageBox.Show("Skor anda : " + skor , "Waktu Habis", MessageBoxButtons.OK);
                this.Close();
                
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("Skor anda : " + skor, "Anda Menyerah", MessageBoxButtons.OK);
            this.Close();

        }
    }
}
