using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblOperatorHeader
    {
        public int OperatorId { get; set; }
        public int MachineId { get; set; }
        public string TabConnecStatus { get; set; }
        public string ServerConnecStatus { get; set; }
        public string Shift { get; set; }
        public string MachineMode { get; set; }
        public DateTime InsertedOn { get; set; }
        public int InsertedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int IsDeleted { get; set; }

        public virtual Tblmachinedetails Machine { get; set; }
    }
}
