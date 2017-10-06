using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using PocketHome.Core.Models;
namespace PocketHome.Core.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
		public DbSet<Event> Events { get; set; }
		public DbSet<ConditionElement> Conditions { get; set; }
		public DbSet<VeraAction> Actions { get; set; }
		public DbSet<Trigger> Triggers { get; set; }
		public DbSet<Room> Rooms { get; set; }
		public DbSet<Device> Devices { get; set; }
		public DbSet<Scene> Scenes { get; set; }
		public DbSet<Section> Sections { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
