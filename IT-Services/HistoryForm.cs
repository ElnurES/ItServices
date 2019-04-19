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
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable("Arxiv");
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Price", typeof(int));
            table.Columns.Add("Description", typeof(string));
            table.Columns.Add("Time", typeof(DateTime));

            int count = 0;
            foreach (History item in StaticFakeDB.HistoryList)
            {
                table.Rows.Add(count, item.Name, item.Price, item.Description , item.Time);
                count++;
            }
            dataGW.DataSource = table;
        }
    }
}
