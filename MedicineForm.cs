using System;
using System.Windows.Forms;

namespace Dental_Clinic_Management_System
{
    public partial class MedicineForm : UserControl
    {
        public MedicineForm()
        {
            InitializeComponent();
        }

        private void MedicineForm_Load(object sender, EventArgs e)
        {
            comboBoxMedicine.Items.Add("Tablet");
            comboBoxMedicine.Items.Add("Capsule");
            comboBoxMedicine.Items.Add("Syrup");
            comboBoxMedicine.Items.Add("Injection");
            comboBoxMedicine.Items.Add("Drops");
            comboBoxMedicine.Items.Add("Cream");
            comboBoxMedicine.Items.Add("Ointment");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxMedicine.Text == "" || txtMedicineName.Text == "")
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            MessageBox.Show("Medicine Added Successfully.");

            comboBoxMedicine.SelectedIndex = -1;
            txtMedicineName.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxMedicine.Text == "" || txtMedicineName.Text == "")
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            MessageBox.Show("Medicine Updated Successfully.");

            comboBoxMedicine.SelectedIndex = -1;
            txtMedicineName.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            comboBoxMedicine.SelectedIndex = -1;
            txtMedicineName.Clear();

            MessageBox.Show("Medicine Deleted Successfully.");
        }
    }
}