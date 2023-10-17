using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Siniflar
{
    public class İletisim
    {
        [Key]
        public int iletisimID { get; set; }
        public string iletisimAdSoyad { get; set; }
        public string İletisimMail { get; set; }
        public string iletisimMessage { get; set; }

    }
}