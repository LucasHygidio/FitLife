using System.ComponentModel.DataAnnotations;

namespace FitLife.Models
{
    public class User
    {
        [Key]
        public int IdUser { get; set; }
        public String Name { get; set; }
    }
}
