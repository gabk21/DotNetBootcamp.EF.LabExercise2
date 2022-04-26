using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Part2.Models
{
    public class EmployeeReferral
    {
        public string CEmployeeReferralNo { get; set; }
        public string CEmployeeCode { get; set; }
        public string CCandidateCode { get; set; }

        public virtual ExternalCandidate CCandidateCodeNavigation { get; set; }
        public virtual Employee CEmployeeCodeNavigation { get; set; }
    }
}
