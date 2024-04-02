using Entities.Model.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Entities.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User
                {
                    Id = new Guid("80f7f49b-e5f2-4248-ab3a-349da4390553"),
                    FirstName = "Hojimurod",
                    LastName = "Ergashov",
                    Password = "122333",
                    UserName = "salom123",
                    Email = "ergashovhojimurod4@gmail.com",
                    IsActive = true,
                    Roles = new List<RoleEnum> { RoleEnum.Admin , RoleEnum.User , RoleEnum.Moderator} ,
                    CreatedAt = DateTimeOffset.Now,
                },
                new User
                {
                    Id = new Guid("36929717-b202-479b-aa74-6cf59e59cadf"),
                    FirstName = "Nodirxon",
                    LastName = "Nabixonov",
                    Password = "c6bd2f4bb77b2712314e8cf4ff3af0528e1145f886131eefa26d3952cced2006",
                    UserName ="alikk123",
                    Email = "allajanovyakub@gmail.com",
                    IsActive = true,
                    Roles = new List<RoleEnum> {RoleEnum.User},
                    CreatedAt = DateTimeOffset.Now,
                });
        }
    }
}
