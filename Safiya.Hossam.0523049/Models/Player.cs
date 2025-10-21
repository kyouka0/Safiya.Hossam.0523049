using System.ComponentModel.DataAnnotations;

namespace Safiya.Hossam._0523049.Models
{
    public class Player
    {
        [Key]
       public int Id { get; set; }
        [Required]
        public string FullName { get; set; }=string.Empty;
        public string Position { get; set; } = string.Empty;
        public int Age {  get; set; }
        public int TeamId { get; set; }
        public Team? Team { get; set; }
    }
}
