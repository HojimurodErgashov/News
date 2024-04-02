using System.Threading.Tasks;
using Contracts.Services;

namespace Contracts
{
    public interface IRepositoryManager
    {
        IUserRepository User { get; }
        ILoginRepository Login { get; }
        IEmailService EmailService { get; }
        Task SaveAsync();
    }
}
