using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class Operationlog
    {
        public int Idoperationlog { get; set; }
        public string OpMsg { get; set; }
        public DateTime? OpDate { get; set; }
        public TimeSpan? OpTime { get; set; }
        public DateTime? OpDateTime { get; set; }
        public string OpReason { get; set; }
        public int? MachineId { get; set; }
    }
}
