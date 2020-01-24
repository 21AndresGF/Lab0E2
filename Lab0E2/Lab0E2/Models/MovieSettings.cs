using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab0E2.Models
{
    public class MovieSettings :MovieInterfaz
    {
        public List<MovieClass> AllMovies = new List<MovieClass>();

        public void Add(MovieClass newdata)
        {
            AllMovies.Add(newdata);
        }
        public List<MovieClass> library()
        {
            List<MovieClass> getmovies = new List<MovieClass>();
            if (AllMovies.Count > 10)
            {
                int temp = AllMovies.Count - 1;
                for (int i = 0; i < 10; i++)
                {
                    getmovies.Add(AllMovies[temp - i]);
                }
            }
            else
            {
                for (int i = 0; i < AllMovies.Count; i++)
                {
                    getmovies.Add(AllMovies[i]);
                }
            }
            return getmovies;

        }
    }
}
