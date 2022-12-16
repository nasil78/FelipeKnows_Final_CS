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
    public partial class PD : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int totalQuestions;

        public PD()
        {
            InitializeComponent();
            askQuestion(questionNumber);

            totalQuestions = 10;
        }

        private void PD_Load(object sender, EventArgs e)
        {

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
                  
                    "To see the Answer Key, click Credits"+ Environment.NewLine+
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
        private void askQuestion(int qnumPD)
        {
            switch (qnumPD)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.lsDCyvIHHjodPPA_800x450_noPad;

                    label1.Text = "Who is the Senator known as the grand old man of Philippine politics?";

                    button1.Text = "Emilio Aguinaldo";
                    button2.Text = "Manuel Quezon";
                    button3.Text = "Lorenzo Tanada";
                    button4.Text = "Juan Luna";

                    correctAnswer = 3;

                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.lsDCyvIHHjodPPA_800x450_noPad;

                    label1.Text = "Who is the third president of the Philippines?";

                    button1.Text = "Jose Laurel";
                    button2.Text = "Benigno Aquino Sr.";
                    button3.Text = "Sergio Osmena";
                    button4.Text = "Emilio Aguinaldo";

                    correctAnswer = 1;

                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.lsDCyvIHHjodPPA_800x450_noPad;

                    label1.Text = "Who was the president who declared the Proclamation 1081 or Marital Law?";

                    button1.Text = "Jose Rizal";
                    button2.Text = "Ferdinand Marcos Sr.";
                    button3.Text = "Andres Bonifacio";
                    button4.Text = "Manuel Quezon";

                    correctAnswer = 2;

                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.lsDCyvIHHjodPPA_800x450_noPad;

                    label1.Text = "Who was the president responsible for the implementation of K12 in the country?";

                    button1.Text = "Benigno Aquino III";
                    button2.Text = "Elpidio Quirino";
                    button3.Text = "Diosdado Macapagal";
                    button4.Text = "Corazon Aquino";

                    correctAnswer = 1;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.lsDCyvIHHjodPPA_800x450_noPad;

                    label1.Text = "Who is the Philippine president known as the Ama ng Wikang Pambansa?";

                    button1.Text = "Manuel Quirino";
                    button2.Text = "Manuel Quezon";
                    button3.Text = "Manuel Lopez";
                    button4.Text = "Jose Rizal";

                    correctAnswer = 2;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.lsDCyvIHHjodPPA_800x450_noPad;

                    label1.Text = "Who was the 2022 elections presidential runner that was previously an actor before entering politics?";

                    button1.Text = "Leodigario De Guzman";
                    button2.Text = "Ferdinand Marcos Jr.";
                    button3.Text = "Francisco Domagoso";
                    button4.Text = "Panfilo Lacson";

                    correctAnswer = 3;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.lsDCyvIHHjodPPA_800x450_noPad;

                    label1.Text = "Who is the Iron Butterfly of the Philippines?";

                    button1.Text = "Maria Leonora Robredo";
                    button2.Text = "Imelda Marcos";
                    button3.Text = "Miriam Defensor Santiago";
                    button4.Text = "Imee Marcos";

                    correctAnswer = 2;
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.lsDCyvIHHjodPPA_800x450_noPad;

                    label1.Text = "Who was the 2022 elections presidential runner who was implicated with multiple cases of murder?";

                    button1.Text = "Emmanuel Pacquiao";
                    button2.Text = "Francisco Domagoso";
                    button3.Text = "Panfilo Lacson";
                    button4.Text = "Maria Leonora Robredo";

                    correctAnswer = 3;
                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources.lsDCyvIHHjodPPA_800x450_noPad;

                    label1.Text = "Who was the 2022 elections senatorial runner that aspired to become the first Philippine senator from an indigenous community?";

                    button1.Text = "Teodoro Baguilat";
                    button2.Text = "Greco Balgica";
                    button3.Text = "Alex Lacson";
                    button4.Text = "Risa Hontiveros";

                    correctAnswer = 1;
                    break;
                case 10:
                    pictureBox1.Image = Properties.Resources.lsDCyvIHHjodPPA_800x450_noPad;

                    label1.Text = "Who was the 2022 elections presidential runner who was an Oxford dropout?";

                    button1.Text = "Faisal Mangondato";
                    button2.Text = "Ferdinand Marcos Jr.";
                    button3.Text = "Emmanuel Pacquiao";
                    button4.Text = "Maria Leonora Robredo";

                    correctAnswer = 2;
                    break;






            }
        }
        
    }
}
