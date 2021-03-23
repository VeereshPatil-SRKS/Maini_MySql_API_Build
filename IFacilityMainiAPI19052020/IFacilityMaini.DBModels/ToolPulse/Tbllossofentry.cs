using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class Tbllossofentry
    {
        public int LossId { get; set; }
        public int MessageCodeId { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public DateTime? EntryTime { get; set; }
        public string CorrectedDate { get; set; }
        public int MachineId { get; set; }
        public string Shift { get; set; }
        public string MessageDesc { get; set; }
        public string MessageCode { get; set; }
        public int IsUpdate { get; set; }
        public int DoneWithRow { get; set; }
        public int? IsStart { get; set; }
        public int? IsScreen { get; set; }
        public int ForRefresh { get; set; }
        public int? LossMonth { get; set; }
        public int? LossYear { get; set; }
        public int? LossWeekNumber { get; set; }
        public int? LossQuarter { get; set; }

        public virtual Tbllossescodes MessageCodeNavigation { get; set; }
    }
}
