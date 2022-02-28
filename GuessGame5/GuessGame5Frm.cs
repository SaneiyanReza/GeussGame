using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace GuessGame5
{
    public partial class GuessGame5Frm : Form
    {
        public GuessGame5Frm()
        {
            InitializeComponent();
        }

        int rnd;
        int win = 0;
        int lose = 0;
        private void GuessGame5Frm_Load(object sender, EventArgs e)
        {
            Timer.Enabled = false;
            Random random = new Random();
            rnd = random.Next(1, 101);
            TxtNumber.Enabled = false;
            BtnEnter.Enabled = false;
            BtnEdit.Enabled = false;
            TxtInfo.Focus();
            
        }
        private void BtnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                Timer.Enabled = true;
                int num = int.Parse(TxtNumber.Text);

                if (num == rnd)
                {
                    Timer.Enabled = false;
                    win++;
                    BackColor = Color.Green;
                    DialogResult result = MessageBox.Show("Excellent! Do you want to play again?", "You win", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {
                        Close();
                    }
                    else
                    {
                        LblShowTimer.Text = "0";
                        LblShowTimer.ForeColor = Color.LightGreen;
                        BackColor = Color.White;
                        Random random = new Random();
                        rnd = random.Next(1, 101);
                        LbInfo.Items.Add($"Win:{win} Lose:{lose}");
                    }

                }

                else if (num > rnd)
                {
                    BackColor = Color.Red;
                    MessageBox.Show("Your guess number is larg", "Guess again!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    BackColor = Color.White;
                }

                else
                {
                    BackColor = Color.Red;
                    MessageBox.Show("Your guess number is small", "Guess again!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    BackColor = Color.White;
                }
                TxtNumber.Clear();
                TxtNumber.Focus();
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

            if (LblShowTimer.Text == "20")
            {
                SoundPlayer sound = new SoundPlayer(@"c:\Windows\Media\ringout.wav");
                sound.Play();
                LblShowTimer.ForeColor = Color.Red;
            }

            else if (LblShowTimer.Text == "40")
            {
                Timer.Enabled = false;
                lose++;
                BackColor = Color.DarkRed;
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
                    Random random = new Random();
                    rnd = random.Next(1, 101);
                    LbInfo.Items.Add($"Win:{win} Lose:{lose}");
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            LbInfo.Items.Add(TxtInfo.Text);
            TxtNumber.Enabled = true;
            BtnEnter.Enabled = true;
            TxtNumber.Focus();
            BtnSave.Enabled = false;
            TxtInfo.Enabled = false;
            BtnEdit.Enabled = true;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Timer.Enabled = false;
            win = 0;
            lose = 0;
            LblShowTimer.Text = "0";
            LblShowTimer.ForeColor = Color.LightGreen;
            TxtNumber.Enabled = false;
            BtnEnter.Enabled = false;
            BtnSave.Enabled = true;
            TxtInfo.Enabled = true;
            TxtInfo.Clear();
            TxtInfo.Focus();
            BtnEdit.Enabled = false;
        }
    }
}
