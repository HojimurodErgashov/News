using Contracts.Services;
using Entities;
using Entities.Model.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository.Services
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }

        public async Task<User> CreateAsync(User user)
        {
            user.IsActive = false;
            user.CreatedAt = DateTime.UtcNow;
            user.Id = Guid.NewGuid();
            user.Roles = new List<RoleEnum> { RoleEnum.User };
            await InsertAsync(user);
            return user;
        }

        /////////  I do not know what this is true or false
        public void DeleteAll(List<User> users)
        {
            foreach (var user in users)
            {
                user.IsActive = false;  
            }
        }
        /////////  I do not know what this is true or false
        public void DeleteUser(User user)
        {
            user.IsActive = false;
        }


        public async Task<List<User>> GetAllAsync()
        {
            List<User> users = await FindAll(false).ToListAsync();
            return users;
        }

        ///I dont know which ot os true or false
        public async Task<List<User>> GetAllCreatedAtAsync(DateTime dateTime)
        {
            return await FindByCondition(x => x.CreatedAt.Equals(dateTime) , false).ToListAsync();
        }

        //Perfect
        public async Task<List<User>> GetByEmailAsync(string email)
        {
            return await FindByCondition(x => x.Email.Contains(email), false).ToListAsync();
        }

        //// Perfect
        public async Task<List<User>> GetByFirstNameAsync(string firstName)
        {
            return await FindByCondition(x => x.FirstName.Contains(firstName) , false).ToListAsync();
        }

        //unique Id
        public async Task<User> GetByIdAsync(Guid id)
        {
            return await FindByCondition(x => x.Email.Equals(id), false).FirstOrDefaultAsync();
        }

        //Perfect
        public async Task<List<User>> GetByLastNameAsync(string lastName)
        {
            return await FindByCondition(x => x.Email.Contains(lastName), false).ToListAsync();
        }

        //unique UserName
        public async Task<User> GetByUserNameAsync(string userName)
        {
            return await FindByCondition(x => x.Email.Equals(userName), false).FirstOrDefaultAsync();
        }
        /////////  I do not know what this is true or false
        void IUserRepository.Update(User user)
            {
                Update(user);
            }
        }
}
////////*************
///Bizda Role lar bilan ishlashga oid funksiyalar hali qo'shilmagan
///Bu yerga yangi qo'shilgan serviselarga api lar ham shakllantirilmagan
///Va Asosiysi update va Delete funksiyalari hali ham mavjud emas.
