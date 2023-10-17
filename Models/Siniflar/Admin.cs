using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Siniflar
{
    public class Admin
    {

        [Key]
        public int adminID { get; set; }
        public string adminKullanici { get; set; }
        public string adminSifre { get; set; }

    }
}