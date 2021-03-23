using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class Tblwolossess
    {
        public int WolossesId { get; set; }
        public int? Hmiid { get; set; }
        public int? LossId { get; set; }
        public string LossName { get; set; }
        public decimal? LossDuration { get; set; }
        public int? Level { get; set; }
        public int? LossCodeLevel1Id { get; set; }
        public string LossCodeLevel1Name { get; set; }
        public int? LossCodeLevel2Id { get; set; }
        public string LossCodeLevel2Name { get; set; }
        public DateTime? InsertedOn { get; set; }
        public int IsDeleted { get; set; }
    }
}
