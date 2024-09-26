using Microsoft.EntityFrameworkCore;
namespace WebApplication1.Models
{
    public class DBcon : DbContext 
    {
        public DBcon(DbContextOptions<DBcon> options) : base(options) { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classs { get; set; }
    }
}
