using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SomethingToDo.Models
{
    public class EventLocation
    {
        public int Id { get; set; }

        public decimal Longitude { get; set; }

        public decimal Latitude { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }
    }
}