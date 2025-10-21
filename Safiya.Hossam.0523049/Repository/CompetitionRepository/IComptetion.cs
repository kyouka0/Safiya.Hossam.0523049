using Safiya.Hossam._0523049.Models;
using Safiya.Hossam._0523049.Repository.GenericRepository;

namespace Safiya.Hossam._0523049.Repository.CompetitionRepository
{
    public interface IComptetion: IGeneric<Competition>
    {
        Task<IEnumerable<Competition>> GetComptetionList();
    }
}
