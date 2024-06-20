using Microsoft.EntityFrameworkCore;
using Quill_Lite_App.Models;

namespace Quill_Lite_App.Data
{
    public class Quill_Lite_AppContext : DbContext
    {
        public Quill_Lite_AppContext(DbContextOptions<Quill_Lite_AppContext> options) : base(options)
        {
        }

        public DbSet<Quill> Quill { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Customize your model if needed
            modelBuilder.Entity<Quill>().ToTable("Quills"); // Example customization
        }
    }
}
