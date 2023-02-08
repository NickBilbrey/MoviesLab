using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Movies
{
    public class Movie_Store
    {
        public string movieTitle;
        public string movieCategory;

        public Movie_Store(string title, string category)
            {
            this.movieTitle = title;
            this.movieCategory = category;

            }
        
      /* public override string ToString()
        {
            return $"{movieTitle},{movieCategory}";
        }*/
    }
}
