using System;
using System.Collections.Generic;
using System.Text;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.WimarasysEntity;

namespace IFacilityMaini.Interface
{
    public interface IWimarasys
    {
        CommonResponse GetOperationNoBasedOnPartNo(string woNo);
        CommonResponse GetRunningBalance(GetRunningQuantityCustom data);
        CommonResponse GetWoNumber(string partNo);
        CommonResponse DefectCodes(string partNo);
        CommonResponse GetPartNoDeatails(string partNo);
        CommonResponse GetGeneralDefectCodes();

        CommonResponse GetFgPartNo(int plantId);
        CommonResponse GetChildPartNo(string partNo);
        CommonResponse GetMachineList(int plantId);



    }
}
