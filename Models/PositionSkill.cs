﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Part2.Models
{
    public partial class PositionSkill
    {
        public string CPositionCode { get; set; }
        public string CSkillCode { get; set; }

        public virtual Position CPositionCodeNavigation { get; set; }
        public virtual Skill CSkillCodeNavigation { get; set; }
    }
}