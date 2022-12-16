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
    public partial class LE : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int totalQuestions;

        public LE()
        {
            InitializeComponent();
            AskQuestion(questionNumber);

            totalQuestions = 10;
        }

        private void CheckAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
            }
            if (questionNumber == totalQuestions)
            {

                MessageBox.Show(
                    "Congratulations, Kababayan!" + Environment.NewLine +
                    "You gained " + score + " out of 10" + Environment.NewLine +

                    "To see the Answer Key, click Credits" + Environment.NewLine +
                    "Click OK to return to the home page"


                    );
                Application.Restart();

                score = 0;
                questionNumber = 0;
                AskQuestion(questionNumber);

            }
            questionNumber++;
            AskQuestion(questionNumber);
        }
        private void AskQuestion(int qnumLE)
        {
            switch (qnumLE)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.phshortstories_1200x900;
                    label1.Text = "Who is the author of Noli Me Tangere?";

                    button1.Text = "Juan Luna";
                    button2.Text = "Ferdinand Blumentritt";
                    button3.Text = "Maximo Viola";
                    button4.Text = "Jose Rizal";

                    correctAnswer = 4;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.phshortstories_1200x900;
                    label1.Text = "Who was the writer of Dekada 70?";

                    button1.Text = "Ferdinand Blumentritt";
                    button2.Text = "Lualhati Bautista";
                    button3.Text = "Andres Bonifacio";
                    button4.Text = "Francisco Baltazar";

                    correctAnswer = 2;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.phshortstories_1200x900;
                    label1.Text = "Who goes by the nickname Balagtas and the writer of Florante at Laura?";

                    button1.Text = "Juan Luna";
                    button2.Text = "Jose Corazon de Jesus";
                    button3.Text = "Francisco Baltazar";
                    button4.Text = "Jose Rizal";

                    correctAnswer = 3;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.phshortstories_1200x900;
                    label1.Text = " Who is the Filipino poet known by his pen name Huseng Batute?";

                    button1.Text = "Jose Rizal";
                    button2.Text = "Ferdinand Blumentritt";
                    button3.Text = "Maximo Viola";
                    button4.Text = "Jose Corazon de Jesus";

                    correctAnswer = 4;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.phshortstories_1200x900;
                    label1.Text = "Who was the writer of the 1990 novel Dogeaters which won American Book Award?";

                    button1.Text = "Jessica Hagerdorn";
                    button2.Text = "Jessica Sanchez";
                    button3.Text = "Jessica Soho";
                    button4.Text = "Jessica Soho";

                    correctAnswer = 1;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.phshortstories_1200x900;
                    label1.Text = "Who won the National Artist award for Literature and is the most esteemed Filipino writer?";

                    button1.Text = "Julian Felipe";
                    button2.Text = "Nick Joaquin";
                    button3.Text = "Nick Jonas";
                    button4.Text = "Juan Luna";

                    correctAnswer = 2;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.phshortstories_1200x900;
                    label1.Text = "Who is the author of the Ibong Adarna?";

                    button1.Text = "Francisco Jose";
                    button2.Text = "Jose de la Cruz";
                    button3.Text = "Jose Rizal";
                    button4.Text = "Amado Hernandez";

                    correctAnswer = 2;
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.phshortstories_1200x900;
                    label1.Text = "Who is the author of Mi Ultimo Adios?";

                    button1.Text = "Jose Rizal";
                    button2.Text = "Juan Luna";
                    button3.Text = "Jose de la Cruz";
                    button4.Text = "Jose Damian";

                    correctAnswer = 1;
                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources.phshortstories_1200x900;
                    label1.Text = "Who is the activist author of the book Ang Ibong Mandaragit that tackles social-political issues?";

                    button1.Text = "Gregorio Del Pilar";
                    button2.Text = "Pedro Paterno";
                    button3.Text = "Maximo Viola";
                    button4.Text = "Amador Hernandez";

                    correctAnswer = 4;
                    break;
                case 10:
                    pictureBox1.Image = Properties.Resources.phshortstories_1200x900;
                    label1.Text = "Who was the author of the novel Po-On?";

                    button1.Text = "Jose RizaL";
                    button2.Text = "Francisco Jose";
                    button3.Text = "Francois Rizal";
                    button4.Text = "Ferdinand Blumentritt";

                    correctAnswer = 2;
                    break;
            }
        }
    }
}
