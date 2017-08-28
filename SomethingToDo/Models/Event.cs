using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SomethingToDo.Models
{
    public class Event
    {
        public int Id { get; set; }

        public int SubCategoryId { get; set; }

        public int LocationId { get; set; }

        public int TypeId { get; set; }

        public string Description { get; set; }

        public int CreatedById { get; set; }

        public int UpdatedById { get; set; }

        public DateTime LastUpdatedOn { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime ExpiresOn { get; set; }

        public virtual SubCategory SubCategory { get; set; }

        public virtual EventLocation Location { get; set; }

        public virtual EventType Type { get; set; }

        public virtual User CreatedBy { get; set; }

        public virtual User UpdatedBy { get; set; }
    }
}