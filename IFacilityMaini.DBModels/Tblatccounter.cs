using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class Tblatccounter
    {
        public int Atcid { get; set; }
        public int MachineId { get; set; }
        public int ToolNo { get; set; }
        public int Counter { get; set; }
        public DateTime InsertedOn { get; set; }
        public DateTime CycleStartTime { get; set; }
        public DateTime? CycleEndTime { get; set; }
        public int PartCount { get; set; }
    }
}
