using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class Configurationtblsensordatalink
    {
        public int ParameterTypeId { get; set; }
        public string Element { get; set; }
        public string SubElement { get; set; }
        public string Deterioration { get; set; }
        public string ParameterName { get; set; }
        public string ParameterDesc { get; set; }
        public int IsAxis { get; set; }
        public int AxisId { get; set; }
        public int? IsSensor { get; set; }
        public decimal? Lsl { get; set; }
        public decimal? Usl { get; set; }
        public int Unit { get; set; }
        public int LogFrequency { get; set; }
        public int LogFreqUnitId { get; set; }
        public int? IsCycle { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual TblAxisdet Axis { get; set; }
        public virtual Tblunit LogFreqUnit { get; set; }
        public virtual Tblunit UnitNavigation { get; set; }
    }
}
