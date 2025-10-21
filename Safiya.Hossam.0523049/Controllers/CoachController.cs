using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Safiya.Hossam._0523049.DTOs.CoachDTO;
using Safiya.Hossam._0523049.Models;
using Safiya.Hossam._0523049.Repository.CoachRepository;
using Safiya.Hossam._0523049.Repository.GenericRepository;

namespace Safiya.Hossam._0523049.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoachController : ControllerBase
    {
        private readonly ICoach _coach;
        private readonly IGeneric<Team> _Teams;

        public CoachController(ICoach coach, IGeneric<Team> teams)
        {
            _coach = coach;
            _Teams = teams;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            var c = await _coach.GetCoachAsync();
            if (c == null) return NotFound();
            var coach = c.Select(x => new ReadCoach
            {
                Id = x.Id,
                Name = x.Name,
                Specilazation = x.Specilazation,
                ExperienceYears = x.ExperienceYears,
                Teamdto = x.Team == null ? null : new ReadTeamForCoach
                {
                    Name = x.Team.Name,
                    Ciy = x.Team.Ciy
                }
            }).ToList();
            var Couchs = coach.GroupBy(x => x.Specilazation).Select(z => new
            {
                Specilazation = z.Key,
                Couch = z.ToList()
            });
            return Ok(coach);
        }
        [HttpGet("ById")]
        public async Task<IActionResult> GeById(int id)
        {
            var c = await _coach.GeyOneCoach(id);
            if (c== null)
            {
                return NotFound();
            }
            var couch = new ReadOneCoach
            {
                Id = c.Id,
                Name = c.Name,
                Specilazation = c.Specilazation,
                ExperienceYears = c.ExperienceYears,
                Teamdto = c.Team == null ? null : new ReadTeamforCoach
                {
                    Id = c.Team.Id,
                    Name = c.Team.Name,
                    Ciy = c.Team.Ciy,
                     TotalPlayers= c.Team.players.Count(),
                    playersdto = c.Team.players.Select(x => new PlayerforTeamcouch
                    {
                        Age = x.Age,
                        FullName = x.FullName,
                        Position = x.Position,
                    }).ToList()

                }
            };
            return Ok(couch);

        }
    }
}

