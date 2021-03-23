using System;
using System.Collections.Generic;
using System.Text;

namespace IFacilityMaini.EntityModels
{
    public class FgPartNoEntity
    {
        public class AddUpdateFgPartNo
        {
            public int fgPartId { get; set; }
            public int planLinkageId { get; set; }
            public string partsCountMethod { get; set; }
            public int operationNo { get; set; }
            public string workOrderNo { get; set; }
            public string noOfPartsPerCycle { get; set; }
            public int operatorId { get; set; }
            public int machineId { get; set; }
        }

        public class GetFgPartDetails
        {
            public string ProductionOrder { get; set; }
            public string RoutingId { get; set; }
            public decimal? WorkOrderQty { get; set; }
            public int? Operation { get; set; }
            public int? PlanLinkageId { get; set; }
            public string FgPartNo { get; set; }
            public int? NoOfPartsPerCycle { get; set; }
        }
    }
}
