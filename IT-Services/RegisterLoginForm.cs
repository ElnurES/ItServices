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
    public partial class RegisterLoginForm : Form
    {
        public RegisterLoginForm()
        {
            InitializeComponent();
        }

        private void Btn_register_Click(object sender, EventArgs e)
        {
            lbl_error.Text = "";
            Users user = new Users();
            bool check = user.ValidateConfirmPassword(txbx_register_password.Text, txbx_register_confirm_password.Text);

            user.Name = txbx_register_name.Text;
            user.Surname = txbx_register_surname.Text;
            user.Email = txbx_register_email.Text;
            user.Password = txbx_register_password.Text;

            if (check == false)
            {
                lbl_error.Text = "Error confirm password";
            }

            if (lbl_error.Text == "")
            {
                StaticFakeDB.UsersList.Add(user);
            }

        }

        private void Btn_cart_register_Click(object sender, EventArgs e)
        {
            lbl_error.Text = "";
            Users user = new Users();
            bool check = user.ValidateConfirmPassword(txbx_reg_cart_password.Text, txbx_reg_confirm_password.Text);
            user.CartNumber = txbx_cart_number.Text;
            user.Email = txbx_reg_cart_email.Text;
            user.Password = txbx_reg_cart_password.Text;
            if (check == false)
            {
                lbl_error.Text = "Error confirm password";
            }

            foreach (RegisterCart item in StaticFakeDB.RegisterCartList)
            {
                user.Price = item.Price;
                if (txbx_cart_number.Text == item.Number && lbl_error.Text == "")
                {
                    StaticFakeDB.UsersList.Add(user);
                    item.IsUsed = false;
                }
            }
            
           
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txbx_login_email.Text == "admin" && txbx_login_password.Text == "admin")
            {
                AdminPanel admin = new AdminPanel();
                admin.Show();
            }
            else
            {
                foreach (Users user in StaticFakeDB.UsersList)
                {
                    if (txbx_login_email.Text == user.Email && txbx_login_password.Text == user.Password)
                    {
                        UserForm userForm = new UserForm();
                        userForm.Show();
                    }
                }
            }
        }
    }
}
