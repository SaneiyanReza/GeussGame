
namespace GuessGame3
{
    partial class GuessGameHardFrm
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
            this.TxtNumber = new System.Windows.Forms.TextBox();
            this.BtnEnter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.LblShowTimer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblHelp = new System.Windows.Forms.Label();
            this.TxtInfo = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.LbInfo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Guess a number between 1 and 500!";
            // 
            // LblCount
            // 
            this.LblCount.AutoSize = true;
            this.LblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCount.Location = new System.Drawing.Point(9, 128);
            this.LblCount.Name = "LblCount";
            this.LblCount.Size = new System.Drawing.Size(125, 13);
            this.LblCount.TabIndex = 1;
            this.LblCount.Text = "Your chances are 10\r\n";
            // 
            // TxtNumber
            // 
            this.TxtNumber.BackColor = System.Drawing.SystemColors.Window;
            this.TxtNumber.Location = new System.Drawing.Point(12, 162);
            this.TxtNumber.Name = "TxtNumber";
            this.TxtNumber.Size = new System.Drawing.Size(243, 20);
            this.TxtNumber.TabIndex = 2;
            // 
            // BtnEnter
            // 
            this.BtnEnter.BackColor = System.Drawing.Color.LightGray;
            this.BtnEnter.Location = new System.Drawing.Point(12, 188);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(82, 23);
            this.BtnEnter.TabIndex = 3;
            this.BtnEnter.Text = "Enter";
            this.BtnEnter.UseVisualStyleBackColor = false;
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(12, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hard Mode \r\n10 chances in 20 secondes";
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // LblShowTimer
            // 
            this.LblShowTimer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblShowTimer.ForeColor = System.Drawing.Color.LightGreen;
            this.LblShowTimer.Location = new System.Drawing.Point(213, 143);
            this.LblShowTimer.Name = "LblShowTimer";
            this.LblShowTimer.Size = new System.Drawing.Size(26, 16);
            this.LblShowTimer.TabIndex = 5;
            this.LblShowTimer.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Timer:";
            // 
            // LblHelp
            // 
            this.LblHelp.Location = new System.Drawing.Point(100, 188);
            this.LblHelp.Name = "LblHelp";
            this.LblHelp.Size = new System.Drawing.Size(155, 23);
            this.LblHelp.TabIndex = 7;
            this.LblHelp.Text = "label4";
            this.LblHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtInfo
            // 
            this.TxtInfo.Location = new System.Drawing.Point(15, 58);
            this.TxtInfo.MaxLength = 15;
            this.TxtInfo.Multiline = true;
            this.TxtInfo.Name = "TxtInfo";
            this.TxtInfo.Size = new System.Drawing.Size(192, 22);
            this.TxtInfo.TabIndex = 8;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(12, 86);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(51, 23);
            this.BtnSave.TabIndex = 9;
            this.BtnSave.Text = "&Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(69, 86);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(51, 23);
            this.BtnNew.TabIndex = 10;
            this.BtnNew.Text = "&New";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // LbInfo
            // 
            this.LbInfo.FormattingEnabled = true;
            this.LbInfo.Location = new System.Drawing.Point(261, 38);
            this.LbInfo.Name = "LbInfo";
            this.LbInfo.Size = new System.Drawing.Size(164, 199);
            this.LbInfo.TabIndex = 11;
            // 
            // GuessGameHardFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(437, 249);
            this.Controls.Add(this.LbInfo);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtInfo);
            this.Controls.Add(this.LblHelp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblShowTimer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnEnter);
            this.Controls.Add(this.TxtNumber);
            this.Controls.Add(this.LblCount);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "GuessGameHardFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guess Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GuessGameHardFrm_FormClosing);
            this.Load += new System.EventHandler(this.GuessGameHardFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblCount;
        private System.Windows.Forms.TextBox TxtNumber;
        private System.Windows.Forms.Button BtnEnter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label LblShowTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblHelp;
        private System.Windows.Forms.TextBox TxtInfo;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.ListBox LbInfo;
    }
}