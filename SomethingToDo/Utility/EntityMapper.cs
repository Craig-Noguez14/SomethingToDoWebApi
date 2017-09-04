using SomethingToDo.DTO.Event;
using SomethingToDo.DTO.User;
using SomethingToDo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SomethingToDo.Utility
{
    internal static class EntityMapper
    {
        internal static Event Map(EventDTO eve) 
        {
            var result = new Event
            {
                StartsOn = eve.StartOn,
                ExpiresOn = eve.ExpiresOn,
                SubCategoryId = (int) eve.SubCategory,
                Location = eve.Location,
                TypeId =(int) eve.Type,
                Description = eve.Description,
                CreatedBy = new User() { Email = eve.CreatedBy }
            };

            return result;
        }

        internal static User Map(UserDTO user)
        {
            var result = new User
            {
                Name = user.Name,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber
            };

            return result;
        }
    }
}