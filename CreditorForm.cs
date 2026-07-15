using System;
using System.Windows.Forms;

namespace Dental_Clinic_Management_System
{
    public partial class CreditorForm : UserControl
    {
        public CreditorForm()
        {
            InitializeComponent();
        }

        private void CreditorForm_Load(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCreditorName.Text == "")
            {
                MessageBox.Show("Please enter creditor name.");
                return;
            }

            MessageBox.Show("Creditor Added Successfully.");

            txtCreditorName.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtCreditorName.Text == "")
            {
                MessageBox.Show("Please select creditor name to edit.");
                return;
            }

            MessageBox.Show("Creditor Updated Successfully.");

            txtCreditorName.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtCreditorName.Clear();

            MessageBox.Show("Creditor Deleted Successfully.");
        }
    }
}