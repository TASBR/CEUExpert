using System.Threading.Tasks;

namespace CEU.Core.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}