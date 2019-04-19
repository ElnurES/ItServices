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
    public partial class CartMenegerForm : Form
    {
        public CartMenegerForm()
        {
            InitializeComponent();
        }

        private void CartMenegerForm_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable("Cartlar");
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Number", typeof(string));
            table.Columns.Add("Price", typeof(int));
            table.Columns.Add("StartTime", typeof(DateTime));
            table.Columns.Add("EndTime", typeof(DateTime));
            table.Columns.Add("IsUsed", typeof(bool));


            int count = 0;
            foreach (RegisterCart item in StaticFakeDB.RegisterCartList)
            {
                table.Rows.Add(count, item.Number, item.Price, item.CreateTime, item.EndTime,item.IsUsed);
                count++;
            }
            dGW_cartMeneger.DataSource = table;
        }
    }
}
