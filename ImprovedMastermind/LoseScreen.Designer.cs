namespace ImprovedMastermind
{
    partial class LoseScreen
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
            loseTitleLabel = new Label();
            loseLabel = new Label();
            playAgainButton = new Button();
            quitButton = new Button();
            SuspendLayout();
            // 
            // loseTitleLabel
            // 
            loseTitleLabel.AutoSize = true;
            loseTitleLabel.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point);
            loseTitleLabel.ForeColor = Color.White;
            loseTitleLabel.Location = new Point(190, 9);
            loseTitleLabel.Name = "loseTitleLabel";
            loseTitleLabel.Size = new Size(310, 56);
            loseTitleLabel.TabIndex = 3;
            loseTitleLabel.Text = "Lose Screen\r\n";
            loseTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loseLabel
            // 
            loseLabel.AutoSize = true;
            loseLabel.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            loseLabel.ForeColor = Color.White;
            loseLabel.Location = new Point(46, 77);
            loseLabel.Name = "loseLabel";
            loseLabel.Size = new Size(586, 72);
            loseLabel.TabIndex = 4;
            loseLabel.Text = "Unfortunately you didn't guess the code, \r\nwould you wish to play again?\r\n";
            loseLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // playAgainButton
            // 
            playAgainButton.BackColor = Color.MidnightBlue;
            playAgainButton.FlatAppearance.BorderColor = Color.MidnightBlue;
            playAgainButton.FlatAppearance.BorderSize = 0;
            playAgainButton.FlatStyle = FlatStyle.Flat;
            playAgainButton.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            playAgainButton.ForeColor = Color.White;
            playAgainButton.Location = new Point(240, 170);
            playAgainButton.Name = "playAgainButton";
            playAgainButton.Size = new Size(192, 44);
            playAgainButton.TabIndex = 9;
            playAgainButton.Text = "Play Again\r\n";
            playAgainButton.UseVisualStyleBackColor = false;
            playAgainButton.Click += playAgainButton_Click;
            // 
            // quitButton
            // 
            quitButton.BackColor = Color.MidnightBlue;
            quitButton.FlatAppearance.BorderColor = Color.MidnightBlue;
            quitButton.FlatAppearance.BorderSize = 0;
            quitButton.FlatStyle = FlatStyle.Flat;
            quitButton.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            quitButton.ForeColor = Color.White;
            quitButton.Location = new Point(240, 235);
            quitButton.Name = "quitButton";
            quitButton.Size = new Size(192, 44);
            quitButton.TabIndex = 10;
            quitButton.Text = "Quit Game\r\n";
            quitButton.UseVisualStyleBackColor = false;
            quitButton.Click += quitButton_Click;
            // 
            // LoseScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(74, 48, 19);
            ClientSize = new Size(664, 314);
            Controls.Add(quitButton);
            Controls.Add(playAgainButton);
            Controls.Add(loseLabel);
            Controls.Add(loseTitleLabel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "LoseScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lose Screen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loseTitleLabel;
        private Label loseLabel;
        private Button playAgainButton;
        private Button quitButton;
    }
}