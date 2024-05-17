using AlarmClock;
using Newtonsoft.Json;

namespace AlarmProject
{
    public partial class NewAlarmCreationForm : Form
    {
        AlarmMainForm form;
        Alarm alarm;
        bool isEditing = false;
        
        public NewAlarmCreationForm(AlarmMainForm form, Alarm alarm)
        {
            InitializeComponent();

            alarmRepeatComboBox.SelectedIndex = 0;
            alarmRepeatTypeComboBox.SelectedIndex = 0;

            this.form = form;
            this.alarm = alarm;

            if (alarm != null)
            {
                this.Text = "Редактирование будильника";

                alarmDateTimePicker.Value = alarm.Time;
                alarmNameTextBox.Text = alarm.Name;
                alarmRepeatComboBox.SelectedIndex = alarm.IsRepeating ? 1 : 2;
                alarmRepeatTypeComboBox.SelectedIndex = alarm.RepeatType;

                isEditing = true;
            }
        }

        private void cancelButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (isEditing)
            {
                var dialogResult = MessageBox.Show("Вы точно не хотите сохранить изменения?",
                "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult.Equals(DialogResult.Yes))
                {
                    this.Close();
                }
            }
            else
            {
                var dialogResult = MessageBox.Show("Вы точно не хотите создать новый будильник?",
                "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult.Equals(DialogResult.Yes))
                {
                    this.Close();
                }
            }

        }
        private void createButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (!alarmRepeatComboBox.SelectedIndex.Equals(0) && !alarmRepeatTypeComboBox.SelectedIndex.Equals(0)
                && !alarmNameTextBox.Text.Length.Equals(0))
            {
                try
                {
                    string filePath = @"..\..\..\Data\data.json";
                    if (File.Exists(filePath))
                    {
                        if (isEditing)
                        {
                            alarm.Time = alarmDateTimePicker.Value;
                            alarm.Name = alarmNameTextBox.Text;
                            alarm.RepeatType = alarmRepeatTypeComboBox.SelectedIndex;
                            alarm.IsRepeating = alarmRepeatComboBox.SelectedIndex.Equals(1) ? true : false;

                            string json = JsonConvert.SerializeObject(form.alarmsList);

                            File.WriteAllText(filePath, json);
                        }
                        else
                        {
                            var newAlarm = new Alarm
                            {
                                Time = alarmDateTimePicker.Value,
                                Name = alarmNameTextBox.Text,
                                RepeatType = alarmRepeatTypeComboBox.SelectedIndex,
                                IsActive = true,
                                IsRepeating = alarmRepeatComboBox.SelectedIndex.Equals(1) ? true : false
                        };

                            var newAlarmsList = new Alarm[form.alarmsList.Length + 1];

                            Array.Copy(form.alarmsList, newAlarmsList, form.alarmsList.Length);

                            newAlarmsList[newAlarmsList.Length - 1] = newAlarm;

                            form.alarmsList = newAlarmsList;

                            string json = JsonConvert.SerializeObject(form.alarmsList);

                            File.WriteAllText(filePath, json);
                        }
                        this.Close();

                        form.PopulateActiveAlarmsList();
                        form.PopulateFlowLayoutPanel();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Возникла ошибка!\n {ex.Message}", "Внимание!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста заполните все поля", "Внимание!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
