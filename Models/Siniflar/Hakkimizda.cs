using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Siniflar
{
    public class Hakkimizda
    {
        [Key]
        public int hakkimizdaID { get; set; }
        public string hakkimizdaFotoUrl { get; set; }
        public string hakkimizdaAciklama { get; set; }

    }
}