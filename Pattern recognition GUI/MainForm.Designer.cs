namespace Pattern_recognition_GUI
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AlgorithmComboBox = new System.Windows.Forms.ComboBox();
            this.alogorithmLabel = new System.Windows.Forms.Label();
            this.DotCountLabel = new System.Windows.Forms.Label();
            this.DotCountTextBox = new System.Windows.Forms.TextBox();
            this.CoreCountLabel = new System.Windows.Forms.Label();
            this.CoreCountTextBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.StepListBox = new System.Windows.Forms.ListBox();
            this.MainPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AlgorithmComboBox
            // 
            this.AlgorithmComboBox.BackColor = System.Drawing.Color.Linen;
            this.AlgorithmComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AlgorithmComboBox.DropDownWidth = 124;
            this.AlgorithmComboBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AlgorithmComboBox.FormattingEnabled = true;
            this.AlgorithmComboBox.Location = new System.Drawing.Point(4, 382);
            this.AlgorithmComboBox.Name = "AlgorithmComboBox";
            this.AlgorithmComboBox.Size = new System.Drawing.Size(142, 23);
            this.AlgorithmComboBox.TabIndex = 1;
            this.AlgorithmComboBox.SelectedIndexChanged += new System.EventHandler(this.AlogorithmComboBox_SelectedIndexChanged);
            // 
            // alogorithmLabel
            // 
            this.alogorithmLabel.AllowDrop = true;
            this.alogorithmLabel.AutoSize = true;
            this.alogorithmLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alogorithmLabel.Location = new System.Drawing.Point(10, 364);
            this.alogorithmLabel.Name = "alogorithmLabel";
            this.alogorithmLabel.Size = new System.Drawing.Size(61, 15);
            this.alogorithmLabel.TabIndex = 2;
            this.alogorithmLabel.Text = "Алгоритм";
            // 
            // DotCountLabel
            // 
            this.DotCountLabel.AutoSize = true;
            this.DotCountLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DotCountLabel.Location = new System.Drawing.Point(10, 417);
            this.DotCountLabel.Name = "DotCountLabel";
            this.DotCountLabel.Size = new System.Drawing.Size(104, 15);
            this.DotCountLabel.TabIndex = 3;
            this.DotCountLabel.Text = "Количество точек";
            // 
            // DotCountTextBox
            // 
            this.DotCountTextBox.BackColor = System.Drawing.Color.Linen;
            this.DotCountTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DotCountTextBox.Location = new System.Drawing.Point(4, 435);
            this.DotCountTextBox.Name = "DotCountTextBox";
            this.DotCountTextBox.Size = new System.Drawing.Size(142, 23);
            this.DotCountTextBox.TabIndex = 4;
            this.DotCountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // CoreCountLabel
            // 
            this.CoreCountLabel.AutoSize = true;
            this.CoreCountLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CoreCountLabel.Location = new System.Drawing.Point(10, 466);
            this.CoreCountLabel.Name = "CoreCountLabel";
            this.CoreCountLabel.Size = new System.Drawing.Size(119, 15);
            this.CoreCountLabel.TabIndex = 5;
            this.CoreCountLabel.Text = "Количество центров";
            // 
            // CoreCountTextBox
            // 
            this.CoreCountTextBox.BackColor = System.Drawing.Color.Linen;
            this.CoreCountTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CoreCountTextBox.Location = new System.Drawing.Point(4, 484);
            this.CoreCountTextBox.Name = "CoreCountTextBox";
            this.CoreCountTextBox.Size = new System.Drawing.Size(142, 23);
            this.CoreCountTextBox.TabIndex = 6;
            this.CoreCountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.Color.Linen;
            this.CalculateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CalculateButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculateButton.Location = new System.Drawing.Point(4, 522);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(142, 23);
            this.CalculateButton.TabIndex = 7;
            this.CalculateButton.Text = "Вычислить";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // StepListBox
            // 
            this.StepListBox.BackColor = System.Drawing.Color.Linen;
            this.StepListBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StepListBox.FormattingEnabled = true;
            this.StepListBox.ItemHeight = 15;
            this.StepListBox.Location = new System.Drawing.Point(4, 8);
            this.StepListBox.Name = "StepListBox";
            this.StepListBox.Size = new System.Drawing.Size(142, 334);
            this.StepListBox.TabIndex = 8;
            this.StepListBox.SelectedIndexChanged += new System.EventHandler(this.StepListBox_SelectedIndexChanged);
            // 
            // MainPictureBox
            // 
            this.MainPictureBox.BackColor = System.Drawing.Color.Linen;
            this.MainPictureBox.Location = new System.Drawing.Point(174, 8);
            this.MainPictureBox.Name = "MainPictureBox";
            this.MainPictureBox.Size = new System.Drawing.Size(853, 617);
            this.MainPictureBox.TabIndex = 9;
            this.MainPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1035, 632);
            this.Controls.Add(this.MainPictureBox);
            this.Controls.Add(this.StepListBox);
            this.Controls.Add(this.alogorithmLabel);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.CoreCountTextBox);
            this.Controls.Add(this.CoreCountLabel);
            this.Controls.Add(this.DotCountTextBox);
            this.Controls.Add(this.DotCountLabel);
            this.Controls.Add(this.AlgorithmComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Распознование образов";
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox AlgorithmComboBox;
        private System.Windows.Forms.Label alogorithmLabel;
        private System.Windows.Forms.Label DotCountLabel;
        private System.Windows.Forms.TextBox DotCountTextBox;
        private System.Windows.Forms.Label CoreCountLabel;
        private System.Windows.Forms.TextBox CoreCountTextBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.ListBox StepListBox;
        private System.Windows.Forms.PictureBox MainPictureBox;
    }
}

