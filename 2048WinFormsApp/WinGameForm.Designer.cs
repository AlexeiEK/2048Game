namespace _2048WinFormsApp
{
    partial class WinGameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            restartWinGameButton = new Button();
            exitWinGameButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 39);
            label1.Name = "label1";
            label1.Size = new Size(435, 31);
            label1.TabIndex = 0;
            label1.Text = "Поздравляю! Вы одержали победу!!!";
            // 
            // restartWinGameButton
            // 
            restartWinGameButton.ForeColor = SystemColors.ActiveCaptionText;
            restartWinGameButton.Location = new Point(31, 94);
            restartWinGameButton.Name = "restartWinGameButton";
            restartWinGameButton.Size = new Size(159, 23);
            restartWinGameButton.TabIndex = 1;
            restartWinGameButton.Text = "Попробуем ещё раз?";
            restartWinGameButton.UseVisualStyleBackColor = true;
            restartWinGameButton.Click += restartWinGameButton_Click;
            // 
            // exitWinGameButton
            // 
            exitWinGameButton.ForeColor = SystemColors.ActiveCaptionText;
            exitWinGameButton.Location = new Point(257, 94);
            exitWinGameButton.Name = "exitWinGameButton";
            exitWinGameButton.Size = new Size(143, 23);
            exitWinGameButton.TabIndex = 2;
            exitWinGameButton.Text = "ВЫЙТИ";
            exitWinGameButton.UseVisualStyleBackColor = true;
            exitWinGameButton.Click += exitWinGameButton_Click;
            // 
            // WinGameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 138);
            Controls.Add(exitWinGameButton);
            Controls.Add(restartWinGameButton);
            Controls.Add(label1);
            ForeColor = Color.Red;
            Name = "WinGameForm";
            Text = "WinGameForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button restartWinGameButton;
        private Button exitWinGameButton;
    }
}