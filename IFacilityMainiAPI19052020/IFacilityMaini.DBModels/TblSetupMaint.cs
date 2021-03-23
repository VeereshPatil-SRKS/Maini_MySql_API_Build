using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblSetupMaint
    {
        public int SetMainId { get; set; }
        public int LossCodeId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int IsCompleted { get; set; }
        public int ModeId { get; set; }
        public int IsStarted { get; set; }
        public int IsSetup { get; set; }
        public int MachineId { get; set; }
        public int DurationInSec { get; set; }
        public int MinorLossTime { get; set; }
        public int Sync { get; set; }
        public int? ServerSetMainId { get; set; }

        public virtual Tbllossescodes LossCode { get; set; }
        public virtual Tblmachinedetails Machine { get; set; }
    }
}
