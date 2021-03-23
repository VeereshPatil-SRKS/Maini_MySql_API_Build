using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class UnitworkccsSmtpdetails
    {
        public int SmtpId { get; set; }
        public int Port { get; set; }
        public string Host { get; set; }
        public byte EnableSsl { get; set; }
        public byte UseDefaultCredentials { get; set; }
        public byte Certificate { get; set; }
        public byte IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
