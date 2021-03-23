using System;
using System.Collections.Generic;
using System.Text;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.DryRunEntity;

namespace IFacilityMaini.Interface
{
    public interface IDryRun
    {
        CommonResponseWithIds AddDryRun(DryRunDetails data);
        CommonResponse CloseDryRun(int dryRunId, int userId);
        CommonResponse AutomaticCloseDryRun(int dryRunId);
    }
}
