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
    public partial class RoutesForm : Form
    {
        private RouteBL routeBL = new RouteBL();
        public RoutesForm()
        {
            InitializeComponent();
        }

        public void LoadRoutes()
        {
            List<Route> driverList = routeBL.ReadRoutes();
            dgvRoutes.DataSource = driverList;
        }

        

        private void RoutesForm_Load(object sender, EventArgs e)
        {
            LoadRoutes();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dgvRoutes.SelectedRows.Count > 0)
            {

                int id = Convert.ToInt32(dgvRoutes.CurrentRow.Cells["RouteID"].Value);
                routeBL.DeleteRoute(id);

                MessageBox.Show("Route deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                LoadRoutes();

            }
            else
            {
                MessageBox.Show("Please select a route to delete.", "Required selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
