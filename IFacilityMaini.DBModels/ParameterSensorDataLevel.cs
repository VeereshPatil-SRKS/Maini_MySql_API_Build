using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class ParameterSensorDataLevel
    {
        public int ParameterSensorDataLevelId { get; set; }
        public int? ParameterSensorDataId { get; set; }
        public decimal? LevelValue { get; set; }
    }
}
