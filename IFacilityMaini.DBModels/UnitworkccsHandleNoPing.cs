using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class UnitworkccsHandleNoPing
    {
        public int NoPingId { get; set; }
        public int? MachineId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
