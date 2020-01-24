using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab0E2.Models;

namespace Lab0E2.Models
{
    public class Singleton
    {
        //private readonly static Singleton _instance = new Singleton();

        private Singleton()
        {
        }
        private static Singleton _instance = null;
        public static Singleton Instance
        {
            get
            {
                if (_instance == null) _instance = new Data();
                return _instance;
            }
        }
        public List<MovieClass> MovieClass = new List<MovieClass>();
    }
}
