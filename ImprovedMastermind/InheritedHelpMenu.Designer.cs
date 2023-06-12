namespace ImprovedMastermind
{
    partial class InheritedHelpMenu
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
            quitButton = new Button();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.FlatAppearance.BorderColor = Color.MidnightBlue;
            backButton.FlatAppearance.BorderSize = 0;
            
            // 
            // quitButton
            // 
            quitButton.BackColor = Color.MidnightBlue;
            quitButton.FlatAppearance.BorderColor = Color.MidnightBlue;
            quitButton.FlatAppearance.BorderSize = 0;
            quitButton.FlatStyle = FlatStyle.Flat;
            quitButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            quitButton.ForeColor = Color.White;
            quitButton.Location = new Point(606, 12);
            quitButton.Name = "quitButton";
            quitButton.Size = new Size(70, 44);
            quitButton.TabIndex = 12;
            quitButton.Text = "Quit";
            quitButton.UseVisualStyleBackColor = false;
            // 
            // InheritedHelpMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 685);
            Name = "InheritedHelpMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button quitButton;
    }
}