using System;
using System.Collections.Generic;
using System.Text;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.EmployeeShiftDetailsEntity;

namespace IFacilityMaini.Interface
{
    public interface IEmployeeShiftDetails
    {
        CommonResponse ViewMultipleOperator();
        CommonResponse ViewShifts();
        CommonResponse ViewMultipleMachines();
        CommonResponse AddUpdateEmployeeShift(AddUpdateOperatorShift data);
        CommonResponse ViewMultipleOperatorShift();
        CommonResponse ViewMultipleOperatorShiftById(int Id);
        CommonResponse DeleteOperatorShift(int Id);
        CommonResponse UploadOperatorsShift(AddUpdateOperatorShiftExcel data);

        CommonResponse DownLoadOperatorsShiftDetails();
    }
}
