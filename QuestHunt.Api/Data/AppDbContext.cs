using Microsoft.EntityFrameworkCore;
using QuestHunt.Api.Entities;

namespace QuestHunt.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Quest> Quests { get; set; }
    }
}
