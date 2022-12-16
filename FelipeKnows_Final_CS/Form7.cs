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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AE ArE = new AE();
            ArE.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AA ArA = new AA();
            ArA.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AD ArD = new AD();
            ArD.ShowDialog();
        }
    }
}
