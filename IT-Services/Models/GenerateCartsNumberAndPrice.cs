using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Services.Models
{
    class GenerateCartsNumberAndPrice
    {

        public string GenerateCartNumer()
        {
            string number = "";
            for (int i = 0; i < 3; i++)
            {
                Random random = new Random();
                number += random.Next(1000, 9999);
            }
            return number;

        }

        public string GenerateCartPrice()
        {
            Random price = new Random();
            string cartPrice = "";
            for (int i = 0; i < 40; i++)
            {
                int a = price.Next(10, 51);
                if (a == 10 || a == 15 || a == 25 || a == 50)
                {
                    cartPrice += a.ToString();
                    break;
                }
            }
            return cartPrice;

        }
    }
}
