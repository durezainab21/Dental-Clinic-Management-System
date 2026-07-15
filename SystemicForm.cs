using System;
using System.Windows.Forms;

namespace Dental_Clinic_Management_System
{
    public partial class SystemForm : UserControl
    {
        public SystemForm()
        {
            InitializeComponent();
        }

        private void SystemForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("High");
            comboBox1.Items.Add("Medium");
            comboBox1.Items.Add("Low");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            MessageBox.Show("Record Added Successfully");

            comboBox1.SelectedIndex = -1;
            textBox1.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edit feature removed (no GridView available)");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete feature removed (no GridView available)");
        }
    }
}