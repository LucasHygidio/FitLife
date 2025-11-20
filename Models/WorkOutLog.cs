namespace FitLife.Models
{
    public class WorkOut
    {
        public int WorkOutId { get; set; }
        public int UserId { get; set; }
        public DateOnly LogDate { get; set; }
        public  String ExerciseName { get; set; }
        public int DurationMinutes { get; set; }
        public int CaloriesBurned { get; set; }
    }
}
