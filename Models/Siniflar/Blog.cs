using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Siniflar
{
    public class Blog
    {
        [Key]
        public int blogID { get; set; }
        public string blogBaslik { get; set; }
        public DateTime blogTarih { get; set; }
        public string blogAciklama { get; set; }
        public string blogImage { get; set; }
        public ICollection<Yorumlar> Yorumlars { get; set; }
    }
}