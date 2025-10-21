using Microsoft.EntityFrameworkCore;
using Safiya.Hossam._0523049.Db;
using Safiya.Hossam._0523049.Models;
using Safiya.Hossam._0523049.Repository.GenericRepository;

namespace Safiya.Hossam._0523049.Repository.TeamRepository
{
    public class TeamRepo : GenericRepo<Team>, ITeam
    {
        public TeamRepo(AppDbContext contex) : base(contex)
        {
        }

        public async Task<IEnumerable<Team>> GetTeamsDosenot()
        {

            return await _contex.Teams.Where(x => x.competitions.Any(c => c.teams
                                      .Any(t => t.Id != x.Id))).Include(p=> p.players).ToListAsync();
        }
    }
}
