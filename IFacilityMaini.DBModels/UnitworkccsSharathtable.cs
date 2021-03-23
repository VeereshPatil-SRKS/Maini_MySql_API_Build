using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class UnitworkccsSharathtable
    {
        public int Sharathid { get; set; }
        public string Sharathname { get; set; }
        public int? Sharathvalue { get; set; }
        public byte Syncid { get; set; }
        public int Mcid { get; set; }
        public int TabSharathId { get; set; }
    }
}
