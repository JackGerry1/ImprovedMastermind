namespace ImprovedMastermind
{
    public partial class InheritedHelpMenu : HelpMenu
    {
        public InheritedHelpMenu()
        {
            InitializeComponent();
            // overrides text, width and location of the back button, so it is different from the super class.
            backButton.Text = "Back To Mastermind Game";
            backButton.Width = 475;
            backButton.Location = new Point(122, 629);

        }
        /// <summary>
        /// Calls overriden Back Method when the button is clicked.
        /// </summary>
        protected void backMainMenuButtonClick(object sender, EventArgs e)
        {
            Back();
        }
        /// <summary>
        /// Overrides the Back Menu, so it only hides the InheritedHelpMenu.
        /// Doesn't create a new instance of any form, therefore keeping the current state of the Board Form.
        /// </summary>
        protected override void Back()
        {
            Hide();
        }
    }
}
