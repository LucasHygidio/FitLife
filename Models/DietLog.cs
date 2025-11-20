using System.ComponentModel.DataAnnotations;

namespace FitLife.Models
{
    public class DietLog
    {
        [Key]
        public int LogId { get; set; }
        public DateOnly LogDate { get; set; }
        public String MealName { get; set; }
        public int Calories { get; set; }
        public bool IsHealthy { get; set; }

        public int UserId { get; set; } //id que referencia o user
        public User User { get; set; } //reference navigation property, consigo acessar a classe diretamente por aqui
    }
}
