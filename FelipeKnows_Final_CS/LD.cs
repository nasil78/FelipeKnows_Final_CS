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
    public partial class LD : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int totalQuestions;

        public LD()
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
        private void AskQuestion(int qnumLD)
        {
            switch (qnumLD)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.o1AJ9qDyyJNSpZWhUgGYc3MngFqoAMx4FXJ72qHigAy4aFCKg;
                    label1.Text = "Who is the oldest brother in the book Ibong Adarna?";

                    button1.Text = "Juan Luna";
                    button2.Text = "Don Pedro";
                    button3.Text = "Maximo Viola";
                    button4.Text = "Jose Rizal";

                    correctAnswer = 2;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.o1AJ9qDyyJNSpZWhUgGYc3MngFqoAMx4FXJ72qHigAy4aFCKg;
                    label1.Text = "Who is the female main character in Noli Me Tangere?";

                    button1.Text = "Juan Luna";
                    button2.Text = "Ferdinand Blumentritt";
                    button3.Text = "Maria Clara";
                    button4.Text = "Jose Rizal";

                    correctAnswer = 3;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.o1AJ9qDyyJNSpZWhUgGYc3MngFqoAMx4FXJ72qHigAy4aFCKg;
                    label1.Text = "Who is the author of My Last Farewell?";

                    button1.Text = "Juan Luna";
                    button2.Text = "Ferdinand Blumentritt";
                    button3.Text = "Maximo Viola";
                    button4.Text = "Jose Rizal";

                    correctAnswer = 4;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.o1AJ9qDyyJNSpZWhUgGYc3MngFqoAMx4FXJ72qHigAy4aFCKg;
                    label1.Text = "WWho is the main character in the book Dekada 70?";

                    button1.Text = "Amanda Bartolome";
                    button2.Text = "Ferdinand Blumentritt";
                    button3.Text = "Maximo Viola";
                    button4.Text = "Jose Rizal";

                    correctAnswer = 1;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.o1AJ9qDyyJNSpZWhUgGYc3MngFqoAMx4FXJ72qHigAy4aFCKg;
                    label1.Text = "Who is the writer of the comic series Trese?";

                    button1.Text = "Juan Luna";
                    button2.Text = "Budjette Tan";
                    button3.Text = "Maximo Viola";
                    button4.Text = "Jose Rizal";

                    correctAnswer = 2;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.o1AJ9qDyyJNSpZWhUgGYc3MngFqoAMx4FXJ72qHigAy4aFCKg;
                    label1.Text = "Who is the author of the book Salamanca?";

                    button1.Text = "Juan Luna";
                    button2.Text = "Ferdinand Blumentritt";
                    button3.Text = "Dean Francis Alfar";
                    button4.Text = "Jose Rizal";

                    correctAnswer = 3;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.o1AJ9qDyyJNSpZWhUgGYc3MngFqoAMx4FXJ72qHigAy4aFCKg;
                    label1.Text = "Who is Florante’s lover in the story written by Francisco Balagtas?";

                    button1.Text = "Juan Luna";
                    button2.Text = "Ferdinand Blumentritt";
                    button3.Text = "Maximo Viola";
                    button4.Text = "Laura";

                    correctAnswer = 4;
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.o1AJ9qDyyJNSpZWhUgGYc3MngFqoAMx4FXJ72qHigAy4aFCKg;
                    label1.Text = "Who is Lam-Ang’s lover?";

                    button1.Text = "Juan Luna";
                    button2.Text = "Ines Kannoyan";
                    button3.Text = "Maximo Viola";
                    button4.Text = "Jose Rizal";

                    correctAnswer = 2;
                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources.o1AJ9qDyyJNSpZWhUgGYc3MngFqoAMx4FXJ72qHigAy4aFCKg;
                    label1.Text = "Who is the author of Touch me Not?";

                    button1.Text = "Juan Luna";
                    button2.Text = "Ferdinand Blumentritt";
                    button3.Text = "Jose Rizal";
                    button4.Text = "Jose Bukaneg";

                    correctAnswer = 3;
                    break;
                case 10:
                    pictureBox1.Image = Properties.Resources.o1AJ9qDyyJNSpZWhUgGYc3MngFqoAMx4FXJ72qHigAy4aFCKg;
                    label1.Text = "Who is the author of The Reign of Greed?";

                    button1.Text = "Juan Luna";
                    button2.Text = "Ferdinand Blumentritt";
                    button3.Text = "Maximo Viola";
                    button4.Text = "Jose Rizal";

                    correctAnswer = 4;
                    break;
            }
        }
    }
}
