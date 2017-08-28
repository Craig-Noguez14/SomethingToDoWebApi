using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SomethingToDo.Repositories.User
{
    public interface IUserRepository
    {
        Task<Models.User> GetUserAsync(string email);

        Task CreateAsync(Models.User user);
    }
}
