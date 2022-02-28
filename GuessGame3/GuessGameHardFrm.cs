using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace GuessGame3
{
    public partial class GuessGameHardFrm : Form
    {
        public GuessGameHardFrm()
        {
            InitializeComponent();
        }

        int rnd;
        int counter=10;
        int win = 0;
        int lose = 0;
        bool flag = true;
        bool flag2 = true;
        private void GuessGameHardFrm_Load(object sender, EventArgs e)
        {
            rnd = new Random().Next(1, 501);
            Timer.Enabled = false;
            TxtNumber.Enabled = false;
            BtnEnter.Enabled = false;
            BtnNew.Enabled = false;
            LblHelp.Text = string.Empty;
            TxtInfo.Focus();
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(TxtNumber.Text);
                Timer.Enabled = true;

                if (counter > 1)
                {
                    if (num == rnd)
                    {
                        win++;
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
                            rnd = new Random().Next(1, 501);
                            counter = 10;
                            flag = true;
                            flag2 = true;
                            LblShowTimer.Text = "0";
                            LblHelp.Text = string.Empty;
                            LblShowTimer.ForeColor = Color.LightGreen;
                            BackColor = Color.White;
                            LblCount.Text = $"Youre chances are {counter}";
                            LbInfo.Items.Add($"Win:{win} Lose:{lose}");
                            
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
                            if (rnd > 100)
                            {
                                char[] ch = rnd.ToString().ToCharArray();
                                LblHelp.Text = "Whitout sorting: " + ch[1] + ch[0] + "_";
                            }

                            if(rnd > 10 && rnd < 100)
                            {
                                LblHelp.Text = "The first number is: " + rnd.ToString().Substring(0, 1) + "__";
                            }

                            counter += 2;
                            LblCount.Text = $"Youre chances are {counter}";
                            TxtNumber.Clear();
                            TxtNumber.Focus();
                        }
                        Timer.Enabled = true;
                    }
                }

                else
                {
                    lose++;
                    Timer.Enabled = false;
                    LblShowTimer.Text = "0";
                    LblCount.Text = "Game Over!";
                    DialogResult result = MessageBox.Show("Sorry dear friend you were not lucky. Want to try your luck again?", "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {
                        Close();
                    }
                    else
                    {
                        rnd = new Random().Next(1, 501);
                        counter = 10;
                        flag = true;
                        flag2 = true;
                        LblHelp.Text = string.Empty;
                        BackColor = Color.White;
                        LblCount.Text = $"Youre chances are {counter}";
                        LbInfo.Items.Add($"Win:{win} Lose:{lose}");
                        TxtNumber.Clear();
                        TxtNumber.Focus();

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Plz Enter Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNumber.Clear();
                TxtNumber.Focus();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            LbInfo.Items.Add(TxtInfo.Text);
            TxtNumber.Enabled = true;
            BtnEnter.Enabled = true;
            BtnSave.Enabled = false;
            TxtInfo.Enabled = false;
            BtnNew.Enabled = true;
            TxtNumber.Focus();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            rnd = new Random().Next(1, 501);
            win = 0;
            lose = 0;
            counter = 10;
            LblShowTimer.Text = "0";
            Timer.Enabled = false;
            TxtNumber.Enabled = false;
            BtnEnter.Enabled = false;
            BtnSave.Enabled = true;
            TxtInfo.Enabled = true;
            BtnNew.Enabled = false;
            LblShowTimer.ForeColor = Color.LightGreen;
            LblCount.Text = $"Youre chances are {counter}";
            TxtInfo.Clear();
            TxtInfo.Focus();

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            LblShowTimer.Text = (int.Parse(LblShowTimer.Text) + 1).ToString();

            if (LblShowTimer.Text == "15")
            {
                SoundPlayer sound = new SoundPlayer(@"c:\Windows\Media\ringout.wav");
                sound.Play();
                LblShowTimer.ForeColor = Color.Red;
                if (flag2 == true)
                {
                    Timer.Enabled = false;
                    DialogResult result = MessageBox.Show("Do you want help?", "Help", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (rnd > 100)
                        {
                            char[] ch = rnd.ToString().ToCharArray();
                            LblHelp.Text = "Whitout sorting: " + ch[1] + ch[0] + "_";
                        }

                        if (rnd > 10 && rnd < 100)
                        {
                            LblHelp.Text = "The first number is: " + rnd.ToString().Substring(0, 1) + "_";
                        }

                        flag2 = false;
                        LblShowTimer.ForeColor = Color.LightGreen;
                        LblShowTimer.Text = "10";
                        TxtNumber.Clear();
                        TxtNumber.Focus();
                    }
                    Timer.Enabled = true;
                }

            }

            else if (LblShowTimer.Text == "20")
            {
                lose++;
                Timer.Enabled = false;
                BackColor = Color.DarkRed;
                LblCount.Text = "Game Over!";
                DialogResult result = MessageBox.Show("Sorry dear friend you were not lucky. Want to try your luck again?", "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    Close();
                }
                else
                {
                    rnd = new Random().Next(1, 501);
                    counter = 10;
                    flag = true;
                    flag2 = true;
                    LblShowTimer.Text = "0";
                    LblHelp.Text = string.Empty;
                    TxtNumber.Text = string.Empty; 
                    LblShowTimer.ForeColor = Color.LightGreen;
                    BackColor = Color.White;
                    LblCount.Text = $"Youre chances are {counter}";
                    LbInfo.Items.Add($"Win:{win} Lose:{lose}");
                    TxtNumber.Focus();
                }
            }
        }

        private void GuessGameHardFrm_FormClosing(object sender, FormClosingEventArgs e)
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
