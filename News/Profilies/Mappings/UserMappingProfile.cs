using AutoMapper;
using Entities.DTOs.Users;
using Entities.Model.Users;

namespace News.Profilies.Mappings
{
    public class UserMappingProfile:Profile
    {
        public UserMappingProfile()
        {
            CreateMap<UserCreatedDTO, User>();
            CreateMap<User, UserDTO>();
        }
    }
}
