using System;
using System.Collections.Generic;
using System.Text;

namespace IFacilityMaini.EntityModels
{
    public class CheckListDetailsEntity
    {
        public class addCheckList
        {
            public int CheckListId { get; set; }
            public int HeaderId { get; set; }
            public string WhatToCheck { get; set; }
            public string How { get; set; }
            public string Frequency { get; set; }
            public string RunningHrs { get; set; }
            public int PartsCount { get; set; }
            public string PeriodFrequency { get; set; }
            public string Date { get; set; }
            public bool isNumeric { get; set; }
            public bool isText { get; set; }
            public int roleId { get; set; }
            public int flag { get; set; }
            public int addEdit { get; set; }
        }


        public class ViewCheckList
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
        }

        public class REVIconViewCheckList
        {
            public REVIconViewCheckListCur currentList { get; set; }
            public REVIconViewCheckListPre previousList { get; set; }

        }

        public class REVIconViewCheckListCur
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
        }
        public class REVIconViewCheckListPre
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
        }



        public class date
        {
            public string dateArray { get; set; }
        }

        public class approveDet
        {
            public int approverId { get; set; }
            public int headerId { get; set; }

            // public string approvedDate { get; set; }
            // public string checkListIds { get; set; }
            public int checkListId { get; set; }
            public string isOk { get; set; }
            public string comment { get; set; }
        }


        public class uploadCK
        {
            public int headerId { get; set; }
            public List<uploadCKdetails> checkListDetails { get; set; }

          
        }

        public class uploadCKdetails
        {
             	     


            public string whatToCheck { get; set; }
            public string how { get; set; }
            public string whoWillDo { get; set; }

            public string outputForm { get; set; }
            public string numberOfRunningHours { get; set; }
            public int? numberOfPartCount { get; set; }
            public string periodFrequency { get; set; }
            public string calenderDate { get; set; }
          
           
        }






    }
}
