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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PE PolE = new PE();
            PolE.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PA PolA = new PA();
            PolA.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PD PolD = new PD();
            PolD.ShowDialog();
        }
    }
}
