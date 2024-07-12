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
    public partial class UpdateBusForm : Form
    {
        private Bus _bus;
        private BusBL busBL = new BusBL();

        public UpdateBusForm(Bus bus)
        {
            InitializeComponent();
            _bus = bus;
            LoadBusData();
        }

        private void LoadBusData()
        {
            //txtBusID.Text = _bus.BusID.ToString();
            txtBrand.Text = _bus.Brand;
            txtModel.Text = _bus.Model;
            txtPlate.Text = _bus.Plate;
            txtColor.Text = _bus.Color;
            txtYearProduction.Text = _bus.YearProduction.ToString();
            chkIsAvailable.Checked = _bus.IsAvailable;
        }

        private void btnUpdateBus_Click(object sender, EventArgs e)
        {
            _bus.Brand = txtBrand.Text;
            _bus.Model = txtModel.Text;
            _bus.Plate = txtPlate.Text;
            _bus.Color = txtColor.Text;
            _bus.YearProduction = int.Parse(txtYearProduction.Text);
            _bus.IsAvailable = chkIsAvailable.Checked;

            try
            {
                busBL.UpdateBus(_bus);
                MessageBox.Show("Successfully updated bus.", "Successful update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating bus: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }

}
