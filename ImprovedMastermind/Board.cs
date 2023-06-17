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

        // Move the brush declarations to the view class.
        private SolidBrush outputBrush = new(Color.Gray);
        private readonly SolidBrush grayBrush = new(Color.Gray);
        private int[] userPegs; // Add userPegs array
        private int[,] submittedPegStore;
        private int userPegsArrayCounter = 0; // Add userPegsArrayCounter array
        private int[] submittedPegs;
        private bool isWinScreenDisplayed = false;
        private int codeLength;
        private int attemptsLeft;

        public Board()
        {
            InitializeComponent();
            codeLength = DifficultyMenu.difficultyMenu.codeLength;
            attemptsLeft = DifficultyMenu.difficultyMenu.guessNumber;
            // Assign codeLength and attemptsLeft, in this case 4 long secret code and 10 attemptsLeft 
            model = new MastermindGame(codeLength, attemptsLeft);
            game = new GameController(codeLength, attemptsLeft);
            userPegs = new int[model.CodeLength]; // Initialize userPegs array
            submittedPegs = new int[model.CodeLength];
            submittedPegStore = new int[model.CodeLength, model.AttemptsLeft];
            submittedPegs = new int[model.CodeLength];

        }

        private void secretPanel_Paint(object sender, PaintEventArgs e)
        {
            // Retrieve game state from the model via the controller.
            bool winstate = model.CheckWinState();
            int attemptsLeft = game.GetAttemptsLeft();

            ControlPaint.DrawBorder(e.Graphics, secretPanel.ClientRectangle, Color.White, ButtonBorderStyle.Solid);

            int xcoords = 60;
            Graphics secretCodeGraphics = e.Graphics;
            Console.WriteLine("secret attempts " + attemptsLeft);
            Console.WriteLine("secret " + winstate);
            for (int i = 0; i < model.CodeLength; i++)
            {
                if (winstate || attemptsLeft == 0)
                {
                    outputBrush = model.GetColorBrush(i);
                    DisableElements();
                    BoardHide();
                }

                ////UNCOMMENT THIS IF YOU WANT TO SEE THE SECRET CODE BEFORE THE GAME HAS FINISHED.
                //outputBrush = model.GetColorBrush(i);

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
                model.DrawCluePegs(cluePegGraphics, x, y, model.CodeLength, i);
                x = 10;
                y += 10;
                y += 25;
            }

            // Draw the current user inputs and draw the rows and columns for the submited pegs.
            Graphics submitedPegsGraphics = pegs.Graphics;
            y = 45;
            x = 65;
            int startX = 65;
            int startY = 45;

            model.DrawSubmittedPegs(submitedPegsGraphics, startX, startY, model.AttemptsLeft, model.CodeLength, submittedPegStore, grayBrush, model.GetUserPegColorBrush);
        }

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
                bool isLastAttempt = game.GetAttemptsLeft() == 0;

                if (isGameWon)
                {
                    // Call the Win method to display the win screen
                    await Win();
                }
                else if (!isGameWon && isLastAttempt)
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


        private void helpButton_Click(object sender, EventArgs e)
        {
            InheritedHelpMenu inheritedHelpMenu = new();
            inheritedHelpMenu.Show();

        }
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
        private async void BoardHide()
        {
            await Task.Delay(3000);
            Hide();
        }

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
