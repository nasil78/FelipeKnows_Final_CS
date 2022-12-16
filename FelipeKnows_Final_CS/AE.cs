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
    public partial class AE : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int totalQuestions;


        public AE()
        {
            InitializeComponent();
            askQuestion(questionNumber);

            totalQuestions = 10;

        }
        private void checkAnswerEvent(object sender, EventArgs e)
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
                askQuestion(questionNumber);

            }
            questionNumber++;
            askQuestion(questionNumber);

        }
        private void askQuestion(int qnumAE)
        {
            switch (qnumAE)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources._87705;
                    label1.Text = "Who is the Grand Old Man of Philippine Art?";

                    button1.Text = "Fernando Amorsolo";
                    button2.Text = "Juan Luna";
                    button3.Text = "Benedicto Cabrera";
                    button4.Text = "Victorio Edades";

                    correctAnswer = 1;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources._87705;
                    label1.Text = "Who is the Father of modern Philippine painting?";

                    button1.Text = "Juan Luna";
                    button2.Text = "Victorio Edades";
                    button3.Text = "Fernando Amorsolo";
                    button4.Text = "Benedicto Cabrera";

                    correctAnswer = 2;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources._87705;
                    label1.Text = "Who is the Filipino activist, painter and sculptor that painted that Spoliarium?";

                    button1.Text = "Benedicto Cabrera";
                    button2.Text = "Napoleon Abueva";
                    button3.Text = "Juan Luna";
                    button4.Text = "Fernando Amorsolo";

                    correctAnswer = 3;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources._87705;
                    label1.Text = "Who is the Filipino painter known as BenCab?";

                    button1.Text = "Juan Luna";
                    button2.Text = "Fernando Amorsolo";
                    button3.Text = "Benedicto Cabrera";
                    button4.Text = "Napoleon Abueva";

                    correctAnswer = 3;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources._87705;
                    label1.Text = "Who is known as the Father of Modern Philippine Sculpture?";

                    button1.Text = "Napoleon Dynamite";
                    button2.Text = "Napoleon Abueva";
                    button3.Text = "Napoleon Torres";
                    button4.Text = "Napoleon Abrenica";

                    correctAnswer = 2;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources._87705;
                    label1.Text = "Who is the woman hailed as the Mother of Filipino folk dances?";

                    button1.Text = "Lea Salonga";
                    button2.Text = "Regine Velasquez";
                    button3.Text = "Francisa Reyes-Aquino";
                    button4.Text = "Sarah Geronimo";

                    correctAnswer = 3;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources._87705;
                    label1.Text = "Who is the only acclaimed prima ballerina of the Philippines?";

                    button1.Text = "Lisa Macuja-Elizalde";
                    button2.Text = "Lani Misalucha";
                    button3.Text = "Rachelle Ann Go";
                    button4.Text = "Regine Velasquez";

                    correctAnswer = 1;
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources._87705;
                    label1.Text = "Who is the Filipino sculptor who created the Bonifacio Monument?";

                    button1.Text = "Quentin Tarentino";
                    button2.Text = "Lorna Tolentino";
                    button3.Text = "Guillermo Tolentino";
                    button4.Text = "Napoleon Abueva";

                    correctAnswer = 3;
                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources._87705;
                    label1.Text = "Who is the painter behind the work entitled Rice Planting?";

                    button1.Text = "Brandon Vera";
                    button2.Text = "Benedict Cumberbatch";
                    button3.Text = "Benedicto Cabrera";
                    button4.Text = "Benjie Paras";

                    correctAnswer = 3;
                    break;
                case 10:
                    pictureBox1.Image = Properties.Resources._87705;
                    label1.Text = "Who is the Filipino photographer behind the title as the Father of Philippine Photography?";

                    button1.Text = "Eduardo Masferre";
                    button2.Text = "Eduardo Cullen";
                    button3.Text = "Edward Cullen";
                    button4.Text = "Edward Tolentino";

                    correctAnswer = 1;
                    break;


            }
        }
    }
}
