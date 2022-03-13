using System;
using System.Threading.Tasks;

namespace VotingSystem.Infrastructure.SeedWorks
{
    public interface IUnitOfWork    
    {   
        Task<int> SaveChangeAsync();   
		Task<TResult> ExecuteTransactionAsync<TResult>(Func<Task<TResult>> func);
    }  
}