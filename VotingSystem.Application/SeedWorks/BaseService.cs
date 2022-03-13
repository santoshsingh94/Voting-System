

using VotingSystem.Infrastructure.SeedWorks;

namespace VotingSystem.Application.SeedWorks
{
    public abstract class BaseService
    {
        protected readonly IUnitOfWork UnitOfWork;

        protected BaseService(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }
    }
}