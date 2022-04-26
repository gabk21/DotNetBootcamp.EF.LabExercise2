using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Part2.Models
{
    public partial class CampusRecruitment
    {
        public CampusRecruitment()
        {
            ExternalCandidates = new HashSet<ExternalCandidate>();
        }

        public string CCampusRecruitmentCode { get; set; }
        public string CCollegeCode { get; set; }
        public DateTime? DRecruitmentStartDate { get; set; }
        public DateTime? DRecruitmentEndDate { get; set; }

        public virtual College CCollegeCodeNavigation { get; set; }
        public virtual ICollection<ExternalCandidate> ExternalCandidates { get; set; }
    }
}
