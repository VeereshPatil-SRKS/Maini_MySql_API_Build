using System;
using System.Collections.Generic;
using System.Text;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.PMSDashBoardEntity;

namespace IFacilityMaini.Interface
{
    public interface IPMSDashBoard
    {
        CommonResponse ViewMultipleCheckListHeaderPMS();
        CommonResponse ApproveCheckList(approveDetPM data);
        CommonResponse ViewMultipleCheckListDetailsPMS(int headerId);
    }
}
