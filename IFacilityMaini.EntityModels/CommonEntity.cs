using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace IFacilityMaini.EntityModels
{
    public class CommonEntity
    {
        public class CommonResponse
        {
            public bool isStatus { get; set; }
            public dynamic response { get; set; }
        }

        public class CommonResponseGraph
        {
            public bool isStatus { get; set; }
            public dynamic response { get; set; }
           
        }

        public class OEEDashboard
        {
            public double AvailabilityPercentage { get; set; }
            public double PerformancePercentage { get; set; }
            public double OEEPercentage { get; set; }
            public double Quality { get; set; }
            public int Actual { get; set; }
            public double Target { get; set; }
        }

        public class CommonResponseWithIds
        {
            public bool isStatus { get; set; }
            public dynamic response { get; set; }
            public dynamic id { get; set; }
        }

        public class MailSender
        {
            public dynamic emailContent { get; set; }
            public List<ToAddress> toRecipents { get; set; }
            public List<CCAddress> ccRecipents { get; set; }
            public List<BccAddress> bccRecipents { get; set; }
            public string subject { get; set; }
            public int moduleWiseEmailMasterId { get; set; }
            public bool isExpiryExists { get; set; }
        }

        public class ToAddress
        {
            public string to { get; set; }
        }

        public class CCAddress
        {
            public string cc { get; set; }
        }
        public class BccAddress
        {
            public string bcc { get; set; }
        }

        public class SkipDetailsFunction
        {
            public int skipValue { get; set; }
            public int takeValue { get; set; }
        }

        public class MailTracker
        {
            public string from { get; set; }
            public string to { get; set; }
            public int moduleId { get; set; }
            public bool isExpiryExists { get; set; }
            public int expiryHours { get; set; }
            public dynamic emailContent { get; set; }
            public bool isMailSentStatus { get; set; }
        }

        public class CommonResponseLogin
        {
            public bool isStatus { get; set; }
            public dynamic response { get; set; }
            public dynamic token { get; set; }
        }

        public class GeneralResponse
        {
            public bool isStatus { get; set; }
            public dynamic response { get; set; }
            public int fgPartId { get; set; }
            public string partNo { get; set; }
        }

        public class ShiftList
        {
            public int shfitId { get; set; }
            public string shiftName { get; set; }
            public DateTime shiftStartDateTime { get; set; }
            public DateTime shiftEndDateTime { get; set; }
        }

        public class Mode
        {
            public string modeName { get; set; }
            public string modeColor { get; set; }
        }

        public class ResponseMessage
        {
            public bool isStatus { get; set; }

            public Response response { get; set; } 
        }

        public class Response
        {
            public graphDetails graphDetails { get; set; }
            public tableDetails tableDetails { get; set; }
        }

        public class graphDetails
        {
            public double propOee { get; set; }
            public double availblity { get; set; }
            public double performance { get; set; }
            public double quality { get; set; }
            public int? runningBalance { get; set; }
            public int? woBalance { get; set; }
        }

        public class tableDetails
        {
            public tablePartsDetails partCountShiftDetails { get; set; }
            public tablePartsDetails totalPartHrDetails { get; set; }
            public tablePartsDetails trialPartCountDetails { get; set; }
            public tablePartsDetails dryRunCountDetails { get; set; }
            public tablePartsDetails rejectionDetails { get; set; }
            public tablePartsDetails reworkDetails { get; set; }
            public tablePartsDetails okQuanity { get; set; }
        }

        public class tablePartsDetails
        {
            public int actual { get; set; }
            public double target { get; set; }
            public int rejectionQty { get; set; }
            public int reworkQty { get; set; }
            public int okQty { get; set; }
        }

        public class CommonResponseWithUserName
        {
            public bool isStatus { get; set; }
            public dynamic response { get; set; }
            public int id { get; set; }
            public string userName { get; set; }
        }

        public class CommonResponseWithStatus
        {
            public bool isStatus { get; set; }
            public dynamic response { get; set; }
            public bool ovarallStatus { get; set; }
        }
    }
}