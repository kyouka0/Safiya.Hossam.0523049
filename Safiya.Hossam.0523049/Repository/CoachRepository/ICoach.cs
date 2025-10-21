using Safiya.Hossam._0523049.Models;
using Safiya.Hossam._0523049.Repository.GenericRepository;

namespace Safiya.Hossam._0523049.Repository.CoachRepository
{
    public interface ICoach :IGeneric<Coach>
    {
        Task<IEnumerable<Coach>> GetCoachAsync();
        Task<Coach> GeyOneCoach(int id);
    }
}
