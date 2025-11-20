namespace FitLife.Models
{
    public class DietLog
    {
        public int LogId { get; set; }
        public int UserId { get; set; }
        public DateOnly LogDate { get; set; }
        public String MealName { get; set; }
        public int Calories { get; set; }
        public bool IsHealthy { get; set; }

    }
}
