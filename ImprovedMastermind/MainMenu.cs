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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Board board = new();
            board.Show();
            Hide();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            HelpMenu helpMenu = new();
            helpMenu.Show();
            Hide();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
