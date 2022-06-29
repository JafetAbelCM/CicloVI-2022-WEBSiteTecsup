using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WEBSiteTecsup.Models
{
    public class Musica
    {
        [Key]
        public int MusicID { get; set; }

        public string MusicName { get; set; }

        public string MusicAutor { get; set; }

    }
}