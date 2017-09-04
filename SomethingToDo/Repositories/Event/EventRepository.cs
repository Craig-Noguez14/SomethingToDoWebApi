using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using SomethingToDo.Models;
using SomethingToDo.Context;
using System.Data.Entity;

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

        public async Task<List<Models.Event>> GetAll()
        {
            using (var context = new SomethingToDoContext())
            {
                return await context.Events.Include(x => x.Location).Include(x => x.CreatedBy).Include(w => w.SubCategory).ToListAsync();//context.Events.Where(w => w.StartsOn >= DateTime.Now.AddHours(2) || w.ExpiresOn >= DateTime.Now.AddHours(3)).ToListAsync();
            }
        }
    }
}