using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using SomethingToDo.Models;
using SomethingToDo.Context;
using System.Data.Entity;
using SomethingToDo.Repositories.User;

namespace SomethingToDo.Services.User
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepo;

        public UserService(IUserRepository userRepo)
        {
            this.userRepo = userRepo;
        }

        public async Task CreateAsync(Models.User user)
        {
            await userRepo.CreateAsync(user);
        }

        public async Task<Models.User> GetAsync(string email)
        {
            return await userRepo.GetUserAsync(email);
        }
    }
}