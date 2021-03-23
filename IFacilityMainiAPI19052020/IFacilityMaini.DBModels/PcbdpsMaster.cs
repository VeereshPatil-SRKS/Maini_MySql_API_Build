using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class PcbdpsMaster
    {
        public int PcbDpsMasterId { get; set; }
        public int? Pin17 { get; set; }
        public int? Pin18 { get; set; }
        public int? Pin19 { get; set; }
        public int? Pin20 { get; set; }
        public int? Pin22 { get; set; }
        public int? Pin23 { get; set; }
        public int? Pin24 { get; set; }
        public int? Pin25 { get; set; }
        public int? Pin26 { get; set; }
        public int? MachineId { get; set; }
        public string ColorValue { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? IsDeleted { get; set; }
    }
}
