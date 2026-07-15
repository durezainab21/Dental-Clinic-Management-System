using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Clinic_Management_System
{
    public partial class Homeform : Form
    {
        public Homeform()
        {
            InitializeComponent();
        }

        private void LoadSystemForm()
        {
            panelContainer.Controls.Clear();

            SystemForm sys = new SystemForm();
            sys.Dock = DockStyle.Fill;

            panelContainer.Controls.Add(sys);
        }

        private void LoadTreatmentForm()
        {
            panelContainer.Controls.Clear();

            TreatmentForm t = new TreatmentForm();
            t.Dock = DockStyle.Fill;

            panelContainer.Controls.Add(t);
        }

        private void LoadMedicineTypeForm()
        {
            panelContainer.Controls.Clear();

            MedicineTypeForm t = new MedicineTypeForm();
            t.Dock = DockStyle.Fill;

            panelContainer.Controls.Add(t);
        }

        private void LoadMedicineForm()
        {
            panelContainer.Controls.Clear();

            MedicineForm t = new MedicineForm();
            t.Dock = DockStyle.Fill;

            panelContainer.Controls.Add(t);
        }

        private void LoadCreditorForm()
        {
            panelContainer.Controls.Clear();

            CreditorForm t = new CreditorForm();
            t.Dock = DockStyle.Fill;

            panelContainer.Controls.Add(t);
        }

        private void LoadNewPatientForm()
        {
            panelContainer.Controls.Clear();

            NewPatientForm patient = new NewPatientForm();
            patient.Dock = DockStyle.Fill;

            panelContainer.Controls.Add(patient);
        }

        private void LoadMedicalForm()
        {
            panelContainer.Controls.Clear();

            Medical patient = new Medical();
            patient.Dock = DockStyle.Fill;

            panelContainer.Controls.Add(patient);
        }

        public Homeform(string username)
        {
            InitializeComponent();
            lblUserName.Text = username;
        }
        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaster_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(btnMaster, 0, btnMaster.Height);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
         

        }

        private void Homeform_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void systematicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();

            SystemForm sys = new SystemForm();
            sys.Dock = DockStyle.Fill;

            panelContainer.Controls.Add(sys);
        }

        private void treatmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadTreatmentForm();
        }

        private void medicineTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadMedicineTypeForm();
        }

        private void medicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadMedicineForm();
        }

        private void creditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadCreditorForm();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoadNewPatientForm();

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            LoadMedicalForm();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            contextMenuStrip2.Show(btnPatient, 0, btnPatient.Height);
        }
    }
    }
    
