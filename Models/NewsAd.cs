using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Part2.Models
{
    public partial class NewsAd
    {
        public NewsAd()
        {
            ExternalCandidates = new HashSet<ExternalCandidate>();
        }

        public string CNewsAdNo { get; set; }
        public string CNewspaperCode { get; set; }
        public DateTime? DAdStartDate { get; set; }
        public DateTime? DDeadline { get; set; }

        public virtual Newspaper CNewspaperCodeNavigation { get; set; }
        public virtual ICollection<ExternalCandidate> ExternalCandidates { get; set; }
    }
}
