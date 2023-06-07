using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImprovedMastermind
{

    public class GameController
    {
        private MastermindGame game;

        public GameController(int codeLength, int maxAttempts)
        {
            game = new MastermindGame(codeLength, maxAttempts);
        }

        public void SubmitGuess(int[] guess)
        {
            game.SubmitGuess(guess);
            // Update the view based on the game state.
        }
    }

}
