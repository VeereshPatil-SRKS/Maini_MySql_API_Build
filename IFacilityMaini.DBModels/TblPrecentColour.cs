using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblPrecentColour
    {
        public int ColourId { get; set; }
        public string Colour { get; set; }
        public int? Min { get; set; }
        public int? Max { get; set; }
        public int IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
    }
}
