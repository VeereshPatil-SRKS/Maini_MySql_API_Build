using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class Tblshiftmethod
    {
        public Tblshiftmethod()
        {
            Tblshiftdetails = new HashSet<Tblshiftdetails>();
        }

        public int ShiftMethodId { get; set; }
        public string ShiftMethodName { get; set; }
        public string ShiftMethodDesc { get; set; }
        public int NoOfShifts { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int? IsShiftMethodEdited { get; set; }
        public DateTime? EditedDate { get; set; }

        public virtual ICollection<Tblshiftdetails> Tblshiftdetails { get; set; }
    }
}
