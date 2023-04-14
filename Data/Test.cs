using Microsoft.EntityFrameworkCore;
using Testing_System.Models;

namespace Testing_System.Data
{
    public class Test : DbContext
    {
        public Test(DbContextOptions<Test> options) : base(options) {



        }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Blank> Blanks { get; set; }
    }
}
