using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesListing
{
    internal class MovieManager
    {
        public List<Movie> Movies { get; set; } = new List<Movie>();
        public void Add(Movie m)
        {
            Movies.Add(m);
        }
        public void Load()
        {

        }

        public void Save()
        {

        }
    }
}
