using Microsoft.EntityFrameworkCore;
using Safiya.Hossam._0523049.Db;
using Safiya.Hossam._0523049.Models;
using Safiya.Hossam._0523049.Repository.GenericRepository;

namespace Safiya.Hossam._0523049.Repository.PlayerRepository
{
    public class PlayerRepo : GenericRepo<Player>, IPlayer
    {
        public PlayerRepo(AppDbContext contex) : base(contex)
        {
        }

        public async Task<IEnumerable<Team>> GetPlayersAsync()
        {
            return await _contex.Teams.Include(x => x.players).ToListAsync();
        }

      
    }
}
