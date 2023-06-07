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
    public partial class Board : Form
    {
        private MastermindGame model;

        // Move the brush declarations to the view class.
        private SolidBrush outputBrush = new(Color.Gray);
        private readonly SolidBrush grayBrush = new(Color.Gray);

        public Board()
        {
            InitializeComponent();

            // Assign codeLength and attemptsLeft, in this case 4 long secret code and 10 attemptsLeft 
            model = new MastermindGame(4, 10);
        }

        private void secretPanel_Paint(object sender, PaintEventArgs e)
        {
            // Retrieve game state from the model via the controller.
            bool winstate = model.CheckWinState();
            int attemptsLeft = model.AttemptsLeft;

            ControlPaint.DrawBorder(e.Graphics, secretPanel.ClientRectangle, Color.White, ButtonBorderStyle.Solid);

            int xcoords = 60;
            Graphics secretCodeGraphics = e.Graphics;

            for (int i = 0; i < model.CodeLength; i++)
            {
                if (winstate || attemptsLeft == 0)
                {
                    outputBrush = model.GetColorBrush(i);
                }

                secretCodeGraphics.FillEllipse(outputBrush, xcoords, 15, 30, 30);
                outputBrush = grayBrush;
                xcoords += 40;
            }
        }

        // Quit Button
        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // Add event handlers for submitting guesses and updating the UI accordingly.
    }
}
