using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class Tblmanuallossofentry
    {
        public int MlossId { get; set; }
        public int MessageCodeId { get; set; }
        public DateTime? StartDateTime { get; set; }
        public string CorrectedDate { get; set; }
        public int MachineId { get; set; }
        public string Shift { get; set; }
        public string MessageDesc { get; set; }
        public string MessageCode { get; set; }
        public int? Hmiid { get; set; }
        public string PartNo { get; set; }
        public int? OpNo { get; set; }
        public string Wono { get; set; }
        public DateTime? EndDateTime { get; set; }
        public int? EndHmiid { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? ManualLossMonth { get; set; }
        public int? ManualLossYear { get; set; }
        public int? ManualLossWeekNumber { get; set; }
        public int? ManualLossQuarter { get; set; }

        public virtual Tbllossescodes MessageCodeNavigation { get; set; }
    }
}
