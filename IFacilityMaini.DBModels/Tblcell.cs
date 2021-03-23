using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class Tblcell
    {
        public Tblcell()
        {
            ConfigurationTblpmchecklist = new HashSet<ConfigurationTblpmchecklist>();
            ConfigurationTblpmcheckpoint = new HashSet<ConfigurationTblpmcheckpoint>();
            ConfigurationTblprimitivemaintainancescheduling = new HashSet<ConfigurationTblprimitivemaintainancescheduling>();
            TblAndonDispDet = new HashSet<TblAndonDispDet>();
            TblAndonImageTextScheduledDisplay = new HashSet<TblAndonImageTextScheduledDisplay>();
            TblAutoreportsetting = new HashSet<TblAutoreportsetting>();
            Tblbottelneck = new HashSet<Tblbottelneck>();
            Tblcellpart = new HashSet<Tblcellpart>();
            Tblemailescalation = new HashSet<Tblemailescalation>();
            Tblmachinedetails = new HashSet<Tblmachinedetails>();
            Tblmultipleworkorder = new HashSet<Tblmultipleworkorder>();
            Tblrejectreason = new HashSet<Tblrejectreason>();
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
        public string CelldisplayName { get; set; }
        public bool? DefaultFlag { get; set; }

        public virtual Tblplant Plant { get; set; }
        public virtual Tblshop Shop { get; set; }
        public virtual ICollection<ConfigurationTblpmchecklist> ConfigurationTblpmchecklist { get; set; }
        public virtual ICollection<ConfigurationTblpmcheckpoint> ConfigurationTblpmcheckpoint { get; set; }
        public virtual ICollection<ConfigurationTblprimitivemaintainancescheduling> ConfigurationTblprimitivemaintainancescheduling { get; set; }
        public virtual ICollection<TblAndonDispDet> TblAndonDispDet { get; set; }
        public virtual ICollection<TblAndonImageTextScheduledDisplay> TblAndonImageTextScheduledDisplay { get; set; }
        public virtual ICollection<TblAutoreportsetting> TblAutoreportsetting { get; set; }
        public virtual ICollection<Tblbottelneck> Tblbottelneck { get; set; }
        public virtual ICollection<Tblcellpart> Tblcellpart { get; set; }
        public virtual ICollection<Tblemailescalation> Tblemailescalation { get; set; }
        public virtual ICollection<Tblmachinedetails> Tblmachinedetails { get; set; }
        public virtual ICollection<Tblmultipleworkorder> Tblmultipleworkorder { get; set; }
        public virtual ICollection<Tblrejectreason> Tblrejectreason { get; set; }
        public virtual ICollection<Tblshiftplanner> Tblshiftplanner { get; set; }
    }
}
