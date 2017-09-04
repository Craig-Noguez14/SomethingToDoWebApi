using SomethingToDo.DTO.Event;
using SomethingToDo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SomethingToDo.Utility
{
    internal static class DtoMapper
    {
        internal static List<EventDTO> Map(List<Event> events)
        {
            return events.Select(Map).ToList();
        }

        internal static EventDTO Map(Event eve)
        {
            var result = new EventDTO
            {
                Id = eve.Id,
                StartOn = eve.StartsOn.ToUniversalTime(),
                ExpiresOn = eve.ExpiresOn.ToUniversalTime(),
                SubCategory = (SubCategoryEnum)eve.SubCategoryId,
                Description = eve.Description,
                Location = eve.Location,
                Type = (EventTypeEnum) eve.TypeId,
                LastUpdatedOn = eve.LastUpdatedOn.ToUniversalTime(),
                CreatedBy = eve.CreatedBy.Email
            };

            return result;
        }
    }
}