namespace Domain
{
    using System.Collections.Generic;

    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Actor> Actors{ get; set; }

        public Movie()
        {
            Actors = new List<Actor>();
        }
    }
}
