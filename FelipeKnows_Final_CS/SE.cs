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
    public partial class SE : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int totalQuestions;

        public SE()
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
        private void askQuestion(int qnumSE)
        {
            switch (qnumSE)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.Special_Pub_July_Aug_2_min_1200x674;
                    label1.Text = "Who was the Filipina who won gold in the Olympics for weightlifting?";

                    button1.Text = "Hidilyn Diaz";
                    button2.Text = "Nesthy Petecio";
                    button3.Text = "Mona Sulaiman";
                    button4.Text = "Jia Morado";

                    correctAnswer = 1;

                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.Special_Pub_July_Aug_2_min_1200x674;

                    label1.Text = "Who was the athlete known by the nickname Pacman?";

                    button1.Text = "Nonito Donaire";
                    button2.Text = "Carlos Yulo";
                    button3.Text = "Manny Pacquiao";
                    button4.Text = "Eumir Marcial";

                    correctAnswer = 3;

                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.Special_Pub_July_Aug_2_min_1200x674;

                    label1.Text = "Who is the Filipino professional pool player that also goes by the nickname Bata?";

                    button1.Text = "Eumir Marcial";
                    button2.Text = "Efren Reyes";
                    button3.Text = "Rafael Nepomuceno";
                    button4.Text = "James Yap";

                    correctAnswer = 2;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.Special_Pub_July_Aug_2_min_1200x674;

                    label1.Text = "Who is the Filipino gymnast who won at the World Artistic Gymnastics Championship?";

                    button1.Text = "Carlos Yulo";
                    button2.Text = "Manny Pacquiao";
                    button3.Text = "Nesthy Petecio";
                    button4.Text = "Hidilyn Diaz";

                    correctAnswer = 1;

                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.Special_Pub_July_Aug_2_min_1200x674;

                    label1.Text = "Who is the volleyball player who is hailed as the Queen of Philippine Volleyball?";

                    button1.Text = "Kianna Dy";
                    button2.Text = "Deanna Wong";
                    button3.Text = "Julia Morado";
                    button4.Text = "Alyssa Valdez";

                    correctAnswer = 4;

                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.Special_Pub_July_Aug_2_min_1200x674;

                    label1.Text = " Who is the son of former PBA player Bong Ravena and was the partner of Alyssa Valdez?";

                    button1.Text = "Thirdy Ravena";
                    button2.Text = "Kiefer Ravena";
                    button3.Text = "Kevin Ravena";
                    button4.Text = "Dani Ravena";

                    correctAnswer = 2;

                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.Special_Pub_July_Aug_2_min_1200x674;

                    label1.Text = "Who is hailed as the best Filipino chess player?";

                    button1.Text = "Eugene Torre";
                    button2.Text = "Mona Sulaiman";
                    button3.Text = "Hidilyn Diaz";
                    button4.Text = "Nesthy Petecio";

                    correctAnswer = 1;

                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.Special_Pub_July_Aug_2_min_1200x674;

                    label1.Text = "Who is the Filipino bowler known for the nickname Paeng?";

                    button1.Text = "Eumir Marcial";
                    button2.Text = "Eugene Torre";
                    button3.Text = "Efren Reyes";
                    button4.Text = "Rafael Nepomuceno";

                    correctAnswer = 4;

                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources.Special_Pub_July_Aug_2_min_1200x674;

                    label1.Text = "Who is the professional street skateboarder who competed in the X Games Minneapolis 2018?";

                    button1.Text = "Dennise Lazaro";
                    button2.Text = "Deanna Wong";
                    button3.Text = "Margielyn Didal";
                    button4.Text = "Nesthy Petecio";

                    correctAnswer = 3;

                    break;
                case 10:
                    pictureBox1.Image = Properties.Resources.Special_Pub_July_Aug_2_min_1200x674;

                    label1.Text = "Who is the Filipino boxer known for the nickname The Filipino Flash?";

                    button1.Text = "Carlos Yulo";
                    button2.Text = "Nonito Donaire";
                    button3.Text = "Manny Pacquiao";
                    button4.Text = "Eumir Marcial";

                    correctAnswer = 2;

                    break;

            }

        }
    }
}
