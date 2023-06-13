using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;

namespace ImprovedMastermind
{
    public class MastermindGame
    {
        private bool winstate;
        private int codeLength;
        private int[] secretCode;
        private static string[,]? cluePegStore;
        private readonly SolidBrush grayBrush = new SolidBrush(Color.Gray);
        private readonly SolidBrush redBrush = new SolidBrush(Color.Red);
        private readonly SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
        private readonly SolidBrush blueBrush = new SolidBrush(Color.DodgerBlue);
        private readonly SolidBrush pinkBrush = new SolidBrush(Color.Fuchsia);
        private readonly SolidBrush greenBrush = new SolidBrush(Color.Lime);
        private readonly SolidBrush purpleBrush = new SolidBrush(Color.Purple);
        private readonly SolidBrush blackBrush = new SolidBrush(Color.Black);
        private readonly SolidBrush whiteBrush = new SolidBrush(Color.White);
        private Random randomGenerator;

        public int AttemptsLeft { get; private set; }
        public int CodeLength { get { return codeLength; } }

        public MastermindGame(int codeLength, int maxAttempts)
        {
            this.codeLength = codeLength;
            AttemptsLeft = maxAttempts;
            secretCode = new int[codeLength];
            randomGenerator = new Random();
            cluePegStore = new string[codeLength, maxAttempts];

            GenerateSecretCode();
        }

        public bool CheckWinState()
        {
            return winstate;
        }

        public void SubmitGuess(int[] guess)
        {
            // Implement logic to compare guess with secret code and update winstate and AttemptsLeft accordingly.
        }

        private void GenerateSecretCode()
        {
            for (int i = 0; i < secretCode.Length; i++)
            {
                secretCode[i] = randomGenerator.Next(1, 9);
            }
        }

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

        public void AddUserPeg(int[] userPegs, int pegValue)
        {
            int index = Array.IndexOf(userPegs, 0);
            if (index != -1)
            {
                userPegs[index] = pegValue;
            }
        }

        public void DrawCluePegs(Graphics graphics, int startX, int startY, int endIndex, int rowIndex)
        {
            
            for (int i = 0; i < endIndex; i++)
            {
                switch (cluePegStore[i, rowIndex])
                {
                    case "Red":
                        graphics.FillEllipse(redBrush, startX, startY, 10, 10);
                        break;

                    case "White":
                        graphics.FillEllipse(whiteBrush, startX, startY, 10, 10);
                        break;

                    default:
                        graphics.FillEllipse(grayBrush, startX, startY, 10, 10);
                        break;
                }
                startX += 10;
            }
        }
        
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
    }
}
