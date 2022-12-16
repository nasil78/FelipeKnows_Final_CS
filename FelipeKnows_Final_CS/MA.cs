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
    public partial class MA : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int totalQuestions;


        public MA()
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
        private void askQuestion(int qnumMA)
        {
            switch (qnumMA)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources._87705;
                    label1.Text = "Who is the Father of Philippine Kundiman?";

                    button1.Text = "Zsa Zsa Padilla";
                    button2.Text = "Francisco Santiago";
                    button3.Text = "Lani Misalucha";
                    button4.Text = "Morisette Amon";

                    correctAnswer = 2;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources._87705;
                    label1.Text = "Who is known as the Concert King of the Philippines?";

                    button1.Text = "Martin Nievera";
                    button2.Text = "Gary Valenciano";
                    button3.Text = "Eric Santos";
                    button4.Text = "Vice Ganda";

                    correctAnswer = 1;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources._87705;
                    label1.Text = "Who is the king of Philippine kundiman songs?";

                    button1.Text = "Jose Mari Chan";
                    button2.Text = "Rey Valera";
                    button3.Text = "Randy Santiago";
                    button4.Text = "Ruben Tagalog";

                    correctAnswer = 4;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources._87705;
                    label1.Text = "Who is the Queen of Kundiman?";

                    button1.Text = "Sylvia La Torre";
                    button2.Text = "Sylvia Santos";
                    button3.Text = "Imelda Papin";
                    button4.Text = "Pilita Corales";

                    correctAnswer = 1;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources._87705;
                    label1.Text = "Who was the first person who played the Lupang Hinirang?";

                    button1.Text = "Juan Luna";
                    button2.Text = "Emilio Aquinaldo";
                    button3.Text = "Julian Felipe";
                    button4.Text = "Jose Palma";

                    correctAnswer = 3;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources._87705;
                    label1.Text = "Who is the most accomplished musician in the Philippines?";

                    button1.Text = "Joel Torre";
                    button2.Text = "Joey Santiago";
                    button3.Text = "Gary Valenciano";
                    button4.Text = "Martin Nievera";

                    correctAnswer = 2;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources._87705;
                    label1.Text = "Who was awarded the Guiness World Book of Record as the only person to make real leaf music?";

                    button1.Text = "Bullet Dumas";
                    button2.Text = "Ryan Cayabyab";
                    button3.Text = "Julian Felipe";
                    button4.Text = "Levi Celerio";

                    correctAnswer = 4;
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources._87705;
                    label1.Text = "Who is the orchestral piano soloist who debuted with the Philippine Philharmonic Orchestra?";
                    button1.Text = "Pops Fernandez";
                    button2.Text = "Cecile Licad";
                    button3.Text = "Lea Salonga";
                    button4.Text = "Sylvia La Torre";

                    correctAnswer = 2;
                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources._87705;
                    label1.Text = "Who is the only Filipina prize winner of the Paganini International Violin Competition?";

                    button1.Text = "Carmencita Lozada";
                    button2.Text = "Lani Misalucha";
                    button3.Text = "Cecile Licad";
                    button4.Text = "Carol Banawa";

                    correctAnswer = 1;
                    break;
                case 10:
                    pictureBox1.Image = Properties.Resources._87705;
                    label1.Text = "Who was the king of Philippine Rock?";

                    button1.Text = "Arnel Pineda";
                    button2.Text = "Tado";
                    button3.Text = "Pepe Smith";
                    button4.Text = "Ariel Rivera";

                    correctAnswer = 3;
                    break;
            }
        }
    }
}

