namespace _2048WinFormsApp
{
    partial class EndGameForm
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
            restartButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(89, 37);
            label1.Name = "label1";
            label1.Size = new Size(293, 28);
            label1.TabIndex = 0;
            label1.Text = "Сожалею, но Вы проиграли!";
            // 
            // restartButton
            // 
            restartButton.Location = new Point(50, 97);
            restartButton.Name = "restartButton";
            restartButton.Size = new Size(136, 23);
            restartButton.TabIndex = 1;
            restartButton.Text = "Сыграем ещё?";
            restartButton.UseVisualStyleBackColor = true;
            restartButton.Click += restartButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(268, 97);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(134, 23);
            exitButton.TabIndex = 2;
            exitButton.Text = "Выйти из игры!";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // EndGameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 147);
            Controls.Add(exitButton);
            Controls.Add(restartButton);
            Controls.Add(label1);
            Name = "EndGameForm";
            Text = "Конец игры";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button restartButton;
        private Button exitButton;
    }
}