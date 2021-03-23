using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class UnitworkccsTbloperatormachinedetails
    {
        public int OpertorMacDetId { get; set; }
        public int? OperatorLoginId { get; set; }
        public int? MachineId { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }

        public virtual UnitworkccsTbloperatorlogindetails OperatorLogin { get; set; }
    }
}
