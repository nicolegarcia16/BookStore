using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class ShippingAddressModel
    {
        [Required, StringLength(50)]
        [Display(Name = "name")]
        public string name { get; set; }

        [Required]
        [Display(Name = "address")]
        public string address { get; set; }

        [Required, StringLength(50)]
        [Display(Name = "city")]
        public string city { get; set; }

        [Required, StringLength(2)]
        [Display(Name = "state")]
        public string state { get; set; }

        [Required]
        [Display(Name = "zip")]
        public int zipCode { get; set; }
    }
}
