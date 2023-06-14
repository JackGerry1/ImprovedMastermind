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

        public GameController(int codeLength, int maxAttempts)
        {
            model = new MastermindGame(codeLength, maxAttempts);
        }

        public void SubmitGuess(int[] guess)
        {
            model.SubmitGuess(guess);
            // Update the view based on the game state.
        }
        public void CountDown()
        {
            int attempts = model.AttemptsLeft;
            attempts--;
            model.AttemptsLeft = attempts; // Update the AttemptsLeft 

            if (attempts == 0)
            {
                MessageBox.Show("Game Over, You Lose", "Lose Screen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

}
