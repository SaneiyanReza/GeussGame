
namespace GuessGame5
{
    partial class GuessGame5Frm
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
            this.TxtNumber = new System.Windows.Forms.TextBox();
            this.BtnEnter = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.LblShowTimer = new System.Windows.Forms.Label();
            this.TxtInfo = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.LbInfo = new System.Windows.Forms.ListBox();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Guess a number between 1 and 100!";
            // 
            // TxtNumber
            // 
            this.TxtNumber.BackColor = System.Drawing.Color.LightGray;
            this.TxtNumber.Location = new System.Drawing.Point(12, 170);
            this.TxtNumber.Multiline = true;
            this.TxtNumber.Name = "TxtNumber";
            this.TxtNumber.Size = new System.Drawing.Size(182, 25);
            this.TxtNumber.TabIndex = 1;
            // 
            // BtnEnter
            // 
            this.BtnEnter.BackColor = System.Drawing.Color.LightGray;
            this.BtnEnter.Location = new System.Drawing.Point(66, 201);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(75, 25);
            this.BtnEnter.TabIndex = 2;
            this.BtnEnter.Text = "&Enter";
            this.BtnEnter.UseVisualStyleBackColor = false;
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Timer:";
            // 
            // LblShowTimer
            // 
            this.LblShowTimer.AutoSize = true;
            this.LblShowTimer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblShowTimer.ForeColor = System.Drawing.Color.LightGreen;
            this.LblShowTimer.Location = new System.Drawing.Point(63, 151);
            this.LblShowTimer.Name = "LblShowTimer";
            this.LblShowTimer.Size = new System.Drawing.Size(16, 16);
            this.LblShowTimer.TabIndex = 5;
            this.LblShowTimer.Text = "0";
            // 
            // TxtInfo
            // 
            this.TxtInfo.Location = new System.Drawing.Point(12, 64);
            this.TxtInfo.MaxLength = 10;
            this.TxtInfo.Multiline = true;
            this.TxtInfo.Name = "TxtInfo";
            this.TxtInfo.Size = new System.Drawing.Size(195, 22);
            this.TxtInfo.TabIndex = 6;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(12, 92);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(50, 23);
            this.BtnSave.TabIndex = 7;
            this.BtnSave.Text = "&Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // LbInfo
            // 
            this.LbInfo.FormattingEnabled = true;
            this.LbInfo.Location = new System.Drawing.Point(229, 27);
            this.LbInfo.Name = "LbInfo";
            this.LbInfo.Size = new System.Drawing.Size(172, 199);
            this.LbInfo.TabIndex = 8;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(68, 92);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(50, 23);
            this.BtnEdit.TabIndex = 9;
            this.BtnEdit.Text = "&Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // GuessGame5Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(413, 238);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.LbInfo);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtInfo);
            this.Controls.Add(this.LblShowTimer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnEnter);
            this.Controls.Add(this.TxtNumber);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "GuessGame5Frm";
            this.Text = "Guess Game";
            this.Load += new System.EventHandler(this.GuessGame5Frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNumber;
        private System.Windows.Forms.Button BtnEnter;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblShowTimer;
        private System.Windows.Forms.TextBox TxtInfo;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.ListBox LbInfo;
        private System.Windows.Forms.Button BtnEdit;
    }
}

