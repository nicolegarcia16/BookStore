using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BookStore.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace BookStore.Controllers
{
    public class OrderController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult placeOrder(string cardholderName, int cardNumber, DateTime expiryDate, int securityCode,
                                        string name, string address, string city, string state, int zipCode)
        {
            var card = new CreditCardModel();
            if (validateCardInfo(name, cardNumber, expiryDate, securityCode))
            {

                card.cardholderName = name;
                card.cardNumber = cardNumber;
                card.expiryDate = expiryDate;
                card.securityCode = securityCode;
            }
            else
            {
                ViewBag.Info = "One or more fields are invalid. Please re-enter your information.";
                return View("Order");
            }
            if (validateShippingInfo(name, address, city, state, zipCode))
            {
                var thisAddress = new ShippingAddressModel();
                thisAddress.name = name;
                thisAddress.address = address;
                thisAddress.city = city;
                thisAddress.state = state;
                thisAddress.zipCode = zipCode;
            }
            else
            {
                ViewBag.Info = "One or more fields are invalid. Please re-enter your information.";
                return View("Order");
            }
            return View("Views/Home/Index.cshtml");
        }

        [HttpPost]
        public IActionResult confirmShippingInfo(string name, string address, string city, string state, int zipCode)
        {
            if (validateShippingInfo(name, address, city, state, zipCode))
            {
                var thisAddress = new ShippingAddressModel();
                thisAddress.name = name;
                thisAddress.address = address;
                thisAddress.city = city;
                thisAddress.state = state;
                thisAddress.zipCode = zipCode;
                ViewBag.Info = "Address is valid.";
            }
            else
                ViewBag.Info = "One or more fields are invalid.";
            return View();
        }

        public bool validateCardInfo(string name, int cardNumber, DateTime expiryDate, int securityCode)
        {
            bool isValid = true;
            if (name.Length == 0 || name == null)
                isValid = false;
            if (expiryDate.CompareTo(DateTime.Today) < 0 || expiryDate == null)
                isValid = false;
            return isValid;
        }

        public bool validateShippingInfo(string name, string address, string city, string state, int zipCode)
        {
            bool isValid = true;
            if (name.Length == 0 || name == null)
                isValid = false;
            if (address.Length == 0 || address == null)
                isValid = false;
            if (name.Length == 0 || name == null)
                isValid = false;
            if (name.Length == 0 || name == null)
                isValid = false;
            if (name.Length == 0 || name == null)
                isValid = false;
            return isValid;
        }
    }
}
