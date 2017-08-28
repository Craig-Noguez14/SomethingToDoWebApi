using SomethingToDo.Context.Mappings;
using SomethingToDo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Web;

namespace SomethingToDo.Context
{
    public class SomethingToDoContext : DbContext
    {
        public SomethingToDoContext() : base("name=SomethingToDoContext")
        {
            Database.SetInitializer<SomethingToDoContext>(null);
        }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<UserEventLog> UserEventLogs { get; set; }

        public virtual DbSet<Event> Events { get; set; }

        public virtual DbSet<EventType> EventTypes { get; set; }

        public virtual DbSet<EventLocation> EventLocations { get; set; }

        public virtual DbSet<Category> Categories { get; set; }

        public virtual DbSet<SubCategory> SubCategories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            MappingHelper.ConfigureMaps(modelBuilder);
        }
    }
}