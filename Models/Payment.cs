using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Part2.Models
{
    public partial class Payment
    {
        public string CSourceCode { get; set; }
        public decimal? MAmount { get; set; }
        public string CChequeNo { get; set; }
        public DateTime DDate { get; set; }
    }
}
