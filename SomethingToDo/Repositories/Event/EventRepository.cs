using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using SomethingToDo.Models;
using SomethingToDo.Context;

namespace SomethingToDo.Repositories.Event
{
    public class EventRepository : IEventRepository
    {
        public async Task CreateAsync(Models.Event evnt)
        {
            using (var context = new SomethingToDoContext())
            {
                context.Events.Add(evnt);
                await context.SaveChangesAsync();
            }
        }
    }
}