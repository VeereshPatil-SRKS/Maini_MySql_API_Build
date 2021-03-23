using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class UnitworkccsTbltoolbrkdnreason
    {
        public int ReasonId { get; set; }
        public string ReasonName { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public byte? ForResharpening { get; set; }
        public int? PlantId { get; set; }
    }
}
