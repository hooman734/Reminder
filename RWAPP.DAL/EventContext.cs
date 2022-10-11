using Microsoft.EntityFrameworkCore;
using RWAPP.CoreBusiness;

namespace RWAPP.DAL;

public class EventContext: DbContext
{
    public DbSet<Event> Events { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source=ReminderDB.db");
    }
}