
namespace GuessGame4Frm
{
    partial class GuessGame4Frm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.LblCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblShowTimer = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNumber = new System.Windows.Forms.TextBox();
            this.BtnEnter = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.LblHelp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Guess a number between 1 and 200!";
            // 
            // LblCount
            // 
            this.LblCount.AutoSize = true;
            this.LblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCount.Location = new System.Drawing.Point(12, 38);
            this.LblCount.Name = "LblCount";
            this.LblCount.Size = new System.Drawing.Size(125, 13);
            this.LblCount.TabIndex = 1;
            this.LblCount.Text = "Your chances are 10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(160, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Timer:";
            // 
            // LblShowTimer
            // 
            this.LblShowTimer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblShowTimer.ForeColor = System.Drawing.Color.LightGreen;
            this.LblShowTimer.Location = new System.Drawing.Point(203, 60);
            this.LblShowTimer.Name = "LblShowTimer";
            this.LblShowTimer.Size = new System.Drawing.Size(33, 16);
            this.LblShowTimer.TabIndex = 3;
            this.LblShowTimer.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(12, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hard Mode \r\n10 chances in 20 secondes";
            // 
            // TxtNumber
            // 
            this.TxtNumber.BackColor = System.Drawing.Color.LightGray;
            this.TxtNumber.Location = new System.Drawing.Point(15, 79);
            this.TxtNumber.Name = "TxtNumber";
            this.TxtNumber.Size = new System.Drawing.Size(221, 20);
            this.TxtNumber.TabIndex = 5;
            // 
            // BtnEnter
            // 
            this.BtnEnter.BackColor = System.Drawing.Color.LightGray;
            this.BtnEnter.Location = new System.Drawing.Point(15, 105);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(75, 23);
            this.BtnEnter.TabIndex = 6;
            this.BtnEnter.Text = "Enter";
            this.BtnEnter.UseVisualStyleBackColor = false;
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // LblHelp
            // 
            this.LblHelp.BackColor = System.Drawing.Color.White;
            this.LblHelp.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHelp.ForeColor = System.Drawing.Color.Black;
            this.LblHelp.Location = new System.Drawing.Point(119, 105);
            this.LblHelp.Name = "LblHelp";
            this.LblHelp.Size = new System.Drawing.Size(117, 23);
            this.LblHelp.TabIndex = 8;
            this.LblHelp.Text = "label2";
            this.LblHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GuessGame4Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(251, 180);
            this.Controls.Add(this.LblHelp);
            this.Controls.Add(this.BtnEnter);
            this.Controls.Add(this.TxtNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblShowTimer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblCount);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "GuessGame4Frm";
            this.Text = "Guess Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GuessGame4Frm_FormClosing);
            this.Load += new System.EventHandler(this.GuessGame4Frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblShowTimer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtNumber;
        private System.Windows.Forms.Button BtnEnter;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label LblHelp;
    }
}

