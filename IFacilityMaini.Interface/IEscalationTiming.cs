using System;
using System.Collections.Generic;
using System.Text;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.EscalationTimingEntity;

namespace IFacilityMaini.Interface
{
    public interface IEscalationTiming
    {
        CommonResponse ViewMultipleCategory();

        CommonResponse AddAndUpdateEscalationTiming(AddUpdateEscalationTm data);
        CommonResponse ViewEscalationTiming();
        CommonResponse ViewEscalationTimingById(int Id);
        CommonResponse DeleteEscalationTiming(int Id);
    }
}
