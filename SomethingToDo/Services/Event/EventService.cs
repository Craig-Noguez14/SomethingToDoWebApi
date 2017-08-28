using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using SomethingToDo.Models;
using SomethingToDo.Repositories.Event;
using SomethingToDo.Repositories.User;

namespace SomethingToDo.Services.Event
{
    public class EventService : IEventService
    {
        private readonly IEventRepository eventRepo;
        private readonly IUserRepository userRepo;

        public EventService(IEventRepository eventRepo, IUserRepository userRepo)
        {
            this.eventRepo = eventRepo;
            this.userRepo = userRepo;
        }

        public async Task CreateAsync(Models.Event evnt)
        {
            evnt.LastUpdatedOn = DateTime.Now;
            evnt.CreatedBy = await userRepo.GetUserAsync(evnt.CreatedBy.Email);
            evnt.UpdatedBy = evnt.CreatedBy;

            await eventRepo.CreateAsync(evnt);
        }
    }
}