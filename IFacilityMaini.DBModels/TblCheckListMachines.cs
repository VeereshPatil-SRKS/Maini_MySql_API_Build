using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblCheckListMachines
    {
        public int Id { get; set; }
        public int CheckListHeaderId { get; set; }
        public int IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int? IsActive { get; set; }
        public string MachineIds { get; set; }
        public int? PlantId { get; set; }
        public int? CategoryId { get; set; }
        public int? MakeId { get; set; }
    }
}
