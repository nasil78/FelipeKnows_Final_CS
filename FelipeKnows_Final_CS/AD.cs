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
    public partial class AD : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int totalQuestions;
        int percentage;

        public AD()
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
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(
                    "Congratulations, Kababayan!" + Environment.NewLine +
                    "You gained " + score + " out of 10" + Environment.NewLine +
                    "Your total percentage is: " + percentage + "%" + Environment.NewLine +
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
        private void askQuestion(int qnumAD)
        {
            switch (qnumAD)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.national_artists;
                    label1.Text = "Who is the sculptor who created the UP Oblation?";

                    button1.Text = "Guillermo Tolentino";
                    button2.Text = "Ogie Alcasid";
                    button3.Text = "Benedicto Cabrera";
                    button4.Text = "Victorio Edades";

                    correctAnswer = 1;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.national_artists;
                    label1.Text = "Who sculpted the People Power Monument?";

                    button1.Text = "Eduardo Castrillo";
                    button2.Text = "Victorio Edades";
                    button3.Text = "Napoleon Abueva";
                    button4.Text = "Benigno Simeon";

                    correctAnswer = 1;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.national_artists;
                    label1.Text = "Who designed the statues at the MacArthur Park in Palo, Leyte?";

                    button1.Text = "Levi Celerio";
                    button2.Text = "Anastacio Caedo";
                    button3.Text = "Benedicto Cabrera";
                    button4.Text = "Victorio Edades";

                    correctAnswer = 2;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.national_artists;
                    label1.Text = "Who is the painter of The Making of the Philippine Flag?";

                    button1.Text = "Eduardo Masferre";
                    button2.Text = "Fernando Amorsolo";
                    button3.Text = "Benedicto Cabrera";
                    button4.Text = "Edward Tolentino";

                    correctAnswer = 2;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.national_artists;
                    label1.Text = "Who is the painter of the First Mass at Limasawa?";

                    button1.Text = "Juan Luna";
                    button2.Text = "Benedicto Cabral";
                    button3.Text = "Carlos Francisco";
                    button4.Text = "Bob Ross";

                    correctAnswer = 3;
                    break;
                case 6: 
                    pictureBox1.Image = Properties.Resources.national_artists;
                    label1.Text = "Who is the lyricist of the Philippine National Anthem?";

                    button1.Text = "Emilio Aguinaldo";
                    button2.Text = "Rey Valera";
                    button3.Text = "Jose Palma";
                    button4.Text = "Julian Felipe";

                    correctAnswer = 3;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.national_artists;
                    label1.Text = "Who was the creator of Sabel in Blue?";

                    button1.Text = "Benedicto Cabrera";
                    button2.Text = "Ogie Alcasid";
                    button3.Text = "Jose Cruz";
                    button4.Text = "Jose Palma";

                    correctAnswer = 1;
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.national_artists;
                    label1.Text = "Who is the Filipino artist with the most artworks?";

                    button1.Text = "Julian Felipe";
                    button2.Text = "Fernando Amorsolo";
                    button3.Text = "Victorio Edades";
                    button4.Text = "Benedict Valdez";

                    correctAnswer = 2;
                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources.national_artists;
                    label1.Text = "Who is the most-selling artist of all time in the Philippines?";

                    button1.Text = "Levi Celerio";
                    button2.Text = "Ogie Alcasid";
                    button3.Text = "Benedicto Cabrera";
                    button4.Text = "Regine Velasquez";

                    correctAnswer = 4; 
                    break;
                case 10:
                    pictureBox1.Image = Properties.Resources.national_artists;
                    label1.Text = "Who is the painter of Gathering of Heroes?";

                    button1.Text = "Levi Celerio";
                    button2.Text = "Ogie Alcasid";
                    button3.Text = "Benedicto Cabrera";
                    button4.Text = "Juanito Torres";

                    correctAnswer = 4;
                    break;

            }
        }
    }
}
