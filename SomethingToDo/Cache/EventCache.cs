using SomethingToDo.DTO.Event;
using SomethingToDo.Repositories.Event;
using SomethingToDo.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Web;

namespace SomethingToDo.Cache
{
    public static class EventCache
    {
        private static MemoryCache _cache = MemoryCache.Default;
        private static IEventRepository eventRepo = new EventRepository();


        public static List<EventDTO> Events
        {
            get
            {
                if (!_cache.Contains("Events"))
                    RefreshEvents();
                return _cache.Get("Events") as List<EventDTO>;
            }
        }

        public static void RefreshEvents()
        {
            var events = eventRepo.GetAll();
            events.Wait();

            var result = DtoMapper.Map(events.Result);
            CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
            cacheItemPolicy.AbsoluteExpiration = DateTime.Now.AddDays(1);

            _cache.Add("Events", result, cacheItemPolicy);
        }

        public static void AddOrChangeCache(Models.Event _event)
        {
            var currentEvent = Events.FirstOrDefault(w => w.Id == _event.Id);

            if (currentEvent != null)
            {
                Events.Remove(currentEvent);
                Events.Add(DtoMapper.Map(_event));
            } else
            {
                Events.Add(DtoMapper.Map(_event));
            }
        }
    }
}