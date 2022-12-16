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
    public partial class AA : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int totalQuestions;



        public AA()
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
        private void askQuestion(int qnumAA)
        {
            switch (qnumAA)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.ph_national_artist_october_24_2018;
                    label1.Text = "Who is the famous lyricist that was hailed by the Guiness Book of Record as the only leaf player in the world?";

                    button1.Text = "Levi Celerio";
                    button2.Text = "Ogie Alcasid";
                    button3.Text = "Benedicto Cabrera";
                    button4.Text = "Victorio Edades";

                    correctAnswer = 1;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.ph_national_artist_october_24_2018;
                    label1.Text = "Who was the woman called Atang and was the first Filipina film actress and Queen of Kundiman?";

                    button1.Text = "Lea Salonga";
                    button2.Text = "Honorata Dela Rama";
                    button3.Text = "Lani Misalucha";
                    button4.Text = "Nora Aunor";

                    correctAnswer = 2;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.ph_national_artist_october_24_2018;
                    label1.Text = "Who is the theatre actress most famous for her lead role in the play Les Miserables as Fantine?";

                    button1.Text = "Rachelle Ann Go";
                    button2.Text = "Lani Misalucha";
                    button3.Text = "Nora Aunor";
                    button4.Text = "Lea Salonga";

                    correctAnswer = 1;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.ph_national_artist_october_24_2018;
                    label1.Text = "Who is the Filipina National Artist who was the famous lead actress in Miss Saigon?";

                    button1.Text = "Vilma Santos";
                    button2.Text = "Rachelle Ann Go";
                    button3.Text = "Lea Salonga";
                    button4.Text = "Lani Misalucha";

                    correctAnswer = 3;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.ph_national_artist_october_24_2018;
                    label1.Text = "Who is the famous Maestro in the Philippines who is known for his compositions such as Kumukutikutitap?";

                    button1.Text = "Bryan Cayabyab";
                    button2.Text = "Ryan Cayabyab";
                    button3.Text = "Brian Cayabyab";
                    button4.Text = "Riann Cayabyab";

                    correctAnswer = 2;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.ph_national_artist_october_24_2018;
                    label1.Text = "Who is movie director of the film adaptation of the book Dekada 70?";

                    button1.Text = "Ryan Cayabyab";
                    button2.Text = "Fernando Poe Jr.";
                    button3.Text = "Chito Rono";
                    button4.Text = "Darryl Yap";

                    correctAnswer = 3;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.ph_national_artist_october_24_2018;
                    label1.Text = "Who is the Filipina Award-winning actress who was played the role of Elsa in the famous movie, Himala?";

                    button1.Text = "Nora Aunor";
                    button2.Text = "Sharon Cuneta";
                    button3.Text = "Vilma Santos";
                    button4.Text = "Lorna Tolentino";

                    correctAnswer = 1;
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.ph_national_artist_october_24_2018;
                    label1.Text = "Who is the Filipino movie legend who had the nickname Da King?";

                    button1.Text = "Aga Muhlach";
                    button2.Text = "Gabby Concepcion";
                    button3.Text = "Eddie Garcia";
                    button4.Text = "Fernando Poe Jr.";

                    correctAnswer = 4;
                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources.ph_national_artist_october_24_2018;
                    label1.Text = "Who is the actor who played Heneral Luna and also won at the 78th Venice International Film Festival?";


                    button1.Text = "Eddie Garcia";
                    button2.Text = "John Arcilla";
                    button3.Text = "Paolo Avelino";
                    button4.Text = "John Lloyd Cruz";

                    correctAnswer = 2;
                    break;
                case 10:
                    pictureBox1.Image = Properties.Resources.ph_national_artist_october_24_2018;
                    label1.Text = "Who is the most famous artist from the Philippines?";


                    button1.Text = "Daniel Padilla";
                    button2.Text = "Fernando Poe Jr.";
                    button3.Text = "John Lloyd Cruz";
                    button4.Text = "Wendell Ramos";

                    correctAnswer = 2;
                    break;










            }
        }
    }
}
