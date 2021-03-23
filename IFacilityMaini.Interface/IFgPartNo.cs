using System;
using System.Collections.Generic;
using System.Text;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.FgPartNoEntity;

namespace IFacilityMaini.Interface
{
    public interface IFgPartNo
    {
        CommonResponse GetFgPartDetails(int machineId);
        //CommonResponse GetWorkOrderNo(int machineId);
        //CommonResponse ViewMultiplePartNo(string ProductionOrder, int PlanLinkageId);
        //CommonResponse GetOperationNo(string FgPartNo, int PlanLinkageId);
        //CommonResponse GetWorkOrderQty(int operationNo, int PlanLinkageId);
        //CommonResponse ViewMultiplePartNo(int opearationNo, int machineId);
        GeneralResponse AddUpdateFgPartNo(AddUpdateFgPartNo data);
        CommonResponse ViewMultipleFgPartNo(int machineId);
        CommonResponse ViewMultipleFgPartNoById(int fgPartId);
        CommonResponse CloseFgPartNo(int fgPartId);
    }
}
