using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class UnitworkccsTblOeereportasdivision
    {
        public int Lid { get; set; }
        public int? MachineId { get; set; }
        public string Fgcode { get; set; }
        public int? LossId { get; set; }
        public long LossDuration { get; set; }
        public DateTime? CorrectedDate { get; set; }
        public DateTime? InsertedOn { get; set; }
    }
}
