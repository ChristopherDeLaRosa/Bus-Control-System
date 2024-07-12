using BusinessLogicLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class DriverRegistration : Form
    {
        DriverBL driverBL = new DriverBL();
        public DriverRegistration()
        {
            InitializeComponent();
        }

        private void btnSaveDriver_Click(object sender, EventArgs e)
        {
            Driver driver = new Driver
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                BirthDate = dtpBirhdate.Value,
                IDNumber = txtIdNumber.Text

            };
            driverBL.AddDriver(driver);
            CleanControls();

            MessageBox.Show("Driver added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;


        }

        private void CleanControls()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            dtpBirhdate.Value = DateTime.Now;
            txtIdNumber.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CleanControls();
            MessageBox.Show("Registration Canceled", "Failed registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
