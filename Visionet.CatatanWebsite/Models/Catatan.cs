using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Visionet.CatatanWebsite.Models
{
    public class Catatan
    {
        [Key]
        public int ID_catatan { get; set; }

        public int ID_user { get; set; }

        [Display(Name = "Catatan")]
        public string Notes { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Tgl_dibuat { get; set; }

        [Display(Name = "Decsription")]
        public string Description { get; set; }
        public virtual User User { get; set; }
    }
}