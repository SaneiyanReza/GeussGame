
namespace GuessGame2
{
    partial class GuessGame2Frm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNumber = new System.Windows.Forms.TextBox();
            this.BtnEnter = new System.Windows.Forms.Button();
            this.LblCount = new System.Windows.Forms.Label();
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
            this.TxtNumber.Location = new System.Drawing.Point(15, 65);
            this.TxtNumber.Multiline = true;
            this.TxtNumber.Name = "TxtNumber";
            this.TxtNumber.Size = new System.Drawing.Size(166, 25);
            this.TxtNumber.TabIndex = 1;
            // 
            // BtnEnter
            // 
            this.BtnEnter.BackColor = System.Drawing.Color.LightGray;
            this.BtnEnter.Location = new System.Drawing.Point(62, 96);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(75, 23);
            this.BtnEnter.TabIndex = 2;
            this.BtnEnter.Text = "Enter";
            this.BtnEnter.UseVisualStyleBackColor = false;
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // LblCount
            // 
            this.LblCount.AutoSize = true;
            this.LblCount.Location = new System.Drawing.Point(12, 40);
            this.LblCount.Name = "LblCount";
            this.LblCount.Size = new System.Drawing.Size(106, 13);
            this.LblCount.TabIndex = 3;
            this.LblCount.Text = "Your chances are 10";
            // 
            // GuessGame2Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(198, 131);
            this.Controls.Add(this.LblCount);
            this.Controls.Add(this.BtnEnter);
            this.Controls.Add(this.TxtNumber);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "GuessGame2Frm";
            this.Text = "GuessGame";
            this.Load += new System.EventHandler(this.GuessGame2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNumber;
        private System.Windows.Forms.Button BtnEnter;
        private System.Windows.Forms.Label LblCount;
    }
}

