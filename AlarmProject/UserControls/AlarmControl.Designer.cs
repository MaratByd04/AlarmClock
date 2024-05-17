namespace AlarmClock
{
    partial class AlarmControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            alarmNameLabel = new Label();
            alarmTimeLabel = new Label();
            alarmRepeatLabel = new Label();
            alarmRepeatTypeLabel = new Label();
            editButton = new Button();
            alarmActivityPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)alarmActivityPictureBox).BeginInit();
            SuspendLayout();
            // 
            // alarmNameLabel
            // 
            alarmNameLabel.AutoSize = true;
            alarmNameLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            alarmNameLabel.Location = new Point(111, 23);
            alarmNameLabel.Margin = new Padding(5, 0, 5, 0);
            alarmNameLabel.Name = "alarmNameLabel";
            alarmNameLabel.Size = new Size(312, 37);
            alarmNameLabel.TabIndex = 0;
            alarmNameLabel.Text = "Название будильника";
            // 
            // alarmTimeLabel
            // 
            alarmTimeLabel.AutoSize = true;
            alarmTimeLabel.Location = new Point(119, 80);
            alarmTimeLabel.Margin = new Padding(5, 0, 5, 0);
            alarmTimeLabel.Name = "alarmTimeLabel";
            alarmTimeLabel.Size = new Size(140, 20);
            alarmTimeLabel.TabIndex = 1;
            alarmTimeLabel.Text = "Время будильника";
            // 
            // alarmRepeatLabel
            // 
            alarmRepeatLabel.AutoSize = true;
            alarmRepeatLabel.Location = new Point(119, 116);
            alarmRepeatLabel.Margin = new Padding(5, 0, 5, 0);
            alarmRepeatLabel.Name = "alarmRepeatLabel";
            alarmRepeatLabel.Size = new Size(147, 20);
            alarmRepeatLabel.TabIndex = 2;
            alarmRepeatLabel.Text = "Повтор будильника";
            // 
            // alarmRepeatTypeLabel
            // 
            alarmRepeatTypeLabel.AutoSize = true;
            alarmRepeatTypeLabel.Location = new Point(119, 148);
            alarmRepeatTypeLabel.Margin = new Padding(5, 0, 5, 0);
            alarmRepeatTypeLabel.Name = "alarmRepeatTypeLabel";
            alarmRepeatTypeLabel.Size = new Size(233, 20);
            alarmRepeatTypeLabel.TabIndex = 3;
            alarmRepeatTypeLabel.Text = "Тип повторяемости будильника";
            // 
            // editButton
            // 
            editButton.Cursor = Cursors.Hand;
            editButton.Location = new Point(447, 63);
            editButton.Margin = new Padding(3, 4, 3, 4);
            editButton.Name = "editButton";
            editButton.Size = new Size(106, 53);
            editButton.TabIndex = 4;
            editButton.Text = "Править";
            editButton.UseVisualStyleBackColor = true;
            editButton.MouseDown += ClickOnDeleteAlarmButton;
            // 
            // alarmActivityPictureBox
            // 
            alarmActivityPictureBox.BackColor = SystemColors.ControlLight;
            alarmActivityPictureBox.Cursor = Cursors.Hand;
            alarmActivityPictureBox.Location = new Point(22, 63);
            alarmActivityPictureBox.Margin = new Padding(3, 4, 3, 4);
            alarmActivityPictureBox.Name = "alarmActivityPictureBox";
            alarmActivityPictureBox.Size = new Size(65, 69);
            alarmActivityPictureBox.TabIndex = 5;
            alarmActivityPictureBox.TabStop = false;
            alarmActivityPictureBox.MouseDown += ToggleAlarmActivity;
            // 
            // AlarmControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(alarmActivityPictureBox);
            Controls.Add(editButton);
            Controls.Add(alarmRepeatTypeLabel);
            Controls.Add(alarmRepeatLabel);
            Controls.Add(alarmTimeLabel);
            Controls.Add(alarmNameLabel);
            Margin = new Padding(5, 4, 5, 4);
            Name = "AlarmControl";
            Size = new Size(596, 187);
            MouseDoubleClick += EditAlarmData;
            ((System.ComponentModel.ISupportInitialize)alarmActivityPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label alarmNameLabel;
        private System.Windows.Forms.Label alarmTimeLabel;
        private Label alarmRepeatLabel;
        private Label alarmRepeatTypeLabel;
        private Button editButton;
        private PictureBox alarmActivityPictureBox;
    }
}
