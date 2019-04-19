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
    public partial class CreateComboBoxForm : Form
    {
        public CreateComboBoxForm()
        {
            InitializeComponent();
        }

        private void btn_add_comboBoxModel_Click(object sender, EventArgs e)
        {
            ComboBoxModel comboBoxModel = new ComboBoxModel(txbx_cbx_name.Text, Convert.ToInt32(txbx_cbc_price.Text));
            StaticFakeDB.ComboBoxList.Add(comboBoxModel);
        }
    }
}
