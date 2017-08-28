using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SomethingToDo.Services.Event
{
    public interface IEventService
    {
        Task CreateAsync(Models.Event evnt);
    }
}