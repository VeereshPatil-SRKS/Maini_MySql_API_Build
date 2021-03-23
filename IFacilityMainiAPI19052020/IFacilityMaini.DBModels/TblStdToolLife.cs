using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblStdToolLife
    {
        public int StdToolLifeId { get; set; }
        public string Fgcode { get; set; }
        public string OperationNo { get; set; }
        public string ToolNo { get; set; }
        public string Ctcode { get; set; }
        public string ToolName { get; set; }
        public int StdToolLife { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public int MachineId { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
