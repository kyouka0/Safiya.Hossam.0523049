namespace Safiya.Hossam._0523049.Repository.GenericRepository
{
    public interface IGeneric < T> where T : class
    {
        Task<IEnumerable<T>> Get();
        Task<T> GetBy(int id);
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(T id);
        Task SaveChange();
            
    }
}
