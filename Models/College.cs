using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Part2.Models
{
    public partial class College
    {
        public College()
        {
            CampusRecruitments = new HashSet<CampusRecruitment>();
        }

        public string CCollegeCode { get; set; }
        public string CCollegeName { get; set; }
        public string VCollegeAddress { get; set; }
        public string CCity { get; set; }
        public string CState { get; set; }
        public string CZip { get; set; }
        public string CPhone { get; set; }

        public virtual ICollection<CampusRecruitment> CampusRecruitments { get; set; }
    }
}
