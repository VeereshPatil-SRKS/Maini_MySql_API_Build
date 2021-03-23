using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class ParameterSensorDataTemperature
    {
        public int ParameterSensorDataTemperatureId { get; set; }
        public int? ParameterSensorDataId { get; set; }
        public decimal? TemperatureValue { get; set; }
    }
}
