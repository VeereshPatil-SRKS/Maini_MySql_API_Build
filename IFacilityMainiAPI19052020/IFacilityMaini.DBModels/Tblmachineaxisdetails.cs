using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class Tblmachineaxisdetails
    {
        public int MacAxisId { get; set; }
        public int? MachineId { get; set; }
        public int? AxisNo { get; set; }
        public string AxisName { get; set; }
        public int IsDeleted { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
