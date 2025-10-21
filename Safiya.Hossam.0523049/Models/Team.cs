using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Safiya.Hossam._0523049.Models
{
    [Index(nameof(Name), IsUnique = true)]
    public class Team
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        = string.Empty;
        public string Ciy { get; set; } = string.Empty;
        public int CoachId { get; set; }
        public Coach? Coach { get; set; }
        public List<Player>? players { get; set; }
        public List<Competition>? competitions { get; set; }
    }
// pkdsn  jn 
}
