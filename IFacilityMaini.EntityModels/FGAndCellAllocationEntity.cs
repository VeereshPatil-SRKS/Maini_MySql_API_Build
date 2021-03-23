using System;
using System.Collections.Generic;
using System.Text;

namespace IFacilityMaini.EntityModels
{
    public class FGAndCellAllocationEntity
    {
        public class UploadFgAndCellAllocation
        {
            public string plantCode { get; set; }
            public string partNo { get; set; }
            public string partDesc { get; set; }
            public string cellName { get; set; }
            public string subcellName { get; set; }
            public string dmcCodeStatus { get; set; }
        }

        public class AddPlanLinkage
        {
            public int planLinkageId { get; set; }
            public string plantId { get; set; }
            public int scheduleId { get; set; }
            public string scheduleDate { get; set; }
            public int shiftId { get; set; }
            public string productionOrder { get; set; }
            public string routingId { get; set; }
            public int operation { get; set; }
            public int workOrderQty { get; set; }
            public int workOrderCompletedQty { get; set; }
            public string resourceId { get; set; }
            public int scheduledQty { get; set; }
            public string plannedStartTime { get; set; }
            public string plannedEndTime { get; set; }
            public int setUpTime { get; set; }
            public string sapDateTimeStamp { get; set; }
            public string fgPartNo { get; set; }
            public string lastUpdate { get; set; }
            public string lastUpdatedUse { get; set; }
            public int numUpdates { get; set; }
        }

        public class ReadPlanLinkage
        {
            //public int planLinkageId { get; set; }
            public string plantId { get; set; }
            public int scheduleId { get; set; }
            public string scheduleDate { get; set; }
            public int shiftId { get; set; }
            public string productionOrder { get; set; }
            public string routingId { get; set; }
            public int operation { get; set; }
            public int workOrderQty { get; set; }
            public int workOrderCompletedQty { get; set; }
            public string resourceId { get; set; }
            public int scheduledQty { get; set; }
            public string plannedStartTime { get; set; }
            public string plannedEndTime { get; set; }
            public int setUpTime { get; set; }
            public string sapDateTimeStamp { get; set; }
            public string fgPartNo { get; set; }
            public string lastUpdate { get; set; }
            public string lastUpdatedUse { get; set; }
            public int numUpdates { get; set; }
        }

        public class AddUpdateFgCellAllocation
        {
            public int fgAndCellAllocationId { get; set; }
            public int plantId { get; set; }
            public string partNo { get; set; }
            public string partDesc { get; set; }
            public int cellFinalId { get; set; }
            public int subFinalId { get; set; }
            public string dmcCodeStatus { get; set; }
        }
    }
}
