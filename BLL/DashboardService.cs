using HMS_Solution.DAL;
using HMS_Solution.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Solution.BLL
{
    internal class DashboardService
    {
        public static DashboardStats LoadDashboardData()
        {
            return DashboardRepository.FetchDashboardData();
        }
    }
}
