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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.AlogorithmComboBox = new System.Windows.Forms.ComboBox();
            this.alogorithmLabel = new System.Windows.Forms.Label();
            this.PointCountLabel = new System.Windows.Forms.Label();
            this.PointCountTextBox = new System.Windows.Forms.TextBox();
            this.CoreCountLabel = new System.Windows.Forms.Label();
            this.CoreCountTextBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.StepListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Linen;
            this.mainPanel.Location = new System.Drawing.Point(130, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(670, 450);
            this.mainPanel.TabIndex = 0;
            // 
            // AlogorithmComboBox
            // 
            this.AlogorithmComboBox.BackColor = System.Drawing.Color.Linen;
            this.AlogorithmComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AlogorithmComboBox.DropDownWidth = 124;
            this.AlogorithmComboBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AlogorithmComboBox.FormattingEnabled = true;
            this.AlogorithmComboBox.Location = new System.Drawing.Point(3, 275);
            this.AlogorithmComboBox.Name = "AlogorithmComboBox";
            this.AlogorithmComboBox.Size = new System.Drawing.Size(125, 23);
            this.AlogorithmComboBox.TabIndex = 1;
            this.AlogorithmComboBox.SelectedIndexChanged += new System.EventHandler(this.AlogorithmComboBox_SelectedIndexChanged);
            // 
            // alogorithmLabel
            // 
            this.alogorithmLabel.AllowDrop = true;
            this.alogorithmLabel.AutoSize = true;
            this.alogorithmLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alogorithmLabel.Location = new System.Drawing.Point(9, 257);
            this.alogorithmLabel.Name = "alogorithmLabel";
            this.alogorithmLabel.Size = new System.Drawing.Size(61, 15);
            this.alogorithmLabel.TabIndex = 2;
            this.alogorithmLabel.Text = "Алгоритм";
            // 
            // PointCountLabel
            // 
            this.PointCountLabel.AutoSize = true;
            this.PointCountLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PointCountLabel.Location = new System.Drawing.Point(9, 310);
            this.PointCountLabel.Name = "PointCountLabel";
            this.PointCountLabel.Size = new System.Drawing.Size(104, 15);
            this.PointCountLabel.TabIndex = 3;
            this.PointCountLabel.Text = "Количество точек";
            // 
            // PointCountTextBox
            // 
            this.PointCountTextBox.BackColor = System.Drawing.Color.Linen;
            this.PointCountTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PointCountTextBox.Location = new System.Drawing.Point(3, 328);
            this.PointCountTextBox.Name = "PointCountTextBox";
            this.PointCountTextBox.Size = new System.Drawing.Size(125, 23);
            this.PointCountTextBox.TabIndex = 4;
            this.PointCountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // CoreCountLabel
            // 
            this.CoreCountLabel.AutoSize = true;
            this.CoreCountLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CoreCountLabel.Location = new System.Drawing.Point(9, 359);
            this.CoreCountLabel.Name = "CoreCountLabel";
            this.CoreCountLabel.Size = new System.Drawing.Size(119, 15);
            this.CoreCountLabel.TabIndex = 5;
            this.CoreCountLabel.Text = "Количество центров";
            // 
            // CoreCountTextBox
            // 
            this.CoreCountTextBox.BackColor = System.Drawing.Color.Linen;
            this.CoreCountTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CoreCountTextBox.Location = new System.Drawing.Point(3, 377);
            this.CoreCountTextBox.Name = "CoreCountTextBox";
            this.CoreCountTextBox.Size = new System.Drawing.Size(125, 23);
            this.CoreCountTextBox.TabIndex = 6;
            this.CoreCountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.Color.Linen;
            this.CalculateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CalculateButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculateButton.Location = new System.Drawing.Point(3, 415);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(124, 23);
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
            this.StepListBox.Size = new System.Drawing.Size(122, 244);
            this.StepListBox.TabIndex = 8;
            this.StepListBox.SelectedIndexChanged += new System.EventHandler(this.StepListBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StepListBox);
            this.Controls.Add(this.alogorithmLabel);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.CoreCountTextBox);
            this.Controls.Add(this.CoreCountLabel);
            this.Controls.Add(this.PointCountTextBox);
            this.Controls.Add(this.PointCountLabel);
            this.Controls.Add(this.AlogorithmComboBox);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Распознование образов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ComboBox AlogorithmComboBox;
        private System.Windows.Forms.Label alogorithmLabel;
        private System.Windows.Forms.Label PointCountLabel;
        private System.Windows.Forms.TextBox PointCountTextBox;
        private System.Windows.Forms.Label CoreCountLabel;
        private System.Windows.Forms.TextBox CoreCountTextBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.ListBox StepListBox;
    }
}

