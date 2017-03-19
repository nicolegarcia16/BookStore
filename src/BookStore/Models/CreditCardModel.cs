using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class CreditCardModel
    {
        public string cardholderName { get; set; }
        
        public int cardNumber { get; set; }

        public DateTime expiryDate { get; set; }
        
        public int securityCode { get; set; }
    }
}
