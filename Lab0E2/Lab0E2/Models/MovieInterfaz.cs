using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab0E2.Models
{
    interface MovieInterfaz
    {
        public void Add(Movie newdata);

        public List<Movie> library();
    }
}
