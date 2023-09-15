namespace ImprovedMastermind
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        public HelpMenu HelpMenu
        {
            get => default;
            set
            {
            }
        }

        public DifficultyMenu DifficultyMenu
        {
            get => default;
            set
            {
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            DifficultyMenu difficultyMenu = new();
            difficultyMenu.Show();
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
