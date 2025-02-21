namespace Practice.Data
{
    using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            //no options yet
        }
        public DbSet<Person> Persons { get; set; }
    }
}
