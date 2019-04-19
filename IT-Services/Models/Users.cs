using IT_Services.FakeDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_Services.Models
{
    class Users:Person
    {
        public string CartNumber { get; set; }
        public int Price { get; set; }
        
        public bool ValidateConfirmPassword(string password, string confirmPassword)
        {
            if (password == confirmPassword)
            {
                return true;
            }
            else
                return false;
        }

    }
}
