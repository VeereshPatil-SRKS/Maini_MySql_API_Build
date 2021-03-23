﻿using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class UnitworkccsProgramExecutionMaster
    {
        public int ProgramExecutionId { get; set; }
        public string ProgramName { get; set; }
        public int? MachineId { get; set; }
        public DateTime? ProgramExcutedDateTime { get; set; }
        public DateTime? ProgramStartDateTime { get; set; }
        public DateTime? ProgramEndDateTime { get; set; }
        public DateTime? CorrectedDate { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
