using System;
using System.Text;
using System.Windows.Forms;

namespace Dental_Clinic_Management_System
{
    public partial class Medical : UserControl
    {
        public Medical()
        {
            InitializeComponent();
        }

        private void Medical_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add("Diabetes");
            checkedListBox1.Items.Add("Hypertension");
            checkedListBox1.Items.Add("Heart Disease");
            checkedListBox1.Items.Add("Asthma");
            checkedListBox1.Items.Add("Allergy");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StringBuilder alerts = new StringBuilder();

            foreach (var item in checkedListBox1.CheckedItems)
            {
                alerts.AppendLine(item.ToString());
            }

            MessageBox.Show(
                "Medical Record Saved Successfully\n\n" +
                "Systemic Alerts:\n" + alerts.ToString() +
                "\nNote:\n" + txtNote.Text,
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            ClearFields();
        }

        private void ClearFields()
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }

            txtNote.Clear();
        }
    }
}