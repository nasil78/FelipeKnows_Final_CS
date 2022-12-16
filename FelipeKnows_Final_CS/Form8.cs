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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ME MuE = new ME();
            MuE.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MA MuA = new MA();
            MuA.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MD MuD = new MD();
            MuD.ShowDialog();
        }
    }
}
