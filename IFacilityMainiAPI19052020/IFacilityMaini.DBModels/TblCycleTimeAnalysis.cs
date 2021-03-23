using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblCycleTimeAnalysis
    {
        public int Ctaid { get; set; }
        public string PartNum { get; set; }
        public int? MachineId { get; set; }
        public string CorrectedDate { get; set; }
        public int? PartsCount { get; set; }
        public decimal? StdCycleTime { get; set; }
        public string StdCycleTimeUnit { get; set; }
        public decimal? AvgLoadTimeinMinutes { get; set; }
        public decimal? OperatingTime { get; set; }
        public string OperatingTimeUnit { get; set; }
        public decimal? AvgOperatingTime { get; set; }
        public string AvgOperatingTimeUnit { get; set; }
        public decimal? StdLoadTime { get; set; }
        public string StdLoadTimeUnit { get; set; }
        public decimal? TotalLoadTime { get; set; }
        public string TotalLoadTimeUnit { get; set; }
        public decimal? LossTime { get; set; }
        public string LossTimeUnit { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }

        public virtual Tblmachinedetails Machine { get; set; }
    }
}
