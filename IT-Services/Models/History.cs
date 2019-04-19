using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Services.Models
{
    class History
    {
        public History(string _name, int _price, string _description, DateTime _time)
        {
            Name = _name;
            Price = _price;
            Description = _description;
            Time = _time;
        }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public DateTime Time { get; set; }

    }
}
