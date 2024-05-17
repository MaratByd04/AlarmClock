using AlarmProject;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace AlarmClock
{
    public partial class AlarmControl : UserControl
    {
        Alarm alarm;
        Alarm[] alarmsList;

        private void ClickOnDeleteAlarmButton(object sender, MouseEventArgs e)
        {
            var dialogResult = MessageBox.Show("Вы уверены, что хотите удалить этот будильник?",
                "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult.Equals(DialogResult.Yes))
            {
                RemoveAlarmFromList(alarm);
                UpdateJsonFile();

                if (Parent != null)
                {
                    Parent.Controls.Remove(this);
                }
            }
        }
        private void EditAlarmData(object sender, MouseEventArgs e)
        {
            var form = this.FindForm() as AlarmMainForm;

            if (form != null)
            {
                using (var editForm = new NewAlarmCreationForm(form, alarm))
                {
                    editForm.ShowDialog();
                }
            }
        }
        private void ToggleAlarmActivity(object sender, MouseEventArgs e)
        {
            string filePath = @"..\..\..\Data\data.json";

            if (alarm.IsActive)
            {
                alarmActivityPictureBox.Image = null;
                alarm.IsActive = false;

                string json = JsonConvert.SerializeObject(alarmsList);

                File.WriteAllText(filePath, json);
            }
            else
            {
                string imagePath = @"..\..\..\Images\checkmark.png";
                alarmActivityPictureBox.Image = Image.FromFile(imagePath);
                alarmActivityPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                alarm.IsActive = true;

                string json = JsonConvert.SerializeObject(alarmsList);

                File.WriteAllText(filePath, json);
            }
        }

        private void RemoveAlarmFromList(Alarm alarm)
        {
            Alarm[] newAlarmsList = new Alarm[alarmsList.Length - 1];

            int index = 0;

            foreach (var newAlarm in alarmsList)
            {
                if (!newAlarm.Equals(alarm))
                {
                    newAlarmsList[index] = newAlarm;
                    index++;
                }
            }

            alarmsList = newAlarmsList;

            var form = FindForm() as AlarmMainForm;

            if (form != null)
            {
                form.alarmsList = alarmsList;

                UpdateJsonFile();

                form.PopulateActiveAlarmsList();
                form.PopulateFlowLayoutPanel();
            }

        }
        private void UpdateJsonFile()
        {
            string filePath = @"..\..\..\Data\data.json";

            try
            {
                if (File.Exists(filePath))
                {
                    string jsonData = JsonConvert.SerializeObject(alarmsList);
                    File.WriteAllText(filePath, jsonData);
                }
                else
                {
                    MessageBox.Show("Файл с данными о будильниках не найден!", "Внимание!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Возникла ошибка!\n {ex.Message}", "Внимание!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public AlarmControl(Alarm alarm, Alarm[] alarmsList)
        {
            InitializeComponent();

            alarmNameLabel.Text = $"{alarm.Name}";
            alarmTimeLabel.Text = $"Время: {alarm.Time.ToString("HH:mm")}";

            switch (alarm.RepeatType)
            {
                case 1:
                    alarmRepeatTypeLabel.Text = "Однократно";
                    break;
                case 2:
                    alarmRepeatTypeLabel.Text = "Ежедневно";
                    break;
                case 3:
                    alarmRepeatTypeLabel.Text = "По будням";
                    break;
                case 4:
                    alarmRepeatTypeLabel.Text = "По выходным";
                    break;
            }

            alarmRepeatLabel.Text = alarm.IsRepeating ? "Повторяется: Да" : "Повторяется: Нет";

            this.alarm = alarm;
            this.alarmsList = alarmsList;

            if (alarm.IsActive)
            {
                string imagePath = @"..\..\..\Images\checkmark.png";
                alarmActivityPictureBox.Image = Image.FromFile(imagePath);
                alarmActivityPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                alarm.IsActive = true;
            }
            else
            {
                alarmActivityPictureBox.Image = null;
                alarm.IsActive = false;
            }
        }
    }
}
