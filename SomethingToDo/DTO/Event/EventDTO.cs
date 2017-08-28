using SomethingToDo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SomethingToDo.DTO.Event
{
    public class EventDTO
    {
        public string Description { get; set; }

        public DateTime LastUpdatedOn { get; set; }

        public DateTime StartOn { get; set; }

        public DateTime ExpiresOn { get; set; }

        public SubCategoryEnum SubCategory { get; set; }

        public EventLocation Location { get; set; }

        public EventTypeEnum Type { get; set; }

        public string CreatedBy { get; set; }
    }
}