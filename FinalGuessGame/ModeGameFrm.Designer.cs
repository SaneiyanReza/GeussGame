
namespace GuessGame3
{
    partial class ModeGameFrm
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
            this.BtnEasy = new System.Windows.Forms.Button();
            this.BtnHard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnEasy
            // 
            this.BtnEasy.BackColor = System.Drawing.Color.LightGray;
            this.BtnEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEasy.ForeColor = System.Drawing.Color.Blue;
            this.BtnEasy.Location = new System.Drawing.Point(12, 38);
            this.BtnEasy.Name = "BtnEasy";
            this.BtnEasy.Size = new System.Drawing.Size(112, 46);
            this.BtnEasy.TabIndex = 1;
            this.BtnEasy.Text = "Easy Mode";
            this.BtnEasy.UseVisualStyleBackColor = false;
            this.BtnEasy.Click += new System.EventHandler(this.BtnEasy_Click);
            this.BtnEasy.MouseLeave += new System.EventHandler(this.BtnEasy_MouseLeave);
            this.BtnEasy.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnEasy_MouseMove);
            // 
            // BtnHard
            // 
            this.BtnHard.BackColor = System.Drawing.Color.LightGray;
            this.BtnHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHard.ForeColor = System.Drawing.Color.Red;
            this.BtnHard.Location = new System.Drawing.Point(149, 38);
            this.BtnHard.Name = "BtnHard";
            this.BtnHard.Size = new System.Drawing.Size(112, 46);
            this.BtnHard.TabIndex = 2;
            this.BtnHard.Text = "Hard Mode";
            this.BtnHard.UseVisualStyleBackColor = false;
            this.BtnHard.Click += new System.EventHandler(this.BtnHard_Click);
            this.BtnHard.MouseLeave += new System.EventHandler(this.BtnHard_MouseLeave);
            this.BtnHard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnHard_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select game mode:";
            // 
            // ModeGameFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(273, 105);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnHard);
            this.Controls.Add(this.BtnEasy);
            this.MaximizeBox = false;
            this.Name = "ModeGameFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guess Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEasy;
        private System.Windows.Forms.Button BtnHard;
        private System.Windows.Forms.Label label1;
    }
}