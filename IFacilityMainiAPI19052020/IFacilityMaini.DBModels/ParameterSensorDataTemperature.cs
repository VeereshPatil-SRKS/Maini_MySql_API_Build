using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class ParameterSensorDataTemperature
    {
        public int ParameterSensorDataTemperatureId { get; set; }
        public int? ParameterSensorDataId { get; set; }
        public decimal? TemperatureValue { get; set; }
    }
}
