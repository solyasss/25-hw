namespace hw

{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            start_button = new Button();
            exit_button = new Button();
            title_label = new Label();
            instruction_label = new Label();
            SuspendLayout();
            
            start_button.BackColor = Color.Pink;
            start_button.Location = new Point(100, 150);
            start_button.Name = "start_button";
            start_button.Size = new Size(100, 30);
            start_button.TabIndex = 0;
            start_button.Text = "Start game";
            start_button.UseVisualStyleBackColor = false;
            start_button.Click += start_button_Click;
           
            exit_button.BackColor = Color.Salmon;
            exit_button.Location = new Point(220, 150);
            exit_button.Name = "exit_button";
            exit_button.Size = new Size(100, 30);
            exit_button.TabIndex = 1;
            exit_button.Text = "Exit";
            exit_button.UseVisualStyleBackColor = false;
            exit_button.Click += exit_button_Click;
            
            title_label.AutoSize = true;
            title_label.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            title_label.Location = new Point(83, 31);
            title_label.Name = "title_label";
            title_label.Size = new Size(305, 37);
            title_label.TabIndex = 2;
            title_label.Text = "Game guess number";
            
            instruction_label.AutoSize = true;
            instruction_label.Location = new Point(60, 80);
            instruction_label.Name = "instruction_label";
            instruction_label.Size = new Size(367, 20);
            instruction_label.TabIndex = 3;
            instruction_label.Text = "Press start and imagine number from 1 to 100";
           
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(420, 220);
            Controls.Add(instruction_label);
            Controls.Add(title_label);
            Controls.Add(exit_button);
            Controls.Add(start_button);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Guess number";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label instruction_label;
    }
}
