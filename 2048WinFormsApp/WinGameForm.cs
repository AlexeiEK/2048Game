namespace _2048WinFormsApp
{
    public partial class WinGameForm : Form
    {
        public WinGameForm()
        {
            InitializeComponent();
        }

        private void restartWinGameButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitWinGameButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
