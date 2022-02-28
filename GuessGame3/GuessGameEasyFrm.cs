using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessGame3
{
    public partial class GuessGameEasyFrm : Form
    {
        int rnd;
        public GuessGameEasyFrm()
        {
            InitializeComponent();
            Random random = new Random();
            rnd= random.Next(1, 101);
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            //SoundPlayer player = new SoundPlayer(@"c:\Windows\Media\Music.wav");
            //player.Play();
            try
            {
                int num = int.Parse(TxtNumber.Text);

                if (num == rnd)
                {
                    BackColor = Color.Green;
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
                MessageBox.Show("Plz Enter Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNumber.Clear();
                TxtNumber.Focus();
            }
        }

        private void GuessGameEasyFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you Want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
