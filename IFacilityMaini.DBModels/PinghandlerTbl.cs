using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class PinghandlerTbl
    {
        public int Pid { get; set; }
        public int? MachineId { get; set; }
        public int? Pingcount { get; set; }
        public string CorrectedDate { get; set; }
        public string Ipaddress { get; set; }
    }
}
