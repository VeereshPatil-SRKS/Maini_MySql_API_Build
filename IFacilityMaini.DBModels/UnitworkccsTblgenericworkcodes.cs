using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class UnitworkccsTblgenericworkcodes
    {
        public UnitworkccsTblgenericworkcodes()
        {
            UnitworkccsTblgenericworkentry = new HashSet<UnitworkccsTblgenericworkentry>();
        }

        public int GenericWorkId { get; set; }
        public string GenericWorkCode { get; set; }
        public string GenericWorkDesc { get; set; }
        public string MessageType { get; set; }
        public int GwcodesLevel { get; set; }
        public int? GwcodesLevel1Id { get; set; }
        public int? GwcodesLevel2Id { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int? EndCode { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual ICollection<UnitworkccsTblgenericworkentry> UnitworkccsTblgenericworkentry { get; set; }
    }
}
