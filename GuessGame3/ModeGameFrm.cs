using System;
using System.Drawing;
using System.Windows.Forms;

namespace GuessGame3
{
    public partial class ModeGameFrm : Form
    {
        public ModeGameFrm()
        {
            InitializeComponent();
        }

        private void ModeGameFrm_Load(object sender, EventArgs e)
        {
            SplashScreenFrm frm = new SplashScreenFrm();
            frm.ShowDialog();
        }

        private void BtnEasy_Click(object sender, EventArgs e)
        {
            GuessGameEasyFrm frm = new GuessGameEasyFrm();
            frm.ShowDialog();
        }

        private void BtnHard_Click(object sender, EventArgs e)
        {
            GuessGameHardFrm frm = new GuessGameHardFrm();
            frm.ShowDialog();
        }

        private void BtnHard_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            BtnHard.BackColor = Color.Red;
            BtnHard.ForeColor = Color.Black;
        }

        private void BtnHard_MouseLeave(object sender, EventArgs e)
        {
            BtnHard.BackColor = Color.LightGray;
            BtnHard.ForeColor = Color.Red;
        }

        private void BtnEasy_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            BtnEasy.BackColor = Color.Blue;
            BtnEasy.ForeColor = Color.Black;
        }

        private void BtnEasy_MouseLeave(object sender, EventArgs e)
        {
            BtnEasy.BackColor = Color.LightGray;
            BtnEasy.ForeColor = Color.Blue;
        }

        private void LblGuid_MouseMove(object sender, MouseEventArgs e)
        {
            LblGuid.ForeColor = Color.DarkViolet;
        }

        private void LblGuid_MouseLeave(object sender, EventArgs e)
        {
            LblGuid.ForeColor = Color.Black;
        }
    }
}
