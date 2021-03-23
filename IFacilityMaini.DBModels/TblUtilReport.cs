using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblUtilReport
    {
        public int UtilReportId { get; set; }
        public int MachineId { get; set; }
        public DateTime CorrectedDate { get; set; }
        public decimal TotalTime { get; set; }
        public decimal OperatingTime { get; set; }
        public decimal SetupTime { get; set; }
        public decimal MinorLossTime { get; set; }
        public decimal LossTime { get; set; }
        public decimal Bdtime { get; set; }
        public decimal PowerOffTime { get; set; }
        public decimal UtilPercent { get; set; }
        public DateTime InsertedOn { get; set; }
        public decimal SetupMinorTime { get; set; }

        public virtual Tblmachinedetails Machine { get; set; }
    }
}
