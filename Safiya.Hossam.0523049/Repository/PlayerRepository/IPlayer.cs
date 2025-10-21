using Safiya.Hossam._0523049.Models;
using Safiya.Hossam._0523049.Repository.GenericRepository;

namespace Safiya.Hossam._0523049.Repository.PlayerRepository
{
    public interface IPlayer : IGeneric<Player>
    {
        Task<IEnumerable<Team>> GetPlayersAsync();
    }
}
