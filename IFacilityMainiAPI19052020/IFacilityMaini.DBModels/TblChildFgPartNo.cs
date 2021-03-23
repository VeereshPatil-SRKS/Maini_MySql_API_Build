using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblChildFgPartNo
    {
        public int ChildFgpartId { get; set; }
        public string ChildFgPartNo { get; set; }
        public string ChildPartNoDesc { get; set; }
        public int? PlantId { get; set; }
        public string FgPartNo { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public string FgPartDesc { get; set; }
    }
}
