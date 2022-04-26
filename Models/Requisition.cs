using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Part2.Models
{
    public partial class Requisition
    {
        public string CRequisitionCode { get; set; }
        public string CPositionCode { get; set; }
        public DateTime? DDateofRequisition { get; set; }
        public DateTime? DDeadline { get; set; }
        public string CDepartmentCode { get; set; }
        public string VRegion { get; set; }
        public short? SiNoOfVacancy { get; set; }

        public virtual Position CPositionCodeNavigation { get; set; }
    }
}
