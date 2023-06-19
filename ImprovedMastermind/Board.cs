using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace ImprovedMastermind
{
    public partial class Board : Form
    {
        private MastermindGame model;
        private GameController game;
        private SolidBrush outputBrush = new(Color.Gray);
        private readonly SolidBrush grayBrush = new(Color.Gray);
        private int[] userPegs;
        private int[,] submittedPegStore;
        private int userPegsArrayCounter = 0;
        private int[] submittedPegs;
        private bool isWinScreenDisplayed = false;
        private int codeLength;
        private int attemptsLeft;

        /// <summary>
        /// Initializes a new instance of the Board class.
        /// </summary>
        public Board()
        {
            InitializeComponent();

            // Retrieve codeLength and attemptsLeft from the DifficultyMenu and assign them
            codeLength = DifficultyMenu.difficultyMenu.codeLength;
            attemptsLeft = DifficultyMenu.difficultyMenu.guessNumber;

            // Create instances of the MastermindGame and GameController classes with the specified codeLength and attemptsLeft
            model = new MastermindGame(codeLength, attemptsLeft);
            game = new GameController(codeLength, attemptsLeft);

            // Initialize the userPegs, submittedPegs, and submittedPegStore arrays with the appropriate sizes
            userPegs = new int[model.CodeLength];
            submittedPegs = new int[model.CodeLength];
            submittedPegStore = new int[model.CodeLength, model.AttemptsLeft];
        }

        /// <summary>
        /// Paints the secret panel by drawing the secret code circles based on the game state.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The PaintEventArgs.</param>
        private void secretPanel_Paint(object sender, PaintEventArgs e)
        {
            // Retrieve game state from the model via the controller.
            bool winstate = model.CheckWinState();
            int attemptsLeft = game.GetAttemptsLeft();

            ControlPaint.DrawBorder(e.Graphics, secretPanel.ClientRectangle, Color.White, ButtonBorderStyle.Solid);

            int xcoords = 60;
            Graphics secretCodeGraphics = e.Graphics;

            // Loop through each position in the secret code
            for (int i = 0; i < model.CodeLength; i++)
            {
                if (winstate || attemptsLeft == 0)
                {
                    outputBrush = model.GetColorBrush(i); // Get the brush color for the secret code
                    DisableElements(); // Disable game elements
                    BoardHide(); // Hide the board
                }

                ////UNCOMMENT THIS IF YOU WANT TO SEE THE SECRET CODE BEFORE THE GAME HAS FINISHED.
                //outputBrush = model.GetColorBrush(i); // Get the brush color for the secret code

                secretCodeGraphics.FillEllipse(outputBrush, xcoords, 15, 30, 30); // Draw a filled ellipse representing the secret code
                outputBrush = grayBrush; // Reset the brush color to gray for the next position
                xcoords += 40;
            }
        }
        /// <summary>
        /// Paints the user input panel by drawing the user pegs based on their values.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The PaintEventArgs.</param>
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


        /// <summary>
        /// Paints the mastermind output panel by drawing clue pegs and submitted pegs.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="pegs">The PaintEventArgs.</param>
        private void mastermindOutputPanel_Paint(object sender, PaintEventArgs pegs)
        {
            // Draw a border around the mastermindOutputPanel control
            ControlPaint.DrawBorder(pegs.Graphics, mastermindOutputPanel.ClientRectangle, Color.White, ButtonBorderStyle.Solid);

            // Draw the clue pegs
            Graphics cluePegGraphics = pegs.Graphics;
            int x = 10;
            int y = 50;
            Pen whitePen = new Pen(Color.White);
            cluePegGraphics.DrawRectangle(whitePen, 5, 40, 50, 565);

            for (int i = 0; i < model.AttemptsLeft; i++)
            {
                // Draw the clue pegs for the current attempt
                model.DrawCluePegs(cluePegGraphics, x, y, model.CodeLength, i);

                // Reset the x and y coordinates for the next row of clue pegs
                x = 10;
                y += 10;
                y += 25;
            }

            // Draw the current user inputs and draw the rows and columns for the submitted pegs.
            Graphics submittedPegsGraphics = pegs.Graphics;
            y = 45;
            x = 65;
            int startX = 65;
            int startY = 45;

            // Draw the submitted pegs, including the current user inputs and the rows and columns for the submitted pegs
            model.DrawSubmittedPegs(submittedPegsGraphics, startX, startY, model.AttemptsLeft, model.CodeLength, submittedPegStore, grayBrush, model.GetUserPegColorBrush);
        }
        /// <summary>
        /// Handles the event when a color circle button is clicked and updates the user's peg selection.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The EventArgs.</param>
        private void ColorCircleButton_Click(object sender, EventArgs e)
        {
            if (userPegsArrayCounter < model.CodeLength)
            {
                Button colorButton = (Button)sender;
                int colorValue = Convert.ToInt32(colorButton.Tag);

                model.AddUserPeg(userPegs, colorValue);
                submittedPegs[userPegsArrayCounter] = colorValue;

                // Increment the counter for user pegs array
                userPegsArrayCounter++;

                userInputPanel.Refresh();
            }
        }

        /// <summary>
        /// Handles the event when the clear button is clicked and removes the last user peg.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The EventArgs.</param>
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

        /// <summary>
        /// Handles the event when the clear all button is clicked and clears all user guesses.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The EventArgs.</param>
        private void clearAllButton_Click(object sender, EventArgs e)
        {
            if (userPegsArrayCounter == 0)
            {
                // Display a message box informing the user that there are no guesses to clear
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

        /// <summary>
        /// Handles the event when the submit button is clicked and processes the user's guess.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The EventArgs.</param>
        private async void submitButton_Click(object sender, EventArgs e)
        {
            if (userPegsArrayCounter == model.CodeLength)
            {
                userPegsArrayCounter = 0;
                model.UpdateMastermindPanel(userPegs, submittedPegs, submittedPegStore);
                game.CountDown();
                mastermindOutputPanel.Refresh(); // Refresh the mastermindOutputPanel
                userInputPanel.Refresh(); // Refresh the userInputPanel
                secretPanel.Refresh();

                // Check if the game is won
                bool isGameWon = model.CheckWinState();

                if (isGameWon)
                {
                    // Call the Win method to display the win screen
                    await Win();
                }
                else if (!isGameWon)
                {
                    // Call the Lose method to display the lose screen
                    await Lose();
                }
            }
            else
            {
                string title = "Submit Button Error";
                string message = "Please fill the entire row before submitting your guess";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Handles the click event of the helpButton, displaying an inherited help menu.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The EventArgs.</param>
        private void helpButton_Click(object sender, EventArgs e)
        {
            InheritedHelpMenu inheritedHelpMenu = new();
            inheritedHelpMenu.Show();
        }

        /// <summary>
        /// Event handler for the click event of the quit button. Terminates the application.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The EventArgs.</param>
        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Disables various elements on the game board to prevent user interaction.
        /// </summary>
        private void DisableElements()
        {
            submitButton.Enabled = false;
            clearAllButton.Enabled = false;
            redCircleButton.Enabled = false;
            blueCircleButton.Enabled = false;
            yellowCircleButton.Enabled = false;
            greenCircleButton.Enabled = false;
            pinkCircleButton.Enabled = false;
            purpleCircleButton.Enabled = false;
            whiteCircleButton.Enabled = false;
            blackCircleButton.Enabled = false;
            helpButton.Enabled = false;
            quitButton.Enabled = false;
            clearButton.Enabled = false;
        }

        /// <summary>
        /// Hides the game board after a delay, creating a smooth transition.
        /// </summary>
        private async void BoardHide()
        {
            await Task.Delay(3000);
            Hide();
        }

        /// <summary>
        /// Displays the lose screen if the game is lost.
        /// </summary>
        /// <returns>A Task representing the asynchronous operation.</returns>
        public async Task Lose()
        {
            if (!isWinScreenDisplayed && !model.CheckWinState() && game.GetAttemptsLeft() == 0)
            {
                await Task.Delay(3000);
                LoseScreen loseScreen = new LoseScreen();
                loseScreen.Show();
                isWinScreenDisplayed = true; // Set the flag to prevent the win screen from being displayed
            }
        }

        /// <summary>
        /// Displays the win screen if the game is won.
        /// </summary>
        /// <returns>A Task representing the asynchronous operation. The result is true if the win screen is displayed; otherwise, false.</returns>
        public async Task<bool> Win()
        {
            if (!isWinScreenDisplayed && model.CheckWinState())
            {
                await Task.Delay(3000);
                WinScreen winScreen = new WinScreen();
                winScreen.Show();
                isWinScreenDisplayed = true; // Set the flag to prevent the win screen from being displayed again
            }
            return isWinScreenDisplayed;
        }


    }
}

