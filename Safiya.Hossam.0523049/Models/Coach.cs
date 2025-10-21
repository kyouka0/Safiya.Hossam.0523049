using System.ComponentModel.DataAnnotations;

namespace Safiya.Hossam._0523049.Models
{
    public class Coach
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }= string.Empty;
        public string Specilazation { get; set; } = string.Empty;
        [Required]
        public int ExperienceYears { get; set; }
        public Team? Team { get; set; }

    }
}
