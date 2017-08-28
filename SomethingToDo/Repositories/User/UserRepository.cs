using SomethingToDo.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SomethingToDo.Repositories.User
{
    public class UserRepository : IUserRepository
    {
        public async Task<Models.User> GetUserAsync(string email)
        {
            Models.User user;

            using (var context = new SomethingToDoContext())
            {
                user = await context.Users.FirstOrDefaultAsync(w => w.Email.Trim() == email.Trim());
            }

            return user;
        }

        public async Task CreateAsync(Models.User user)
        {
            using (var context = new SomethingToDoContext())
            {
                context.Users.Add(user);
                await context.SaveChangesAsync();
            }
        }
    }
}