using System;
using System.Collections.Generic;
using System.Text;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.FGAndCellAllocationEntity;

namespace IFacilityMaini.Interface
{
    public interface IFGAndCellAllocation
    {
        CommonResponse ViewMultiplePlantCodes();
        CommonResponse ViewMultiplePartName();
        CommonResponse ViewMultipleCellFinal();
        CommonResponse ViewMultipleSubCellFinal(int cellFinalId);
        CommonResponse AddUpdateFgAndCellAllocation(List<AddUpdateFgCellAllocation> data);
        CommonResponse ViewMultipleFgAndCellAllocation();
        CommonResponse DeleteFgAndCellAllocation(int fgAndCellAllocationId);
        CommonResponse UploadPlanLinkageMaster(List<ReadPlanLinkage> data);
        CommonResponse ReadPlanVisageMaster();
        CommonResponse DownloadFGpartCellAllocation();
        CommonResponse UploadFgAndCellAllocation(List<UploadFgAndCellAllocation> data);
    }
}
