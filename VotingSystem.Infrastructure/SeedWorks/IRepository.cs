using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VotingSystem.Infrastructure.SeedWorks
{
    public interface IRepository<T> where T : class   
    {   
        void Add(T entity);   
        void Delete(T entity);   
        void Update(T entity);
        Task<T> GetAsync(int id);
        Task<List<T>> GetAllAsync();
    }
}