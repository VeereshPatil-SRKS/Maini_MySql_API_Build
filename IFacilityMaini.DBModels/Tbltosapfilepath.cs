using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class Tbltosapfilepath
    {
        public int ToSapfilePathId { get; set; }
        public string PathName { get; set; }
        public string Path { get; set; }
        public int IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string Tbltosapfilepathcol { get; set; }
    }
}
