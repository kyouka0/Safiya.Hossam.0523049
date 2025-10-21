using Microsoft.EntityFrameworkCore;
using Safiya.Hossam._0523049.Db;
using Safiya.Hossam._0523049.Models;
using Safiya.Hossam._0523049.Repository.GenericRepository;

namespace Safiya.Hossam._0523049.Repository.CompetitionRepository
{
    public class CompetitionRepo : GenericRepo<Competition>, IComptetion
    {
        public CompetitionRepo(AppDbContext contex) : base(contex)
        {
        }

        public async Task<IEnumerable<Competition>> GetComptetionList()
        {
         return await _contex.competitions.Include(c=> c.teams).ThenInclude(x=> x.players).ToListAsync();   
        }
    }
}
