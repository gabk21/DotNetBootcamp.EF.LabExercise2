using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Part2.Models
{
    public partial class EmployeeSkill
    {
            public string CEmployeeCode { get; set; }
            public string CSkillCode { get; set; }

            public virtual Employee CEmployeeCodeNavigation { get; set; }
            public virtual Skill CSkillCodeNavigation { get; set; }
    }
}
