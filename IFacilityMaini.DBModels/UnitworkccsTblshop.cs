using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class UnitworkccsTblshop
    {
        public UnitworkccsTblshop()
        {
            UnitworkccsConfigurationTblpmchecklist = new HashSet<UnitworkccsConfigurationTblpmchecklist>();
            UnitworkccsConfigurationTblpmcheckpoint = new HashSet<UnitworkccsConfigurationTblpmcheckpoint>();
            UnitworkccsConfigurationTblprimitivemaintainancescheduling = new HashSet<UnitworkccsConfigurationTblprimitivemaintainancescheduling>();
            UnitworkccsTblAutoreportsetting = new HashSet<UnitworkccsTblAutoreportsetting>();
            UnitworkccsTblandondispdet = new HashSet<UnitworkccsTblandondispdet>();
            UnitworkccsTblandonimagetextscheduleddisplay = new HashSet<UnitworkccsTblandonimagetextscheduleddisplay>();
            UnitworkccsTblbottelneck = new HashSet<UnitworkccsTblbottelneck>();
            UnitworkccsTblcell = new HashSet<UnitworkccsTblcell>();
            UnitworkccsTblemailescalation = new HashSet<UnitworkccsTblemailescalation>();
            UnitworkccsTblmachinedetails = new HashSet<UnitworkccsTblmachinedetails>();
            UnitworkccsTblmultipleworkorder = new HashSet<UnitworkccsTblmultipleworkorder>();
            UnitworkccsTblshiftplanner = new HashSet<UnitworkccsTblshiftplanner>();
        }

        public int ShopId { get; set; }
        public string ShopName { get; set; }
        public string ShopDesc { get; set; }
        public string Shopdisplayname { get; set; }
        public int PlantId { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual UnitworkccsTblplant Plant { get; set; }
        public virtual ICollection<UnitworkccsConfigurationTblpmchecklist> UnitworkccsConfigurationTblpmchecklist { get; set; }
        public virtual ICollection<UnitworkccsConfigurationTblpmcheckpoint> UnitworkccsConfigurationTblpmcheckpoint { get; set; }
        public virtual ICollection<UnitworkccsConfigurationTblprimitivemaintainancescheduling> UnitworkccsConfigurationTblprimitivemaintainancescheduling { get; set; }
        public virtual ICollection<UnitworkccsTblAutoreportsetting> UnitworkccsTblAutoreportsetting { get; set; }
        public virtual ICollection<UnitworkccsTblandondispdet> UnitworkccsTblandondispdet { get; set; }
        public virtual ICollection<UnitworkccsTblandonimagetextscheduleddisplay> UnitworkccsTblandonimagetextscheduleddisplay { get; set; }
        public virtual ICollection<UnitworkccsTblbottelneck> UnitworkccsTblbottelneck { get; set; }
        public virtual ICollection<UnitworkccsTblcell> UnitworkccsTblcell { get; set; }
        public virtual ICollection<UnitworkccsTblemailescalation> UnitworkccsTblemailescalation { get; set; }
        public virtual ICollection<UnitworkccsTblmachinedetails> UnitworkccsTblmachinedetails { get; set; }
        public virtual ICollection<UnitworkccsTblmultipleworkorder> UnitworkccsTblmultipleworkorder { get; set; }
        public virtual ICollection<UnitworkccsTblshiftplanner> UnitworkccsTblshiftplanner { get; set; }
    }
}
