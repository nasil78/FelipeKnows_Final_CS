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
    public partial class ME : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int totalQuestions;

        public ME()
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
        private void askQuestion(int qnumME)
        {
            switch (qnumME)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.National_Artists_In_Music;
                    label1.Text = "Who is the singer and actress known with the nickname, Divine Diva?";

                    button1.Text = "Zsa Zsa Padilla";
                    button2.Text = "Pops Fernandez";
                    button3.Text = "Lani Misalucha";
                    button4.Text = "Morisette Amon";

                    correctAnswer = 1;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.National_Artists_In_Music;
                    label1.Text = "Who is Asia’s Nightingale?";

                    button1.Text = "Pops Fernandez";
                    button2.Text = "Lani Misalucha";
                    button3.Text = "Vilma Santos";
                    button4.Text = "Sarah Geronimo";

                    correctAnswer = 2;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.National_Artists_In_Music;
                    label1.Text = "Who is the Pop Princess of the Philippines?";

                    button1.Text = "Morisette Amon";
                    button2.Text = "Kim Chiu";
                    button3.Text = "Maja Salvador";
                    button4.Text = "Sarah Geronimo";

                    correctAnswer = 4;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.National_Artists_In_Music;
                    label1.Text = "Who is the Filipino rapper who goes by the tittle of King of Pinoy Rap?";

                    button1.Text = "Elmo Magalona";
                    button2.Text = "Max Magalona";
                    button3.Text = "Francis Magalona";
                    button4.Text = "Gloc9";

                    correctAnswer = 3;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.National_Artists_In_Music;
                    label1.Text = "Who is the Filipino-American rapper who was a part of the international group Black Eyed Peas?";

                    button1.Text = "Usher";
                    button2.Text = "50 Cent";
                    button3.Text = "Apl De Ap";
                    button4.Text = "Chris Brown";

                    correctAnswer = 3;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.National_Artists_In_Music;
                    label1.Text = "Who is the performer who goes by the name Mr. Pure Energy?";

                    button1.Text = "Martin Nievera";
                    button2.Text = "Ogie Alcasid";
                    button3.Text = "Eric Santos";
                    button4.Text = "Gary Valenciano";

                    correctAnswer = 4;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.National_Artists_In_Music;
                    label1.Text = "Who is the Asia’s Queen of Songs?";

                    button1.Text = "Imelda Papin";
                    button2.Text = "Nora Aunor";
                    button3.Text = "Pilita Corales";
                    button4.Text = "Sarah Geronimo";

                    correctAnswer = 3;
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.National_Artists_In_Music;
                    label1.Text = "Who is the singer who was famous for his song Anak?";

                    button1.Text = "Fernando Poe Jr.";
                    button2.Text = "Freddie Aguilar";
                    button3.Text = "Pepe Smith";
                    button4.Text = "Ryan Cayabyab";

                    correctAnswer = 2;
                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources.National_Artists_In_Music;
                    label1.Text = "Who is known as the Concert Queen?";

                    button1.Text = "Pops Fernandez";
                    button2.Text = "Zsa Zsa Padilla";
                    button3.Text = "Maja Salvador";
                    button4.Text = "Vice Ganda";

                    correctAnswer = 1;
                    break;
                case 10:
                    pictureBox1.Image = Properties.Resources.National_Artists_In_Music;
                    label1.Text = "Who is known as the Philippine Queen of Bossa Nova?";
                    button1.Text = "Zia Quizon";
                    button2.Text = "Kyla";
                    button3.Text = "Sitti Navarro";
                    button4.Text = "Kathryn Bernardo";

                    correctAnswer = 3;
                    break;

            }
        }
    } 
}
