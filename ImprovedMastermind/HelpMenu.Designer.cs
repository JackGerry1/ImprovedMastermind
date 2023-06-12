namespace ImprovedMastermind
{
    partial class HelpMenu
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
            helpTitleLabel = new Label();
            tipLabel1 = new Label();
            tipLabel2 = new Label();
            tipLabel3 = new Label();
            tipLabel4 = new Label();
            tipLabel5 = new Label();
            backButton = new Button();
            rulesLabel = new Label();
            strategyLabel = new Label();
            strategyLabel1 = new Label();
            strategyLabel2 = new Label();
            strategyLabel3 = new Label();
            strategyLabel4 = new Label();
            strategyLabel5 = new Label();
            SuspendLayout();
            // 
            // helpTitleLabel
            // 
            helpTitleLabel.AutoSize = true;
            helpTitleLabel.Font = new Font("Arial", 36F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            helpTitleLabel.ForeColor = Color.White;
            helpTitleLabel.Location = new Point(205, 0);
            helpTitleLabel.Name = "helpTitleLabel";
            helpTitleLabel.Size = new Size(267, 56);
            helpTitleLabel.TabIndex = 4;
            helpTitleLabel.Text = "Help Menu\n";
            helpTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tipLabel1
            // 
            tipLabel1.AutoSize = true;
            tipLabel1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tipLabel1.ForeColor = Color.White;
            tipLabel1.Location = new Point(12, 108);
            tipLabel1.Name = "tipLabel1";
            tipLabel1.Size = new Size(632, 48);
            tipLabel1.TabIndex = 5;
            tipLabel1.Text = "Click the coloured buttons to fill up the entire user guess pegs row, \r\nthen click the submit button to get feedback.\r\n";
            tipLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tipLabel2
            // 
            tipLabel2.AutoSize = true;
            tipLabel2.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tipLabel2.ForeColor = Color.White;
            tipLabel2.Location = new Point(12, 170);
            tipLabel2.Name = "tipLabel2";
            tipLabel2.Size = new Size(607, 24);
            tipLabel2.TabIndex = 7;
            tipLabel2.Text = "Red pegs means the pegs are in the correct colour and position.";
            tipLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tipLabel3
            // 
            tipLabel3.AutoSize = true;
            tipLabel3.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tipLabel3.ForeColor = Color.White;
            tipLabel3.Location = new Point(12, 206);
            tipLabel3.Name = "tipLabel3";
            tipLabel3.Size = new Size(678, 48);
            tipLabel3.TabIndex = 8;
            tipLabel3.Text = "White pegs the pegs are the correct colour, but in the incorrect position.\r\n\r\n";
            tipLabel3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tipLabel4
            // 
            tipLabel4.AutoSize = true;
            tipLabel4.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tipLabel4.ForeColor = Color.White;
            tipLabel4.Location = new Point(12, 254);
            tipLabel4.Name = "tipLabel4";
            tipLabel4.Size = new Size(652, 48);
            tipLabel4.TabIndex = 9;
            tipLabel4.Text = "Gray Pegs means there are pegs in the incorrect position and colour.\r\n\r\n";
            tipLabel4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tipLabel5
            // 
            tipLabel5.AutoSize = true;
            tipLabel5.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tipLabel5.ForeColor = Color.White;
            tipLabel5.Location = new Point(12, 302);
            tipLabel5.Name = "tipLabel5";
            tipLabel5.Size = new Size(621, 48);
            tipLabel5.TabIndex = 10;
            tipLabel5.Text = "Guess the secret code in the specified number of attempts to win.\r\n\r\n";
            tipLabel5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // backButton
            // 
            backButton.BackColor = Color.MidnightBlue;
            backButton.FlatAppearance.BorderColor = Color.MidnightBlue;
            backButton.FlatAppearance.BorderSize = 0;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            backButton.ForeColor = Color.White;
            backButton.Location = new Point(182, 629);
            backButton.Name = "backButton";
            backButton.Size = new Size(342, 44);
            backButton.TabIndex = 11;
            backButton.Text = "Back To Main Menu";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // rulesLabel
            // 
            rulesLabel.AutoSize = true;
            rulesLabel.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            rulesLabel.ForeColor = Color.White;
            rulesLabel.Location = new Point(290, 71);
            rulesLabel.Name = "rulesLabel";
            rulesLabel.Size = new Size(104, 37);
            rulesLabel.TabIndex = 12;
            rulesLabel.Text = "Rules";
            rulesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // strategyLabel
            // 
            strategyLabel.AutoSize = true;
            strategyLabel.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            strategyLabel.ForeColor = Color.White;
            strategyLabel.Location = new Point(182, 333);
            strategyLabel.Name = "strategyLabel";
            strategyLabel.Size = new Size(335, 37);
            strategyLabel.TabIndex = 13;
            strategyLabel.Text = "Mastermind Strategy";
            strategyLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // strategyLabel1
            // 
            strategyLabel1.AutoSize = true;
            strategyLabel1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            strategyLabel1.ForeColor = Color.White;
            strategyLabel1.Location = new Point(115, 379);
            strategyLabel1.Name = "strategyLabel1";
            strategyLabel1.Size = new Size(472, 48);
            strategyLabel1.TabIndex = 14;
            strategyLabel1.Text = "Fill the guess row evenly with two differnt colours.\r\n\r\n";
            strategyLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // strategyLabel2
            // 
            strategyLabel2.AutoSize = true;
            strategyLabel2.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            strategyLabel2.ForeColor = Color.White;
            strategyLabel2.Location = new Point(97, 411);
            strategyLabel2.Name = "strategyLabel2";
            strategyLabel2.Size = new Size(522, 72);
            strategyLabel2.TabIndex = 15;
            strategyLabel2.Text = "If the clue pegs are gray, repeat the previous step with \r\nTWO DIFFERENT COLOURS.\r\n\r\n";
            strategyLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // strategyLabel3
            // 
            strategyLabel3.AutoSize = true;
            strategyLabel3.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            strategyLabel3.ForeColor = Color.White;
            strategyLabel3.Location = new Point(97, 465);
            strategyLabel3.Name = "strategyLabel3";
            strategyLabel3.Size = new Size(525, 72);
            strategyLabel3.TabIndex = 16;
            strategyLabel3.Text = "If you get a white or red pegs on your guess, \r\nfill your next guess with one of the two previous colours\r\n\r\n";
            strategyLabel3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // strategyLabel4
            // 
            strategyLabel4.AutoSize = true;
            strategyLabel4.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            strategyLabel4.ForeColor = Color.White;
            strategyLabel4.Location = new Point(12, 525);
            strategyLabel4.Name = "strategyLabel4";
            strategyLabel4.Size = new Size(699, 24);
            strategyLabel4.TabIndex = 17;
            strategyLabel4.Text = "Repeat process above until you know all of the colours in the secret code.\r\n";
            strategyLabel4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // strategyLabel5
            // 
            strategyLabel5.AutoSize = true;
            strategyLabel5.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            strategyLabel5.ForeColor = Color.White;
            strategyLabel5.Location = new Point(97, 558);
            strategyLabel5.Name = "strategyLabel5";
            strategyLabel5.Size = new Size(503, 48);
            strategyLabel5.TabIndex = 18;
            strategyLabel5.Text = "Now keep changing the position of the known colours\r\nuntil you get all red clue pegs to win";
            strategyLabel5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HelpMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(74, 48, 19);
            ClientSize = new Size(710, 685);
            Controls.Add(strategyLabel5);
            Controls.Add(strategyLabel4);
            Controls.Add(strategyLabel3);
            Controls.Add(strategyLabel2);
            Controls.Add(strategyLabel1);
            Controls.Add(strategyLabel);
            Controls.Add(rulesLabel);
            Controls.Add(backButton);
            Controls.Add(tipLabel5);
            Controls.Add(tipLabel4);
            Controls.Add(tipLabel3);
            Controls.Add(tipLabel2);
            Controls.Add(tipLabel1);
            Controls.Add(helpTitleLabel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "HelpMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Help Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label helpTitleLabel;
        private Label tipLabel1;
        private Label tipLabel2;
        private Label tipLabel3;
        private Label tipLabel4;
        private Label tipLabel5;
        protected Button backButton;
        private Label rulesLabel;
        private Label strategyLabel;
        private Label strategyLabel1;
        private Label strategyLabel2;
        private Label strategyLabel3;
        private Label strategyLabel4;
        private Label strategyLabel5;
    }
}