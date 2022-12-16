using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FelipeKnows_Final_CS
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LE LiE = new LE();
            LiE.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LA LiA = new LA();
            LiA.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LD LiD = new LD();
            LiD.ShowDialog();
        }
    }
}
