using Microsoft.EntityFrameworkCore;
using Safiya.Hossam._0523049.Db;
using Safiya.Hossam._0523049.Models;
using Safiya.Hossam._0523049.Repository.GenericRepository;

namespace Safiya.Hossam._0523049.Repository.CoachRepository
{
    public class CoachRepo : GenericRepo<Coach>, ICoach
    {
        public CoachRepo(AppDbContext contex) : base(contex)
        {
        }

        public async Task<IEnumerable<Coach>> GetCoachAsync()
        {
            return await _contex.Coachs.Include(x => x.Team).ToListAsync();
        }

        public async Task<Coach> GeyOneCoach(int id)
        {
            return await _contex.Coachs.Include(x => x.Team).ThenInclude(x => x.players).FirstOrDefaultAsync(x => id == x.Id);
        }
    }
}
