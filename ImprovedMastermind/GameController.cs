using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImprovedMastermind
{

    public class GameController
    {
        private MastermindGame model;

        /// <summary>
        /// Initializes a new instance of the GameController class with the specified code length and maximum attempts.
        /// </summary>
        /// <param name="codeLength">The length of the secret code.</param>
        /// <param name="maxAttempts">The maximum number of attempts allowed.</param>
        public GameController(int codeLength, int maxAttempts)
        {
            model = new MastermindGame(codeLength, maxAttempts);
        }

        /// <summary>
        /// Gets the number of attempts left.
        /// </summary>
        /// <returns>The number of attempts left.</returns>
        public int GetAttemptsLeft()
        {
            return model.GuessCount;
        }

        /// <summary>
        /// Decrements the number of attempts left and checks for a win or loss condition.
        /// If the player runs out of attempts without winning, it triggers the lose screen.
        /// </summary>
        public void CountDown()
        {
            Board board = new Board();
            model.GuessCount--;

            if (!model.CheckWinState() && model.GuessCount == 0)
            {
                _ = board.Lose();
            }
        }
    }

}
