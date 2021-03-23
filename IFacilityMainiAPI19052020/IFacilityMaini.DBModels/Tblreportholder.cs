using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class Tblreportholder
    {
        public int Rhid { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string Shift { get; set; }
        public string ShopNo { get; set; }
        public string WorkCenter { get; set; }
    }
}
