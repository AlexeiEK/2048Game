namespace _2048WinFormsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            менюToolStripMenuItem = new ToolStripMenuItem();
            правилаИгрыToolStripMenuItem = new ToolStripMenuItem();
            перезапуститьИгруToolStripMenuItem = new ToolStripMenuItem();
            выйтиИзИгрыToolStripMenuItem = new ToolStripMenuItem();
            результатыИгрыToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            scoreLabel = new Label();
            hiScoreLabel = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { менюToolStripMenuItem, результатыИгрыToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(317, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            менюToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { правилаИгрыToolStripMenuItem, перезапуститьИгруToolStripMenuItem, выйтиИзИгрыToolStripMenuItem });
            менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            менюToolStripMenuItem.Size = new Size(53, 20);
            менюToolStripMenuItem.Text = "Меню";
            // 
            // правилаИгрыToolStripMenuItem
            // 
            правилаИгрыToolStripMenuItem.Name = "правилаИгрыToolStripMenuItem";
            правилаИгрыToolStripMenuItem.Size = new Size(183, 22);
            правилаИгрыToolStripMenuItem.Text = "Правила игры";
            правилаИгрыToolStripMenuItem.Click += правилаИгрыToolStripMenuItem_Click;
            // 
            // перезапуститьИгруToolStripMenuItem
            // 
            перезапуститьИгруToolStripMenuItem.Name = "перезапуститьИгруToolStripMenuItem";
            перезапуститьИгруToolStripMenuItem.Size = new Size(183, 22);
            перезапуститьИгруToolStripMenuItem.Text = "Перезапустить игру";
            перезапуститьИгруToolStripMenuItem.Click += перезапуститьИгруToolStripMenuItem_Click;
            // 
            // выйтиИзИгрыToolStripMenuItem
            // 
            выйтиИзИгрыToolStripMenuItem.Name = "выйтиИзИгрыToolStripMenuItem";
            выйтиИзИгрыToolStripMenuItem.Size = new Size(183, 22);
            выйтиИзИгрыToolStripMenuItem.Text = "Выйти из игры";
            выйтиИзИгрыToolStripMenuItem.Click += выйтиИзИгрыToolStripMenuItem_Click;
            // 
            // результатыИгрыToolStripMenuItem
            // 
            результатыИгрыToolStripMenuItem.Name = "результатыИгрыToolStripMenuItem";
            результатыИгрыToolStripMenuItem.Size = new Size(112, 20);
            результатыИгрыToolStripMenuItem.Text = "Результаты игры";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(178, 24);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 1;
            label1.Text = "Счёт:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveBorder;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(178, 39);
            label2.Name = "label2";
            label2.Size = new Size(65, 21);
            label2.TabIndex = 2;
            label2.Text = "Рекорд:";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Location = new Point(272, 24);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(13, 15);
            scoreLabel.TabIndex = 3;
            scoreLabel.Text = "0";
            // 
            // hiScoreLabel
            // 
            hiScoreLabel.AutoSize = true;
            hiScoreLabel.BackColor = SystemColors.ActiveBorder;
            hiScoreLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hiScoreLabel.Location = new Point(272, 39);
            hiScoreLabel.Name = "hiScoreLabel";
            hiScoreLabel.Size = new Size(19, 21);
            hiScoreLabel.TabIndex = 4;
            hiScoreLabel.Text = "0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 374);
            Controls.Add(hiScoreLabel);
            Controls.Add(scoreLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Игра 2048";
            Load += MainForm_Load;
            KeyDown += MainForm_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem менюToolStripMenuItem;
        private ToolStripMenuItem правилаИгрыToolStripMenuItem;
        private ToolStripMenuItem перезапуститьИгруToolStripMenuItem;
        private ToolStripMenuItem выйтиИзИгрыToolStripMenuItem;
        private ToolStripMenuItem результатыИгрыToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label scoreLabel;
        private Label hiScoreLabel;
    }
}