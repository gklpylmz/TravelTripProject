using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Siniflar
{
    public class Yorumlar
    {
        [Key]
        public int yorumID { get; set; }
        public string yorumKadi { get; set; }
        public string yorumMail { get; set; }
        public string yorumMain { get; set; }
        public int blogID { get; set; }
        public virtual Blog Blog { get; set; }

    }
}