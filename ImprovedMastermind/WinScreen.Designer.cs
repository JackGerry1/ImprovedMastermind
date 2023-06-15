namespace ImprovedMastermind
{
    partial class WinScreen
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
            winTitleLabel = new Label();
            winLabel = new Label();
            playAgainButton = new Button();
            quitButton = new Button();
            SuspendLayout();
            // 
            // winTitleLabel
            // 
            winTitleLabel.AutoSize = true;
            winTitleLabel.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point);
            winTitleLabel.ForeColor = Color.White;
            winTitleLabel.Location = new Point(200, 9);
            winTitleLabel.Name = "winTitleLabel";
            winTitleLabel.Size = new Size(285, 56);
            winTitleLabel.TabIndex = 4;
            winTitleLabel.Text = "Win Screen\r\n";
            winTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // winLabel
            // 
            winLabel.AutoSize = true;
            winLabel.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            winLabel.ForeColor = Color.White;
            winLabel.Location = new Point(117, 78);
            winLabel.Name = "winLabel";
            winLabel.Size = new Size(432, 72);
            winLabel.TabIndex = 5;
            winLabel.Text = "Congratulations, you won,\r\nwould you wish to play again?";
            winLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // playAgainButton
            // 
            playAgainButton.BackColor = Color.MidnightBlue;
            playAgainButton.FlatAppearance.BorderColor = Color.MidnightBlue;
            playAgainButton.FlatAppearance.BorderSize = 0;
            playAgainButton.FlatStyle = FlatStyle.Flat;
            playAgainButton.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            playAgainButton.ForeColor = Color.White;
            playAgainButton.Location = new Point(235, 177);
            playAgainButton.Name = "playAgainButton";
            playAgainButton.Size = new Size(192, 44);
            playAgainButton.TabIndex = 10;
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
            quitButton.Location = new Point(235, 238);
            quitButton.Name = "quitButton";
            quitButton.Size = new Size(192, 44);
            quitButton.TabIndex = 11;
            quitButton.Text = "Quit Game\r\n";
            quitButton.UseVisualStyleBackColor = false;
            quitButton.Click += quitButton_Click;
            // 
            // WinScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(74, 48, 19);
            ClientSize = new Size(664, 321);
            Controls.Add(quitButton);
            Controls.Add(playAgainButton);
            Controls.Add(winLabel);
            Controls.Add(winTitleLabel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "WinScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Win Screen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label winTitleLabel;
        private Label winLabel;
        private Button playAgainButton;
        private Button quitButton;
    }
}