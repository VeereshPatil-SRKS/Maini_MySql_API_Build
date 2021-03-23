using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblSourceMaster
    {
        public int SourceId { get; set; }
        public string SourceName { get; set; }
        public string SourceDescription { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
