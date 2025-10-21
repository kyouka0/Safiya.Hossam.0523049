using System.ComponentModel.DataAnnotations;

namespace Safiya.Hossam._0523049.Models
{
    public class Competition
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }= string.Empty;
        public string Location { get; set; } = string.Empty;
        public DateOnly Date { get; set; }
        public List<Team>? teams { get; set; }
    }
}
