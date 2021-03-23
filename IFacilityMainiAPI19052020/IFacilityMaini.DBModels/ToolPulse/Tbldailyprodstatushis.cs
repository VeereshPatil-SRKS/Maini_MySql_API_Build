using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class Tbldailyprodstatushis
    {
        public int Id { get; set; }
        public int MachineId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int? Duration { get; set; }
        public string Status { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? InsertedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string CorrectedDate { get; set; }
        public string ColorCode { get; set; }
    }
}
