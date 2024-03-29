﻿namespace ImprovedMastermind
{
    public class MastermindGame
    {
        private bool winstate;
        private int codeLength;
        private int[] secretCode;
        private List<string>[,] cluePegStore;
        private static string[]? cluePegs;
        private readonly SolidBrush grayBrush = new SolidBrush(Color.Gray);
        private readonly SolidBrush redBrush = new SolidBrush(Color.Red);
        private readonly SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
        private readonly SolidBrush blueBrush = new SolidBrush(Color.DodgerBlue);
        private readonly SolidBrush pinkBrush = new SolidBrush(Color.Fuchsia);
        private readonly SolidBrush greenBrush = new SolidBrush(Color.Lime);
        private readonly SolidBrush purpleBrush = new SolidBrush(Color.Indigo);
        private readonly SolidBrush blackBrush = new SolidBrush(Color.Black);
        private readonly SolidBrush whiteBrush = new SolidBrush(Color.White);
        private Random randomGenerator;

        public int AttemptsLeft { get; set; }
        public int GuessCount { get; set; }
        public int GuessRowPositionTracker { get; set; }
        public int CodeLength { get { return codeLength; } }

        public Board DrawPegs
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// Initializes a new instance of the MastermindGame class with the specified codeLength and maxAttempts.
        /// </summary>
        /// <param name="codeLength">The length of the secret code.</param>
        /// <param name="maxAttempts">The maximum number of attempts allowed.</param>
        public MastermindGame(int codeLength, int maxAttempts)
        {
            this.codeLength = codeLength;
            AttemptsLeft = maxAttempts;
            GuessCount = maxAttempts;
            GuessRowPositionTracker = maxAttempts - 1;
            secretCode = new int[codeLength];
            randomGenerator = new Random();
            cluePegStore = new List<string>[codeLength, maxAttempts];
            cluePegs = new string[codeLength];

            GenerateSecretCode();
        }
        /// <summary>
        /// Checks the current win state of the game.
        /// </summary>
        /// <returns>True if the game is in a win state, otherwise false.</returns>
        public bool CheckWinState()
        {
            return winstate;
        }

        /// <summary>
        /// Generates a secret code by assigning random values to each element of the secretCode array.
        /// </summary>
        private void GenerateSecretCode()
        {
            for (int i = 0; i < secretCode.Length; i++)
            {
                secretCode[i] = randomGenerator.Next(1, 9);
            }
        }

        /// <summary>
        /// Gets the color brush corresponding to the code value at the specified index in the secretCode.
        /// </summary>
        /// <param name="index">The index of the secretCode array.</param>
        /// <returns>The color brush associated with the code value.</returns>
        public SolidBrush GetColorBrush(int index)
        {
            int codeValue = secretCode[index];
            return codeValue switch
            {
                1 => redBrush,
                2 => blueBrush,
                3 => yellowBrush,
                4 => greenBrush,
                5 => purpleBrush,
                6 => pinkBrush,
                7 => whiteBrush,
                8 => blackBrush,
                _ => grayBrush,
            };
        }

        /// <summary>
        /// Gets the color brush corresponding to the user peg value.
        /// </summary>
        /// <param name="pegValue">The value of the user peg.</param>
        /// <returns>The color brush associated with the user peg value.</returns>
        public SolidBrush GetUserPegColorBrush(int pegValue)
        {
            return pegValue switch
            {
                1 => redBrush,
                2 => blueBrush,
                3 => yellowBrush,
                4 => greenBrush,
                5 => purpleBrush,
                6 => pinkBrush,
                7 => whiteBrush,
                8 => blackBrush,
                _ => grayBrush,
            };
        }

        /// <summary>
        /// Adds a user peg to the userPegs array at the first available index.
        /// </summary>
        /// <param name="userPegs">The array of user pegs.</param>
        /// <param name="pegValue">The value of the peg to be added.</param>
        public void AddUserPeg(int[] userPegs, int pegValue)
        {
            int indexUser = Array.IndexOf(userPegs, 0);

            if (indexUser != -1)
            {
                userPegs[indexUser] = pegValue;
            }
        }

        /// <summary>
        /// Draws the clue pegs on the graphics object based on the cluePegStore array.
        /// </summary>
        /// <param name="graphics">The graphics object on which to draw the clue pegs.</param>
        /// <param name="startX">The starting X-coordinate for drawing the clue pegs.</param>
        /// <param name="startY">The starting Y-coordinate for drawing the clue pegs.</param>
        /// <param name="endIndex">The end index of the clue pegs to be drawn.</param>
        /// <param name="rowIndex">The index of the current row.</param>
        public void DrawCluePegs(Graphics graphics, int startX, int startY, int endIndex, int rowIndex)
        {
            int rowCount = 0; // Keep track of the current row count
            int columnCount = 0; // Keep track of the current column count

            for (int i = 0; i < endIndex; i++)
            {
                // Calculate the position for the current clue peg
                int x = startX + (columnCount * 10);
                int y = startY + (rowCount * 10);

                if (cluePegStore[i, rowIndex] != null && cluePegStore[i, rowIndex].Count > 0)
                {
                    switch (cluePegStore[i, rowIndex][0])
                    {
                        case "Red":
                            graphics.FillEllipse(redBrush, x, y, 10, 10);
                            break;

                        case "White":
                            graphics.FillEllipse(whiteBrush, x, y, 10, 10);
                            break;

                        default:
                            graphics.FillEllipse(grayBrush, x, y, 10, 10);
                            break;
                    }

                    // Increment the column count
                    columnCount++;
                }
                else
                {
                    // If no clue peg is present, display a gray peg
                    graphics.FillEllipse(grayBrush, x, y, 10, 10);

                    // Increment the column count
                    columnCount++;
                }

                // Check if the maximum number of columns is reached
                if (columnCount >= codeLength / 2)
                {
                    // Reset the column count and increment the row count
                    columnCount = 0;
                    rowCount++;
                }
            }
        }

        /// <summary>
        /// Draws the submitted pegs on the graphics object based on the submittedPegStore array.
        /// </summary>
        /// <param name="graphics">The graphics object on which to draw the submitted pegs.</param>
        /// <param name="startX">The starting X-coordinate for drawing the submitted pegs.</param>
        /// <param name="startY">The starting Y-coordinate for drawing the submitted pegs.</param>
        /// <param name="attemptsLeft">The number of attempts left.</param>
        /// <param name="codeLength">The length of the code.</param>
        /// <param name="submittedPegStore">The array storing the submitted pegs.</param>
        /// <param name="grayBrush">The color brush for the gray peg.</param>
        /// <param name="getUserPegColorBrush">A function to get the color brush for user pegs.</param>
        public void DrawSubmittedPegs(Graphics graphics, int startX, int startY, int attemptsLeft, int codeLength, int[,] submittedPegStore, SolidBrush grayBrush, Func<int, Brush> getUserPegColorBrush)
        {
            for (int i = 0; i < attemptsLeft; i++)
            {
                for (int j = 0; j < codeLength; j++)
                {
                    int pegValue = submittedPegStore[j, i];
                    Brush outputBrush = pegValue == 0 ? grayBrush : getUserPegColorBrush(pegValue);

                    // Draw the ellipse on the submittedPegsGraphics object
                    graphics.FillEllipse(outputBrush, startX, startY, 32, 32);
                    startX += 40;
                }
                startX = 65;
                startY += 35;
            }
        }
        /// <summary>
        /// Updates the mastermind panel by evaluating the submitted pegs and updating the clue pegs.
        /// </summary>
        /// <param name="userPegs">The array of user pegs.</param>
        /// <param name="submittedPegs">The array of submitted pegs.</param>
        /// <param name="submittedPegStore">The array storing the submitted pegs for each guess.</param>
        public void UpdateMastermindPanel(int[] userPegs, int[] submittedPegs, int[,] submittedPegStore)
        {
            bool[] redVisited = new bool[CodeLength];
            bool[] whiteVisited = new bool[CodeLength];
            int redHits = 0;
            int whiteHits = 0;

            for (int i = 0; i < CodeLength; i++)
            {
                userPegs[i] = 0;
                submittedPegStore[i, GuessRowPositionTracker] = submittedPegs[i];
            }

            // Find the gray pegs (incorrect color and incorrect index)
            for (int i = 0; i < secretCode.Length; i++)
            {
                if (submittedPegs[i] != secretCode[i])
                {
                    cluePegs[i] = "Gray";
                }
            }

            // Find red pegs (correct color and correct index)
            for (int i = 0; i < secretCode.Length; i++)
            {

                if (submittedPegs[i] == secretCode[i])
                {
                    // Increment red peg counter and mark element as visited in red visited array
                    redHits++;
                    redVisited[i] = true;
                    cluePegs[i] = "Red";
                    continue;
                }
            }

            // Find white pegs (correct color, incorrect index).
            for (int i = 0; i < secretCode.Length; i++)
            {
                // Skip any elements that have already been counted as red pegs, to avoid duplicates.
                if (redVisited[i])
                {
                    continue;
                }

                // Nested loop to find matching elements in the secret code array
                for (int j = 0; j < secretCode.Length; j++)
                {
                    // Skip this iteration if the indices are the same
                    if (j == i)
                    {
                        continue;
                    }

                    // If the secret code peg has not been marked as visited in either the red or white visited arrays
                    // As well as matching the submited Peg.
                    if (!redVisited[j] && !whiteVisited[j] && secretCode[j] == submittedPegs[i])
                    {
                        whiteHits++;
                        whiteVisited[j] = true;
                        cluePegs[i] = "White";
                        break;
                    }
                }
            }

            // Shuffle the red and white pegs, so that the user cannot infer what position the submitted pegs correspond to.
            var shuffledCluePegs = cluePegs.OrderBy(a => Guid.NewGuid()).ToList();

            // Store the red and white pegs in the cluePegStore array.
            for (int i = 0; i < secretCode.Length; i++)
            {
                cluePegStore[i, GuessRowPositionTracker] = new List<string> { shuffledCluePegs[i] };
            }

            if (redHits == CodeLength)
            {
                winstate = true;
                Board board = new Board();
                _ = board.Win();

            }
            else
            {
                GuessRowPositionTracker--;
            }
        }
    }
}