using HMS_Solution.BLL;
using HMS_Solution.Forms.AppointmentForm;
using HMS_Solution.Forms.BillForm;
using HMS_Solution.Forms.PatientForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HMS_Solution.Forms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnNewPatient_Click(object sender, EventArgs e)
        {
            ADDPatientForm aDDPatientForm = new ADDPatientForm();
            aDDPatientForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ADDAppointmentForm aDDAppointmentForm = new ADDAppointmentForm();
            aDDAppointmentForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ALLServices aLLServices = new ALLServices();
            aLLServices.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ADDBill aDDBill = new ADDBill();
            aDDBill.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            var data = DashboardService.LoadDashboardData();

            lblTotalPatients.Text = data.TotalPatients.ToString();
            lblTodaysApp.Text = data.TodayAppointments.ToString();
            lblTodaysRevenue.Text = data.TodayRevenue.ToString();
            lblPendingBills.Text = data.TotalPendingRevenue.ToString();
            lblSevenDays.Text = data.last7days.ToString();
            lblThirtyDays.Text = data.last30days.ToString();
            lblLastYear.Text = data.last365days.ToString();

        }
    }
    public class DashboardStats
    {
        public int TotalPatients { get; set; }
        public int TodayAppointments { get; set; }
        public decimal TodayRevenue { get; set; }
        public decimal TotalPendingRevenue { get; set; }
        public decimal last7days { get; set; }
        public decimal last30days { get; set; }
        public decimal last365days { get; set; }
    }

}
