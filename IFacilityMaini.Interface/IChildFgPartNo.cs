using System;
using System.Collections.Generic;
using System.Text;
using static IFacilityMaini.EntityModels.ChildFgPartNoEntity;
using static IFacilityMaini.EntityModels.CommonEntity;

namespace IFacilityMaini.Interface
{
    public interface IChildFgPartNo
    {
        CommonResponse UploadChildFgPartNo(List<UploadChildPartNo> data);
        CommonResponse AddChildFgPartNo(CustomChildPartNo data);
        CommonResponse ViewMultipleChildFgPartNo();
        CommonResponse DeleteChildFgPartNo(int childFgPartId);
    }
}
