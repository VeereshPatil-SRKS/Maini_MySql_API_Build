using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class Tblplant
    {
        public Tblplant()
        {
            TblAutoreportsetting = new HashSet<TblAutoreportsetting>();
            Tblcell = new HashSet<Tblcell>();
            Tblemailescalation = new HashSet<Tblemailescalation>();
            Tblmachinedetails = new HashSet<Tblmachinedetails>();
            Tblmachinedetailsnew = new HashSet<Tblmachinedetailsnew>();
            Tblmultipleworkorder = new HashSet<Tblmultipleworkorder>();
            Tblshiftplanner = new HashSet<Tblshiftplanner>();
            Tblshop = new HashSet<Tblshop>();
        }

        public int PlantId { get; set; }
        public string PlantName { get; set; }
        public string PlantDesc { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public string PlantCode { get; set; }

        public virtual ICollection<TblAutoreportsetting> TblAutoreportsetting { get; set; }
        public virtual ICollection<Tblcell> Tblcell { get; set; }
        public virtual ICollection<Tblemailescalation> Tblemailescalation { get; set; }
        public virtual ICollection<Tblmachinedetails> Tblmachinedetails { get; set; }
        public virtual ICollection<Tblmachinedetailsnew> Tblmachinedetailsnew { get; set; }
        public virtual ICollection<Tblmultipleworkorder> Tblmultipleworkorder { get; set; }
        public virtual ICollection<Tblshiftplanner> Tblshiftplanner { get; set; }
        public virtual ICollection<Tblshop> Tblshop { get; set; }
    }
}
