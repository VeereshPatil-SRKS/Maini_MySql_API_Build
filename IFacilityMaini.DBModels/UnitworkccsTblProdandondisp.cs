using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class UnitworkccsTblProdandondisp
    {
        public int ProdDashboardId { get; set; }
        public int MachineId { get; set; }
        public DateTime CorrectedDate { get; set; }
        public int Woid { get; set; }
        public decimal? UtilPercent { get; set; }
        public decimal TotalLoss { get; set; }
        public decimal TotalSetup { get; set; }
        public decimal TotalOperatingTime { get; set; }
        public DateTime InsertedOn { get; set; }

        public virtual UnitworkccsTblworkorderentry Wo { get; set; }
    }
}
