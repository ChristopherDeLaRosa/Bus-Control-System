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
    public partial class DriversForm : Form
    {
        private DriverBL driverBL = new DriverBL();
        public DriversForm()
        {
            InitializeComponent();
            LoadDrivers();
        }

        public void LoadDrivers()
        {
            List<Driver> driverList = driverBL.ReadDrivers();
            dgvDrivers.DataSource = driverList;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDrivers.SelectedRows.Count > 0)
            {

                int id = Convert.ToInt32(dgvDrivers.CurrentRow.Cells["DriverID"].Value);
                driverBL.DeleteDriver(id);

                MessageBox.Show("Driver deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                LoadDrivers();

            }
            else
            {
                MessageBox.Show("Please select a driver to delete.", "Required selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvDrivers.SelectedRows.Count > 0)
            {
                Driver selectedDriver = (Driver)dgvDrivers.SelectedRows[0].DataBoundItem;
                UpdateDriverForm updateDriverForm = new UpdateDriverForm(selectedDriver);
                if (updateDriverForm.ShowDialog() == DialogResult.OK)
                {
                    LoadDrivers(); // Recargar los datos después de la actualización
                }
            }
            else
            {
                MessageBox.Show("Please select a driver to update.", "Required selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
