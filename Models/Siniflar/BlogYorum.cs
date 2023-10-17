using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace TravelTripProject.Models.Siniflar
{
    public class BlogYorum
    {
        // Bir view aracılığı ile iki tane deger cekicez
        public IEnumerable<Blog> Deger1 { get; set; }
        public IEnumerable<Yorumlar> Deger2 { get; set; }
        public IEnumerable<Blog> Deger3 { get; set; }
    }
}