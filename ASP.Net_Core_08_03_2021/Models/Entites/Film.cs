using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Net_Core_08_03_2021.Models.Entites
{
    public class Film
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }


        public int GenreId { get; set; }

        public Genre Genre { get; set; }
    }
}
