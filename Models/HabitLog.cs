using System.ComponentModel.DataAnnotations;

namespace FitLife.Models
{
    public class HabitLog
    {
        [Key]
        public int HabitLogId { get; set; }
        public DateOnly LogDate { get; set; }
        public string HabitName { get; set; }
        public bool IsCompleted { get; set; }

        public int UserId { get; set; } //id que referencia o user
        public User User { get; set; }
    }
}
