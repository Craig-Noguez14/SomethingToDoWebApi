using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SomethingToDo.Repositories.Event
{
    public interface IEventRepository
    {
        Task CreateAsync(Models.Event evnt);

        Task<List<Models.Event>> GetAll();
    }
}