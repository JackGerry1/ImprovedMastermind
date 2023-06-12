namespace ImprovedMastermind
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleLabel = new Label();
            startButton = new Button();
            quitButton = new Button();
            helpButton = new Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(138, 9);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(295, 56);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Mastermind";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            startButton.BackColor = Color.MidnightBlue;
            startButton.FlatAppearance.BorderColor = Color.MidnightBlue;
            startButton.FlatAppearance.BorderSize = 0;
            startButton.FlatStyle = FlatStyle.Flat;
            startButton.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            startButton.ForeColor = Color.White;
            startButton.Location = new Point(186, 93);
            startButton.Name = "startButton";
            startButton.Size = new Size(214, 44);
            startButton.TabIndex = 1;
            startButton.Text = "Start Game";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // quitButton
            // 
            quitButton.BackColor = Color.MidnightBlue;
            quitButton.FlatAppearance.BorderColor = Color.MidnightBlue;
            quitButton.FlatAppearance.BorderSize = 0;
            quitButton.FlatStyle = FlatStyle.Flat;
            quitButton.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            quitButton.ForeColor = Color.White;
            quitButton.Location = new Point(186, 214);
            quitButton.Name = "quitButton";
            quitButton.Size = new Size(214, 44);
            quitButton.TabIndex = 2;
            quitButton.Text = "Quit Game";
            quitButton.UseVisualStyleBackColor = false;
            quitButton.Click += quitButton_Click;
            // 
            // helpButton
            // 
            helpButton.BackColor = Color.MidnightBlue;
            helpButton.FlatAppearance.BorderColor = Color.MidnightBlue;
            helpButton.FlatAppearance.BorderSize = 0;
            helpButton.FlatStyle = FlatStyle.Flat;
            helpButton.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            helpButton.ForeColor = Color.White;
            helpButton.Location = new Point(186, 153);
            helpButton.Name = "helpButton";
            helpButton.Size = new Size(214, 44);
            helpButton.TabIndex = 3;
            helpButton.Text = "Help Menu";
            helpButton.UseVisualStyleBackColor = false;
            helpButton.Click += helpButton_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(74, 48, 19);
            ClientSize = new Size(564, 289);
            Controls.Add(helpButton);
            Controls.Add(quitButton);
            Controls.Add(startButton);
            Controls.Add(titleLabel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Button startButton;
        private Button helpButton;
        private Button quitButton;
    }
}