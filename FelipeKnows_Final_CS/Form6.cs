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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SA SpoA = new SA();
            SpoA.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SE SpoE = new SE();
            SpoE.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SD SpoD = new SD();
            SpoD.ShowDialog();
        }
    }
}
