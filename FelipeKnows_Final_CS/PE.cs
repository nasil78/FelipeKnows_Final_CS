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
    public partial class PE : Form
    {
        int correctAnswer;
        int questionNumber=1;
        int score;
        int totalQuestions;

        public PE()
        {
            InitializeComponent();
            askQuestion(questionNumber);

            totalQuestions = 10;
        }

        private void PE_Load(object sender, EventArgs e)
        {

        }

        private void OnTimeEvent(object sender, EventArgs e)
        { }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject= (Button)sender;
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

        private void askQuestion(int qnumPE)
        {
            switch(qnumPE)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.PHPolitics;
                
                    label1.Text = "Who is the first president of the Philippines?";

                    button1.Text = "Emilio Aguinaldo";
                    button2.Text = "Andres Bonifacio";
                    button3.Text = "Jose Rizal";
                    button4.Text = "Juan Luna";

                    correctAnswer = 1;

                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.PHPolitics;

                    label1.Text = "Who is the founder of the Katipunan?";

                    button1.Text = "Gregorio Del Pilar";
                    button2.Text = "Andres Bonifacio";
                    button3.Text = "Juan Luna";
                    button4.Text = "Jose Rizal";

                    correctAnswer = 2;

                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.PHPolitics;

                    label1.Text = "Who is the Philippine National Hero?";

                    button1.Text = "Andres Bonifacio";
                    button2.Text = "Jose Rizal";
                    button3.Text = "Gregorio Del Pilar";
                    button4.Text = "Lapu Lapu";

                    correctAnswer = 2;

                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.PHPolitics;

                    label1.Text = "Who is the Philippine president that established the War on Drugs?";

                    button1.Text = "Manuel Quezon";
                    button2.Text = "Joseph Estrada";
                    button3.Text = "Rodrigo Duterte";
                    button4.Text = "Benigno Aquino III";

                    correctAnswer = 3;

                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.PHPolitics;

                    label1.Text = "Who is the wife of late president Ferdinand Marcos Sr.?";

                    button1.Text = "Irene Marcos";
                    button2.Text = "Imee Marcos";
                    button3.Text = "Imelda Marcos";
                    button4.Text = "Iree Marcos";

                    correctAnswer = 3;

                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.PHPolitics;

                    label1.Text = " Who is the first Filipina president of the Philippines?";

                    button1.Text = "Gabriela Silang";
                    button2.Text = "Corazon Aquino";
                    button3.Text = "Gloria Macapagal Arroyo";
                    button4.Text = "Miriam Defensor Santiago";

                    correctAnswer = 2;

                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.PHPolitics;

                    label1.Text = "Who is the recorded first and only dictator that led the Philippines?";

                    button1.Text = "Ferdinand Marcos Jr.";
                    button2.Text = "Ferdinand Marcos";
                    button3.Text = "Ferdinand Marcos Sr.";
                    button4.Text = "Ferdinand Marcos III";

                    correctAnswer = 3;

                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.PHPolitics;

                    label1.Text = "Who is the 16th president of the Philippines?";

                    button1.Text = "Benigno Aquino III";
                    button2.Text = "Rodrigo Duterte";
                    button3.Text = "Emilio Aguinaldo";
                    button4.Text = "Diosdado Macapagal";

                    correctAnswer = 2;

                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources.PHPolitics;

                    label1.Text = "Who was known as the Iron Lady of Asia?";

                    button1.Text = "Miriam Defensor Santiago";
                    button2.Text = "Corazon Aquino";
                    button3.Text = "Gabriela Silang";
                    button4.Text = "Risa Hontiveros";

                    correctAnswer = 1;

                    break;
                case 10:
                    pictureBox1.Image = Properties.Resources.PHPolitics;

                    label1.Text = "Who was the president elected after the EDSA Revolution?";

                    button1.Text = "Corazon Aquino";
                    button2.Text = "Gloria Arroyo";
                    button3.Text = "Imelda Marcos";
                    button4.Text = "Gabriela Silang";

                    correctAnswer = 1;

                    break;






            }
        }
    }
}
