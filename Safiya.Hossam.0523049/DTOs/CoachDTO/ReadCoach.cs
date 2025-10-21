using Safiya.Hossam._0523049.Models;
using System.ComponentModel.DataAnnotations;

namespace Safiya.Hossam._0523049.DTOs.CoachDTO
{
    public class ReadCoach
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public string Specilazation { get; set; } = string.Empty;
        [Required]
        public int ExperienceYears { get; set; }
        public ReadTeamForCoach? Teamdto { get; set; }
    }
    public class ReadTeamForCoach
    {
        public string Name { get; set; }
    = string.Empty;
        public string Ciy { get; set; } = string.Empty;
    }
}
