using System;
using System.Windows.Forms;

namespace Dental_Clinic_Management_System
{
    public partial class TreatmentForm : UserControl
    {
        public TreatmentForm()
        {
            InitializeComponent();
        }

        private void TreatmentForm_Load(object sender, EventArgs e)
        {
            comboBoxTreatment.Items.Add("Cleaning");
            comboBoxTreatment.Items.Add("Filling");
            comboBoxTreatment.Items.Add("Extraction");
            comboBoxTreatment.Items.Add("Root Canal");
        }

        // ADD (just show message)
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxTreatment.Text == "" || txtTreatmentName.Text == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            MessageBox.Show("Treatment Added:\n" +
                            comboBoxTreatment.Text + " - " +
                            txtTreatmentName.Text);

            ClearFields();
        }

        // EDIT (just show message)
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxTreatment.Text == "" || txtTreatmentName.Text == "")
            {
                MessageBox.Show("Select data to edit");
                return;
            }

            MessageBox.Show("Treatment Updated:\n" +
                            comboBoxTreatment.Text + " - " +
                            txtTreatmentName.Text);
        }

        // DELETE (just clear fields)
        private void btnDelete_Click(object sender, EventArgs e)
        {
            comboBoxTreatment.SelectedIndex = -1;
            txtTreatmentName.Clear();

            MessageBox.Show("Fields Cleared");
        }

        // CLEAR FUNCTION
        private void ClearFields()
        {
            comboBoxTreatment.SelectedIndex = -1;
            txtTreatmentName.Clear();
        }
    }
}