using Microsoft.EntityFrameworkCore;
using Project.Models;

namespace Project.Data
{
    public class CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt) 
        {
            
        }

        public DbSet<Command> Commands { get; set; }
    }
}
