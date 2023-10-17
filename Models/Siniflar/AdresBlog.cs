using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Siniflar
{
    public class AdresBlog
    {
        [Key]
        public int adresID { get; set; }
        public string baslik { get; set; }
        public string aciklama { get; set; }
        public string adresAcik { get; set; }
        public string mail { get; set; }
        public string tel { get; set; }
        public string konum { get; set; }
    }
}