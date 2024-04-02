using Entities.Model.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Contracts.Services
{
    public interface ILoginRepository
    {
        Task<User> LoginAsync(string username, string password, bool tracking, CancellationToken cancellationToken = default);
        public string GenerateToken(User user);
        public string HashPassword(string password);
    }
}