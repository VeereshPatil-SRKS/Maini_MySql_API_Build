using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class TblMultiwoselection
    {
        public int MultiWoid { get; set; }
        public string WorkOrder { get; set; }
        public string PartNo { get; set; }
        public string OperationNo { get; set; }
        public int? TargetQty { get; set; }
        public int? DeliveredQty { get; set; }
        public int? Hmiid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? IsCompleted { get; set; }
        public int? ProcessQty { get; set; }
        public string DdlworkCentre { get; set; }
        public int IsSubmit { get; set; }
        public int ScrapQty { get; set; }
        public string SplitWo { get; set; }

        public virtual Tblhmiscreen Hmi { get; set; }
    }
}
