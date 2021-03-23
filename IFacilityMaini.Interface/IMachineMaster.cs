using System;
using System.Collections.Generic;
using System.Text;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.MachineMasterEntity;

namespace IFacilityMaini.Interface
{
    public interface IMachineMaster
    {
        CommonResponse ViewMultiplePlant();
        CommonResponse ViewMultipleCell(int plantId);
        CommonResponse ViewMultipleSubCell(int shopId);
        CommonResponse ViewMultipleMachineCategory(int plantId);
        CommonResponse ViewMultipleMake(int machineCategoryId);
        CommonResponse ViewMultipleTallStockAvailibility();
        CommonResponse ViewMultipleNoOfAxis();
        CommonResponse ViewMultiplePallet();
        CommonResponse AddAndUpdateMachineMaster(AddUpdateMachine data);
        CommonResponse ViewMachineDetails();
        CommonResponse ViewMachineDetailsById(int machineId);
        CommonResponse DeleteMachineDetails(int machineId);
        CommonResponse UploadMachineMaster(List<UploadMachine> data);
        CommonResponse DownloadMachineMaster();
    }
}
