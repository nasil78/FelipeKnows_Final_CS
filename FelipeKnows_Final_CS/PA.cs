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
    public partial class PA : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int totalQuestions;

        public PA()
        {
            InitializeComponent();
            askQuestion(questionNumber);

            totalQuestions = 10;
        }
        


        private void PA_Load(object sender, EventArgs e)
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
                    
                    "To see the Answer Key, click Credits" + Environment.NewLine +
                    "Click OK to return to the home page "


                    );
                Application.Restart();

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);

            }
            questionNumber++;
            askQuestion(questionNumber);
        }

        private void askQuestion(int qnumPA)
        {
            switch (qnumPA) 
            {
                case 1:
                    pictureBox1.Image = Properties.Resources._200809404_241602377772278_5981706775485067849_n;

                    label1.Text = "Who is the first president of the Philippine senate?";

                    button1.Text = "Emilio Aguinaldo";
                    button2.Text = "Manuel Quezon";
                    button3.Text = "Jose Rizal";
                    button4.Text = "Juan Luna";

                    correctAnswer = 2;

                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources._200809404_241602377772278_5981706775485067849_n;

                    label1.Text = "Who was the second Filipina president of the Philippines?";

                    button1.Text = "Geronima Pecson";
                    button2.Text = "Corazon Aquino";
                    button3.Text = "Gloria Arroyo";
                    button4.Text = "Miriam Defensor Santiago";

                    correctAnswer = 3;

                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources._200809404_241602377772278_5981706775485067849_n;

                    label1.Text = "Who was the first Filipina senator?";

                    button1.Text = "Corazon Aquino";
                    button2.Text = "Geronima Pecson";
                    button3.Text = "Gabriela Silang";
                    button4.Text = "Melchora Aquino";

                    correctAnswer = 2;

                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources._200809404_241602377772278_5981706775485067849_n;

                    label1.Text = "Who was the late husband of president Corazon Aquino?";

                    button1.Text = "Benigno Aquino";
                    button2.Text = "Benigno Aquino III";
                    button3.Text = "Benigno Aquino Jr.";
                    button4.Text = "Benigno Aquino Sr.";

                    correctAnswer = 3;

                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources._200809404_241602377772278_5981706775485067849_n;

                    label1.Text = "Who was the first vice president of the Philippines?";

                    button1.Text = "Jose Laurel";
                    button2.Text = "Sergio Osmena";
                    button3.Text = "Emilio Jacinto";
                    button4.Text = "Juan Luna";

                    correctAnswer = 2;

                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources._200809404_241602377772278_5981706775485067849_n;

                    label1.Text = "Who is the 15th president of the Philippines?";

                    button1.Text = "Benigno Aquino III";
                    button2.Text = "Joseph Estrada";
                    button3.Text = "Elpidio Quirino";
                    button4.Text = "Ferdinand Marcos Jr.";

                    correctAnswer = 1;

                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources._200809404_241602377772278_5981706775485067849_n;

                    label1.Text = "Who is the first Filipina vice president of the Philippines?";

                    button1.Text = "Geronima Pecson";
                    button2.Text = "Gloria Arroyo";
                    button3.Text = "Trinidad Tecson";
                    button4.Text = "Marina Dizon";

                    correctAnswer = 2;

                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources._200809404_241602377772278_5981706775485067849_n;

                    label1.Text = "Who was the president of the country when the Philippines had the highest amount of debt?";

                    button1.Text = "Fidel Ramos";
                    button2.Text = "Ferdinand Marcos Sr.";
                    button3.Text = "Rodrigo Duterte";
                    button4.Text = "Diosdado Macapagal";

                    correctAnswer = 3;

                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources._200809404_241602377772278_5981706775485067849_n;

                    label1.Text = "Who is the Filipina politician adopted by late actor Fernando Poe Jr.?";

                    button1.Text = "Loren Legarda";
                    button2.Text = "Mary Grace Llamanarez";
                    button3.Text = "Lovi Poe";
                    button4.Text = "Diosdado Macapagal";

                    correctAnswer = 2;

                    break;
                case 10:
                    pictureBox1.Image = Properties.Resources._200809404_241602377772278_5981706775485067849_n;

                    label1.Text = "Who is the second Filipina vice president of the Philippines?";

                    button1.Text = "Sara Duterte";
                    button2.Text = "Gloria Arroyo";
                    button3.Text = "Nancy Binay";
                    button4.Text = "Maria Leonor Robredo";

                    correctAnswer = 2;

                    break;



            }
        }
    }
}
