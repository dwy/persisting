namespace Application.EF7
{
    using System;
    using System.Linq;
    using Context.EF7;
    using Domain;
    using Microsoft.Data.Entity;

    static class Program
    {
        static void Main()
        {
            var optionsBuilder = new DbContextOptionsBuilder();
            optionsBuilder.UseInMemoryDatabase(); // extension method from package entityframework.inmemory

            using (var context = new VideoStoreContext(optionsBuilder.Options))
            {
                PrintEntitiesCount(context);

                var movie = new Movie { Name = "I am Legend" };
                var actor = new Actor { FirstName = "Will", LastName = "Smith" };
                movie.Actors.Add(actor);
                actor.Movies.Add(movie);

                context.AddRange(movie, actor);
                context.SaveChanges();

                PrintEntitiesCount(context);
            }

            Console.ReadLine();
        }

        private static void PrintEntitiesCount(VideoStoreContext context)
        {
            Console.WriteLine("movies: " + context.Movies.Count());
            Console.WriteLine("actors: " + context.Actors.Count());
        }
    }
}
