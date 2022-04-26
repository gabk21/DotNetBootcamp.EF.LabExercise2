using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Part2.Models
{
    public partial class AnnualSalary
    {
        public string CEmployeeCode { get; set; }
        public decimal? MAnnualSalary { get; set; }
        public short SiYear { get; set; }

        public virtual Employee CEmployeeCodeNavigation { get; set; }
    }
}
