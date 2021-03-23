using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblReworkReasons
    {
        public int ReWorkId { get; set; }
        public string ReworkName { get; set; }
        public int IsDeleted { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
