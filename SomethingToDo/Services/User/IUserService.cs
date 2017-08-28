using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SomethingToDo.Services.User
{
    public interface IUserService
    {
        Task<Models.User> GetAsync(string email);

        Task CreateAsync(Models.User user);
    }
}