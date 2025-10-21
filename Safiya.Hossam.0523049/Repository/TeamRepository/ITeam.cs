using Safiya.Hossam._0523049.Models;
using Safiya.Hossam._0523049.Repository.GenericRepository;

namespace Safiya.Hossam._0523049.Repository.TeamRepository
{
    public interface ITeam:IGeneric<Team>
    {
         Task<IEnumerable<Team>> GetTeamsDosenot();
    }
}
