using System.ComponentModel.DataAnnotations;
using Safiya.Hossam._0523049.Models;

namespace Safiya.Hossam._0523049.DTOs.CoachDTO
{
    public class ReadOneCoach
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public string Specilazation { get; set; } = string.Empty;
        [Required]
        public int ExperienceYears { get; set; }
        public ReadTeamforCoach? Teamdto { get; set; }
    }
    public class ReadTeamforCoach
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        = string.Empty;
        public string Ciy { get; set; } = string.Empty;
        public int TotalPlayers { get; set; }
        public List<PlayerforTeamcouch>? playersdto { get; set; }
    }
    public class PlayerforTeamcouch
    {
        public string FullName { get; set; } = string.Empty;
        public string Position = string.Empty;
        public int Age { get; set; }
    }
}
