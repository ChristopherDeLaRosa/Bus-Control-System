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
    public partial class UpdateDriverForm : Form
    {
        private Driver _driver;
        private DriverBL driverBL = new DriverBL();

        public UpdateDriverForm(Driver driver)
        {
            InitializeComponent();
            _driver = driver;
            LoadDriverData();
        }

        private void LoadDriverData()
        {
            txtFirstName.Text = _driver.FirstName;
            txtLastName.Text = _driver.LastName;
            dtpBirhdate.Value = _driver.BirthDate;
            txtIdNumber.Text = _driver.IDNumber;
            chkIsAvailable.Checked = _driver.IsAvailable;

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            _driver.FirstName = txtFirstName.Text;
            _driver.LastName = txtLastName.Text;
            _driver.BirthDate = dtpBirhdate.Value;
            _driver.IDNumber = txtIdNumber.Text;
            _driver.IsAvailable = chkIsAvailable.Checked;

            try
            {
                driverBL.UpdateDriver(_driver);
                MessageBox.Show("Successfully updated driver.", "Successful update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating driver: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
