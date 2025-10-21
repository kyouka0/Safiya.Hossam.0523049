using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Safiya.Hossam._0523049.DTOs.TeamDo;
using Safiya.Hossam._0523049.Models;
using Safiya.Hossam._0523049.Repository.CoachRepository;
using Safiya.Hossam._0523049.Repository.TeamRepository;

namespace Safiya.Hossam._0523049.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly ITeam _Team;
        private readonly ICoach _coach;

        public TeamController(ITeam team, ICoach coach)
        {
            _Team = team;
            _coach = coach;
        }
        [HttpPost]
        public async Task<IActionResult> AddTeam(CreateTeam dto)
        {
            var couid = dto.CoachId;
            if (couid == null)
            {
                return NotFound();
            }
            var team = new Team
            {
                Name = dto.Name,
                Ciy = dto.Ciy,
                CoachId = dto.CoachId,
            };
            await _Team.Add(team);
            await _Team.SaveChange();
            return StatusCode(201);
        }

        [HttpGet]
        public async Task<IActionResult> GetTeamsDosenothaveComptetion()
        {
            var e = await _Team.GetTeamsDosenot();
            var Team = e.Select(x => new ReadTeamdto
            {
                Name = x.Name,
                Ciy = x.Ciy,
                TotalPlayesr = x.players.Count(),
                 

            }).OrderByDescending(x => x.TotalPlayesr);
            return Ok(Team);

        }
    }
}
