using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class IotgatwayPacketsData
    {
        public int GatewayMsgId { get; set; }
        public string Sof { get; set; }
        public string SiteId { get; set; }
        public string UnitId { get; set; }
        public string PacketType { get; set; }
        public string Time { get; set; }
        public string Date { get; set; }
        public string Ipaddres { get; set; }
        public string ProductSerialNo { get; set; }
        public string Swversion { get; set; }
        public string NumOfNodeDetected { get; set; }
        public string NumOfNodeActive { get; set; }
        public string NodeId { get; set; }
        public string NodeCommunication { get; set; }
        public string NodePayLoadLength { get; set; }
        public string NodeDataPayLoad { get; set; }
        public string Eof { get; set; }
        public string IotgateWayMsg { get; set; }
        public string CorrectedDate { get; set; }
        public string TypeOfDevice { get; set; }
        public string DevicePayLoadLength { get; set; }
        public int? AlaramInput116 { get; set; }
        public int? AlaramInput217 { get; set; }
        public int? AlaramInput318 { get; set; }
        public int? AlaramInput419 { get; set; }
        public int? AlaramInput520 { get; set; }
        public int? AlaramInput622 { get; set; }
        public int? AlaramInput723 { get; set; }
        public int? AlaramInput824 { get; set; }
        public string Reserved { get; set; }
        public string RelayFeedbak1Status { get; set; }
        public string RelayFeedbak2Status { get; set; }
        public string RelayFeedbak3Status { get; set; }
        public string RelayFeedbak4Status { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
