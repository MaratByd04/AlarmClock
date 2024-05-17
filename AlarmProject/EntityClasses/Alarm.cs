namespace AlarmClock
{
    /// <summary>
    /// Класс сущности будильника
    /// </summary>
    public class Alarm
    {
        public DateTime Time { get; set; }
        public string Name { get; set; } = null!;
        public int RepeatType { get; set; }
        public bool IsActive { get; set; }
        public bool IsRepeating { get; set; }
    }
}