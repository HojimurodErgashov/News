using Entities.Model.Categories;
using Entities.Model.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Services
{
    public interface ICategoryRepository
    {
        Task<Category> CreateAsync(User user);
        Task<List<Category>> GetAllAsync();
        Task<Category> GetByIdAsync();
        Task<Category> GetByNameAsync();
        
    }
}
