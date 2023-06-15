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
        public int GetAttemptsLeft()
        {
            return model.AttemptsLeft;
        }

        public void CountDown()
        {
            model.AttemptsLeft--;
            if (model.AttemptsLeft == 0)
            {
                MessageBox.Show("Game Over, You Lose", "Lose Screen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        public void Win()
        {
            MessageBox.Show("Game Over, You Win", "Win Screen", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}
