using System.ComponentModel.DataAnnotations;

namespace FitLife.Models
{
    public class WorkOutLog
    {
        [Key]
        public int WorkOutId { get; set; }
        public DateOnly LogDate { get; set; }
        public  String ExerciseName { get; set; }
        public int DurationMinutes { get; set; }
        public int CaloriesBurned { get; set; }

        public int UserId { get; set; } //id que referencia o user
        public User User { get; set; }
    }
}
