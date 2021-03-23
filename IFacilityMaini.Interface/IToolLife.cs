using System;
using System.Collections.Generic;
using System.Text;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.ToolLifeEntity;

namespace IFacilityMaini.Interface
{
    public interface IToolLife
    {
        CommonResponse AddAndEditToolAndSocketDetails(TblToolAndSocketDetailsCustom data);
        CommonResponse GetToolLife(string socketNumber, int machineId);
        CommonResponse DeleteToolFromSocket(string socketNumber, int machineId);
        CommonResponse ScanToolData(string toolNumber, int machineId, string fgCode);
    }
}
