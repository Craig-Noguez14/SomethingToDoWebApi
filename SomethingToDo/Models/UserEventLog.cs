using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SomethingToDo.Models
{
    public class UserEventLog
    {
        public int Id { get; set; }

        public int EventId { get; set; }

        public int UserId { get; set; }

        public virtual Event Event { get; set; }

        public virtual User User { get; set; }
    }
}