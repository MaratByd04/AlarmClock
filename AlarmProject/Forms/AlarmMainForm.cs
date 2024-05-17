using AlarmClock;
using Newtonsoft.Json;
using System.Media;

namespace AlarmProject
{
    public partial class AlarmMainForm : Form
    {
        public Alarm[] alarmsList = new Alarm[0];
        
        public void PopulateActiveAlarmsList()
        {
            string filePath = @"..\..\..\Data\data.json";

            try
            {
                if (File.Exists(filePath))
                {
                    string data = File.ReadAllText(filePath);

                    var deserializedAlarms = JsonConvert.DeserializeObject<Alarm[]>(data);

                    if (deserializedAlarms != null)
                    {
                        alarmsList = deserializedAlarms;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Возникла ошибка!\n {ex.Message}", "Внимание!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void PopulateFlowLayoutPanel()
        {
            alarmsFlowLayoutPanel.Controls.Clear();

            foreach (var alarm in alarmsList)
            {
                var control = new AlarmControl(alarm, alarmsList);
                alarmsFlowLayoutPanel.Controls.Add(control);
            }
        }
        private void InitializeTimer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;
            timer1.Tick += Timer_Tick;
            timer1.Start();
        }
        private bool IsWeekday(DateTime dateTime)
        {
            var dayOfWeek = dateTime.DayOfWeek;
            return dayOfWeek >= DayOfWeek.Monday && dayOfWeek <= DayOfWeek.Friday;
        }
        private void PlaySound()
        {
            string soundFilePath = @"..\..\..\AlarmSound\alarm.wav";

            using (var soundPlayer = new SoundPlayer(soundFilePath))
            {
                soundPlayer.Play();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            foreach (var alarm in alarmsList)
            {
                if (DateTime.Now.Hour.Equals(alarm.Time.Hour) && DateTime.Now.Minute.Equals(alarm.Time.Minute) &&
                    DateTime.Now.Second.Equals(alarm.Time.Second) && alarm.IsActive)
                {
                    switch (alarm.RepeatType)
                    {
                        case 1:
                            PlaySound();

                            MessageBox.Show($"Сработал будильник: {alarm.Name}\nТип: Однократный",
                                "Будильник", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            alarm.IsActive = false;

                            string filePath = @"..\..\..\Data\data.json";

                            string json = JsonConvert.SerializeObject(alarmsList);

                            File.WriteAllText(filePath, json);

                            PopulateActiveAlarmsList();
                            PopulateFlowLayoutPanel();

                            break;
                        case 2:
                            PlaySound();

                            MessageBox.Show($"Сработал будильник: {alarm.Name}\nТип: Ежедневный",
                                "Будильник", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        case 3:
                            if (IsWeekday(DateTime.Now))
                            {
                                PlaySound();

                                MessageBox.Show($"Сработал будильник: {alarm.Name}\nТип: По будням",
                                    "Будильник", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            break;
                        case 4:
                            if (!IsWeekday(DateTime.Now))
                            {
                                PlaySound();

                                MessageBox.Show($"Сработал будильник: {alarm.Name} \nТип: По выходным",
                                    "Будильник", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            break;

                    }

                }
            }
        }
        private void EditExistingAlarmPictureBoxClick(object sender, MouseEventArgs e)
        {
            using (var newAlarmCreationForm = new NewAlarmCreationForm(this, null!))
            {
                newAlarmCreationForm.ShowDialog();
            }
            PopulateActiveAlarmsList();
            PopulateFlowLayoutPanel();
        }

        public AlarmMainForm()
        {
            InitializeComponent();

            PopulateActiveAlarmsList();
            PopulateFlowLayoutPanel();

            InitializeTimer();
            MessageBox.Show("В данном приложении будильник имеет встроенный звук, пожалуйста, убавьте громкость динамиков",
                "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}