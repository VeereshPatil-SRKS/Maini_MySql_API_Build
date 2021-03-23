using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class JobcardDetails
    {
        public int JobcardId { get; set; }
        public int? Slno { get; set; }
        public string EmpNo { get; set; }
        public string OpnIdleCode { get; set; }
        public string Workorderno { get; set; }
        public string Compcode { get; set; }
        public int? Qtyprod { get; set; }
        public int? QtyAccp { get; set; }
        public int? QtyRej { get; set; }
        public TimeSpan? Fromtime { get; set; }
        public TimeSpan? Totime { get; set; }
        public string Totalhours { get; set; }
        public string MachineInvNumber { get; set; }
        public string Shift { get; set; }
        public string JobCardDate { get; set; }
        public DateTime? Fromdatetime { get; set; }
    }
}
