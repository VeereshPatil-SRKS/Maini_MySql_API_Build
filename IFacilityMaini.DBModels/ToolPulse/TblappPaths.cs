using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class TblappPaths
    {
        public int AppPathsId { get; set; }
        public string AppName { get; set; }
        public string AppPath { get; set; }
        public int IsDeleted { get; set; }
        public DateTime? InsertedOn { get; set; }
    }
}
