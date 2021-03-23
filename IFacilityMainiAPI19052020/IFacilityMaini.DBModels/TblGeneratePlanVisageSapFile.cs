using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblGeneratePlanVisageSapFile
    {
        public int SapFileId { get; set; }
        public DateTime? SapFileGeneratedDate { get; set; }
        public int? TotalActualCount { get; set; }
        public int? MachineId { get; set; }
        public string SapFileName { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int? IsDeleted { get; set; }
        public string CorrectedDate { get; set; }
    }
}
