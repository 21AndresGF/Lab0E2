﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab0E2.Models
{
    public interface MovieInterfaz
    {
        public void Add(MovieClass newdata);

        public List<MovieClass> library();
    }
}
