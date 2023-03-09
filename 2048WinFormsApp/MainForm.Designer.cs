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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правилаИгрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перезапуститьИгруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиИзИгрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.результатыИгрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.hiScoreLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.результатыИгрыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(317, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.правилаИгрыToolStripMenuItem,
            this.перезапуститьИгруToolStripMenuItem,
            this.выйтиИзИгрыToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // правилаИгрыToolStripMenuItem
            // 
            this.правилаИгрыToolStripMenuItem.Name = "правилаИгрыToolStripMenuItem";
            this.правилаИгрыToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.правилаИгрыToolStripMenuItem.Text = "Правила игры";
            this.правилаИгрыToolStripMenuItem.Click += new System.EventHandler(this.правилаИгрыToolStripMenuItem_Click);
            // 
            // перезапуститьИгруToolStripMenuItem
            // 
            this.перезапуститьИгруToolStripMenuItem.Name = "перезапуститьИгруToolStripMenuItem";
            this.перезапуститьИгруToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.перезапуститьИгруToolStripMenuItem.Text = "Перезапустить игру";
            this.перезапуститьИгруToolStripMenuItem.Click += new System.EventHandler(this.перезапуститьИгруToolStripMenuItem_Click);
            // 
            // выйтиИзИгрыToolStripMenuItem
            // 
            this.выйтиИзИгрыToolStripMenuItem.Name = "выйтиИзИгрыToolStripMenuItem";
            this.выйтиИзИгрыToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.выйтиИзИгрыToolStripMenuItem.Text = "Выйти из игры";
            this.выйтиИзИгрыToolStripMenuItem.Click += new System.EventHandler(this.выйтиИзИгрыToolStripMenuItem_Click);
            // 
            // результатыИгрыToolStripMenuItem
            // 
            this.результатыИгрыToolStripMenuItem.Name = "результатыИгрыToolStripMenuItem";
            this.результатыИгрыToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.результатыИгрыToolStripMenuItem.Text = "Результаты игры";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Счёт:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(178, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Рекорд:";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(272, 24);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(13, 15);
            this.scoreLabel.TabIndex = 3;
            this.scoreLabel.Text = "0";
            // 
            // hiScoreLabel
            // 
            this.hiScoreLabel.AutoSize = true;
            this.hiScoreLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.hiScoreLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hiScoreLabel.Location = new System.Drawing.Point(272, 39);
            this.hiScoreLabel.Name = "hiScoreLabel";
            this.hiScoreLabel.Size = new System.Drawing.Size(23, 28);
            this.hiScoreLabel.TabIndex = 4;
            this.hiScoreLabel.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 374);
            this.Controls.Add(this.hiScoreLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Игра 2048";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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