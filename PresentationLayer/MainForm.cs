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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            CustomizeDesign();

        }
        private void CustomizeDesign()
        {
            panelRouteSubmenu.Visible = false;
            panelBusesSubmenu.Visible = false;
            panelDriverSubmenu.Visible = false;
        }

        private void HideSubmenu()
        {
            if (panelRouteSubmenu.Visible)
            {
                panelRouteSubmenu.Visible = false;
            }

            if (panelBusesSubmenu.Visible)
            {
                panelBusesSubmenu.Visible = false;
            }

            if (panelDriverSubmenu.Visible)
            {
                panelDriverSubmenu.Visible = false;
            }
        }

        public void ShowSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        public void OpenFormInPanel(Form childForm)
        {
            if (this.panelContainer.Controls.Count > 0)
            {
                this.panelContainer.Controls.RemoveAt(0);
            }

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(childForm);
            this.panelContainer.Tag = childForm;
            childForm.Show();
        }

        private void btnRoutes_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelRouteSubmenu);

        }
        #region RouteSubmenu
        private void btnAddRoute_Click(object sender, EventArgs e)
        {
            RouteRegistration routeRegistration = new RouteRegistration();
            OpenFormInPanel(routeRegistration);
            //..
            HideSubmenu();
        }

        private void btnSeeRoutes_Click(object sender, EventArgs e)
        {
            //..
            HideSubmenu();
        }
        #endregion


        private void btnBuses_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelBusesSubmenu);
        
        }

        #region BusesSubmenu
        private void btnAddBus_Click(object sender, EventArgs e)
        {
            BusesRegistration busesRegistration = new BusesRegistration();
            OpenFormInPanel(busesRegistration);
            //..
            HideSubmenu();
        }

        private void btnReadBuses_Click(object sender, EventArgs e)
        {
            BusesForm busesForm = new BusesForm();
            OpenFormInPanel(busesForm);
            //..
            HideSubmenu();
        }
        #endregion

        private void btnDrivers_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelDriverSubmenu);

        }

        #region DriverSubmenu
        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            DriverRegistration driverRegistration = new DriverRegistration();
            OpenFormInPanel(driverRegistration);
            //..
            HideSubmenu();
        }

        private void btnReadDriver_Click(object sender, EventArgs e)
        {
            DriversForm driversForm = new DriversForm();
            OpenFormInPanel(driversForm);
            //..
            HideSubmenu();
        }
        #endregion

        private void btnAssignments_Click(object sender, EventArgs e)
        {
            AssignmentForm assignmentForm = new AssignmentForm();
            OpenFormInPanel(assignmentForm);
        }

        
    }

}
