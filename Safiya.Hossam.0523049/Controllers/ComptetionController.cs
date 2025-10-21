using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Safiya.Hossam._0523049.DTOs.Competetiondto;
using Safiya.Hossam._0523049.Repository.CompetitionRepository;

namespace Safiya.Hossam._0523049.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComptetionController : ControllerBase
    {
        private readonly IComptetion _comp;

        public ComptetionController(IComptetion comp)
        {
            _comp = comp;
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var c = await _comp.GetBy(id);
            if (c == null) return NotFound();

            await _comp.Delete(c);
            await _comp.SaveChange();
            return NoContent();
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var c = await _comp.GetComptetionList();
            var comp = c.Select(x => new ReadCompetetion
            {
                Name = x.Name,
                Location = x.Location,
                Date = x.Date,
                Totalteams = x.teams.Count(),
                Teamsdto = x.teams.Select(z => new Teamsforcomp
                {
                    Name = z.Name,
                    Ciy = z.Ciy,
                    Totalcount = z.players.Count(),
                    Playres = z.players.Select(a => new Playerforcompetetion
                    {
                        Age = a.Age,
                        FullName = a.FullName,
                        Position = a.Position,
                    }).ToList(),

                }).ToList()
            }).ToList();
            var copmmm = comp.GroupBy(x => x.Location).Select(z => new
            {
                Location = z.Key,
                Competition = z.ToList(),
            });
            return Ok(copmmm);
        }
    }
}
