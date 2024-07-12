using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class AssignmentForm : Form
    {
        private DriverBL _driverBL = new DriverBL();
        private BusBL _busBL = new BusBL();
        private RouteBL _routeBL = new RouteBL();
        private AssignmentBL _assignmentBL = new AssignmentBL();
        public AssignmentForm()
        {
            InitializeComponent();
            //LoadData();
        }

        private void LoadData()
        {
            LoadDrivers();
            LoadBuses();
            LoadRoutes();
            LoadAssignments();
        }


        private void LoadDrivers()
        {
            DataTable drivers = _driverBL.GetAvailableDrivers();
            cmbDrivers.DataSource = drivers;
            cmbDrivers.DisplayMember = "FullName";
            cmbDrivers.ValueMember = "DriverID";
            cmbDrivers.SelectedIndex = -1;
        }

        private void LoadBuses()
        {
            DataTable buses = _busBL.GetAvailableBuses();
            cmbBuses.DataSource = buses;
            cmbBuses.DisplayMember = "Brand";
            cmbBuses.ValueMember = "BusID";
            cmbBuses.SelectedIndex = -1;
        }

        private void LoadRoutes()
        {
            DataTable routes = _routeBL.GetAvailableRoutes();
            cmbRoutes.DataSource = null;
            cmbRoutes.Items.Clear();
            cmbRoutes.DataSource = routes;
            cmbRoutes.DisplayMember = "RouteName";
            cmbRoutes.ValueMember = "RouteID";
            cmbRoutes.SelectedIndex = -1;
        }

        private void LoadAssignments()
        {
            DataTable assignments = _assignmentBL.GetAssignments();
            //cmbAssignments.DataSource = assignments;
            //cmbAssignments.DisplayMember = "AssignmentDetails";
            //cmbAssignments.ValueMember = "AssignmentID";
            //cmbAssignments.SelectedIndex = -1;

            dgvAssignments.DataSource = assignments;
            dgvAssignments.Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            if (dgvAssignments.SelectedRows.Count > 0)
            {

                int id = Convert.ToInt32(dgvAssignments.CurrentRow.Cells["AssignmentID"].Value);
                _assignmentBL.DeleteAssignment(id);

                MessageBox.Show("Assignment released successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                LoadData();

            }
            else
            {
                MessageBox.Show("Please select a Assignment to delete.", "Required selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AssignmentForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAssign_Click_1(object sender, EventArgs e)
        {
            if (cmbDrivers.SelectedIndex == -1 || cmbBuses.SelectedIndex == -1 || cmbRoutes.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a driver, bus, and route.");
                return;
            }

            int driverId = (int)cmbDrivers.SelectedValue;
            int busId = (int)cmbBuses.SelectedValue;
            int routeId = (int)cmbRoutes.SelectedValue;
            DateTime assignmentDate = DateTime.Now;

            try
            {
                _assignmentBL.AssignDriverToBusAndRoute(driverId, busId, routeId, assignmentDate);
                MessageBox.Show("Assignment added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                LoadData();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
