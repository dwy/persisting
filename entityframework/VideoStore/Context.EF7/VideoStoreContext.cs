namespace Context.EF7
{
    using Domain;
    using Microsoft.Data.Entity;
    using Microsoft.Data.Entity.Infrastructure;

    public class VideoStoreContext: DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }

        public VideoStoreContext(DbContextOptions options) : base(options)
        {

        }

// Alternative to getting the options from outside the DbContext: the DbContext configures itself:

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            optionsBuilder.UseInMemoryDatabase();
//        }
    }
}
