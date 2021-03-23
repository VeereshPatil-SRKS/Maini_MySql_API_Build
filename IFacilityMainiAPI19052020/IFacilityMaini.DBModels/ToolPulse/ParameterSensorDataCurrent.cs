using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class ParameterSensorDataCurrent
    {
        public int ParameterSensorDataCurrentId { get; set; }
        public int? ParameterSensorDataId { get; set; }
        public decimal? CurrentValue { get; set; }
    }
}
