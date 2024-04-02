using Entities.Model.Users;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Entities;
using Microsoft.EntityFrameworkCore;
using Contracts.Services;

namespace Repository.Services
{
    public class LoginRepository : RepositoryBase<User>, ILoginRepository
    {
        public LoginRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }

        public async Task<User> LoginAsync(string username, string password, bool tracking, CancellationToken cancellationToken = default) =>
                   await FindByCondition(x => x.UserName.Equals(username) && x.Password.Equals(password), tracking)
                         .SingleOrDefaultAsync(cancellationToken);

        public string GenerateToken(User user)
        {
            throw new NotImplementedException();
        }

        public string HashPassword(string password)
        {
            using SHA256 sha256 = SHA256.Create();
            byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
        }
    }
}