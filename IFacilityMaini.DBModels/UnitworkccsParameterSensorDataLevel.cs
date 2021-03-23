using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class UnitworkccsParameterSensorDataLevel
    {
        public int ParameterSensorDataLevelId { get; set; }
        public int? ParameterSensorDataId { get; set; }
        public decimal? LevelValue { get; set; }
    }
}
