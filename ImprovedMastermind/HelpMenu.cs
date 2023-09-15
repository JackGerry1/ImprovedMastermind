namespace ImprovedMastermind
{
    public partial class HelpMenu : Form
    {
        public HelpMenu()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Back();
        }

        protected virtual void Back()
        {
            MainMenu mainMenu = new();
            mainMenu.Show();
            Hide();
        }
    }
}
