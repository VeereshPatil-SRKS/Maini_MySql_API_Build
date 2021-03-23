using System;
using System.Collections.Generic;
using System.Text;

namespace IFacilityMaini.EntityModels
{
    public class CheckListHeaderEntity
    {
        public class genNo
        {
            public string category { get; set; }
            public string make { get; set; }
        }

        public class addHeader
        {
            public int HeaderId { get; set; }
            public int categoryId { get; set; }
            public int makeId { get; set; }
            public int LoginId { get; set; }
            public string checkListNo { get; set; }
            public int flag { get; set; }

        }

        public class viewHeaders
        {
            public int headerId { get; set; }

            public int plantId { get; set; }
            public string plantName { get; set; }
            public string plantCode { get; set; }
            public int? categoryId { get; set; }
            public string categoryName { get; set; }
            public int? makeId { get; set; }
            public string makeName { get; set; }
            public string creationDate { get; set; }
            public string showCreationDate { get; set; }
            public int revNo { get; set; }
            public string lastRevDate { get; set; }
            public string showLastRevDate { get; set; }
            public string checkListNo { get; set; }
            public int id { get; set; }
            public int? preparedBy { get; set; }
            public string preparedName { get; set; }
            public string preparedByDate { get; set; }
            public string showPreparedByDate { get; set; }
            public int? approvedBy { get; set; }
            public string approvedName { get; set; }
            public string approvedByDate { get; set; }
            public string showApprovedByDate { get; set; }
            public int? isApproved { get; set; }
            public int? preparedLogin { get; set; }
            public int? approvedLogin { get; set; }
            public string pendingCheckList { get; set; }
            public int? postToApprover { get; set; }
            //  public string approvedByDate { get; set; }

        }


        public class viewHeadersAndDet
        {
            public int headerId { get; set; }
            public int plantId { get; set; }
            public string plantName { get; set; }
            public string plantCode { get; set; }
            public int id { get; set; }
            public int? categoryId { get; set; }
            public string categoryName { get; set; }
            public int? makeId { get; set; }
            public string makeName { get; set; }
            public string creationDate { get; set; }
            public string showCreationDate { get; set; }
            public int revNo { get; set; }
            public string lastRevDate { get; set; }
            public string showLastRevDate { get; set; }
            public string checkListNo { get; set; }
            public int? preparedBy { get; set; }
            public string preparedName { get; set; }
            public string preparedByDate { get; set; }
            public string showPreparedByDate { get; set; }
            public int? approvedBy { get; set; }
            public string approvedName { get; set; }
            public string approvedByDate { get; set; }
            public string showApprovedByDate { get; set; }
            public int? isApproved { get; set; }
            public int? preparedLogin { get; set; }
            public int? approvedLogin { get; set; }
            public string pendingCheckList { get; set; }
            public int? postToApprover { get; set; }
            public List<CheckListDetailsEntity.ViewCheckList> checkListDetails { get; set; }

        }



        public class MachineDet
        {
            public int machineId { get; set; }
            public string machineName { get; set; }

        }

        public class addMachines
        {
            public int headerId { get; set; }
            public int plantId { get; set; }
            public int categoryId { get; set; }
            public int makeId { get; set; }
            public string MachineIds { get; set; }

        }

        public class viewHeaderMachines
        {
            public int HeaderId { get; set; }
            public string CheckListName { get; set; }
            public int? plantId { get; set; }
            public string plantName { get; set; }
            public int? categoryId { get; set; }
            public string categoryName { get; set; }
            public int? MakeId { get; set; }
            public string makeName { get; set; }
            public List<MachineDet> MachinesDet { get; set; }

        }
    }
}
