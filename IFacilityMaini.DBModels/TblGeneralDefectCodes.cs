using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblGeneralDefectCodes
    {
        public int GeneralDefectCodeId { get; set; }
        public string DefectCodeName { get; set; }
        public string DefectCodeDesc { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
