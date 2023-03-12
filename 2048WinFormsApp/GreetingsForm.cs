namespace _2048WinFormsApp
{
    public partial class GreetingsForm : Form
    {
        public List<RadioButton> radioButtons;
        public GreetingsForm()
        {
            InitializeComponent();
            radioButtons = new List<RadioButton>
            {
           radioButton1, radioButton2, radioButton3, radioButton4
            };
        }
        private void startGameButton_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "")
            {
                MessageBox.Show("Для продолжения, обязательно введите Ваше имя!");
            }
            else
            {
                Close();
            }
        }

        private void userNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char input = e.KeyChar;

            if (!Char.IsLetter(input) && input == 32)
            {
                e.Handled = true;
            }
        }
    }
}