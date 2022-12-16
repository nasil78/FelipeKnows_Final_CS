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
    public partial class LA : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int totalQuestions;

        public LA()
        {
            InitializeComponent();
            AskQuestion(questionNumber);

            totalQuestions = 10;

        }
        private void CheckAnswerEvent(object sender, EventArgs e)
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
                AskQuestion(questionNumber);

            }
            questionNumber++;
            AskQuestion(questionNumber);
        }
        private void AskQuestion(int qnumLA)
        {
            switch (qnumLA)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.noli_me_tangere_and_el_filibusterismo;
                    label1.Text = "Who is the main character of Biag ni Lam-Ang?";

                    button1.Text = "Lam-an";
                    button2.Text = "Lam-Ang";
                    button3.Text = "Lam-ung";
                    button4.Text = "Lamag";

                    correctAnswer = 2;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.noli_me_tangere_and_el_filibusterismo;
                    label1.Text = "Who is the main character in Noli Me Tangere?";

                    button1.Text = "Christiano Ibarra";
                    button2.Text = "Christ Ibarra";
                    button3.Text = "Christian Ibarra";
                    button4.Text = "Crisostomo Ibarra";

                    correctAnswer = 4;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.noli_me_tangere_and_el_filibusterismo;
                    label1.Text = "Who is the author of the book entitled El Filibusterismo?";

                    button1.Text = "Jose Rizal";
                    button2.Text = "Maximo Viola";
                    button3.Text = "Chrisostomo Ibarra";
                    button4.Text = "Andres Bonifacio";

                    correctAnswer = 1;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.noli_me_tangere_and_el_filibusterismo;
                    label1.Text = "Who is the writer behind the pen-name Bob Ong?";

                    button1.Text = "Nick Joaquin";
                    button2.Text = "Unknown";
                    button3.Text = "Miguel Cruz";
                    button4.Text = "Jose Cruz";

                    correctAnswer = 2;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.noli_me_tangere_and_el_filibusterismo;
                    label1.Text = "Who is the author behind the book Illustrados?";

                    button1.Text = "Miguel Syjuco";
                    button2.Text = "Ferdinand Blumentritt";
                    button3.Text = "Jose Garcia Villa";
                    button4.Text = "Apolinario Mabini";

                    correctAnswer = 1;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.noli_me_tangere_and_el_filibusterismo;
                    label1.Text = "Who is the author of The Woman Who Had Two Navels?";

                    button1.Text = "Nicholas Sparks";
                    button2.Text = "Nicholas Joaquin";
                    button3.Text = "Nick Joaquin";
                    button4.Text = "Nick Jonas";

                    correctAnswer = 3;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.noli_me_tangere_and_el_filibusterismo;
                    label1.Text = "Who was the poet behind the pen-name Doveglion and is the writer of The Anchored Angel?";

                    button1.Text = "Juan Luna";
                    button2.Text = "Jose Garcia Villa";
                    button3.Text = "Fernando Amorsolo";
                    button4.Text = "Benedicto Cabrera";

                    correctAnswer = 2;
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.noli_me_tangere_and_el_filibusterismo;
                    label1.Text = "Who is the literary legend behind the pen-name Rio Alma?";

                    button1.Text = "Virgilio Cabrera";
                    button2.Text = "Virgilio Cruz";
                    button3.Text = "Virgilio Santos";
                    button4.Text = "Virgilio Almario";

                    correctAnswer = 4;
                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources.noli_me_tangere_and_el_filibusterismo;
                    label1.Text = "Who wrote the the Lino Brocka film Insiang alongside with Matio O’Hara?";

                    button1.Text = "Bobet Vidanes";
                    button2.Text = "Lamberto Antonio";
                    button3.Text = "Lamberto Uy";
                    button4.Text = "Bobet Villanes";

                    correctAnswer = 2;
                    break;
                case 10:
                    pictureBox1.Image = Properties.Resources.noli_me_tangere_and_el_filibusterismo;
                    label1.Text = "Who is the Filipino literary legend who translated the Philippine National Anthem to Tagalog?";

                    button1.Text = "Ildefonso Santos";
                    button2.Text = "Benedicto Cabrera";
                    button3.Text = "Ariel Santos";
                    button4.Text = "Jose Mari Chan";

                    correctAnswer = 1;
                    break;
            }
        }
    }
}
