using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class Tblplant
    {
        public Tblplant()
        {
            ConfigurationTblpmchecklist = new HashSet<ConfigurationTblpmchecklist>();
            ConfigurationTblpmcheckpoint = new HashSet<ConfigurationTblpmcheckpoint>();
            ConfigurationTblprimitivemaintainancescheduling = new HashSet<ConfigurationTblprimitivemaintainancescheduling>();
            TblAndonDispDet = new HashSet<TblAndonDispDet>();
            TblAndonImageTextScheduledDisplay = new HashSet<TblAndonImageTextScheduledDisplay>();
            TblAutoreportsetting = new HashSet<TblAutoreportsetting>();
            Tblbottelneck = new HashSet<Tblbottelneck>();
            Tblcell = new HashSet<Tblcell>();
            Tblemailescalation = new HashSet<Tblemailescalation>();
            Tblmachinedetails = new HashSet<Tblmachinedetails>();
            Tblmultipleworkorder = new HashSet<Tblmultipleworkorder>();
            Tblshiftplanner = new HashSet<Tblshiftplanner>();
            Tblshop = new HashSet<Tblshop>();
        }

        public int PlantId { get; set; }
        public string PlantName { get; set; }
        public string PlantDesc { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public string PlantDisplayName { get; set; }
        public string PlantCode { get; set; }
        public string PlantLocation { get; set; }

        public virtual ICollection<ConfigurationTblpmchecklist> ConfigurationTblpmchecklist { get; set; }
        public virtual ICollection<ConfigurationTblpmcheckpoint> ConfigurationTblpmcheckpoint { get; set; }
        public virtual ICollection<ConfigurationTblprimitivemaintainancescheduling> ConfigurationTblprimitivemaintainancescheduling { get; set; }
        public virtual ICollection<TblAndonDispDet> TblAndonDispDet { get; set; }
        public virtual ICollection<TblAndonImageTextScheduledDisplay> TblAndonImageTextScheduledDisplay { get; set; }
        public virtual ICollection<TblAutoreportsetting> TblAutoreportsetting { get; set; }
        public virtual ICollection<Tblbottelneck> Tblbottelneck { get; set; }
        public virtual ICollection<Tblcell> Tblcell { get; set; }
        public virtual ICollection<Tblemailescalation> Tblemailescalation { get; set; }
        public virtual ICollection<Tblmachinedetails> Tblmachinedetails { get; set; }
        public virtual ICollection<Tblmultipleworkorder> Tblmultipleworkorder { get; set; }
        public virtual ICollection<Tblshiftplanner> Tblshiftplanner { get; set; }
        public virtual ICollection<Tblshop> Tblshop { get; set; }
    }
}
