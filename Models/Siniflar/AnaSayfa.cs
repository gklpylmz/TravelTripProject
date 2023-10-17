using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Siniflar
{
    public class AnaSayfa
    {
        [Key]
        public int anaSayfaID { get; set; }
        public string anaSayfaBaslik { get; set; }
        public string anaSayfaAciklama { get; set; }

    }
}