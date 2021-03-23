using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class MasterValueTbl
    {
        public long MasterValueId { get; set; }
        public string MasterValueName { get; set; }
        public string MasterValueDesc { get; set; }
        public decimal? MasterValue { get; set; }
    }
}
