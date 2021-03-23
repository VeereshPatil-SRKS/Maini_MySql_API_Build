using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblAxisdetails2
    {
        public int Ad2id { get; set; }
        public int? MachineId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public decimal? FeedRate { get; set; }
        public decimal? SpindleLoad { get; set; }
        public decimal? SpindleSpeed { get; set; }
        public int IsDeleted { get; set; }
        public DateTime? InsertedOn { get; set; }
        public decimal? FeedRatePercentage { get; set; }
    }
}
