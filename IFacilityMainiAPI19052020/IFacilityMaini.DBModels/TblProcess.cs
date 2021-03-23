using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblProcess
    {
        public int ProcessId { get; set; }
        public string ProcessName { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int? IsDeleted { get; set; }
    }
}
