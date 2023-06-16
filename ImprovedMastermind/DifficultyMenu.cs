using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImprovedMastermind
{
    public partial class DifficultyMenu : Form
    {
        // Allows forms to create instances of the difficultyMenu.
        public static DifficultyMenu difficultyMenu;
        // Allows codeLength to be accessed from other forms.
        public int codeLength;
        // Allows guessNumber to be accessed from other forms.
        public int guessNumber;
        public DifficultyMenu()
        {
            InitializeComponent();
            difficultyMenu = this;

        }
        public Board Board
        {
            get => default;
            set
            {
            }
        }
        private void playButton_Click(object sender, EventArgs e)
        {
            if ((guessNumber == 8 || guessNumber == 10 || guessNumber == 12 || guessNumber == 14 || guessNumber == 16) && (codeLength == 4 || codeLength == 6 || codeLength == 8))
            {
                Hide();
                Board board = new();
                board.Show();
            }
            else
            {
                string title = "Play Button Error";
                string message = "Please only enter numbers that are available for each combo box";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void secretCodeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tempSecret;

            // Get the selected value in the secretCodeComboBox and parse it to an integer
            tempSecret = int.Parse(secretCodeComboBox.Text);

            // Set the value of codeLength based on the selected value in the secretCodeComboBox
            codeLength = tempSecret switch
            {
                4 => 4,
                6 => 6,
                8 => 8,
                _ => 4,
            };
        }
        private void guessComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tempGuess;

            tempGuess = int.Parse(guessComboBox.Text);

            // Depending on what the user selected the corresponding value will be assigned.
            guessNumber = tempGuess switch
            {
                8 => 8,
                10 => 10,
                12 => 12,
                14 => 14,
                16 => 16,
                _ => 10,
            };
        }
        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
