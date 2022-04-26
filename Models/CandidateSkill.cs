using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Part2.Models
{
    public partial class CandidateSkill
    {
        public string CCandidateCode { get; set; }
        public string CSkillCode { get; set; }

        public virtual ExternalCandidate CCandidateCodeNavigation { get; set; }
        public virtual Skill CSkillCodeNavigation { get; set; }
    }
}
