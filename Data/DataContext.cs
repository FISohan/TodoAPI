using Microsoft.EntityFrameworkCore;
using TodoAPI.Model;

namespace TodoAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Application.db;Cache=Shared");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<TodoModel> Todos { get; set; }
    }
}
