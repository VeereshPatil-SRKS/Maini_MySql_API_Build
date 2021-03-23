using System;
using System.Collections.Generic;
using System.Text;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.ReworkAndRejectionEntity;

namespace IFacilityMaini.Interface
{
    public interface IReworkAndRejection
    {
        CommonResponse ViewMultipleDefectCode(int fgPartId, int machineId);
        CommonResponse AddRejectionDetails(AddRejection data);
        CommonResponse DeleteRejectionDetails(int rejectionId);
        CommonResponse ViewRejectionDetails(int machineId, int fgPartId);
        CommonResponse AddReworkDetails(AddRework data);
        CommonResponse DeleteReworkDetails(int reworkId);
        CommonResponse ViewReworkDetails(int machineId, int fgPartId);
    }
}
