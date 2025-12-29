using HMS_Solution.Forms;
using HMS_Solution.Forms.AppointmentForm;
using HMS_Solution.Forms.BillForm;
using HMS_Solution.Forms.DoctorForm;
using HMS_Solution.Forms.LoginForm;
using HMS_Solution.Forms.PatientForm;
using HMS_Solution.Forms.UserForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_Solution
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addPatient_Click(object sender, EventArgs e)
        {
            ADDPatientForm patientForm = new ADDPatientForm();
            patientForm.Show();
        }

        private void addDoctor_Click(object sender, EventArgs e)
        {
            ADDDoctorForm doctorForm = new ADDDoctorForm();
            doctorForm.Show();
        }

        private void addAppointment_Click(object sender, EventArgs e)
        {
            ADDAppointmentForm appointmentForm = new ADDAppointmentForm();
            appointmentForm.ShowDialog();

        }

        private void addBill_Click(object sender, EventArgs e)
        {
            ADDBill billForm = new ADDBill();
            billForm.ShowDialog();

        }

        private void addUser_Click(object sender, EventArgs e)
        {
            ADDUserForm userForm = new ADDUserForm();
            userForm.Show();

        }

        private void updatePatient_Click(object sender, EventArgs e)
        {
            UPDATEPatientForm uPDATEPatientForm = new UPDATEPatientForm();
            uPDATEPatientForm.Show();
        }

        private void updateDoctor_Click(object sender, EventArgs e)
        {
            UPDATEDoctor uPDATEDoctor = new UPDATEDoctor();
            uPDATEDoctor.Show();
        }

        private void updateAppointment_Click(object sender, EventArgs e)
        {
            UPDATEAppointment uPDATEAppointment = new UPDATEAppointment();
            uPDATEAppointment.Show();
        }

        private void updateUsers_Click(object sender, EventArgs e)
        {
            UPDATEUsers uPDATEUSERS = new UPDATEUsers();
            uPDATEUSERS.Show();
        }

        private void deletePatient_Click(object sender, EventArgs e)
        {
            DELETEPatient dELETEPatient = new DELETEPatient();
            dELETEPatient.Show();
        }

        private void deleteDoctor_Click(object sender, EventArgs e)
        {
            DELETEDoctor dELETEDoctor = new DELETEDoctor();
            dELETEDoctor.Show();
        }

        private void deleteAppointment_Click(object sender, EventArgs e)
        {
            DELETEAppointment dELETEAppointment = new DELETEAppointment();
            dELETEAppointment.Show();
        }

        private void deleteUsers_Click(object sender, EventArgs e)
        {
            DELETEUsers dELETEUsers = new DELETEUsers();
            dELETEUsers.Show();
        }

        private void viewPatient_Click(object sender, EventArgs e)
        {
            VIEWPatient vIEWPatient = new VIEWPatient();
            vIEWPatient.Show();
        }

        private void viewDoctor_Click(object sender, EventArgs e)
        {
            VIEWDoctor vIEWDoctor = new VIEWDoctor();
            vIEWDoctor.Show();
        }

        private void viewAppointment_Click(object sender, EventArgs e)
        {
            VIEWAppointment vIEWAppointment = new VIEWAppointment();
            vIEWAppointment.Show();
        }

        private void viewUsers_Click(object sender, EventArgs e)
        {
            VIEWUsers vIEWUsers = new VIEWUsers();
            vIEWUsers.Show();
        }

        private void viewBill_Click(object sender, EventArgs e)
        {
            VIEWBill vIEWBill = new VIEWBill();
            vIEWBill.Show();
        }

        private void viewAllPatients_Click(object sender, EventArgs e)
        {
            ALLPatients aLLPatients = new ALLPatients();
            aLLPatients.Show();
        }

        private void viewAllDoctors_Click(object sender, EventArgs e)
        {
            ALLDoctors aLLDoctors = new ALLDoctors();
            aLLDoctors.Show();
        }

        private void viewAllAppointments_Click(object sender, EventArgs e)
        {
            ALLAppointments aLLAppointments = new ALLAppointments();
            aLLAppointments.Show();
        }

        private void viewAllBills_Click(object sender, EventArgs e)
        {
            ALLBills aLLBills = new ALLBills();
            aLLBills.Show();
        }

        private void viewAllUsers_Click(object sender, EventArgs e)
        {
            ALLUsers aLLUsers = new ALLUsers();
            aLLUsers.Show();
        }

        private void searchByDateRangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchByAppointment searchByAppointment = new SearchByAppointment();
            searchByAppointment.Show();
        }

        private void addServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADDService aDDService = new ADDService();
            aDDService.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UPDATEService uPDATEService = new UPDATEService();
            uPDATEService.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DELETEService dELETEService = new DELETEService();
            dELETEService.Show();
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ALLServices aLLServices = new ALLServices();
            aLLServices.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }
    }
}
