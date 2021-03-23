using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblOperatorMachineDetails
    {
        public int OpertorMacDetId { get; set; }
        public int? OperatorLoginId { get; set; }
        public int? MachineId { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Tblmachinedetails Machine { get; set; }
        public virtual TblOperatorLoginDetails OperatorLogin { get; set; }
    }
}
