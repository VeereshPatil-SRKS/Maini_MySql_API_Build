using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblProdOrderLosses
    {
        public int ProdOrderlossId { get; set; }
        public int Woid { get; set; }
        public int LossId { get; set; }
        public long LossDuration { get; set; }
        public DateTime CorrectedDate { get; set; }
        public int LossCodeL1id { get; set; }
        public int? LossCodeL2id { get; set; }
        public int MachineId { get; set; }

        public virtual Tblmachinedetails Machine { get; set; }
    }
}
