using SomethingToDo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SomethingToDo.Context.Mappings
{
    public class MappingHelper
    {
        public static void ConfigureMaps(DbModelBuilder modelBuilder)
        {
            modelBuilder.Properties<DateTime>()
                .Configure(c => c.HasColumnType("datetime2"));

            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<SubCategory>().ToTable("SubCategory").Property(w => w.CategoryId).HasColumnName("CategoryId");
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<UserEventLog>().ToTable("UserEventLog").Property(w => w.UserId).HasColumnName("UserId");
            modelBuilder.Entity<Event>().ToTable("Event").Property(w => w.LocationId).HasColumnName("LocationId");
            modelBuilder.Entity<EventLocation>().ToTable("EventLocation");
            modelBuilder.Entity<EventType>().ToTable("EventType");
        }
    }
}