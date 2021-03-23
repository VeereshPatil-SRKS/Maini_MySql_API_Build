using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class Tblmimics
    {
        public int Mid { get; set; }
        public int MachineOnTime { get; set; }
        public int OperatingTime { get; set; }
        public int SetupTime { get; set; }
        public int IdleTime { get; set; }
        public int MachineOffTime { get; set; }
        public int BreakdownTime { get; set; }
        public int MachineId { get; set; }
        public string Shift { get; set; }
        public string CorrectedDate { get; set; }
        public int? IsSync { get; set; }

        public virtual Tblmachinedetails Machine { get; set; }
    }
}
