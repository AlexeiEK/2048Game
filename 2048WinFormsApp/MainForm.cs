using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace _2048WinFormsApp
{
    public partial class MainForm : Form
    {
        private const int labelSize = 70;
        private const int padding = 6;
        private const int startX = 10;
        private const int startY = 70;

        private Label[,] labelsMap;
        private int mapSize = 4;
        private static Random random = new Random();
        private static string pathFile = "hiScore.json";
        private int score = 0;
        private int hiScore = GetHiScore(pathFile);
        private User user = new User();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var greetingsForm = new GreetingsForm();
            greetingsForm.ShowDialog();
            user.Name = greetingsForm.userNameTextBox.Text;

            CalculateMapSize(greetingsForm.radioButtons);
            InitMap();
            GenerateNumber();
            GenerateNumber();
            ShowScore();
        }

        private void CalculateMapSize(List<RadioButton> radioButtons)
        {
            foreach (RadioButton radioButton in radioButtons)
            {
                if (radioButton.Checked)
                {
                    mapSize = Convert.ToInt32(radioButton.Text[0].ToString());
                    break;
                }
            }
        }
        private void ShowScore()
        {
            scoreLabel.Text = score.ToString();
            hiScoreLabel.Text = hiScore.ToString();
        }

        private int СalculatHiScore(int hiScore, int score)
        {
            if (hiScore < score)
            {
                hiScore = score;
                SaveHiScore(hiScore, pathFile);
            }
            return hiScore;
        }

        private void InitMap()
        {
            ClientSize = new Size(startX + (labelSize + padding) * mapSize, startY + (labelSize + padding) * mapSize);
            labelsMap = new Label[mapSize, mapSize];
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    var newLabel = CreateLabel(i, j);
                    Controls.Add(newLabel);
                    labelsMap[i, j] = newLabel;
                }
            }
        }
        private void GenerateNumber()
        {
            while (true)
            {
                var randomNumberLabel = random.Next(mapSize * mapSize);
                var indexRow = randomNumberLabel / mapSize;
                var indexColumn = randomNumberLabel % mapSize;

                if (labelsMap[indexRow, indexColumn].Text == String.Empty)
                {
                    var randTextLabel = new Random();

                    if (randTextLabel.NextDouble() < 0.75)
                    {
                        labelsMap[indexRow, indexColumn].Text = "2";
                    }
                    else
                    {
                        labelsMap[indexRow, indexColumn].Text = "4";
                    }
                    break;
                }
            }
        }

        private Label CreateLabel(int indexRow, int indexColumn)
        {
            var label = new Label();
            label.BackColor = SystemColors.ButtonShadow;
            label.Size = new Size(labelSize, labelSize);
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Font = new Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            var x = startX + indexColumn * (labelSize + padding);
            var y = startY + indexRow * (labelSize + padding);
            label.Location = new Point(x, y);
            label.TextChanged += Label_TextChanged;
            return label;
        }

        private void Label_TextChanged(object? sender, EventArgs e)
        {
            var label = (Label)sender;
            switch (label.Text)
            {
                case "": label.BackColor = SystemColors.ButtonShadow; break;
                case "2": label.BackColor = Color.FromArgb(238, 228, 218); break;
                case "4": label.BackColor = Color.FromArgb(237, 224, 200); break;
                case "8": label.BackColor = Color.FromArgb(242, 177, 121); break;
                case "16": label.BackColor = Color.FromArgb(245, 149, 99); break;
                case "32": label.BackColor = Color.FromArgb(246, 124, 95); break;
                case "64": label.BackColor = Color.FromArgb(246, 94, 59); break;
                case "128": label.BackColor = Color.FromArgb(237, 207, 114); break;
                case "256": label.BackColor = Color.FromArgb(237, 204, 97); break;
                case "512": label.BackColor = Color.FromArgb(237, 200, 80); break;
                case "1024": label.BackColor = Color.FromArgb(52, 235, 79); break;
                case "2048": label.BackColor = Color.FromArgb(235, 52, 52); break;
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Right && e.KeyCode != Keys.Down && e.KeyCode != Keys.Up && e.KeyCode != Keys.Left)
            {
                return;
            }
            if (e.KeyCode == Keys.Right)
            {
                KeyProcessingRight();
            }
            if (e.KeyCode == Keys.Left)
            {
                KeyProcessingLeft();
            }
            if (e.KeyCode == Keys.Up)
            {
                KeyProcessingUp();
            }
            if (e.KeyCode == Keys.Down)
            {
                KeyProcessingDown();
            }
            ShowScore();

            if (Win())
            {
                user.AcceptScore(score);
                UserStorage.Append(user);
                var winGameForm = new WinGameForm();
                winGameForm.ShowDialog();
                return;
            }

            if (EndGame())
            {
                user.AcceptScore(score);
                UserStorage.Append(user);
                var endGameForm = new EndGameForm();
                endGameForm.ShowDialog();
                return;
            }
        }
        private void KeyProcessingDown()
        {
            var flag = false;
            for (int j = 0; j < mapSize; j++)
            {
                for (int i = mapSize - 1; i >= 0; i--)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    score += number * 2;
                                    hiScore = СalculatHiScore(hiScore, score);
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    labelsMap[k, j].Text = string.Empty;
                                }
                                break;
                            }

                        }
                    }
                }

            }

            for (int j = 0; j < mapSize; j++)
            {
                for (int i = mapSize - 1; i >= 0; i--)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[k, j].Text;
                                labelsMap[k, j].Text = string.Empty;
                                flag = true;
                                break;
                            }

                        }
                    }
                }
            }
            if (flag)
            {
                GenerateNumber();
            }
        }

        private void KeyProcessingUp()
        {
            var flag = false;
            for (int j = 0; j < mapSize; j++)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = i + 1; k < mapSize; k++)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    score += number * 2;
                                    hiScore = СalculatHiScore(hiScore, score);
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    labelsMap[k, j].Text = string.Empty;
                                }
                                break;
                            }

                        }
                    }
                }
            }

            for (int j = 0; j < mapSize; j++)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = i + 1; k < mapSize; k++)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[k, j].Text;
                                labelsMap[k, j].Text = string.Empty;
                                flag = true;
                                break;
                            }

                        }
                    }
                }
            }
            if (flag)
            {
                GenerateNumber();
            }
        }

        private void KeyProcessingLeft()
        {
            var flag = false;
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = j + 1; k < mapSize; k++)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    score += number * 2;
                                    hiScore = СalculatHiScore(hiScore, score);
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    labelsMap[i, k].Text = string.Empty;
                                }
                                break;
                            }

                        }
                    }
                }

            }

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = j + 1; k < mapSize; k++)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[i, k].Text;
                                labelsMap[i, k].Text = string.Empty;
                                flag = true;
                                break;
                            }

                        }
                    }
                }
            }
            if (flag)
            {
                GenerateNumber();
            }
        }

        private void KeyProcessingRight()
        {
            var flag = false;
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = mapSize - 1; j >= 0; j--)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    score += number * 2;
                                    hiScore = СalculatHiScore(hiScore, score);
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    labelsMap[i, k].Text = string.Empty;
                                }
                                break;
                            }

                        }
                    }
                }
            }

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = mapSize - 1; j >= 0; j--)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[i, k].Text;
                                labelsMap[i, k].Text = string.Empty;
                                flag = true;
                                break;
                            }

                        }
                    }
                }
            }
            if (flag)
            {
                GenerateNumber();
            }
        }

        private bool EndGame()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text == "")
                    {
                        return false;
                    }
                }
            }

            for (int i = 0; i < mapSize - 1; i++)
            {
                for (int j = 0; j < mapSize - 1; j++)
                {
                    if (labelsMap[i, j].Text == labelsMap[i, j + 1].Text || labelsMap[i, j].Text == labelsMap[i + 1, j].Text)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private bool Win()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text == "2048")
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static void SaveHiScore(int hiScore, string pathFile)
        {
            var jsonData = JsonConvert.SerializeObject(hiScore, Formatting.Indented);
            FileProvider.Replace(pathFile, jsonData);
        }


        public static int GetHiScore(string pathFile)
        {
            int hiScore;

            if (!FileProvider.Exists(pathFile))
            {
                return hiScore = 0;
            }

            var fileData = FileProvider.GetValue(pathFile);
            hiScore = JsonConvert.DeserializeObject<int>(fileData);
            return hiScore;
        }

        private void правилаИгрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Используйте клавиши вверх/вниз/вправо/влево, чтобы переместить плитки! " +
                "Когда совпадут две плитки с одинаковым числом, они сольются в число в два раза больше номинала. " +
                "Для победы необходимо собрать число 2048!" +
                " Успехов в игре!");
        }

        private void выйтиИзИгрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user.AcceptScore(score);
            UserStorage.Append(user);
            Application.Exit();
        }

        private void перезапуститьИгруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void результатыИгрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var resultsForm = new ResultsForm();
            resultsForm.ShowDialog();
        }
    }
}