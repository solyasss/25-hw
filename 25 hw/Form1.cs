using System;
using System.Windows.Forms;

namespace hw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            start_game();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void start_game()
        {
            int min = 1;
            int max = 100;
            int chance = 0;
            bool right = false;

            MessageBox.Show("Imagine number from 1 to 100 ", "Guess number", MessageBoxButtons.OK, MessageBoxIcon.Information);

            while (!right)
            {
                int guess = (min + max) / 2;
                chance++;

                DialogResult result = MessageBox.Show($"Your number is {guess}?", "Guess number", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    right = true;
                    MessageBox.Show($"I guessed {guess} for {chance} chances!", "Win", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DialogResult playAgain = MessageBox.Show("Do you want to play again?", "New game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (playAgain == DialogResult.Yes)
                    {
                        start_game();
                    }
                    else
                    {
                        break;
                    }
                }
                else if (result == DialogResult.No)
                {
                    DialogResult higherOrLower = MessageBox.Show("Your number is more?", "Asking", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (higherOrLower == DialogResult.Yes)
                    {
                        min = guess + 1;
                    }
                    else
                    {
                        max = guess - 1;
                    }
                }
                else
                {
                    break;
                }

                if (min > max)
                {
                    MessageBox.Show("Inncorrect answers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
