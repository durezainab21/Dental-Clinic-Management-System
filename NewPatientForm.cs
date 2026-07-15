using System;
using System.Windows.Forms;

namespace Dental_Clinic_Management_System
{
    public partial class NewPatientForm : UserControl
    {
        public NewPatientForm()
        {
            InitializeComponent();
        }

        private void NewPatientForm_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            lblPatientID.Text = "P" + rnd.Next(1000, 9999);

            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" ||
                txtEmail.Text == "" ||
                txtMobile.Text == "" ||
                txtAddress.Text == "" ||
                txtPlace.Text == "" ||
                txtNationality.Text == "" ||
                txtBlood.Text == "")
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            string gender = "";

            if (radioMale.Checked)
                gender = "Male";
            else if (radioFemale.Checked)
                gender = "Female";

            MessageBox.Show(
                "Patient Saved Successfully\n\n" +
                "Patient ID: " + lblPatientID.Text +
                "\nName: " + txtName.Text +
                "\nDate of Birth: " + dateTimePicker1.Text +
                "\nGender: " + gender,
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ClearFields();

            MessageBox.Show(
                "Patient Record Deleted.",
                "Delete",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string gender = "";

            if (radioMale.Checked)
                gender = "Male";
            else if (radioFemale.Checked)
                gender = "Female";

            MessageBox.Show(
                "PATIENT INFORMATION\n\n" +
                "Patient ID: " + lblPatientID.Text +
                "\nName: " + txtName.Text +
                "\nDOB: " + dateTimePicker1.Text +
                "\nBlood Group: " + txtBlood.Text +
                "\nGender: " + gender +
                "\nEmail: " + txtEmail.Text +
                "\nMobile: " + txtMobile.Text +
                "\nAddress: " + txtAddress.Text +
                "\nPlace: " + txtPlace.Text +
                "\nNationality: " + txtNationality.Text,
                "Print Preview");
        }

        private void ClearFields()
        {
            txtName.Clear();
            txtBlood.Clear();
            txtEmail.Clear();
            txtMobile.Clear();
            txtAddress.Clear();
            txtPlace.Clear();
            txtNationality.Clear();

            radioMale.Checked = false;
            radioFemale.Checked = false;

            dateTimePicker1.Value = DateTime.Now;
        }

        private void txtTreatmentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}