using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Services.Models
{
    class PayCreditCart
    {
        public PayCreditCart(int _cartNumber, int _cartCVC, string _cartDate, int _amount)
        {
            CartNumber = _cartNumber;
            CartCVC = _cartCVC;
            CartDate = _cartDate;
            Amount = _amount;
        }
        public int CartNumber { get; set; }
        public int CartCVC { get; set; }
        public string CartDate { get; set; }
        public int Amount { get; set; }
    }
}
