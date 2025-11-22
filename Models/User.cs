using System.ComponentModel.DataAnnotations;

namespace FitLife.Models
{
    public class User
    {
        [Key]
        public int IdUser { get; set; }
        public String Name { get; set; }
        public List<DietLog> dietList{ get; set; }
        public List<HabitLog> habitList { get; set; }
        public List<WorkOutLog> WorkOutList { get; set; }
    }
}
