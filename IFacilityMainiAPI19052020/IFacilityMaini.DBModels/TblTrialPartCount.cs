using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblTrialPartCount
    {
        public int TrialPartId { get; set; }
        public int? TrialPartCount { get; set; }
        public int? MachineId { get; set; }
        public string CorrectedDate { get; set; }
        public string Shift { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? IsDeleted { get; set; }
    }
}
