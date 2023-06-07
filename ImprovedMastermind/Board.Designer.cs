namespace ImprovedMastermind
{
    partial class Board
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
            userInputPanel = new Panel();
            clearButton = new Button();
            blackCircleButton = new CircleButtons();
            whiteCircleButton = new CircleButtons();
            pinkCircleButton = new CircleButtons();
            pegGuessLabel = new Label();
            purpleCircleButton = new CircleButtons();
            submitButton = new Button();
            clearAllButton = new Button();
            colourLabel = new Label();
            greenCircleButton = new CircleButtons();
            redCircleButton = new CircleButtons();
            yellowCircleButton = new CircleButtons();
            blueCircleButton = new CircleButtons();
            mastermindOutputPanel = new Panel();
            submitedLabel = new Label();
            clueLabel = new Label();
            quitButton = new Button();
            secretPanel = new Panel();
            secretLabel = new Label();
            helpButton = new Button();
            userInputPanel.SuspendLayout();
            mastermindOutputPanel.SuspendLayout();
            secretPanel.SuspendLayout();
            SuspendLayout();
            // 
            // userInputPanel
            // 
            userInputPanel.BorderStyle = BorderStyle.FixedSingle;
            userInputPanel.Controls.Add(clearButton);
            userInputPanel.Controls.Add(blackCircleButton);
            userInputPanel.Controls.Add(whiteCircleButton);
            userInputPanel.Controls.Add(pinkCircleButton);
            userInputPanel.Controls.Add(pegGuessLabel);
            userInputPanel.Controls.Add(purpleCircleButton);
            userInputPanel.Controls.Add(submitButton);
            userInputPanel.Controls.Add(clearAllButton);
            userInputPanel.Controls.Add(colourLabel);
            userInputPanel.Controls.Add(greenCircleButton);
            userInputPanel.Controls.Add(redCircleButton);
            userInputPanel.Controls.Add(yellowCircleButton);
            userInputPanel.Controls.Add(blueCircleButton);
            userInputPanel.Location = new Point(1, 705);
            userInputPanel.Name = "userInputPanel";
            userInputPanel.Padding = new Padding(2);
            userInputPanel.Size = new Size(596, 208);
            userInputPanel.TabIndex = 0;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.MidnightBlue;
            clearButton.FlatAppearance.BorderColor = Color.MidnightBlue;
            clearButton.FlatAppearance.BorderSize = 0;
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            clearButton.ForeColor = Color.White;
            clearButton.Location = new Point(10, 149);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(103, 34);
            clearButton.TabIndex = 22;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            // 
            // blackCircleButton
            // 
            blackCircleButton.BackColor = Color.Black;
            blackCircleButton.FlatStyle = FlatStyle.Popup;
            blackCircleButton.ForeColor = Color.Black;
            blackCircleButton.Location = new Point(148, 93);
            blackCircleButton.Name = "blackCircleButton";
            blackCircleButton.Size = new Size(40, 40);
            blackCircleButton.TabIndex = 4;
            blackCircleButton.Tag = "8";
            blackCircleButton.UseVisualStyleBackColor = false;
            // 
            // whiteCircleButton
            // 
            whiteCircleButton.BackColor = Color.White;
            whiteCircleButton.FlatStyle = FlatStyle.Popup;
            whiteCircleButton.ForeColor = Color.White;
            whiteCircleButton.Location = new Point(102, 93);
            whiteCircleButton.Name = "whiteCircleButton";
            whiteCircleButton.Size = new Size(40, 40);
            whiteCircleButton.TabIndex = 5;
            whiteCircleButton.Tag = "7";
            whiteCircleButton.UseVisualStyleBackColor = false;
            // 
            // pinkCircleButton
            // 
            pinkCircleButton.BackColor = Color.Fuchsia;
            pinkCircleButton.FlatStyle = FlatStyle.Popup;
            pinkCircleButton.ForeColor = Color.Fuchsia;
            pinkCircleButton.Location = new Point(56, 93);
            pinkCircleButton.Name = "pinkCircleButton";
            pinkCircleButton.Size = new Size(40, 40);
            pinkCircleButton.TabIndex = 7;
            pinkCircleButton.Tag = "6";
            pinkCircleButton.UseVisualStyleBackColor = false;
            // 
            // pegGuessLabel
            // 
            pegGuessLabel.AutoSize = true;
            pegGuessLabel.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            pegGuessLabel.ForeColor = Color.White;
            pegGuessLabel.Location = new Point(244, 16);
            pegGuessLabel.Name = "pegGuessLabel";
            pegGuessLabel.Size = new Size(208, 24);
            pegGuessLabel.TabIndex = 21;
            pegGuessLabel.Text = "Pegs To Be Guessed\r\n";
            // 
            // purpleCircleButton
            // 
            purpleCircleButton.BackColor = Color.Indigo;
            purpleCircleButton.FlatStyle = FlatStyle.Popup;
            purpleCircleButton.ForeColor = Color.Indigo;
            purpleCircleButton.Location = new Point(10, 93);
            purpleCircleButton.Name = "purpleCircleButton";
            purpleCircleButton.Size = new Size(40, 40);
            purpleCircleButton.TabIndex = 6;
            purpleCircleButton.Tag = "5";
            purpleCircleButton.UseVisualStyleBackColor = false;
            // 
            // submitButton
            // 
            submitButton.BackColor = Color.MidnightBlue;
            submitButton.FlatAppearance.BorderColor = Color.MidnightBlue;
            submitButton.FlatAppearance.BorderSize = 0;
            submitButton.FlatStyle = FlatStyle.Flat;
            submitButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            submitButton.ForeColor = Color.White;
            submitButton.Location = new Point(258, 149);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(161, 34);
            submitButton.TabIndex = 10;
            submitButton.Text = "Submit Guess";
            submitButton.UseVisualStyleBackColor = false;
            // 
            // clearAllButton
            // 
            clearAllButton.BackColor = Color.MidnightBlue;
            clearAllButton.FlatAppearance.BorderColor = Color.MidnightBlue;
            clearAllButton.FlatAppearance.BorderSize = 0;
            clearAllButton.FlatStyle = FlatStyle.Flat;
            clearAllButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            clearAllButton.ForeColor = Color.White;
            clearAllButton.Location = new Point(119, 149);
            clearAllButton.Name = "clearAllButton";
            clearAllButton.Size = new Size(103, 34);
            clearAllButton.TabIndex = 9;
            clearAllButton.Text = "Clear All";
            clearAllButton.UseVisualStyleBackColor = false;
            // 
            // colourLabel
            // 
            colourLabel.AutoSize = true;
            colourLabel.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            colourLabel.ForeColor = Color.White;
            colourLabel.Location = new Point(10, 16);
            colourLabel.Name = "colourLabel";
            colourLabel.Size = new Size(154, 24);
            colourLabel.TabIndex = 20;
            colourLabel.Text = "Colour Choices\r\n";
            // 
            // greenCircleButton
            // 
            greenCircleButton.BackColor = Color.Lime;
            greenCircleButton.FlatStyle = FlatStyle.Popup;
            greenCircleButton.ForeColor = Color.Lime;
            greenCircleButton.Location = new Point(148, 47);
            greenCircleButton.Name = "greenCircleButton";
            greenCircleButton.Size = new Size(40, 40);
            greenCircleButton.TabIndex = 3;
            greenCircleButton.Tag = "4";
            greenCircleButton.UseVisualStyleBackColor = false;
            // 
            // redCircleButton
            // 
            redCircleButton.BackColor = Color.Red;
            redCircleButton.FlatStyle = FlatStyle.Popup;
            redCircleButton.ForeColor = Color.Red;
            redCircleButton.Location = new Point(10, 47);
            redCircleButton.Name = "redCircleButton";
            redCircleButton.Size = new Size(40, 40);
            redCircleButton.TabIndex = 0;
            redCircleButton.Tag = "1";
            redCircleButton.UseVisualStyleBackColor = false;
            // 
            // yellowCircleButton
            // 
            yellowCircleButton.BackColor = Color.Yellow;
            yellowCircleButton.FlatStyle = FlatStyle.Popup;
            yellowCircleButton.ForeColor = Color.Yellow;
            yellowCircleButton.Location = new Point(102, 47);
            yellowCircleButton.Name = "yellowCircleButton";
            yellowCircleButton.Size = new Size(40, 40);
            yellowCircleButton.TabIndex = 2;
            yellowCircleButton.Tag = "3";
            yellowCircleButton.UseVisualStyleBackColor = false;
            // 
            // blueCircleButton
            // 
            blueCircleButton.BackColor = Color.DodgerBlue;
            blueCircleButton.FlatStyle = FlatStyle.Popup;
            blueCircleButton.ForeColor = Color.DodgerBlue;
            blueCircleButton.Location = new Point(56, 47);
            blueCircleButton.Name = "blueCircleButton";
            blueCircleButton.Size = new Size(40, 40);
            blueCircleButton.TabIndex = 1;
            blueCircleButton.Tag = "2";
            blueCircleButton.UseVisualStyleBackColor = false;
            // 
            // mastermindOutputPanel
            // 
            mastermindOutputPanel.BorderStyle = BorderStyle.FixedSingle;
            mastermindOutputPanel.Controls.Add(submitedLabel);
            mastermindOutputPanel.Controls.Add(clueLabel);
            mastermindOutputPanel.ForeColor = Color.White;
            mastermindOutputPanel.Location = new Point(1, 67);
            mastermindOutputPanel.Name = "mastermindOutputPanel";
            mastermindOutputPanel.Padding = new Padding(2);
            mastermindOutputPanel.Size = new Size(596, 627);
            mastermindOutputPanel.TabIndex = 1;
            // 
            // submitedLabel
            // 
            submitedLabel.AutoSize = true;
            submitedLabel.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            submitedLabel.ForeColor = Color.White;
            submitedLabel.Location = new Point(94, 18);
            submitedLabel.Name = "submitedLabel";
            submitedLabel.Size = new Size(94, 16);
            submitedLabel.TabIndex = 23;
            submitedLabel.Text = "Submited pegs\r\n";
            // 
            // clueLabel
            // 
            clueLabel.AutoSize = true;
            clueLabel.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            clueLabel.ForeColor = Color.White;
            clueLabel.Location = new Point(5, 2);
            clueLabel.Name = "clueLabel";
            clueLabel.Size = new Size(37, 32);
            clueLabel.TabIndex = 22;
            clueLabel.Text = "Clue \r\npegs\r\n";
            // 
            // quitButton
            // 
            quitButton.BackColor = Color.MidnightBlue;
            quitButton.FlatAppearance.BorderColor = Color.MidnightBlue;
            quitButton.FlatAppearance.BorderSize = 0;
            quitButton.FlatStyle = FlatStyle.Flat;
            quitButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            quitButton.ForeColor = Color.White;
            quitButton.Location = new Point(515, 5);
            quitButton.Name = "quitButton";
            quitButton.Size = new Size(70, 44);
            quitButton.TabIndex = 8;
            quitButton.Text = "Quit";
            quitButton.UseVisualStyleBackColor = false;
            quitButton.Click += quitButton_Click;
            // 
            // secretPanel
            // 
            secretPanel.BorderStyle = BorderStyle.FixedSingle;
            secretPanel.Controls.Add(secretLabel);
            secretPanel.Controls.Add(helpButton);
            secretPanel.Controls.Add(quitButton);
            secretPanel.Location = new Point(1, 3);
            secretPanel.Name = "secretPanel";
            secretPanel.Padding = new Padding(2);
            secretPanel.Size = new Size(596, 58);
            secretPanel.TabIndex = 2;
            secretPanel.Paint += secretPanel_Paint;
            // 
            // secretLabel
            // 
            secretLabel.AutoSize = true;
            secretLabel.BackColor = Color.FromArgb(74, 48, 19);
            secretLabel.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            secretLabel.ForeColor = Color.White;
            secretLabel.Location = new Point(5, 17);
            secretLabel.Name = "secretLabel";
            secretLabel.Size = new Size(49, 32);
            secretLabel.TabIndex = 24;
            secretLabel.Text = "Secret \r\n pegs";
            // 
            // helpButton
            // 
            helpButton.BackColor = Color.MidnightBlue;
            helpButton.FlatAppearance.BorderColor = Color.MidnightBlue;
            helpButton.FlatAppearance.BorderSize = 0;
            helpButton.FlatStyle = FlatStyle.Flat;
            helpButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            helpButton.ForeColor = Color.White;
            helpButton.Location = new Point(384, 5);
            helpButton.Name = "helpButton";
            helpButton.Size = new Size(125, 44);
            helpButton.TabIndex = 9;
            helpButton.Text = "Help Menu";
            helpButton.UseVisualStyleBackColor = false;
            // 
            // Board
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(74, 48, 19);
            ClientSize = new Size(600, 918);
            Controls.Add(secretPanel);
            Controls.Add(mastermindOutputPanel);
            Controls.Add(userInputPanel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Board";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Board";
            userInputPanel.ResumeLayout(false);
            userInputPanel.PerformLayout();
            mastermindOutputPanel.ResumeLayout(false);
            mastermindOutputPanel.PerformLayout();
            secretPanel.ResumeLayout(false);
            secretPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel userInputPanel;
        private Panel mastermindOutputPanel;
        private Button submitButton;
        private Button clearAllButton;
        private Button quitButton;
        private Label colourLabel;
        private Panel secretPanel;
        private Label pegGuessLabel;
        private CircleButtons redCircleButton;
        private CircleButtons blackCircleButton;
        private CircleButtons greenCircleButton;
        private CircleButtons yellowCircleButton;
        private CircleButtons blueCircleButton;
        private CircleButtons pinkCircleButton;
        private CircleButtons purpleCircleButton;
        private CircleButtons whiteCircleButton;
        private Button helpButton;
        private Label clueLabel;
        private Label submitedLabel;
        private Label secretLabel;
        private Button clearButton;
    }
}