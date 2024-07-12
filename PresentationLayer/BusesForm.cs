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
    public partial class BusesForm : Form
    {
        private BusBL busBL = new BusBL();
        public BusesForm()
        {
            InitializeComponent();
        }

        private void BusesForm_Load(object sender, EventArgs e)
        {
            LoadBuses();
        }

        public void LoadBuses()
        {
            List<Bus> busList = busBL.ReadBuses();
            dgvBuses.DataSource = busList;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgvBuses.SelectedRows.Count > 0)
            {

                int id = Convert.ToInt32(dgvBuses.CurrentRow.Cells["BusID"].Value);
                busBL.DeleteBus(id);

                MessageBox.Show("Bus deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                LoadBuses();

            }
            else
            {
                MessageBox.Show("Please select a bus to delete.", "Required selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvBuses.SelectedRows.Count > 0)
            {
                Bus selectedBus = (Bus)dgvBuses.SelectedRows[0].DataBoundItem;
                UpdateBusForm updateForm = new UpdateBusForm(selectedBus);
                if (updateForm.ShowDialog() == DialogResult.OK)
                {
                    LoadBuses(); // Recargar los datos después de la actualización
                }
            }
            else
            {
                MessageBox.Show("Please select a bus to update.", "Required selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
