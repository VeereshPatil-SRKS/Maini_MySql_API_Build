using System;
using System.Collections.Generic;
using System.Text;

namespace IFacilityMaini.EntityModels
{
   public class MasterChildFgPartNumEntity
    {
        #region   1)ChildFgPartNo

        public class addChildfgPartNoDet
        {
            public int childFgpartId { get; set; }

            public string childFgPartNo { get; set; }

            public string fgPartNo { get; set; }

            public string childPartNoDesc { get; set; }
        }

        #endregion

        #region  2)FgAndCellAllocation

        //public class addFgAndCellAllocationDet
        //{
        //    public int fgAndCellAllocationId { get; set; }

        //    public string partNo;

        //    public int childFgpartId;

        //    public string partDesc;

        //}
        #endregion
    }
}
