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
        CommonResponse ViewMultipleDepartments();
        CommonResponse ViewMultipleCategoryDetails();
        CommonResponse ViewMultipleBusiness();
        CommonResponse ViewMultiplePlants();
        CommonResponse ViewMultipleCell(int plantId);
        CommonResponse ViewMultipleSubcell(int cellId);
        CommonResponse AddUpdateOperator(AddUpdateOperator data);
        CommonResponse ViewMultipleOperator();
        CommonResponse ViewMultipleOperatorById(int opId);
        CommonResponse DeleteOperator(int opid);
        CommonResponse UploadOperators(List<OperatorCustom> data);
        CommonResponse DownLoadOperatorsDetails();
    }
}
