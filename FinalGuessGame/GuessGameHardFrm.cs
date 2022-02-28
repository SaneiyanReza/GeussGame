using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace GuessGame4Frm
{
    public partial class GuessGame4Frm : Form
    {
        public GuessGame4Frm()
        {
            InitializeComponent();
        }

        int rnd;
        int counter = 10;
        bool flag = true;
        bool flag2 = true;
        private void GuessGame4Frm_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            rnd = random.Next(1, 201);
            Timer.Enabled = false;
            LblHelp.Text = string.Empty;
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                Timer.Enabled = true;
                int num = int.Parse(TxtNumber.Text);
                if (counter > 1)
                {
                    if (num == rnd)
                    {
                        Timer.Enabled = false;
                        BackColor = Color.Green;
                        LblCount.Text = "You Win!";
                        DialogResult result = MessageBox.Show($"Excellent! Do you want to play again?", "You win", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.No)
                        {
                            Close();
                        }
                        else
                        {
                            LblShowTimer.Text = "0";
                            LblShowTimer.ForeColor = Color.LightGreen;
                            BackColor = Color.White;
                            LblHelp.Text = string.Empty;
                            Random random = new Random();
                            rnd = random.Next(1, 201);
                            counter = 10;
                            LblCount.Text = $"Youre chances are {counter}";
                            flag = true;
                            flag2 = true;
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

                    if (counter == 5 && flag == true)
                    {
                        flag = false;
                        Timer.Enabled = false;
                        DialogResult result = MessageBox.Show("Do you want help?", "Help", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            TxtNumber.Clear();
                            TxtNumber.Focus();
                            LblHelp.Text = "The first number is:" + rnd.ToString().Substring(0,1);
                            counter += 3;
                            LblCount.Text = $"Youre chances are {counter}";
                        }
                            Timer.Enabled = true;
                    }
                }

                else
                {
                    Timer.Enabled = false;
                    LblShowTimer.Text = "0";
                    LblCount.Text = "Game Over!";
                    DialogResult result = MessageBox.Show("Sorry dear friend you were not lucky. Want to try youre luck again?", "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {
                        Close();
                    }
                    else
                    {
                        TxtNumber.Clear();
                        TxtNumber.Focus();
                        BackColor = Color.White;
                        LblHelp.Text = string.Empty;
                        Random random = new Random();
                        rnd = random.Next(1, 201);
                        counter = 10;
                        LblCount.Text = $"Youre chances are {counter}";
                        flag = true;
                        flag2 = true;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Plz Enter Nomber.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNumber.Clear();
                TxtNumber.Focus();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            LblShowTimer.Text = (int.Parse(LblShowTimer.Text) + 1).ToString();
            
            if (LblShowTimer.Text == "15")
            {
                SoundPlayer sound = new SoundPlayer(@"c:\Windows\Media\ringout.wav");
                sound.Play();
                LblShowTimer.ForeColor = Color.Red;
                if (flag2==true)
                {
                    Timer.Enabled = false;
                    DialogResult result = MessageBox.Show("Do you want help?", "Help", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        flag2 = false;
                        TxtNumber.Clear();
                        TxtNumber.Focus();
                        LblShowTimer.ForeColor = Color.LightGreen;
                        LblShowTimer.Text = "10";
                        LblHelp.Text = "The first number is:" + rnd.ToString().Substring(0,1);
                    }
                    Timer.Enabled = true;
                }
                
            }

            else if (LblShowTimer.Text == "20")
            {
                BackColor = Color.DarkRed;
                Timer.Enabled = false;
                LblCount.Text = "Game Over!";
                DialogResult result = MessageBox.Show("Sorry dear friend you were not lucky. Want to try your luck again?", "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    Close();
                }
                else
                {
                    LblShowTimer.Text = "0";
                    LblShowTimer.ForeColor = Color.LightGreen;
                    TxtNumber.Text = string.Empty;
                    TxtNumber.Focus();
                    BackColor = Color.White;
                    LblHelp.Text = string.Empty;
                    Random random = new Random();
                    rnd = random.Next(1, 201);
                    counter = 10;
                    LblCount.Text = $"Youre chances are {counter}";
                    flag = true;
                    flag2 = true;
                }
            }
        }

        private void GuessGame4Frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Timer.Enabled = false;
            DialogResult result = MessageBox.Show("Do you Want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
                Timer.Enabled = true;
            }
        }
    }
}
