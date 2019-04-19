using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Services.Models
{
    class RegisterCart
    {
        public RegisterCart(string _number, int _price, DateTime _createTime, DateTime _endTime, bool _isUsed)
        {
            Number = _number;
            Price = _price;
            CreateTime = _createTime;
            EndTime = _endTime;
            IsUsed = _isUsed;
        }
        public string Number { get; set; }
        public int Price { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsUsed { get; set; }

    }
}
