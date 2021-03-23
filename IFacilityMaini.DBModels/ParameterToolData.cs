using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class ParameterToolData
    {
        public int ParameterToolDataId { get; set; }
        public int? MachineId { get; set; }
        public DateTime? ParameterToolDataCapturedDate { get; set; }
        public string ToolGroupName { get; set; }
        public string ToolNumber { get; set; }
        public int? Capacity { get; set; }
        public int? Partsproduced { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CorrectedDate { get; set; }
    }
}
