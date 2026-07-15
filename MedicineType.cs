using System;
using System.Windows.Forms;

namespace Dental_Clinic_Management_System
{
    public partial class MedicineTypeForm : UserControl
    {
        public MedicineTypeForm()
        {
            InitializeComponent();
        }

        private void MedicineTypeForm_Load(object sender, EventArgs e)
        {
            comboBoxMedicineType.Items.Add("Tablet");
            comboBoxMedicineType.Items.Add("Capsule");
            comboBoxMedicineType.Items.Add("Syrup");
            comboBoxMedicineType.Items.Add("Injection");
            comboBoxMedicineType.Items.Add("Drops");
            comboBoxMedicineType.Items.Add("Cream");
            comboBoxMedicineType.Items.Add("Ointment");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBoxMedicineType.Text == "" || txtMedicineTypeName.Text == "")
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            MessageBox.Show("Medicine Type Added Successfully.");

            comboBoxMedicineType.SelectedIndex = -1;
            txtMedicineTypeName.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBoxMedicineType.Text == "" || txtMedicineTypeName.Text == "")
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            MessageBox.Show("Medicine Type Updated Successfully.");

            comboBoxMedicineType.SelectedIndex = -1;
            txtMedicineTypeName.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBoxMedicineType.SelectedIndex = -1;
            txtMedicineTypeName.Clear();

            MessageBox.Show("Medicine Type Deleted Successfully.");
        }
    }
}