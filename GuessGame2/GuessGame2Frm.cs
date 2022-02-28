using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessGame2
{
    public partial class GuessGame2Frm : Form
    {
        public GuessGame2Frm()
        {
            InitializeComponent();
        }

        int rnd;
        int counter = 10;

        private void GuessGame2_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            rnd = random.Next(1, 101);
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(TxtNumber.Text);
                if (counter > 1)
                {
                    if (num == rnd)
                    {
                        BackColor = Color.Green;
                        LblCount.Text = "You Win!";
                        DialogResult result = MessageBox.Show("Excellent! Do you want to play again?", "You win", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.No)
                        {
                            Close();
                        }
                        else
                        {
                            BackColor = Color.White;
                            Random random = new Random();
                            rnd = random.Next(1, 101);
                            counter = 10;
                        }
                    }

                    else if (num > rnd)
                    {
                        BackColor = Color.Red;
                        MessageBox.Show($"Your guess number({num}) is larg", "Guess again!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        counter--;
                    }

                    else
                    {
                        BackColor = Color.Red;
                        MessageBox.Show($"Your guess number({num}) is small", "Guess again!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        counter--;
                    }
                    BackColor = Color.White;
                    LblCount.Text = $"Youre chances are {counter}";
                    TxtNumber.Clear();
                    TxtNumber.Focus();
                }

                else
                {
                    BackColor = Color.DarkRed;
                    LblCount.Text = "Game Over!";
                    DialogResult result = MessageBox.Show("Sorry dear friend you were not lucky. Want to try your luck again?", "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {
                        Close();
                    }
                    else
                    {
                        TxtNumber.Clear();
                        TxtNumber.Focus();
                        BackColor = Color.White;
                        Random random = new Random();
                        rnd = random.Next(1, 101);
                        counter = 10;
                        LblCount.Text = $"Youre chances are {counter}";
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Plz Enter Nomber.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                TxtNumber.Clear();
                TxtNumber.Focus();
            }
        }
    }
}
