using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PatientForm
{
    public partial class frmPatient : Form
    {
        public frmPatient()
        {
            InitializeComponent();
        }

        private void patientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.patientDBDataSet);

        }

        private void patientBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.patientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.patientDBDataSet);

        }

        private void frmPatient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'patientDBDataSet.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.patientDBDataSet.Patient);

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            this.patientBindingSource.AddNew();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.patientDBDataSet);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            this.patientBindingSource.RemoveCurrent();
        }

        private void searchFirstToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.patientTableAdapter.SearchFirst(this.patientDBDataSet.Patient, firstToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void searchFirstToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.patientTableAdapter.SearchFirst(this.patientDBDataSet.Patient, firstToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
