using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblToolAndSocketDetails
    {
        public int SocketId { get; set; }
        public string ToolNumber { get; set; }
        public string SocketNo { get; set; }
        public int? MachineId { get; set; }
        public int? StandardToolLife { get; set; }
        public int? ActaulToolLife { get; set; }
        public DateTime? ToolInsertedDateTime { get; set; }
        public DateTime? ToolRemovedDateTime { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int? IsDeleted { get; set; }
        public string Qrcode { get; set; }
    }
}
