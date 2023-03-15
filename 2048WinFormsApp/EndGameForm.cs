namespace _2048WinFormsApp
{
    public partial class EndGameForm : Form
    {
        public EndGameForm()
        {
            InitializeComponent();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
