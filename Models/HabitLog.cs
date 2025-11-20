namespace FitLife.Models
{
    public class HabitLog
    {
        public int HabitLogId { get; set; }
        public int UserId { get; set; }
        public DateOnly LogDate { get; set; }
        public string HabitName { get; set; }
        public bool IsCompleted { get; set; }
    }
}
