using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class ProductWiseDefectDetails
    {
        public int Id { get; set; }
        public string Trim { get; set; }
        public string Plant { get; set; }
        public string PartNumber { get; set; }
        public string PartName { get; set; }
        public string DefectCode { get; set; }
        public string DefectDescription { get; set; }
    }
}
