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
    public partial class SA : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int totalQuestions;

        public SA()
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
        private void askQuestion(int qnumSA)
        {
            switch (qnumSA)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.top_filipino_athletes_on_sm_carousel_dec_18_2017;
                    label1.Text = "Who is the highest-paid Filipino athlete?";
                    
                    button1.Text = "Eumir Marcial";
                    button2.Text = "Nesthy Petecio";
                    button3.Text = "Manny Pacquiao";
                    button4.Text = "Hidilyn Diaz";

                    correctAnswer = 3;

                    break;
                    
                case 2:
                    pictureBox1.Image = Properties.Resources.top_filipino_athletes_on_sm_carousel_dec_18_2017;
                    label1.Text = "Who is the oldest active PBA player up to date?";

                    button1.Text = "Benjie Paras";
                    button2.Text = "Paulasi Taulava";
                    button3.Text = "James Yap";
                    button4.Text = "Mark Pingris";

                    correctAnswer = 2;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.top_filipino_athletes_on_sm_carousel_dec_18_2017;
                    label1.Text = "Who is the only woman who won an Olympic gold medal for the Philippines?";

                    button1.Text = "Hidilyn Diaz";
                    button2.Text = "Margielyn Didal";
                    button3.Text = "Alyssa Valdez";
                    button4.Text = "Deanna Wong";

                    correctAnswer = 1;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.top_filipino_athletes_on_sm_carousel_dec_18_2017;
                    label1.Text = "Who is the Filipino figure skater who won multiple awards for his sport?";

                    button1.Text = "Nesthy Petecio";
                    button2.Text = "Carlos Yulo";
                    button3.Text = "Michael Martinez";
                    button4.Text = "Kobe Paras";

                    correctAnswer = 3;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.top_filipino_athletes_on_sm_carousel_dec_18_2017;
                    label1.Text = "Who is the retired Filipino boxer who won the 1996 Atlanta Onlympics silver medal?";

                    button1.Text = "Robert Jaworski";
                    button2.Text = "Nonito Donaire";
                    button3.Text = "Manny Pacquiao";
                    button4.Text = "Mansueto Velasco Jr.";

                    correctAnswer = 4;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.top_filipino_athletes_on_sm_carousel_dec_18_2017;
                    label1.Text = "Who is the Filipino professional basketball player that was the former partner of Kris Aquino?";

                    button1.Text = "Benjie Paras";
                    button2.Text = "James Yap";
                    button3.Text = "Robert Jaworski";
                    button4.Text = "Mark Pingris"; 

                    correctAnswer = 2;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.top_filipino_athletes_on_sm_carousel_dec_18_2017;
                    label1.Text = "Who is the Filipino pole-vaulter who broke a record in the Asian Athletics Championships?";

                    button1.Text = "Eugene Torre";
                    button2.Text = "Carlos Yulo";
                    button3.Text = "Ernest James Obiena";
                    button4.Text = "Eumir Marcial";

                    correctAnswer = 3;
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.top_filipino_athletes_on_sm_carousel_dec_18_2017;
                    label1.Text = "Who is the Filipina-Japanese golfer who represented the Philippines in the Asian Games?";

                    button1.Text = "Ayumi Furukawa";
                    button2.Text = "Yuka Saso";
                    button3.Text = "Alex Eala";
                    button4.Text = "Nesthy Petecio";

                    correctAnswer = 2;
                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources.top_filipino_athletes_on_sm_carousel_dec_18_2017;
                    label1.Text = "Who is the former PBA player and the father of the rising basketball star Kobe Paras?";

                    button1.Text = "Ayumi Furukawa";
                    button2.Text = "Yuka Saso";
                    button3.Text = "Alex Eala";
                    button4.Text = "Hidilyn Diaz";

                    correctAnswer = 2;
                    break;
                case 10:
                    pictureBox1.Image = Properties.Resources.top_filipino_athletes_on_sm_carousel_dec_18_2017;
                    label1.Text = "Who is the Filipino-American mixed-martial artist who competed in the UFC and WEC?";

                    button1.Text = "Brandon Vera";
                    button2.Text = "Jordan Clarkson";
                    button3.Text = "Manny Pacquiao";
                    button4.Text = "Dwayne Johnson";

                    correctAnswer = 1;
                    break;








            }

        }
    }
}
