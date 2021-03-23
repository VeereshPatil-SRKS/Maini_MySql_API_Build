using System;
using System.Collections.Generic;
using System.Text;

namespace IFacilityMaini.EntityModels
{
    public class WimarasysEntity
    {
        public class GetRunningQuantityCustom
        {
            public string partNo { get; set; }
            public string woNo { get; set; }
            public int operation { get; set; }
        }

        public class GetRunningBalanceQuantityDetails
        {
            public decimal? idealCycleTime { get; set; }
            public string unit { get; set; }
            public int? runningBalance { get; set; }
        }
    }
}
