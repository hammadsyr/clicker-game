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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rbMudah.Checked == true )
            {
                Mudah f = new Mudah();
                f.ShowDialog();

            }
            else if (rbSedang.Checked == true)
            {
                Sedang f = new Sedang();
                f.ShowDialog();
            }
            else if (rbSulit.Checked == true)
            {
                Sulit f = new Sulit();
                f.ShowDialog();
            }
        }
    }
}
