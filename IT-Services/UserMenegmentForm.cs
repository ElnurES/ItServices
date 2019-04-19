using IT_Services.FakeDB;
using IT_Services.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_Services
{
    public partial class UserMenegmentForm : Form
    {
        public UserMenegmentForm()
        {
            InitializeComponent();
        }

        private void UserMenegmentForm_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable("Cartlar");
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Surname", typeof(string));
            table.Columns.Add("Password", typeof(string));
            table.Columns.Add("Price", typeof(int));
            table.Columns.Add("CartNumber", typeof(string));


            int count = 0;
            foreach (Users user in StaticFakeDB.UsersList)
            {
                table.Rows.Add(count, user.Name,user.Surname,user.Password,user.Price,user.CartNumber);
                count++;
            }
            dGW_userMenegment.DataSource = table;
        }
    }
}
