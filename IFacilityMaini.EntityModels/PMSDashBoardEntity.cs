using System;
using System.Collections.Generic;
using System.Text;

namespace IFacilityMaini.EntityModels
{
    public class PMSDashBoardEntity
    {
        public class viewHeadersPM
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
            //  public string approvedByDate { get; set; }

        }


        public class ViewCheckListPM
        {
            public int checkListId { get; set; }
            public int headerId { get; set; }
            public string whatToCheck { get; set; }
            public string[] how { get; set; }
            public string frequency { get; set; }
            public string runningHrs { get; set; }
            public int partsCount { get; set; }
            public string periodFrequency { get; set; }
            public string[] dateList { get; set; }
            public string[] showDateList { get; set; }
            public string ok { get; set; }
            public string comment { get; set; }
            public bool? isNumeric { get; set; }
            public bool? isText { get; set; }
            public int? roleId { get; set; }
            public string roleName { get; set; }
            public int? isDashBoardOk { get; set; }
            public int? numericVlaue { get; set; }
            public string textValue { get; set; }
            public string whoWillDo { get; set; }

        }


        public class approveDetPM
        {
            public int approverId { get; set; }
            public int headerId { get; set; }

            public int roleId { get; set; }
            public int checkListId { get; set; }
            public string isOk { get; set; }
            public string comment { get; set; }

            public int numericValue { get; set; }
            public string textValue { get; set; }



        }
    }
}
