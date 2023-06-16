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
            Board board = new();
            int attempts = model.AttemptsRight--;
            if (!model.CheckWinState() && attempts == 0)
            {
                _ = board.Lose();
            }
        }
    }

}
