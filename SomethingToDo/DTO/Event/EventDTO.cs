using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SomethingToDo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SomethingToDo.DTO.Event
{
    public class EventDTO
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public DateTime LastUpdatedOn { get; set; }

        public DateTime StartOn { get; set; }

        public DateTime ExpiresOn { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public SubCategoryEnum SubCategory { get; set; }

        public EventLocation Location { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public EventTypeEnum Type { get; set; }

        public string CreatedBy { get; set; }
    }
}