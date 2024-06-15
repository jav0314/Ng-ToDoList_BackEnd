using Microsoft.EntityFrameworkCore;
using ToDoList.Model;

namespace ToDoList.Context
{
    public class ApplicationDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=SchoolDb;Trusted_Connection=True;");
        }
        public DbSet<Users> Users { get; set; }
    }
}
