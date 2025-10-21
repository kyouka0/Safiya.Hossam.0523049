
using Microsoft.EntityFrameworkCore;
using Safiya.Hossam._0523049.Db;

namespace Safiya.Hossam._0523049.Repository.GenericRepository
{
    public class GenericRepo<T> : IGeneric<T> where T : class
    {
        protected readonly AppDbContext _contex;
        private readonly DbSet<T> _dbSet;

        public GenericRepo(AppDbContext contex)
        {
            _contex = contex;
            _dbSet =  contex.Set<T>();
        }

        public async Task Add(T entity)
        {
           await  _dbSet.AddAsync(entity);
        }

        public async Task Delete(T id)
        {
           _dbSet.Remove(id);

        }

        public async Task<IEnumerable<T>> Get()
        {
return await _dbSet.ToListAsync();
        }

        public async Task<T> GetBy(int id)
        {
        return    await _dbSet.FindAsync(id);
        }

        public Task SaveCange()
        {
            throw new NotImplementedException();
        }

        public async Task SaveChange()
        {
          await _contex.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            _dbSet.Update(entity);
        }
    }
}
