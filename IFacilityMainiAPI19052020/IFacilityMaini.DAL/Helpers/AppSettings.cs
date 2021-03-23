namespace IFacilityMaini.DAL.Helpers
{
    public class AppSettings
    {
        public string Secret { get; set; }
        public string CommonEmail { get; set; }
        public string DocumentEmail { get; set; }
        public string ResetLinkURL { get; set; }
        public string ImageUrl { get; set; }
        public string ImageUrlSave { get; set; }
        public string CandidateUploadURL { get; set; }
        public string QRCodeTemplate { get; set; }
        public string SAPRefFilePath { get; set; }
        public string SAPMatMaster { get; set; }
        public string SAPStockList { get; set; }
        public string SAPWorkCenterMaster { get; set; }
        public string SAPReadFile { get; set; }
        public string SAPToolMaster { get; set; }
        public string PlanVisageMaster { get; set; }
        public string PlanVisageMasterBackup { get; set; }
        public string DefaultConnection { get; set; }
        public string SmsDetails { get; set; }
        public string SmsDetailsPost { get; set; }
        public string SmsDeliveryDetails { get; set; }
        public string SmsKey { get; set; }
        public string SocketName { get; set; }
    }
}