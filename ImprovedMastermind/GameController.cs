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
            Console.WriteLine("Attempts Right GetAttemptsLeft " + model.AttemptsRight);
            return model.AttemptsRight;
        }
        public void CountDown()
        {
            Board board = new();
            model.AttemptsRight--;
            Console.WriteLine("Attempts Right " + model.AttemptsRight);
            Console.WriteLine("countdown" + model.CheckWinState());
            if (!model.CheckWinState() && model.AttemptsRight == 0)
            {
                _ = board.Lose();
            }
        }
    }

}
