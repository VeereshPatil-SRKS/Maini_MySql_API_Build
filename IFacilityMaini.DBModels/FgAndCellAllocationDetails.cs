using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class FgAndCellAllocationDetails
    {
        public int Id { get; set; }
        public string Plant { get; set; }
        public string MaterialDescription { get; set; }
        public string Material { get; set; }
        public string CellFinal { get; set; }
        public string SubCellFinal { get; set; }
        public string DmcorQrcodeStatus { get; set; }
    }
}
