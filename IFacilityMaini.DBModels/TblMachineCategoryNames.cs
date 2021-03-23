using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblMachineCategoryNames
    {
        public int MachineCategoryId { get; set; }
        public string MachineCategoryName { get; set; }
        public string CategoryDesc { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? NodifiedBy { get; set; }
        public int? PlantId { get; set; }
    }
}
