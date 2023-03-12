namespace _2048WinFormsApp
{
    partial class GreetingsForm
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
            startGameButton = new Button();
            label1 = new Label();
            label2 = new Label();
            userNameTextBox = new TextBox();
            sizeLabel = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            SuspendLayout();
            // 
            // startGameButton
            // 
            startGameButton.Font = new Font("Segoe UI", 30.75F, FontStyle.Bold, GraphicsUnit.Point);
            startGameButton.Location = new Point(24, 171);
            startGameButton.Name = "startGameButton";
            startGameButton.Size = new Size(441, 89);
            startGameButton.TabIndex = 0;
            startGameButton.Text = "Начнём? Успехов!";
            startGameButton.UseVisualStyleBackColor = true;
            startGameButton.Click += startGameButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(24, 9);
            label1.Name = "label1";
            label1.Size = new Size(441, 38);
            label1.TabIndex = 1;
            label1.Text = "Приветствую Вас в игре 2048";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(24, 62);
            label2.Name = "label2";
            label2.Size = new Size(259, 38);
            label2.TabIndex = 2;
            label2.Text = "Введите Ваше имя:";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(319, 77);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(176, 23);
            userNameTextBox.TabIndex = 3;
            userNameTextBox.KeyPress += userNameTextBox_KeyPress;
            // 
            // sizeLabel
            // 
            sizeLabel.AutoSize = true;
            sizeLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            sizeLabel.Location = new Point(135, 114);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new Size(172, 20);
            sizeLabel.TabIndex = 4;
            sizeLabel.Text = "Размер игрового поля";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.Location = new Point(35, 137);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(55, 24);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "4X4";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton2.Location = new Point(124, 137);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(55, 24);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "5X5";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton3.Location = new Point(237, 137);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(55, 24);
            radioButton3.TabIndex = 7;
            radioButton3.TabStop = true;
            radioButton3.Text = "6X6";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton4.Location = new Point(340, 137);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(55, 24);
            radioButton4.TabIndex = 8;
            radioButton4.TabStop = true;
            radioButton4.Text = "7X7";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // GreetingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 292);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(sizeLabel);
            Controls.Add(userNameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(startGameButton);
            Name = "GreetingsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startGameButton;
        private Label label1;
        private Label label2;
        public TextBox userNameTextBox;
        private Label sizeLabel;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
    }
}