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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            foreach (Users user in StaticFakeDB.UsersList)
            {
                lbl_balans.Text += user.Price;
            }

            foreach (PayCreditCart cart in StaticFakeDB.CreditCarts)
            {
                int a = Convert.ToInt32(lbl_balans.Text);
                if (cart != null)
                {
                    lbl_balans.Text = (a + cart.Amount).ToString();
                }

            }
            foreach (ComboBoxModel item in StaticFakeDB.ComboBoxList)
            {
                xBox_services.Items.AddRange(new object[] {item.AddFullName()});
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BalansForm balansForm = new BalansForm();
            balansForm.Show();
        }

        private void btn_service_Click(object sender, EventArgs e)
        {
            ServiceBuy service = new ServiceBuy
            {
                ServiceName = xBox_services.Text,
                Description = txbx_description.Text,
                ServiceTime = DateTime.Now
            };
            StaticFakeDB.ServicesList.Add(service);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //foreach (ServiceBuy item in StaticFakeDB.ServicesList)
            //{
                foreach (ComboBoxModel boxItem in StaticFakeDB.ComboBoxList)
                {
                    if (xBox_services.Text == boxItem.AddFullName())
                    {
                        History history = new History(boxItem.Name, boxItem.Price, txbx_description.Text, DateTime.Now);
                        StaticFakeDB.HistoryList.Add(history);
                    }
                }
            //}
            HistoryForm historyForm = new HistoryForm();
            historyForm.Show();
        }
    }
}
