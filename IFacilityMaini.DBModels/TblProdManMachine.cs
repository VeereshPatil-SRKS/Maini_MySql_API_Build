using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblProdManMachine
    {
        public int ProdManMachineId { get; set; }
        public int MachineId { get; set; }
        public DateTime CorrectedDate { get; set; }
        public int Woid { get; set; }
        public decimal? UtilPercent { get; set; }
        public decimal TotalLoss { get; set; }
        public decimal TotalSetup { get; set; }
        public decimal TotalMinorLoss { get; set; }
        public decimal TotalOperatingTime { get; set; }
        public DateTime InsertedOn { get; set; }
        public decimal TotalSetupMinorLoss { get; set; }
        public decimal TotalPowerLoss { get; set; }
        public decimal PerformancePerCent { get; set; }
        public decimal QualityPercent { get; set; }
        public int PerfromaceFactor { get; set; }

        public virtual Tblmachinedetails Machine { get; set; }
        public virtual TblFgPartNoDet Wo { get; set; }
    }
}
