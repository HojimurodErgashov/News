using Contracts;
using Contracts.Services;
using Entities;
using Repository.Services;
using System;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private IUserRepository _userRepository;
        private ILoginRepository _loginRepository;
        private IEmailService _emailService;

        public RepositoryManager(RepositoryContext repositoryConetxt)
        {
            _repositoryContext = repositoryConetxt ?? throw new ArgumentNullException(nameof(repositoryConetxt));
        }

        public IUserRepository User
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new UserRepository(_repositoryContext);
                }
                return _userRepository;
            }
        }

        public ILoginRepository Login
        {
            get
            {
                if (_loginRepository == null)
                {
                    _loginRepository = new LoginRepository(_repositoryContext);
                }
                return _loginRepository;
            }
        }

        public IEmailService EmailService
        {
            get
            {
                if (_emailService == null)
                {
                    _emailService = new EmailRepository();
                }
                return _emailService;
            }
        }

        public Task SaveAsync() => _repositoryContext.SaveChangesAsync();
    }
}
