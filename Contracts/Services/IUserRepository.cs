using Entities.Model.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Contracts.Services
{
    public interface IUserRepository
    {
        //Create
        Task<User> CreateAsync(User user);
        //GetAll
        Task<List<User>> GetAllAsync();
        Task<List<User>> GetAllCreatedAtAsync(DateTime dateTime);
        //GetOne
        Task<User> GetByUserNameAsync(string userName); 
        Task<List<User>> GetByFirstNameAsync(string firstName);
        Task<List<User>> GetByLastNameAsync(string lastName);
        Task<List<User>> GetByEmailAsync(string email);
        Task<User> GetByIdAsync(Guid id);
        //Update
        void Update(User user);
        //delete
        void DeleteUser(User user);
        //DeleteAll
        void DeleteAll(List<User> users);

    }
}
