using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class SapFileGeneratedDetails
    {
        public long SapFileGeneratedId { get; set; }
        public DateTime? SapFileGeneratedDate { get; set; }
        public int? SapFileGeneratedHour { get; set; }
        public long? TotalCountOfRows { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string SapFileNameGenerated { get; set; }
    }
}
