using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Quiz
{
    public partial class Form1 : Form
    {
        // This SoundPlayer plays when the user get a correct answer
        System.Media.SoundPlayer correct = new
        System.Media.SoundPlayer(Properties.Resources.Ping___Sound_Effect);

        // Create a Random object to generate random numbers.
        Random randomizer = new Random();

        // These ints will store the numbers
        // for the addition problem.
        int addend1;
        int addend2;

        // These ints will store the numbers
        // for the subtraction problem.
        int minuend;
        int subtrahend;

        // These ints will store the numbers for the multiplication problem.
        int multiplicand;
        int multiplier;

        // These ints will store the numbers for the division problem.
        int dividend;
        int divisor;


        // This int will keep track of the time left.
        int timeLeft;

        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Start the quiz by filling in all of the problems
        /// and starting the timer.
        /// </summary>
        public void StartTheQuiz()
        {
            // Fill in the addition problem.
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();
            sum.Value = 0;

            // Fill in the subtraction problem.
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            difference.Value = 0;



            // Fill in the multiplication problem.
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            product.Value = 0;

            // Fill in the division problem.
            divisor = randomizer.Next(2, 11);
            // Decides the answer by choosing a number between 1 and 10 
            int temporaryQuotient = randomizer.Next(2, 11);
            // dividend is equal to the divisor times the answer meaning the answer will always be a whole number
            dividend = divisor * temporaryQuotient;
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();
            quotient.Value = 0;


            // Start the timer.
            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timeLabel.BackColor = Color.White;
            timer1.Start();

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                // If the user got the answer right, stop the timer 
                // and show a MessageBox.
                timer1.Stop();
                MessageBox.Show("You got all the answers right!",
                                "Congratulations");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                // Display the new time left
                // by updating the Time Left label.
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds";
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry");
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                startButton.Enabled = true;
            }
            if (timeLeft < 6)
            {
                timeLabel.BackColor = Color.Red;
            }

        }

        /// <summary>
        /// Check the answer to see if the user got everything right.
        /// </summary>
        /// <returns>True if the answer's correct, false otherwise.</returns>
        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == sum.Value) && (minuend - subtrahend == difference.Value) && (multiplicand * multiplier == product.Value)
        && (dividend / divisor == quotient.Value))

                return true;
            else
                return false;
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            // Select the whole answer in the NumericUpDown control.
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void correctsound()
        {
            if (addend1 + addend2 == sum.Value)
            {
                correct.Play();
            }
            if (minuend - subtrahend == difference.Value)
            {
                correct.Play();
            }
            if (multiplicand * multiplier == product.Value)
            {
                correct.Play();
            }
            if (dividend / divisor == quotient.Value)
            {
                correct.Play();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void plusLeftLabel_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void minusLeftLabel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timesLeftLabel_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dividedLeftLabel_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dividedRightLabel_Click(object sender, EventArgs e)
        {

        }

        private void timesRightLabel_Click(object sender, EventArgs e)
        {

        }

        private void minusRightLabel_Click(object sender, EventArgs e)
        {

        }

        private void plusRightLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void quotient_ValueChanged(object sender, EventArgs e)
        {

        }

        private void product_ValueChanged(object sender, EventArgs e)
        {

        }

        private void difference_ValueChanged(object sender, EventArgs e)
        {

        }

        private void sum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void plusLeftLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void plusRightLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void difference_ValueChanged_1(object sender, EventArgs e)
        {
            if (minuend - subtrahend == difference.Value)
            {
                correct.Play();
            }
        }

        private void sum_ValueChanged_1(object sender, EventArgs e)
        {
            if (addend1 + addend2 == sum.Value)
            {
                correct.Play();
            }
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void minusRightLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void minusLeftLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void product_ValueChanged_1(object sender, EventArgs e)
        {
            if (multiplicand * multiplier == product.Value)
            {
                correct.Play();
            }
        }

        private void quotient_ValueChanged_1(object sender, EventArgs e)
        {
            if (dividend / divisor == quotient.Value)
            {
                correct.Play();
            }
        }
    }
}

