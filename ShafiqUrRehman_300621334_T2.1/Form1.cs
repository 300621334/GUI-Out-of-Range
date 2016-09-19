using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShafiqUrRehman_300621334_T2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double rap = 10;
        double arg = 20;
        double bj = 30;
        double ml = 40;

        private void listBox1_MouseEnter(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
            {
                label1.Text = "Raptors: $" + rap + "\nArgaunauts: $" + arg + "\nBlue Jays: $" + bj + "\nMaple Leaf: $" + ml;
            }
        }

        private void listBox1_MouseLeave(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
            {
                label1.Text = "";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    label1.Text = "Raptors: $" + rap;
                    this.BackColor = Color.Orange;
                    break;
                case 1:
                    label1.Text = "Argaunauts: $" + arg;
                    this.BackColor = Color.Green;
                    break;
                case 2:
                    label1.Text = "Blue Jays: $" + bj;
                    this.BackColor = Color.LightBlue;
                    break;
                case 3:
                    label1.Text = "Maple Leaf: $" + ml;
                    this.BackColor = Color.Red;
                    break;
            }
        }
    }
}
