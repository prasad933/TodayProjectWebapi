
using Microsoft.EntityFrameworkCore;
using TodayProjectWebapi.MODELS;
namespace TodayProjectWebapi.DBCONTEXT
{
    public class TodayprojectDBContext : DbContext
    {
        public TodayprojectDBContext(DbContextOptions<TodayprojectDBContext> options):base(options) 
        {
        
        }

        public DbSet<Learner> Learners { get; set; }
        public DbSet<Course> Courses { get; set; }
       


    }
}
