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
    public partial class GenerateCart : Form
    {
        GenerateCartsNumberAndPrice cart;
        public GenerateCart()
        {
            InitializeComponent();
            cart = new GenerateCartsNumberAndPrice();
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            
            txbx_cartNumber.Text = cart.GenerateCartNumer();
            txbx_cart_price.Text = cart.GenerateCartPrice();

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int price = Convert.ToInt32(txbx_cart_price.Text);
            DateTime newTime = DateTime.Now;
            DateTime endTime = newTime.AddMonths(4);
            RegisterCart registerCart = new RegisterCart(txbx_cartNumber.Text, price, newTime , endTime, true);

            StaticFakeDB.RegisterCartList.Add(registerCart);
        }
    }
}
