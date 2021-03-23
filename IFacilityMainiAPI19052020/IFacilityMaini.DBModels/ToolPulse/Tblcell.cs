using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class Tblcell
    {
        public Tblcell()
        {
            TblAutoreportsetting = new HashSet<TblAutoreportsetting>();
            Tblemailescalation = new HashSet<Tblemailescalation>();
            Tblmachinedetails = new HashSet<Tblmachinedetails>();
            Tblmachinedetailsnew = new HashSet<Tblmachinedetailsnew>();
            Tblmultipleworkorder = new HashSet<Tblmultipleworkorder>();
            Tblshiftplanner = new HashSet<Tblshiftplanner>();
        }

        public int CellId { get; set; }
        public string CellName { get; set; }
        public string CellDesc { get; set; }
        public int? PlantId { get; set; }
        public int ShopId { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Tblplant Plant { get; set; }
        public virtual Tblshop Shop { get; set; }
        public virtual ICollection<TblAutoreportsetting> TblAutoreportsetting { get; set; }
        public virtual ICollection<Tblemailescalation> Tblemailescalation { get; set; }
        public virtual ICollection<Tblmachinedetails> Tblmachinedetails { get; set; }
        public virtual ICollection<Tblmachinedetailsnew> Tblmachinedetailsnew { get; set; }
        public virtual ICollection<Tblmultipleworkorder> Tblmultipleworkorder { get; set; }
        public virtual ICollection<Tblshiftplanner> Tblshiftplanner { get; set; }
    }
}
