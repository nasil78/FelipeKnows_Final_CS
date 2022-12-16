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

    public partial class SD : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int totalQuestions;


        public SD()
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
        private void askQuestion(int qnumSD)
        {
            switch (qnumSD)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.sea_games_history_winners_losers_1576138121;
                    label1.Text = "Who is the Filipino-American basketball player for Utah Jazz of the NBA?";

                    button1.Text = "Brandon Vera";
                    button2.Text = "Jordan Clarkson";
                    button3.Text = "Mark Pingris";
                    button4.Text = "Benjie Paras";

                    correctAnswer = 2;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.sea_games_history_winners_losers_1576138121;

                    label1.Text = "Who is the Filipina long jump athlete who is a 4-time SEA Games Champion?";

                    button1.Text = "Marestella Torres";
                    button2.Text = "Deanna Wong";
                    button3.Text = "Alyssa Valdez";
                    button4.Text = "Julia Morado";

                    correctAnswer = 1;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.sea_games_history_winners_losers_1576138121;

                    label1.Text = "Who was the first swimmer who won the first ever Southeast Asian and Olympic silver medal?";

                    button1.Text = "Teofilo Yldefonso";
                    button2.Text = "Michael Martinez";
                    button3.Text = "Eugene Torre";
                    button4.Text = "Brandon Vera";

                    correctAnswer = 1;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.sea_games_history_winners_losers_1576138121;

                    label1.Text = "Who is the 7-footer Filipino basketball prodigy who is the son of Ervin Sotto?";

                    button1.Text = "Vico Sotto";
                    button2.Text = "Tito Sotto";
                    button3.Text = "Vic Sotto";
                    button4.Text = "Kai Sotto";

                    correctAnswer = 4;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.sea_games_history_winners_losers_1576138121;

                    label1.Text = "Who is the Long-Jump Queen of the Philippines?";

                    button1.Text = "Dani Ravena";
                    button2.Text = "Elma Muros";
                    button3.Text = "Deanna Wong";
                    button4.Text = "Hidilyn Diaz";

                    correctAnswer = 2;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.sea_games_history_winners_losers_1576138121;

                    label1.Text = "Who is the famous PBA player who goes by the nickname Jawo?";

                    button1.Text = "Robert Jaworski";
                    button2.Text = "Benjie Paras";
                    button3.Text = "Paulasi Taulava";
                    button4.Text = "Mark Pingris";

                    correctAnswer = 1;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.sea_games_history_winners_losers_1576138121;

                    label1.Text = "Who is the Filipina professional golfer who was a dual medalist at the 2018 Asian Games?";

                    button1.Text = "Bianca Padanganan";
                    button2.Text = "Julia Morado";
                    button3.Text = "Lydia De Vega";
                    button4.Text = "Elma Muros";

                    correctAnswer = 1;
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.sea_games_history_winners_losers_1576138121;

                    label1.Text = "Who is the Filipino boxer who won the silver Olympic medal in 2021 as an amateur?";

                    button1.Text = "Nesthy Petecio";
                    button2.Text = "Nonito Donaire";
                    button3.Text = "Eumir Marcial";
                    button4.Text = "Manny Pacquiao";

                    correctAnswer = 3;
                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources.sea_games_history_winners_losers_1576138121;

                    label1.Text = "Who was the retired sprinter who was hailed as the Asia's fastest woman in the 1980s?";

                    button1.Text = "Alyssa Valdez";
                    button2.Text = "Denise Lazaro";
                    button3.Text = "Lydia De Vega";
                    button4.Text = "Elma Muros";

                    correctAnswer = 3;
                    break;
                case 10:
                    pictureBox1.Image = Properties.Resources.sea_games_history_winners_losers_1576138121;

                    label1.Text = "Who is the Filipino back-to-back gold medalist of the ASEAN Paralympic Games for swimming?";

                    button1.Text = "Michael Martinez";
                    button2.Text = "Michael Phelps";
                    button3.Text = "Gary Bejino";
                    button4.Text = "Eugene Torre";

                    correctAnswer = 3;
                    break;







            }
        }
    }
}
