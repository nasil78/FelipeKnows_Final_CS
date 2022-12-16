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
    public partial class MD : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int totalQuestions;

        public MD()
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
        private void askQuestion(int qnumMD)
        {
            switch (qnumMD)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.ph_national_artist_october_24_2018;
                    label1.Text = "Who is the Filipino singer who was a member of the international band Journey?";

                    button1.Text = "Rico Blanco";
                    button2.Text = "Arnel Pineda";
                    button3.Text = "Ariel Rivera";
                    button4.Text = "Pepe Smith";

                    correctAnswer = 2;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.ph_national_artist_october_24_2018;
                    label1.Text = "Who is well known for his former name as Charice and was the hitmaker behind the song Pyramid?";

                    button1.Text = "Iza Calzado";
                    button2.Text = "Jake Cuenca";
                    button3.Text = "Ice Seguerra";
                    button4.Text = "Jake Zyrus";

                    correctAnswer = 4;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.ph_national_artist_october_24_2018;
                    label1.Text = "Who is the Filipina-African American soul singer who is known as the Philippine Soul Diva?";

                    button1.Text = "Wilma Doesnt";
                    button2.Text = "Lani Misalucha";
                    button3.Text = "Jaya";
                    button4.Text = "Jona";

                    correctAnswer = 3;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.ph_national_artist_october_24_2018;
                    label1.Text = "Who is the Filipino musician who had achieved highest award for kutyapi playing?";

                    button1.Text = "Sylvia La Torre";
                    button2.Text = "Samaon Sulaiman";
                    button3.Text = "Bullet Dumas";
                    button4.Text = "Cecile Licad"; 

                    correctAnswer = 2;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.ph_national_artist_october_24_2018;
                    label1.Text = "Who is the indie song-writer best known for style described by critics as distinctively Filipino?";

                    button1.Text = "Bullet Dumas";
                    button2.Text = "Ryan Cayabyab";
                    button3.Text = "Pepe Herrera";
                    button4.Text = "Aiza Seguerra";

                    correctAnswer = 1;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.ph_national_artist_october_24_2018;
                    label1.Text = "Who is the Filipino composer and musical veteran hosted in Tawag ng Tanghalan?";

                    button1.Text = "Ray Valera";
                    button2.Text = "Rey Valera";
                    button3.Text = "Rey Vanera";
                    button4.Text = "Ray Vanera";

                    correctAnswer = 2;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.ph_national_artist_october_24_2018;
                    label1.Text = "Who is the Filipina singer hailed as Asia’s Soul Supreme?";
                    button1.Text = "KZ Concepcion";
                    button2.Text = "KC Tandigan";
                    button3.Text = "KC Concepcion";
                    button4.Text = "KZ Tandingan";

                    correctAnswer = 4;
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.ph_national_artist_october_24_2018;
                    label1.Text = "Who is the Filipino singer who is the husband of Gelli de Belen and is awarded the Aliw award?";
                    button1.Text = "April Boy Reginio"; 
                    button2.Text = "Ariel Rivera";
                    button3.Text = "Ace Vergel";
                    button4.Text = "Arnel Pineda";

                    correctAnswer = 2;
                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources.ph_national_artist_october_24_2018;
                    label1.Text = "Who is the Filipina singer who is hailed as the Queen of Philippine R&B?";

                    button1.Text = "Kyla";
                    button2.Text = "Yeng Constantino";
                    button3.Text = "Vilma Santos";
                    button4.Text = "Jaya";

                    correctAnswer = 1;
                    break;
                case 10:
                    pictureBox1.Image = Properties.Resources.ph_national_artist_october_24_2018;
                    label1.Text = "Who is the Filipino actor and singer that was formerly known as Aiza and now is a trans man?";

                    button1.Text = "Iza Calzado";
                    button2.Text = "Aiza Santos";
                    button3.Text = "Ice Seguerra";
                    button4.Text = "Charice Pempengco";

                    correctAnswer = 3;
                    break;
            }
        }
    }
}
