using System;
using System.Windows.Forms;

namespace CtuLogistics
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        //Link to address Form//
        private void LinkToAddresses_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddressForm formMain = new AddressForm();
            formMain.ShowDialog();
            formMain = null;
        }

        //Link to customer form//
        private void LinkToCustomers_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerForm formMain = new CustomerForm();
            formMain.ShowDialog();
            formMain = null;
        }

        //Link to Freight Form//
        private void LinkToFreight_Click(object sender, EventArgs e)
        {
            this.Hide();
            FreightForm formMain = new FreightForm();
            formMain.ShowDialog();
            formMain = null;
        }

        //Link to Drivers Form//
        private void LinkToDrivers_Click(object sender, EventArgs e)
        {
            this.Hide();
            DriverForm formMain = new DriverForm();
            formMain.ShowDialog();
            formMain = null;
        }

        //Link to Status Form//
        private void LinkToStatus_Click(object sender, EventArgs e)
        {
            this.Hide();
            StatusForm formMain = new StatusForm();
            formMain.ShowDialog();
            formMain = null;
        }

        //Exit//
        private void AppExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
