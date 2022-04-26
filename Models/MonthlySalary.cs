using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Part2.Models
{
    public partial class MonthlySalary
    {
        public string CEmployeeCode { get; set; }
        public decimal? MMonthlySalary { get; set; }
        public DateTime DPayDate { get; set; }
        public decimal? MReferralBonus { get; set; }

        public virtual Employee CEmployeeCodeNavigation { get; set; }
    }
}
