using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using Entities;

namespace PresentationLayer
{
    public partial class BusesRegistration : Form
    {
        BusBL busBL = new BusBL();
        public BusesRegistration()
        {
            InitializeComponent();
        }

        private void btnSaveBus_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtProductionYear.Text, out int yearProduction))
            {
                Bus bus = new Bus
                {
                    Brand = txtBrand.Text,
                    Model = txtModel.Text,
                    Plate = txtPlate.Text,
                    Color = txtColor.Text,
                    YearProduction = yearProduction, // Usa el entero convertido aquí
                };
                busBL.AddBus(bus);
                CleanControls();
                MessageBox.Show("Bus added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Please enter a valid year for Production Year.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CleanControls()
        {
            txtBrand.Clear();
            txtModel.Clear();
            txtPlate.Clear();
            txtColor.Clear();
            txtProductionYear.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CleanControls();
            MessageBox.Show("Registration Canceled", "Failed registration", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
