using System;
using System.Collections.Generic;
using System.Text;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.OperatorEntity;

namespace IFacilityMaini.Interface
{
    public interface IOperator
    {
        CommonResponse ViewMultipleRoles();
        CommonResponse ViewMultipleCategory();
        CommonResponse ViewMultipleShift();
        CommonResponse ViewMultipleCell();
        CommonResponse ViewMultipleSubcell();
        CommonResponse ViewMultipleMachinename();
        CommonResponse AddUpdateOperator(List<AddUpdateOperator> data);
        CommonResponse ViewMultipleOperator();
        CommonResponse ViewMultipleOperatorById(int opId);
        CommonResponse DeleteOperator(int opid);
    }
}
