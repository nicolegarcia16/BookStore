using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class UserModel
    {
        [StringLength(20), Required]
        [Display(Name ="Username")]
        public string userName { get; set; }

        [Required, MinLength(8)]
        [Display(Name ="password")]
        public string password { get; set; }
    }
}
