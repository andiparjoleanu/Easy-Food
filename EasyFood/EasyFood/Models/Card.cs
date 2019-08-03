using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EasyFood.Models
{
    public class Card
    {
        public int ID { get; set; }

        [Required]
        //[CreditCard]
        [Display(Name = "Număr Card")]
        public string NumarCard { get; set; }
        
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Dată Expirare")]
        //[DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataExpirare { get; set; }

        [Required]
        //[RegularExpression(@"[0-9]{4}")]
        public string CVV { get; set; }

        [Required]
        [Display(Name = "Posesor card")]
        public string Posesor { get; set; }

        public virtual Client Client { get; set; } 
    }
}