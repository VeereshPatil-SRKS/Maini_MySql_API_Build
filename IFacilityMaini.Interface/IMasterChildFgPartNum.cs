using System;
using System.Collections.Generic;
using System.Text;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.MasterChildFgPartNumEntity;

namespace IFacilityMaini.Interface
{
    public interface IMasterChildFgPartNum
    {
        #region   1) ChildFgPartNo
        CommonResponse AddUpdateChildFgPartNo(addChildfgPartNoDet data);
        CommonResponse ViewMultipleChildFgPartNo();
        CommonResponse ViewMultipleChildFgPartNoById(int fgPartNo);
        CommonResponse DeleteChildFgPartNo(int fgPartNo);
        #endregion

        #region  2)FgAndCellAllocation

        //CommonResponse AddUpdateFgAndCellAllocation(addFgAndCellAllocationDet data);
        CommonResponse ViewMultipleFgAndCellAllocation();
        //CommonResponse ViewMultipleFgAndCellAllocationById(int fgAndCellAllocationId);
        //CommonResponse DeleteChildFgAndCellAllocation(int fgAndCellAllocationId);
        #endregion
    }
}
