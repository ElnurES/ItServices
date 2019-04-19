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
    public partial class BalansForm : Form
    {
        public BalansForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PayCreditCart payCreditCart = new PayCreditCart(
                                    Convert.ToInt32(txbx_cart_number.Text),
                                    Convert.ToInt32(txbx_cvc.Text),txbx_cart_date.Text,
                                    Convert.ToInt32(txbx_amunt.Text));

            StaticFakeDB.CreditCarts.Add(payCreditCart);
        }
        
    }
}
