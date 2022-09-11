using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Movie
    {
        public string title;
        public string director;
        private string ageRestriction;
        public Movie(string aTitle, string aDirector, string aAgeRestriction)
        {
            title = aTitle; 
            director = aDirector;
            Rating = aAgeRestriction;
        }

        public string Rating
        {
            get { return ageRestriction; } // GET THE rating
            set {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    ageRestriction = value;
                } else
                {
                    ageRestriction = "NR";
                };
            }
        }
    }
}
