using HMS_Solution.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Solution.DAL
{
    internal class DashboardRepository
    {
        public static DashboardStats FetchDashboardData()
        {
            HMSDataContext db = new HMSDataContext();

            DashboardStats DS = new DashboardStats();

            DS.TotalPatients = db.patients.Count();
            DS.TodayAppointments = db.appointments
                .Where(a => a.appointmentDate >= DateTime.Today && a.appointmentDate < DateTime.Today.AddDays(1))
                .Count();

            DS.TodayRevenue = db.bills
                .Where(b => b.billDate >= DateTime.Today
                         && b.billDate < DateTime.Today.AddDays(1)
                         && b.status == "paid" || b.status == "installments")
                .Sum(b => (decimal?)b.amount) ?? 0;


            DS.TotalPendingRevenue = db.bills
                .Where(b => b.status == "unpaid" || b.status == "installments")
                .Sum(b => (decimal?)b.remaining) ?? 0;

            
            DS.last7days = db.bills
                .Where(b => b.billDate >= DateTime.Today.AddDays(-7) && b.billDate < DateTime.Today)
                .Sum(b => (decimal?)b.amount) ?? 0;

            
            DS.last30days = db.bills
                .Where(b => b.billDate >= DateTime.Today.AddDays(-30) && b.billDate < DateTime.Today)
                .Sum(b => (decimal?)b.amount) ?? 0;


            DS.last365days = db.bills
                .Where(b => b.billDate >= new DateTime(DateTime.Today.Year, 1, 1) &&
                            b.billDate < new DateTime(DateTime.Today.Year + 1, 1, 1))
                .Sum(b => (decimal?)b.amount) ?? 0;


            return DS;
        }

    }
}
