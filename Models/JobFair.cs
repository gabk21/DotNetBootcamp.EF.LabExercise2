using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Part2.Models
{
    public partial class JobFair
    {
        public JobFair()
        {
            ExternalCandidates = new HashSet<ExternalCandidate>();
        }

        public string CJobFairCode { get; set; }
        public string VLocation { get; set; }
        public string VJobFairCompany { get; set; }
        public decimal? MFee { get; set; }
        public DateTime? DFairDate { get; set; }

        public virtual ICollection<ExternalCandidate> ExternalCandidates { get; set; }
    }
}
