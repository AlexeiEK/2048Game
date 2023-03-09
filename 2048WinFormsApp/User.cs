namespace _2048WinFormsApp
{
    public class User
    {
        public string Name;
        public int Score;

        public void AcceptScore(int score)
        {
            Score = score;
        }
    }
}
