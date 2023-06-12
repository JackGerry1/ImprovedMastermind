using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImprovedMastermind
{
    public partial class Board : Form
    {
        private MastermindGame model;

        // Move the brush declarations to the view class.
        private SolidBrush outputBrush = new(Color.Gray);
        private readonly SolidBrush grayBrush = new(Color.Gray);
        private int[] userPegs; // Add userPegs array
        private int userPegsArrayCounter = 0; // Add userPegsArrayCounter array
        private int maxGuessLength = 4;

        public Board()
        {
            InitializeComponent();

            // Assign codeLength and attemptsLeft, in this case 4 long secret code and 10 attemptsLeft 
            model = new MastermindGame(4, 10);
            userPegs = new int[4]; // Initialize userPegs array
        }

        private void secretPanel_Paint(object sender, PaintEventArgs e)
        {
            // Retrieve game state from the model via the controller.
            bool winstate = model.CheckWinState();
            int attemptsLeft = model.AttemptsLeft;

            ControlPaint.DrawBorder(e.Graphics, secretPanel.ClientRectangle, Color.White, ButtonBorderStyle.Solid);

            int xcoords = 60;
            Graphics secretCodeGraphics = e.Graphics;

            for (int i = 0; i < model.CodeLength; i++)
            {
                if (winstate || attemptsLeft == 0)
                {
                    outputBrush = model.GetColorBrush(i);
                }

                secretCodeGraphics.FillEllipse(outputBrush, xcoords, 15, 30, 30);
                outputBrush = grayBrush;
                xcoords += 40;
            }
        }

        // Quit Button
        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void userInputPanel_Paint(object sender, PaintEventArgs e)
        {
            // Draw a rectangle border around the userInputPanel control
            ControlPaint.DrawBorder(e.Graphics, userInputPanel.ClientRectangle, Color.White, ButtonBorderStyle.Solid);

            // Get the Graphics object for the userInputPegs
            Graphics userInputPegsGraphics = e.Graphics;

            // Initialize x-coordinate for drawing the ellipses
            int xcoords = 241;

            // Loop through each element in the user pegs array
            for (int i = 0; i < model.CodeLength; i++)
            {
                // Determine the brush color based on the user pegs value
                int pegValue = userPegs[i];
                SolidBrush outputBrush = pegValue == 0 ? grayBrush : model.GetUserPegColorBrush(pegValue);

                // Fill an ellipse with the current brush color at the current x-coordinate
                userInputPegsGraphics.FillEllipse(outputBrush, xcoords, 75, 35, 35);

                // Displays the next peg 40px to the right.
                xcoords += 40;
            }
        }

        private void ColorCircleButton_Click(object sender, EventArgs e)
        {
            if (userPegsArrayCounter >= maxGuessLength)
            {
                // Display a message box informing the user that the guess row is full
                MessageBox.Show("The guess row is full. Please submit your guess or clear and re-enter.", "Guess Row Full", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Button colorButton = (Button)sender;
            int colorValue = Convert.ToInt32(colorButton.Tag);

            model.AddUserPeg(userPegs, colorValue);

            // Increment the counter for user pegs array
            userPegsArrayCounter++;

            userInputPanel.Refresh();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            if (userPegsArrayCounter == 0)
            {
                // Display a message box informing the user that there are no pegs to clear
                MessageBox.Show("There are no pegs to clear.", "Empty Guess", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Remove one peg from the end of the array
                userPegsArrayCounter--;
                userPegs[userPegsArrayCounter] = 0;
                userInputPanel.Refresh();
            }
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            if (userPegsArrayCounter == 0)
            {
                // Display a message box informing the user that there is nothing to clear
                MessageBox.Show("There are no guesses to clear.", "Empty Guess Row", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Clear the user's guesses
                userPegsArrayCounter = 0;
                for (int i = 0; i < userPegs.Length; i++)
                {
                    userPegs[i] = 0;
                }
                userInputPanel.Refresh();
            }
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            InheritedHelpMenu inheritedHelpMenu = new();
            inheritedHelpMenu.Show();
        }
        /* TODO LIST

1. CREATE MASTERMIND OUTPUT, SO DISPLAY GRAY PEGS AND CLUE PEGS
2. TAKE USERS PEGS AND DISPLAY THEM CORRECTLY ON THE MASTERMIND OUTPUT PANEL
3. IMPLEMENT THE CLUE PEG ALGORTHIM AND DISPLAY CLUE PEGS RESULTS
4. CREATE WIN AND LOSE CONDITIONS, SO KEEP TRACK OF GUESSES, IMPLEMENT WIN AND LOSE SCREENS FROM PREVIOUS GAME
5. CHANGE THE CONSTANT GUESS ATTEMPTS AND CODELENGTH USING THE FORM CREATED IN THE OLD MASTERMIND GAME
6. ADD MAIN MENU FROM OLD GAME
7. ADD HELP MENUS FROM THE OLD GAME

*/
        // Add event handlers for submitting guesses and updating the UI accordingly.
    }
}
