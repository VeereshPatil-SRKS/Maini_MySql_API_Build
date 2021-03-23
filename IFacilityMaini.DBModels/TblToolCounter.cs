using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblToolCounter
    {
        public int ToolCounterId { get; set; }
        public int MachineId { get; set; }
        public string ToolNum { get; set; }
        public int LifeCounter { get; set; }
        public int TotalLifeCounter { get; set; }
        public int IsReset { get; set; }
        public int ResetCounter { get; set; }
        public int InsertedBy { get; set; }
        public DateTime InsertedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int IsDeleted { get; set; }
    }
}
