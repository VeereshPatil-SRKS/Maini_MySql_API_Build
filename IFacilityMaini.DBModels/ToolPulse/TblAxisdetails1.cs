using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class TblAxisdetails1
    {
        public int Adid { get; set; }
        public int MachineId { get; set; }
        public string Axis { get; set; }
        public decimal? AbsPos { get; set; }
        public decimal? RelPos { get; set; }
        public decimal? MacPos { get; set; }
        public decimal? DistPos { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? InsertedOn { get; set; }
    }
}
