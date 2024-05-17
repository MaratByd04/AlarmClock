namespace AlarmProject
{
    partial class NewAlarmCreationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewAlarmCreationForm));
            alarmDateTimePicker = new DateTimePicker();
            alarmNameTextBox = new TextBox();
            alarmRepeatComboBox = new ComboBox();
            alarmRepeatTypeComboBox = new ComboBox();
            cancelButton = new Button();
            createButton = new Button();
            SuspendLayout();
            // 
            // alarmDateTimePicker
            // 
            alarmDateTimePicker.Format = DateTimePickerFormat.Time;
            alarmDateTimePicker.Location = new Point(58, 70);
            alarmDateTimePicker.Name = "alarmDateTimePicker";
            alarmDateTimePicker.ShowUpDown = true;
            alarmDateTimePicker.Size = new Size(254, 23);
            alarmDateTimePicker.TabIndex = 0;
            // 
            // alarmNameTextBox
            // 
            alarmNameTextBox.Location = new Point(58, 121);
            alarmNameTextBox.Name = "alarmNameTextBox";
            alarmNameTextBox.PlaceholderText = "Введите имя будильника";
            alarmNameTextBox.Size = new Size(254, 23);
            alarmNameTextBox.TabIndex = 1;
            // 
            // alarmRepeatComboBox
            // 
            alarmRepeatComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            alarmRepeatComboBox.FormattingEnabled = true;
            alarmRepeatComboBox.Items.AddRange(new object[] { "Должен ли будильник повторяться", "Да", "Нет" });
            alarmRepeatComboBox.Location = new Point(58, 176);
            alarmRepeatComboBox.Name = "alarmRepeatComboBox";
            alarmRepeatComboBox.Size = new Size(254, 23);
            alarmRepeatComboBox.TabIndex = 2;
            // 
            // alarmRepeatTypeComboBox
            // 
            alarmRepeatTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            alarmRepeatTypeComboBox.FormattingEnabled = true;
            alarmRepeatTypeComboBox.Items.AddRange(new object[] { "Как часто должен будильник повторяться", "Однократно", "Ежедневно", "По будням", "По выходным" });
            alarmRepeatTypeComboBox.Location = new Point(58, 237);
            alarmRepeatTypeComboBox.Name = "alarmRepeatTypeComboBox";
            alarmRepeatTypeComboBox.Size = new Size(254, 23);
            alarmRepeatTypeComboBox.TabIndex = 3;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(12, 310);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(90, 35);
            cancelButton.TabIndex = 4;
            cancelButton.Text = "Отменить";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.MouseDown += cancelButton_MouseDown;
            // 
            // createButton
            // 
            createButton.Location = new Point(271, 310);
            createButton.Name = "createButton";
            createButton.Size = new Size(90, 35);
            createButton.TabIndex = 5;
            createButton.Text = "Сохранить";
            createButton.UseVisualStyleBackColor = true;
            createButton.MouseDown += createButton_MouseDown;
            // 
            // NewAlarmCreationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(373, 357);
            Controls.Add(createButton);
            Controls.Add(cancelButton);
            Controls.Add(alarmRepeatTypeComboBox);
            Controls.Add(alarmRepeatComboBox);
            Controls.Add(alarmNameTextBox);
            Controls.Add(alarmDateTimePicker);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "NewAlarmCreationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Создание нового будильника";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker alarmDateTimePicker;
        private TextBox alarmNameTextBox;
        private ComboBox alarmRepeatComboBox;
        private ComboBox alarmRepeatTypeComboBox;
        private Button cancelButton;
        private Button createButton;
    }
}