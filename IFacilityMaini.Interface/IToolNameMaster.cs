using IFacilityMaini.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;
using static IFacilityMaini.EntityModels.CommonEntity;

namespace IFacilityMaini.Interface
{
    public interface IToolNameMaster
    {

        CommonResponse AddUpdateToolNameMaster(ToolNameMasterEntity data);
        CommonResponse ViewToolNameMaster();
        CommonResponse ViewToolNameMasterById(int toolId);
        CommonResponse DeleteToolNameMaster(int toolId);
    }
}
