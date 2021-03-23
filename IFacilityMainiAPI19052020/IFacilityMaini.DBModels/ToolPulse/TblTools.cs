using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class TblTools
    {
        public int ToolId { get; set; }
        public string ToolName { get; set; }
        public string ToolLocation { get; set; }
        public string ToolDesc { get; set; }
        public string ToolBatchNo { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? PlantId { get; set; }
        public string SapCode { get; set; }
        public string GrnNo { get; set; }
        public string InspLotNo { get; set; }
        public int? SlipNo { get; set; }
        public string PlantCode { get; set; }
        public string ToolSapCode { get; set; }
        public string Uom { get; set; }
        public string ToolType { get; set; }
        public string ToolInsert { get; set; }
        public int? StandardToolLife { get; set; }
    }
}
