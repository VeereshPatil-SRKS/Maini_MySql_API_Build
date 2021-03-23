using System;
using System.Collections.Generic;
using System.Text;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.ReportEntity;

namespace IFacilityMaini.Interface
{
    public interface IReport
    {
        CommonResponse ViewMultiplePlant();
        CommonResponse ViewMultiShift();
        CommonResponse ViewMultipleMachines(int plantId, string category);
        CommonResponse OEEReport1(OEEdetails data);
        CommonResponse OEEReportShiftwise(OEEdetailsShiftwise data);
        CommonResponse ViewMultiEmployees();
        CommonResponse ViewMultiEmployeesMachines(string empId);
        CommonResponse OEEReportOperator(OEEdetailsOperator data);
        CommonResponse BreakdownReport(breakdownReportDet data);

    }
}
