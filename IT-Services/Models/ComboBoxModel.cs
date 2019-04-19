using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Services.Models
{
    class ComboBoxModel
    {
        public ComboBoxModel(string _name, int _price)
        {
            Name = _name;
            Price = _price;
        }
        public string Name { get; set; }
        public int Price { get; set; }

        public string AddFullName()
        {
            string result = "";
            result = Name + " " + Price.ToString() + " " + "Azn";
            return result;
        }

    }
}
