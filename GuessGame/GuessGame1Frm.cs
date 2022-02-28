using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessGame
{
    public partial class GuessGame1Frm : Form
    {
        public GuessGame1Frm()
        {
            InitializeComponent();
        }
        int rnd;
        private void GuessGame1Frm_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            rnd = random.Next(1, 101);
        }
        private void BtnEnter_Click(object sender, EventArgs e)
        {
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
                MessageBox.Show("Plz Enter Nomber.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNumber.Clear();
                TxtNumber.Focus();
            }
            
        }
    }
}
