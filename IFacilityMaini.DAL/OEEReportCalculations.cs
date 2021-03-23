using System;
using System.Collections.Generic;
using System.Text;

using IFacilityMaini.DBModels;

using System.Linq;
using static IFacilityMaini.EntityModels.ReportEntity;

namespace IFacilityMaini.DAL
{
   public class OEEReportCalculations
    {


        unitworksccsContext db = new unitworksccsContext();

        public OEEReportCalculations() { }

        public bool OEE(int machineID, string correctdate)
        {
            // string correctdate = DateTime.Now.ToString("yyyy-MM-dd");
            DateTime correctedDate = Convert.ToDateTime(correctdate);
            int GetHour = System.DateTime.Now.Hour;
            DateTime StartModeTime = Convert.ToDateTime(System.DateTime.Now.ToString("yyyy-MM-dd " + GetHour + ":00:00"));
            double SumAvailNu = 0;
            double SumPFNu = 0;
            double SumQFNu = 0;

            double SumAvailDe = 0;
            double SumPFde = 0;
            double SumQFde = 0;

            double AvailabilityPercentage = 0;
            double PerformancePercentage = 0;
            double QualityPercentage = 0;
            double OEEPercentage = 0;

            
            decimal Utilization = 0;
            decimal DayOEEPercent = 0;
            int PerformanceFactor = 0;
            double Quality = 0;
            int TotlaQty = 0;
            decimal IdealCycleTimeVal = 0;

            OEECalModel OEECal = OEEDetails(machineID, correctedDate);
            decimal OperatingTime = OEECal.OperatingTime;
            decimal LossTime = OEECal.LossTime;
            decimal MinorLossTime = OEECal.MinorLossTime;
            decimal MntTime = OEECal.MntTime;
            decimal SetupTime = OEECal.SetupTime;
            //decimal SetupMinorTime = 0;
            decimal PowerOffTime = OEECal.PowerOffTime;
            decimal PowerONTime = OEECal.PowerONTime;
            int cuttingTime = 0;
            decimal? plannedCycleTime = 0;
            decimal? plannedCycleTimeInMin = 0;

            bool Res = false;
            double totalDowntime = 0;
            double NetAvailableTime = 0;
            decimal OkQty = 0;






            var partsDet = db.UnitworkccsTblfgpartnodet.Where(m => m.MachineId == machineID && m.CorrectedDate == correctdate).Select(m => new { m.WorkOrderNo, m.NoOfPartsPerCycle, m.FgPartNo, m.IdealCycleTime, m.Unit, m.OperationNo }).Distinct().ToList();
            if (partsDet.Count > 0)
            {
                foreach (var item in partsDet)
                {
                    //var partNo = db.tblPlanLinkageMasters.Where(m => m.planLinkageId == item.planLinkageId).Select(m => new { m.fgPartNo, m.idealCycleTime, m.unit,m.operation,m.productionOrder }).FirstOrDefault();
                    string fgPartNo = "";
                    int? opNo = 0;
                    string workOrderNo = "";

                    if (item.IdealCycleTime != null)
                    {
                        if (item.Unit == "Minutes")
                        {
                            plannedCycleTime = Convert.ToDecimal(item.IdealCycleTime);
                            plannedCycleTimeInMin = Math.Round((Convert.ToDecimal(plannedCycleTime)), 2);
                            //var StdCycleTimeinMin = Convert.ToDecimal(plannedCycleTimeInMin);
                        }
                        else if (item.Unit == "Seconds")
                        {
                            plannedCycleTime = Convert.ToDecimal(item.IdealCycleTime);
                            plannedCycleTimeInMin = Math.Round((Convert.ToDecimal(plannedCycleTime / 60)), 2);
                        }
                        opNo = item.OperationNo;
                        fgPartNo = item.FgPartNo;
                        workOrderNo = item.WorkOrderNo;
                    }

                    decimal IdleTime = LossTime + MinorLossTime;
                    decimal BDTime = MntTime;

                    //performance Factor calculation

                    TotlaQty = GetQuantiy(machineID, correctedDate.ToString("yyyy-MM-dd")/*, out cuttingTime*/);


                    IdealCycleTimeVal = (decimal)plannedCycleTimeInMin;
                    int qty = Convert.ToInt32(item.NoOfPartsPerCycle);
                    TotlaQty = TotlaQty * qty;



                    if (TotlaQty == 0)
                        TotlaQty = 1;

                    PerformanceFactor = (int)IdealCycleTimeVal * TotlaQty;

                    if (PerformanceFactor == 0)
                    {
                        PerformanceFactor = 100;
                    }


                    //performance Factor calculation end

                    #region Availibility
                    int TotalAvailableTime = 1440;

                    // var checkTicket = db.UnitworkccsTblraisedticket.Where(m => m.MachineId == machineID && (m.Status == 1 || m.Status == 2 || m.Status == 3 ) && m.CorrectedDate == correctdate && m.TicketOpenDate != null && m.TicketNo.Contains("Downtime-Stopped-BDS")).OrderByDescending(m => m.TicketId).FirstOrDefault();

                    //if (checkTicket != null)
                    //{
                    //    DateTime ticketCloseDate = DateTime.Now;
                    //    DateTime ticketOpenDate = Convert.ToDateTime(checkTicket.TicketOpenDate);

                    //    totalDowntime = (ticketCloseDate - ticketOpenDate).TotalMinutes;
                    //    NetAvailableTime = TotalAvailableTime - totalDowntime;
                    //}
                    //else
                    //{


                    //    var checkTicket1 = db.UnitworkccsTblraisedticket.Where(m => m.MachineId == machineID && m.CorrectedDate == correctdate && (m.Status == 4 || m.Status == 5) && m.TicketOpenDate != null && m.TicketClosedDate != null && m.TicketNo.Contains("Downtime-Stopped-BDS")).OrderByDescending(m => m.TicketId).FirstOrDefault();

                    //    if (checkTicket1 != null)
                    //    {
                    //        DateTime ticketCloseDate = Convert.ToDateTime(checkTicket1.TicketClosedDate);
                    //        string tktClosedDate = ticketCloseDate.ToString("yyyy-MM-dd");


                    //          //  DateTime ticketCloseDate1 = Convert.ToDateTime(checkTicket1.TicketClosedDate);
                    //          //  DateTime ticketOpenDate = Convert.ToDateTime(checkTicket.TicketOpenDate);

                    //          //  totalDowntime = (ticketCloseDate1 - ticketOpenDate).TotalMinutes;
                    //          //  NetAvailableTime = TotalAvailableTime - totalDowntime;


                    //            DateTime ticketCloseDate2 = Convert.ToDateTime(checkTicket1.TicketClosedDate);
                    //        DateTime ticketOpenDate2 = Convert.ToDateTime(checkTicket1.TicketOpenDate);

                    //            totalDowntime = (ticketCloseDate2 - ticketOpenDate2).TotalMinutes;
                    //            NetAvailableTime = TotalAvailableTime - totalDowntime;



                    //    }
                    //    else
                    //    {
                    //        NetAvailableTime = TotalAvailableTime;
                    //    }


                    //}

                    // NetAvailableTime = TotalAvailableTime - totalDowntime;

                    NetAvailableTime = TotalAvailableTime - Convert.ToDouble(BDTime);

                    //if (NetAvailableTime == 0)
                    //{
                    //    AvailabilityPercentage = 0;
                    //}

                    if (NetAvailableTime < 0)
                    {
                        NetAvailableTime = 0;
                    }
                    else
                    {
                        //AvailabilityPercentage = Math.Round(((double)OperatingTime / NetAvailableTime), 2) * 100;
                        AvailabilityPercentage = Math.Round(((double)NetAvailableTime / TotalAvailableTime), 2) * 100;
                    }

                    SumAvailNu = NetAvailableTime;
                    SumAvailDe = TotalAvailableTime;


                    if (AvailabilityPercentage < 0)
                    {
                        AvailabilityPercentage = 0;
                    }

                    #endregion

                    //Utilization = Convert.ToInt32(Convert.ToDouble(Convert.ToDouble((Convert.ToDouble(OperatingTime) + (Convert.ToDouble(MinorLossTime))) / Convert.ToDouble(TotalTime)) * 100));
                    //if (OperatingTime == 0)
                    //    OperatingTime = 1;
                    //else
                    //    OperatingTime = Math.Round(OperatingTime, 2);

                    //double TotalTime1 = Convert.ToDouble(PowerONTime) + Convert.ToDouble(OperatingTime) + Convert.ToDouble(IdleTime) + Convert.ToDouble(BDTime) + Convert.ToDouble(PowerOffTime);

                    var actualQty = db.UnitworkccsTblfgpartnodet.Where(m => m.MachineId == machineID && m.CorrectedDate == correctdate && m.IsClosed == 1).Sum(m => m.ActaulValue);

                    ReportsCalcClass.ProdDetAndon prodDetAndon = new ReportsCalcClass.ProdDetAndon();
                    int rejectionQty = prodDetAndon.GetRejectionDetails1(machineID, correctdate);
                    int reworkQty = prodDetAndon.GetReworkDetails1(machineID, correctdate);
                    int? dryRunQty = prodDetAndon.GetDryRunCount1(machineID, correctdate);
                    int trialQty = prodDetAndon.GetTrialCount1(machineID, correctdate);

                    int? scrapQty = rejectionQty + reworkQty + dryRunQty;

                    int? totalPartCount = actualQty + rejectionQty + reworkQty + dryRunQty + trialQty;


                    #region Performance

                    decimal performanceNumerator = ((decimal)actualQty - trialQty) * ((decimal)plannedCycleTimeInMin);

                    double performanceDenominator = (NetAvailableTime);

                    if (performanceNumerator == 0)
                    {
                        PerformancePercentage = 0;
                    }
                    else
                    {
                        //PerformancePercentage = Math.Round(((double)ActualQtyPerShift / (double)OperatingTime), 2) * 100;
                        PerformancePercentage = Math.Round(((double)performanceNumerator / (double)performanceDenominator), 2) * 100;
                    }


                    SumPFNu = Math.Round(((double)performanceNumerator));
                    SumPFde = performanceDenominator;

                    #endregion

                    #region Quality

                    OkQty = (decimal)actualQty - rejectionQty - reworkQty - trialQty;

                    decimal qualityDenominator = OkQty + rejectionQty + reworkQty;

                    if (OkQty < 0)
                    {
                        OkQty = 0;
                    }

                    if (qualityDenominator == 0)
                    {
                        Quality = 0;
                    }
                    else
                    {
                        //Quality = Math.Round(((double)OkQty / (double)ActualQty), 2) * 100;
                        Quality = Math.Round(((double)OkQty / (double)qualityDenominator), 2) * 100;
                    }

                    SumQFNu = (double)OkQty;
                    SumQFde = (double)qualityDenominator;

                    #endregion

                    #region OEE

                    DayOEEPercent = (decimal)(((AvailabilityPercentage) * (PerformancePercentage) * (Quality)) / 1000000) * 100;
                    OEEPercentage = (double)DayOEEPercent;

                    #endregion

                    //Quality = 100;

                    //decimal Performance = (decimal)Math.Round((((double)IdealCycleTimeVal * (double)TotlaQty) / (double)OperatingTime) * 100, 2);
                    // PerformanceFactor = (int)IdealCycleTimeVal * TotlaQty;

                    //if (PerformanceFactor == 0)
                    //{
                    //    //PerformanceFactor = 100;
                    //}
                    //if (Quality == 0)
                    //{
                    //    //Quality = 100;
                    //}
                    //DayOEEPercent = (decimal)Math.Round((double)(Utilization / 100) * (double)(Performance / 100) * (double)(Quality / 100), 2) * 100;

                    //AvailabilityPercentage = AvailabilityPercentage;
                    //QualityPercentage = Quality;
                    //PerformancePercentage = PerformancePercentage;
                    //OEEPercentage = (double)DayOEEPercent;

                    Res = InsertOEEDetails(correctdate, machineID, (decimal)AvailabilityPercentage, (decimal)Quality, (decimal)PerformancePercentage, (decimal)OEEPercentage, TotlaQty, OperatingTime, IdleTime, (decimal)PerformanceFactor, actualQty, rejectionQty, reworkQty, dryRunQty, trialQty, opNo, fgPartNo, workOrderNo, OkQty, MntTime, MinorLossTime, PowerOffTime, TotalAvailableTime,(decimal) SumAvailNu, (decimal)SumAvailDe, (decimal)SumPFNu, (decimal)SumPFde, (decimal)SumQFNu, (decimal)SumQFde);
                   
                    //}

                }



            }
            else
            {
               // AvailabilityPercentage =(double) (1440 - MntTime) / 1440;

                Res = InsertOEEDetails(correctdate, machineID,(decimal) 0, 0, 0,0, 0, OperatingTime, (LossTime + MinorLossTime), 0, 0, 0, 0, 0, 0, 0, null, null, 0, MntTime, MinorLossTime, PowerOffTime, 1440, (1440-MntTime), 1440, 0, (1440 - MntTime), 0, 0);



            }
            return Res;
        }

        private bool InsertOEEDetails(string CorrectedDate, int MachineID, decimal AvailabilityPercentage, decimal QualityPercentage, decimal PerformancePercentage, decimal OEEPercentage,
            int TotalPartsCount, decimal OperatingTime, decimal TotalIdleTimeInMin, decimal PerformanceFactor, int? actualQty, int rejectionQty, int reworkQty, int? dryRunQty, int trialQty, int? opNo, string fgPartNo, string workOrderNo, decimal OkQty, decimal MntTime, decimal MinorLossTime, decimal PowerOffTime,int totaltime,decimal sumavNu,decimal sumavDe, decimal sumPfnu, decimal sumPfDe, decimal sumQntNu, decimal sumQntDe)
        {
            bool res = false;
            var oeedet = db.UnitworkccsTblOeedetails.Where(m => m.CorrectedDate == CorrectedDate && m.MachineId == MachineID).FirstOrDefault();
            if (oeedet == null)
            {
                UnitworkccsTblOeedetails oee = new UnitworkccsTblOeedetails();
                oee.MachineId = MachineID;
                oee.Availability = AvailabilityPercentage;
                oee.IsDeleted = 0;
                oee.Oee = OEEPercentage;
                oee.Performance = PerformancePercentage;
                oee.Quality = QualityPercentage;
                oee.TotalPartsCount = TotalPartsCount;
                oee.CreatedOn = DateTime.Now;
                oee.CreatedBy = 1;
                oee.CorrectedDate = CorrectedDate;
                oee.OperatingTimeinMin = OperatingTime;
                oee.TotalIdletimeinMin = TotalIdleTimeInMin;
                oee.PerformanceFactor = PerformanceFactor;
                oee.FgPartNo = fgPartNo;
                oee.ActualQty = actualQty;
                oee.DryRunQty = dryRunQty;
                oee.RejectionQty = rejectionQty;
                oee.ReworkQty = reworkQty;
                oee.TrialPartCount = trialQty;
                oee.WorkOrderNo = workOrderNo;
                oee.OpNo = opNo;
                oee.BdTime = MntTime;
                oee.TotalTimeInMinutes = totaltime;
                oee.MinorLossTime = MinorLossTime;
                oee.OkQty = Convert.ToInt32(OkQty);
                oee.PowerOffTimeInMinutes = PowerOffTime;
                oee.AvSumNumerator = sumavNu;
                oee.AvsumDenominator = sumavDe;
                oee.PerSumNumerator = sumPfnu;
                oee.PerSumDenominator = sumPfDe;
                oee.QntSumNumerator = sumQntNu; 
                oee.QntSumDenominator = sumQntDe;

                db.UnitworkccsTblOeedetails.Add(oee);
                db.SaveChanges();
                res = true;
            }
            return res;
        }

        private int GetQuantiy(int MachineID, string Correcteddate/*, out int CuttingTime*/)
        {
            int TotalQty = 0;
            //CuttingTime = 0;
            DateTime CorrectedDate = Convert.ToDateTime(Correcteddate);
            // string Correcteddate = CorrectedDate.ToString("yyyy-MM-dd");
            string NxtCorrecteddate = CorrectedDate.AddDays(1).ToString("yyyy-MM-dd");


            string StartTime = Correcteddate + " 06:00:00";
            string EndTime = NxtCorrecteddate + " 06:00:00";

            DateTime St = Convert.ToDateTime(StartTime);
            DateTime Et = Convert.ToDateTime(EndTime);

            // Based on 1st Machine
            var parametermasterlist = db.UnitworkccsParametersMaster.Where(m => m.MachineId == MachineID && m.CorrectedDate == CorrectedDate.Date && m.InsertedOn >= St && m.InsertedOn <= Et).ToList();
            var TopRow = parametermasterlist.OrderByDescending(m => m.ParameterId).FirstOrDefault();
            var LastRow = parametermasterlist.OrderBy(m => m.ParameterId).FirstOrDefault();
            if (TopRow != null && LastRow != null)
            {
                TotalQty = Convert.ToInt32(TopRow.PartsTotal - LastRow.PartsTotal);
                //CuttingTime = Convert.ToInt32(TopRow.CuttingTime) - Convert.ToInt32(LastRow.CuttingTime);
            }
            return TotalQty;

        }


     

        //Inserting Cutting Time Analysis Data
       

        private OEECalModel OEEDetails(int machineID, DateTime correctedDate)
        {
            OEECalModel objCal = new OEECalModel();
            decimal OperatingTime = 0;
            decimal LossTime = 0;
            decimal MinorLossTime = 0;
            decimal MntTime = 0;
            decimal SetupTime = 0;
            decimal SetupMinorTime = 0;
            decimal PowerOffTime = 0;
            decimal PowerONTime = 0;

           // string datet = correctedDate.ToString("yyyy-MM-dd");
            var machinedet = db.UnitworkccsTblmachinedetails.Where(m => m.IsDeleted == 0 && m.IsNormalWc == 0 && m.MachineId == machineID).FirstOrDefault();

            var GetModeDurations = db.UnitworkccsTbllivemode.Where(m => m.MachineId == machineID && m.CorrectedDate ==correctedDate.Date && m.IsCompleted == 1 && m.ModeTypeEnd == 1).ToList();
            foreach (var ModeRow in GetModeDurations)
            {
                //GetCorrectedDate = ModeRow.CorrectedDate;
                if (ModeRow.ModeType == "PROD")
                {

                    OperatingTime += (decimal)(ModeRow.DurationInSec / 60.00);
                }
                else if (ModeRow.ModeType == "IDLE" && ModeRow.DurationInSec > 600)
                {
                    LossTime += (decimal)(ModeRow.DurationInSec / 60.00);
                    decimal LossDuration = (decimal)(ModeRow.DurationInSec / 60.00);
                    //if (ModeRow.LossCodeID != null)
                    // insertProdlosses(ProdRow.HMIID, (int)ModeRow.LossCodeID, LossDuration, CorrectedDate, MachineID);
                }
                else if (ModeRow.ModeType == "IDLE" && ModeRow.DurationInSec < 600)
                {
                    MinorLossTime += (decimal)(ModeRow.DurationInSec / 60.00);
                }
                else if (ModeRow.ModeType == "MNT")
                {
                    MntTime += (decimal)(ModeRow.DurationInSec / 60.00);
                }
                else if (ModeRow.ModeType == "POWEROFF")
                {
                    PowerOffTime += (decimal)(ModeRow.DurationInSec / 60.00);
                }
                else if (ModeRow.ModeType == "SETUP")
                {
                    try
                    {
                        SetupTime += (decimal)Convert.ToDateTime(ModeRow.LossCodeEnteredTime).Subtract(Convert.ToDateTime(ModeRow.StartTime)).TotalMinutes;
                        //SetupMinorTime += (decimal)(db.tblSetupMaints.Where(m => m.ModeID == ModeRow.ModeID).Select(m => m.MinorLossTime).First() / 60.00);
                    }
                    catch { }
                }
                else if (ModeRow.ModeType == "POWERON")
                {
                    PowerONTime += (decimal)(ModeRow.DurationInSec / 60.00);
                }

            }
            objCal.OperatingTime = OperatingTime;
            objCal.LossTime = LossTime;
            objCal.MinorLossTime = MinorLossTime;
            objCal.MntTime = MntTime;
            objCal.PowerOffTime = PowerOffTime;
            objCal.PowerONTime = PowerONTime;
            objCal.SetupTime = SetupTime;
            return objCal;
        }


        //oee details for shift wise 

        //oee details for shift wise 

        public bool OEEshift(int machineID, string correctdate, string shift)
        {
            // string correctdate = DateTime.Now.ToString("yyyy-MM-dd");
            DateTime correctedDate = Convert.ToDateTime(correctdate);
            int GetHour = System.DateTime.Now.Hour;
            DateTime StartModeTime = Convert.ToDateTime(System.DateTime.Now.ToString("yyyy-MM-dd " + GetHour + ":00:00"));
            double AvailabilityPercentage = 0;
            double PerformancePercentage = 0;
          
            double OEEPercentage = 0;
            decimal DayOEEPercent = 0;


            int PerformanceFactor = 0;
            double Quality = 0;
            int TotlaQty = 0;
         
            OEECalModel OEECal = OEEDetailsShift(machineID, correctedDate, shift);
            decimal OperatingTime = OEECal.OperatingTime;
            decimal LossTime = OEECal.LossTime;
            decimal MinorLossTime = OEECal.MinorLossTime;
            decimal MntTime = OEECal.MntTime;
            decimal SetupTime = OEECal.SetupTime;
          
            decimal PowerOffTime = OEECal.PowerOffTime;
            decimal PowerONTime = OEECal.PowerONTime;
           
            decimal? plannedCycleTimeInMin = 0;

            bool Res = false;
         
            double NetAvailableTime = 0;
            decimal OkQty = 0;



            var partsDet = db.UnitworkccsTblfgpartnodet.Where(m => m.MachineId == machineID && m.CorrectedDate == correctdate && m.Shift == shift).Distinct().ToList();
            if (partsDet.Count > 0)
            {
                foreach (var item in partsDet)
                {
                    //var partNo = db.tblPlanLinkageMasters.Where(m => m.planLinkageId == item.planLinkageId).Select(m => new { m.fgPartNo, m.idealCycleTime, m.unit,m.operation,m.productionOrder }).FirstOrDefault();
                    string fgPartNo = "";
                    int? opNo = 0;
                    string workOrderNo = "";

                    opNo = item.OperationNo;
                    fgPartNo = item.FgPartNo;
                    workOrderNo = item.WorkOrderNo;

                    decimal IdleTime = LossTime + MinorLossTime;
                    decimal BDTime = MntTime;


                    #region Availibility
                    int TotalAvailableTime = 480;


                    NetAvailableTime = TotalAvailableTime - Convert.ToDouble(BDTime);

                    if (NetAvailableTime < 0)
                    {
                        NetAvailableTime = 0;
                    }
                    else
                    {
                        //AvailabilityPercentage = Math.Round(((double)OperatingTime / NetAvailableTime), 2) * 100;
                        AvailabilityPercentage = Math.Round(((double)NetAvailableTime / TotalAvailableTime), 2) * 100;
                    }

                    #endregion


                    var actualQty = db.UnitworkccsTblfgpartnodet.Where(m => m.MachineId == machineID && m.CorrectedDate == correctdate && m.IsClosed == 1 && m.Shift == shift).Sum(m => m.ActaulValue);

                    ReportsCalcClass.ProdDetAndon prodDetAndon = new ReportsCalcClass.ProdDetAndon();
                    int rejectionQty = prodDetAndon.GetRejectionDetails(machineID, correctdate, shift);
                    int reworkQty = prodDetAndon.GetReworkDetails(machineID, correctdate, shift);
                    int? dryRunQty = prodDetAndon.GetDryRunCount(machineID, correctdate, shift);
                    int trialQty = prodDetAndon.GetTrialCount(machineID, correctdate, shift);

                    int? scrapQty = rejectionQty + reworkQty + dryRunQty;

                    int? totalPartCount = actualQty + rejectionQty + reworkQty + dryRunQty + trialQty;


                    #region Performance



                    if (item.Performance == null || item.Performance == 0)
                    {
                        PerformancePercentage = 0;
                    }
                    else
                    {

                        PerformancePercentage = (double)item.Performance;
                    }
                    if (PerformancePercentage > 100)
                        PerformancePercentage = 100;

                        #endregion

                        #region Quality

                    OkQty = (decimal)actualQty - rejectionQty - reworkQty - trialQty;

                    decimal qualityDenominator = OkQty + rejectionQty + reworkQty;

                    if (OkQty < 0)
                    {
                        OkQty = 0;
                    }

                    if (item.Quality == 0 || item.Quality == null)
                    {
                        Quality = 0;
                    }
                    else
                    {

                        Quality = (double)item.Quality;
                    }

                    if (Quality>100)
                        Quality = 100;

                        #endregion

                        #region OEE


                    DayOEEPercent = (decimal)(((AvailabilityPercentage) * (PerformancePercentage) * (Quality)) / 1000000) * 100;
                    OEEPercentage = (double)DayOEEPercent;

                    if (OEEPercentage > 100)
                        OEEPercentage = 100;
                    //if (item.Oee==0 || item.Oee==null)
                    //{
                    //    OEEPercentage = 0;
                    //}
                    //else
                    //{
                    //    OEEPercentage = (double)item.Oee;
                    //}


                        #endregion



                    Res = InsertOEEDetailsShift(correctdate, machineID, shift, (decimal)AvailabilityPercentage, (decimal)Quality, (decimal)PerformancePercentage, (decimal)OEEPercentage, TotlaQty, OperatingTime, IdleTime, (decimal)PerformanceFactor, actualQty, rejectionQty, reworkQty, dryRunQty, trialQty, opNo, fgPartNo, workOrderNo, OkQty, MntTime, MinorLossTime, PowerOffTime, TotalAvailableTime);


                }
            }
            else 
            {

                Res = InsertOEEDetailsShift(correctdate, machineID, shift, 0, 0, 0,0, 0, OperatingTime, (LossTime + MinorLossTime), 0, 0, 0, 0, 0, 0, 0, null, null, 0, MntTime, MinorLossTime, PowerOffTime, 480);


            }


            return Res;
        }


        private bool InsertOEEDetailsShift(string CorrectedDate, int MachineID, string shift, decimal AvailabilityPercentage, decimal QualityPercentage, decimal PerformancePercentage, decimal OEEPercentage,
            int TotalPartsCount, decimal OperatingTime, decimal TotalIdleTimeInMin, decimal PerformanceFactor, int? actualQty, int rejectionQty, int reworkQty, int? dryRunQty, int trialQty, int? opNo, string fgPartNo, string workOrderNo, decimal OkQty, decimal MntTime, decimal MinorLossTime, decimal PowerOffTime,int totaltime)
        {
            bool res = false;
            var oeedet = db.UnitworkccsTblOeeshiftdetails.Where(m => m.CorrectedDate == CorrectedDate && m.MachineId == MachineID && m.Shift==shift).FirstOrDefault();
            if (oeedet == null)
            {
                UnitworkccsTblOeeshiftdetails oee = new UnitworkccsTblOeeshiftdetails();
                oee.MachineId = MachineID;
                oee.Availability = AvailabilityPercentage;
                oee.IsDeleted = 0;
                oee.Oee = OEEPercentage;
                oee.Performance = PerformancePercentage;
                oee.Quality = QualityPercentage;
                oee.TotalPartsCount = TotalPartsCount;
                oee.CreatedOn = DateTime.Now;
                oee.CreatedBy = 1;
                oee.CorrectedDate = CorrectedDate;
                oee.OperatingTimeinMin = OperatingTime;
                oee.TotalIdletimeinMin = TotalIdleTimeInMin;
                oee.PerformanceFactor = PerformanceFactor;
                oee.FgPartNo = fgPartNo;
                oee.ActualQty = actualQty;
                oee.DryRunQty = dryRunQty;
                oee.RejectionQty = rejectionQty;
                oee.ReworkQty = reworkQty;
                oee.TrialPartCount = trialQty;
                oee.WorkOrderNo = workOrderNo;
                oee.OpNo = opNo;
                oee.TotalTimeInMinutes = totaltime;
                oee.BdTime = MntTime;
                oee.MinorLossTime = MinorLossTime;
                oee.OkQty = Convert.ToInt32(OkQty);
                oee.PowerOffTimeInMinutes = PowerOffTime;
                oee.Shift = shift;
                db.UnitworkccsTblOeeshiftdetails.Add(oee);
                db.SaveChanges();
                res = true;
            }
            return res;
        }

        private int GetQuantiyShift(int MachineID, string Correcteddate, string shift, out int CuttingTime)
        {
            int TotalQty = 0;
            CuttingTime = 0;
            DateTime CorrectedDate = Convert.ToDateTime(Correcteddate);
            // string Correcteddate = CorrectedDate.ToString("yyyy-MM-dd");
            string NxtCorrecteddate = CorrectedDate.AddDays(1).ToString("yyyy-MM-dd");


            string StartTime = Correcteddate + " 06:00:00";
            string EndTime = NxtCorrecteddate + " 06:00:00";

            DateTime St = Convert.ToDateTime(StartTime);
            DateTime Et = Convert.ToDateTime(EndTime);

            var shiftdet = db.UnitworkccsTblshiftMstr.Where(m => m.ShiftName == shift).FirstOrDefault();

            // Based on 1st Machine
            var parametermasterlist = db.UnitworkccsParametersMaster.Where(m => m.MachineId == MachineID && m.CorrectedDate == CorrectedDate.Date && m.Shift == shiftdet.ShiftId/* m.InsertedOn >= St && m.InsertedOn <= Et*/).ToList();
            var TopRow = parametermasterlist.OrderByDescending(m => m.ParameterId).FirstOrDefault();
            var LastRow = parametermasterlist.OrderBy(m => m.ParameterId).FirstOrDefault();
            if (TopRow != null && LastRow != null)
            {
                TotalQty = Convert.ToInt32(TopRow.PartsTotal - LastRow.PartsTotal);
                CuttingTime = Convert.ToInt32(TopRow.CuttingTime) - Convert.ToInt32(LastRow.CuttingTime);
            }
            return TotalQty;

        }

        private OEECalModel OEEDetailsShift(int machineID, DateTime correctedDate, string shift)
        {
            OEECalModel objCal = new OEECalModel();
            decimal OperatingTime = 0;
            decimal LossTime = 0;
            decimal MinorLossTime = 0;
            decimal MntTime = 0;
            decimal SetupTime = 0;
            decimal SetupMinorTime = 0;
            decimal PowerOffTime = 0;
            decimal PowerONTime = 0;
            var machinedet = db.UnitworkccsTblmachinedetails.Where(m => m.IsDeleted == 0 && m.IsNormalWc == 0 && m.MachineId == machineID).FirstOrDefault();

           var shiftdet = db.UnitworkccsTblshiftMstr.Where(m => m.ShiftName == shift).Select(m=>m.ShiftId).FirstOrDefault();


          //  TimeSpan tblst = (TimeSpan)shiftdet.StartTime;
          //  TimeSpan tblet = (TimeSpan)shiftdet.EndTime;

          //  string[] st1 = tblst.ToString().Split('.');
          //  string[] et1 = tblet.ToString().Split('.');

          //  string st = st1[0];
          // string et = et1[0];

          //  string shiftwiseST = correctedDate.ToString("yyyy-MM-dd") +" "+ st;
          //  string shiftwiseET =correctedDate.ToString("yyyy-MM-dd") +" " +et;

           // DateTime stt = Convert.ToDateTime(shiftwiseST);
          //  DateTime ett = Convert.ToDateTime(shiftwiseET);

            var GetModeDurations = db.UnitworkccsTbllivemode.Where(m => m.MachineId == machineID && m.CorrectedDate == correctedDate.Date && m.IsCompleted == 1 && m.ModeTypeEnd == 1 && m.IsShiftEnd== shiftdet).ToList();
            foreach (var ModeRow in GetModeDurations)
            {
                //GetCorrectedDate = ModeRow.CorrectedDate;
                if (ModeRow.ModeType == "PROD")
                {

                    OperatingTime += (decimal)(ModeRow.DurationInSec / 60.00);
                }
                else if (ModeRow.ModeType == "IDLE" && ModeRow.DurationInSec > 600)
                {
                    LossTime += (decimal)(ModeRow.DurationInSec / 60.00);
                    decimal LossDuration = (decimal)(ModeRow.DurationInSec / 60.00);
                    //if (ModeRow.LossCodeID != null)
                    // insertProdlosses(ProdRow.HMIID, (int)ModeRow.LossCodeID, LossDuration, CorrectedDate, MachineID);
                }
                else if (ModeRow.ModeType == "IDLE" && ModeRow.DurationInSec < 600)
                {
                    MinorLossTime += (decimal)(ModeRow.DurationInSec / 60.00);
                }
                else if (ModeRow.ModeType == "MNT")
                {
                    MntTime += (decimal)(ModeRow.DurationInSec / 60.00);
                }
                else if (ModeRow.ModeType == "POWEROFF")
                {
                    PowerOffTime += (decimal)(ModeRow.DurationInSec / 60.00);
                }
                else if (ModeRow.ModeType == "SETUP")
                {
                    try
                    {
                        SetupTime += (decimal)Convert.ToDateTime(ModeRow.LossCodeEnteredTime).Subtract(Convert.ToDateTime(ModeRow.StartTime)).TotalMinutes;
                        //SetupMinorTime += (decimal)(db.tblSetupMaints.Where(m => m.ModeID == ModeRow.ModeID).Select(m => m.MinorLossTime).First() / 60.00);
                    }
                    catch { }
                }
                else if (ModeRow.ModeType == "POWERON")
                {
                    PowerONTime += (decimal)(ModeRow.DurationInSec / 60.00);
                }

            }
            objCal.OperatingTime = OperatingTime;
            objCal.LossTime = LossTime;
            objCal.MinorLossTime = MinorLossTime;
            objCal.MntTime = MntTime;
            objCal.PowerOffTime = PowerOffTime;
            objCal.PowerONTime = PowerONTime;
            objCal.SetupTime = SetupTime;
            return objCal;
        }


        //operator oee

        public bool OEEoperator(int machineID, string correctdate, int operatorId, string shift)
        {
            // string correctdate = DateTime.Now.ToString("yyyy-MM-dd");
            DateTime correctedDate = Convert.ToDateTime(correctdate);
            int GetHour = System.DateTime.Now.Hour;
            DateTime StartModeTime = Convert.ToDateTime(System.DateTime.Now.ToString("yyyy-MM-dd " + GetHour + ":00:00"));
            double AvailabilityPercentage = 0;
            double PerformancePercentage = 0;
            double QualityPercentage = 0;
            double OEEPercentage = 0;


            decimal Utilization = 0;
            decimal DayOEEPercent = 0;
            int PerformanceFactor = 0;
            double Quality = 0;
            int TotlaQty = 0;
            decimal IdealCycleTimeVal = 0;

            OEECalModel OEECal = OEEDetailsOperator(machineID, correctedDate, operatorId, shift);
            decimal OperatingTime = OEECal.OperatingTime;
            decimal LossTime = OEECal.LossTime;
            decimal MinorLossTime = OEECal.MinorLossTime;
            decimal MntTime = OEECal.MntTime;
            decimal SetupTime = OEECal.SetupTime;
            //decimal SetupMinorTime = 0;
            decimal PowerOffTime = OEECal.PowerOffTime;
            decimal PowerONTime = OEECal.PowerONTime;
            int cuttingTime = 0;
            decimal? plannedCycleTime = 0;
            decimal? plannedCycleTimeInMin = 0;

            bool Res = false;
            double totalDowntime = 0;
            double NetAvailableTime = 0;
            decimal OkQty = 0;

            // var fgdetshift1 = db.UnitworkccsTblfgpartnodet.Where(m => m.OperatorId == operatorId && m.MachineId == machineID && m.CorrectedDate == correctedDate.ToString("yyyy-MM-dd")).Select(m => m.Shift).FirstOrDefault();


            // var shiftdet1 = db.UnitworkccsTblshiftMstr.Where(m => m.ShiftName == fgdetshift1).Select(m => m.ShiftId).FirstOrDefault();



            var partsDet = db.UnitworkccsTblfgpartnodet.Where(m => m.MachineId == machineID && m.CorrectedDate == correctdate && m.OperatorId == operatorId && m.Shift == shift).Select(m => new { m.WorkOrderNo, m.NoOfPartsPerCycle, m.FgPartNo, m.IdealCycleTime, m.Unit, m.OperationNo }).Distinct().ToList();
            if (partsDet.Count > 0)
            {
                foreach (var item in partsDet)
                {

                    string fgPartNo = "";
                    int? opNo = 0;
                    string workOrderNo = "";

                    if (item.IdealCycleTime != null)
                    {
                        if (item.Unit == "Minutes")
                        {
                            plannedCycleTime = Convert.ToDecimal(item.IdealCycleTime);
                            plannedCycleTimeInMin = Math.Round((Convert.ToDecimal(plannedCycleTime)), 2);

                        }
                        else if (item.Unit == "Seconds")
                        {
                            plannedCycleTime = Convert.ToDecimal(item.IdealCycleTime);
                            plannedCycleTimeInMin = Math.Round((Convert.ToDecimal(plannedCycleTime / 60)), 2);
                        }
                        opNo = item.OperationNo;
                        fgPartNo = item.FgPartNo;
                        workOrderNo = item.WorkOrderNo;
                    }

                    decimal IdleTime = LossTime + MinorLossTime;
                    decimal BDTime = MntTime;


                    #region Availibility
                    int TotalAvailableTime = 480;

                    //var checkTicket = db.UnitworkccsTblraisedticket.Where(m => m.MachineId == machineID && (m.Status == 1 || m.Status == 2 || m.Status == 3) && m.CorrectedDate==correctdate && m.TicketOpenDate != null && m.TicketNo.Contains("Downtime-Stopped-BDS")).OrderByDescending(m => m.TicketId).FirstOrDefault();

                    //if (checkTicket != null)
                    //{
                    //    DateTime ticketCloseDate = DateTime.Now;
                    //    DateTime ticketOpenDate = Convert.ToDateTime(checkTicket.TicketOpenDate);

                    //    totalDowntime = (ticketCloseDate - ticketOpenDate).TotalMinutes;
                    //    NetAvailableTime = TotalAvailableTime - totalDowntime;
                    //}

                    //else
                    //{


                    //    var checkTicket1 = db.UnitworkccsTblraisedticket.Where(m => m.MachineId == machineID && (m.Status == 4 || m.Status == 5) && m.CorrectedDate == correctdate && m.TicketOpenDate != null && m.TicketClosedDate != null && m.TicketNo.Contains("Downtime-Stopped-BDS")).OrderByDescending(m => m.TicketId).FirstOrDefault();

                    //    if (checkTicket1 != null)
                    //    {
                    //        DateTime ticketCloseDate = Convert.ToDateTime(checkTicket1.TicketClosedDate);
                    //        string tktClosedDate = ticketCloseDate.ToString("yyyy-MM-dd");



                    //        DateTime ticketCloseDate2 = Convert.ToDateTime(checkTicket1.TicketClosedDate);
                    //        DateTime ticketOpenDate2 = Convert.ToDateTime(checkTicket1.TicketOpenDate);

                    //        totalDowntime = (ticketCloseDate2 - ticketOpenDate2).TotalMinutes;
                    //        NetAvailableTime = TotalAvailableTime - totalDowntime;



                    //    }
                    //    else
                    //    {
                    //        NetAvailableTime = TotalAvailableTime;
                    //    }


                    //}



                    NetAvailableTime = TotalAvailableTime - (double)BDTime;

                    if (NetAvailableTime == 0)
                    {
                        AvailabilityPercentage = 0;
                    }
                    else
                    {
                        //AvailabilityPercentage = Math.Round(((double)OperatingTime / NetAvailableTime), 2) * 100;
                        AvailabilityPercentage = Math.Round(((double)NetAvailableTime / TotalAvailableTime), 2) * 100;
                    }



                    if (AvailabilityPercentage < 0)
                    {
                        AvailabilityPercentage = 0;
                    }
                    #endregion


                    var actualQty = db.UnitworkccsTblfgpartnodet.Where(m => m.MachineId == machineID && m.CorrectedDate == correctdate && m.IsClosed == 1 && m.OperatorId == operatorId && m.Shift == shift).Select(m => m.ActaulValue).FirstOrDefault();

                    ReportsCalcClass.ProdDetAndon prodDetAndon = new ReportsCalcClass.ProdDetAndon();
                    int rejectionQty = prodDetAndon.GetRejectionDetails2(machineID, correctdate, operatorId, shift);
                    int reworkQty = prodDetAndon.GetReworkDetails2(machineID, correctdate, operatorId, shift);
                    int? dryRunQty = prodDetAndon.GetDryRunCount2(machineID, correctdate, operatorId, shift);
                    int trialQty = prodDetAndon.GetTrialCount2(machineID, correctdate, operatorId, shift);

                    int? scrapQty = rejectionQty + reworkQty + dryRunQty;

                    int? totalPartCount = actualQty + rejectionQty + reworkQty + dryRunQty + trialQty;


                    #region Performance

                    if (actualQty == null)
                    {
                        actualQty = 0;
                    }

                    decimal performanceNumerator = ((decimal)actualQty - trialQty) * ((decimal)plannedCycleTimeInMin);

                    double performanceDenominator = (NetAvailableTime);
                    //decimal performanceNumerator = ((decimal)actualQty - trialQty);

                    //double performanceDenominator = (NetAvailableTime / (double)plannedCycleTimeInMin);

                    if (performanceNumerator == 0)
                    {
                        PerformancePercentage = 0;
                    }
                    else
                    {
                        //PerformancePercentage = Math.Round(((double)ActualQtyPerShift / (double)OperatingTime), 2) * 100;
                        PerformancePercentage = Math.Round(((double)performanceNumerator / (double)performanceDenominator), 2) * 100;
                    }

                    #endregion

                    #region Quality

                    OkQty = (decimal)actualQty - rejectionQty - reworkQty - trialQty;

                    decimal qualityDenominator = OkQty + rejectionQty + reworkQty;

                    if (OkQty < 0)
                    {
                        OkQty = 0;
                    }

                    if (qualityDenominator == 0)
                    {
                        Quality = 0;
                    }
                    else
                    {
                        //Quality = Math.Round(((double)OkQty / (double)ActualQty), 2) * 100;
                        Quality = Math.Round(((double)OkQty / (double)qualityDenominator), 2) * 100;
                    }

                    #endregion

                    #region OEE

                    DayOEEPercent = (decimal)(((AvailabilityPercentage) * (PerformancePercentage) * (Quality)) / 1000000) * 100;
                    OEEPercentage = (double)DayOEEPercent;

                    #endregion

                    Res = InsertOEEDetailsOperator(correctdate, machineID, operatorId, (decimal)AvailabilityPercentage, (decimal)Quality, (decimal)PerformancePercentage, (decimal)OEEPercentage, TotlaQty, OperatingTime, IdleTime, (decimal)PerformanceFactor, actualQty, rejectionQty, reworkQty, dryRunQty, trialQty, opNo, fgPartNo, workOrderNo, OkQty, MntTime, MinorLossTime, PowerOffTime, TotalAvailableTime, shift);


                }
            }
            else
            {
                Res = InsertOEEDetailsOperator(correctdate, machineID, operatorId, 0, 0, 0, 0, 0, OperatingTime, (LossTime + MinorLossTime), 0, 0, 0, 0, 0, 0, 0, null, null, 0, MntTime, MinorLossTime, PowerOffTime, 1440, null);
            }


            return Res;
        }

        private bool InsertOEEDetailsOperator(string CorrectedDate, int MachineID, int operatorId, decimal AvailabilityPercentage, decimal QualityPercentage, decimal PerformancePercentage, decimal OEEPercentage,
            int TotalPartsCount, decimal OperatingTime, decimal TotalIdleTimeInMin, decimal PerformanceFactor, int? actualQty, int rejectionQty, int reworkQty, int? dryRunQty, int trialQty, int? opNo, string fgPartNo, string workOrderNo, decimal OkQty, decimal MntTime, decimal MinorLossTime, decimal PowerOffTime, int totaltime, string shift)
        {
            bool res = false;
            var oeedet = db.UnitworkccsTblOeeoperatordetails.Where(m => m.CorrectedDate == CorrectedDate && m.MachineId == MachineID && m.Shift == shift && m.OperatorId == Convert.ToString(operatorId)).FirstOrDefault();
            if (oeedet == null)
            {
                UnitworkccsTblOeeoperatordetails oee = new UnitworkccsTblOeeoperatordetails();
                oee.MachineId = MachineID;
                oee.Availability = AvailabilityPercentage;
                oee.IsDeleted = 0;
                oee.Oee = OEEPercentage;
                oee.Performance = PerformancePercentage;
                oee.Quality = QualityPercentage;
                oee.TotalPartsCount = TotalPartsCount;
                oee.CreatedOn = DateTime.Now;
                oee.CreatedBy = 1;
                oee.CorrectedDate = CorrectedDate;
                oee.OperatingTimeinMin = OperatingTime;
                oee.TotalIdletimeinMin = TotalIdleTimeInMin;
                oee.PerformanceFactor = PerformanceFactor;
                oee.FgPartNo = fgPartNo;
                oee.ActualQty = actualQty;
                oee.DryRunQty = dryRunQty;
                oee.RejectionQty = rejectionQty;
                oee.ReworkQty = reworkQty;
                oee.TrialPartCount = trialQty;
                oee.WorkOrderNo = workOrderNo;
                oee.OpNo = opNo;
                oee.BdTime = MntTime;
                oee.TotalTimeInMinutes = totaltime;
                oee.MinorLossTime = MinorLossTime;
                oee.OkQty = Convert.ToInt32(OkQty);
                oee.PowerOffTimeInMinutes = PowerOffTime;
                oee.OperatorId = Convert.ToString(operatorId);
                oee.Shift = shift;
                db.UnitworkccsTblOeeoperatordetails.Add(oee);

                db.SaveChanges();
                res = true;
            }
            return res;
        }



        private OEECalModel OEEDetailsOperator(int machineID, DateTime correctedDate, int operatorId, string shift)
        {
            OEECalModel objCal = new OEECalModel();
            decimal OperatingTime = 0;
            decimal LossTime = 0;
            decimal MinorLossTime = 0;
            decimal MntTime = 0;
            decimal SetupTime = 0;
            decimal SetupMinorTime = 0;
            decimal PowerOffTime = 0;
            decimal PowerONTime = 0;

            var machinedet = db.UnitworkccsTblmachinedetails.Where(m => m.IsDeleted == 0 && m.IsNormalWc == 0 && m.MachineId == machineID).FirstOrDefault();

            var fgdetshift = db.UnitworkccsTblfgpartnodet.Where(m => m.OperatorId == operatorId && m.MachineId == machineID && m.CorrectedDate == correctedDate.ToString("yyyy-MM-dd")).Select(m => m.Shift).FirstOrDefault();


            var shiftdet = db.UnitworkccsTblshiftMstr.Where(m => m.ShiftName == shift).Select(m => m.ShiftId).FirstOrDefault();


            var GetModeDurations = db.UnitworkccsTbllivemode.Where(m => m.MachineId == machineID && m.CorrectedDate == correctedDate.Date && m.IsShiftEnd == shiftdet && m.IsCompleted == 1 && m.ModeTypeEnd == 1).ToList();
            foreach (var ModeRow in GetModeDurations)
            {
                //GetCorrectedDate = ModeRow.CorrectedDate;
                if (ModeRow.ModeType == "PROD")
                {

                    OperatingTime += (decimal)(ModeRow.DurationInSec / 60.00);
                }
                else if (ModeRow.ModeType == "IDLE" && ModeRow.DurationInSec > 600)
                {
                    LossTime += (decimal)(ModeRow.DurationInSec / 60.00);
                    decimal LossDuration = (decimal)(ModeRow.DurationInSec / 60.00);
                    //if (ModeRow.LossCodeID != null)
                    // insertProdlosses(ProdRow.HMIID, (int)ModeRow.LossCodeID, LossDuration, CorrectedDate, MachineID);
                }
                else if (ModeRow.ModeType == "IDLE" && ModeRow.DurationInSec < 600)
                {
                    MinorLossTime += (decimal)(ModeRow.DurationInSec / 60.00);
                }
                else if (ModeRow.ModeType == "MNT")
                {
                    MntTime += (decimal)(ModeRow.DurationInSec / 60.00);
                }
                else if (ModeRow.ModeType == "POWEROFF")
                {
                    PowerOffTime += (decimal)(ModeRow.DurationInSec / 60.00);
                }
                else if (ModeRow.ModeType == "SETUP")
                {
                    try
                    {
                        SetupTime += (decimal)Convert.ToDateTime(ModeRow.LossCodeEnteredTime).Subtract(Convert.ToDateTime(ModeRow.StartTime)).TotalMinutes;
                        //SetupMinorTime += (decimal)(db.tblSetupMaints.Where(m => m.ModeID == ModeRow.ModeID).Select(m => m.MinorLossTime).First() / 60.00);
                    }
                    catch { }
                }
                else if (ModeRow.ModeType == "POWERON")
                {
                    PowerONTime += (decimal)(ModeRow.DurationInSec / 60.00);
                }

            }
            objCal.OperatingTime = OperatingTime;
            objCal.LossTime = LossTime;
            objCal.MinorLossTime = MinorLossTime;
            objCal.MntTime = MntTime;
            objCal.PowerOffTime = PowerOffTime;
            objCal.PowerONTime = PowerONTime;
            objCal.SetupTime = SetupTime;
            return objCal;
        }

        private bool InsertOEEDetailsOperator(string CorrectedDate, int MachineID, int operatorId, decimal AvailabilityPercentage, decimal QualityPercentage, decimal PerformancePercentage, decimal OEEPercentage,
            int TotalPartsCount, decimal OperatingTime, decimal TotalIdleTimeInMin, decimal PerformanceFactor, int? actualQty, int rejectionQty, int reworkQty, int? dryRunQty, int trialQty, int? opNo, string fgPartNo, string workOrderNo, decimal OkQty, decimal MntTime, decimal MinorLossTime, decimal PowerOffTime,int totaltime)
        {
            bool res = false;
            var oeedet = db.UnitworkccsTblOeeoperatordetails.Where(m => m.CorrectedDate == CorrectedDate && m.MachineId == MachineID &&m.OperatorId==Convert.ToString(  operatorId)).FirstOrDefault();
            if (oeedet == null)
            {
                UnitworkccsTblOeeoperatordetails oee = new UnitworkccsTblOeeoperatordetails();
                oee.MachineId = MachineID;
                oee.Availability = AvailabilityPercentage;
                oee.IsDeleted = 0;
                oee.Oee = OEEPercentage;
                oee.Performance = PerformancePercentage;
                oee.Quality = QualityPercentage;
                oee.TotalPartsCount = TotalPartsCount;
                oee.CreatedOn = DateTime.Now;
                oee.CreatedBy = 1;
                oee.CorrectedDate = CorrectedDate;
                oee.OperatingTimeinMin = OperatingTime;
                oee.TotalIdletimeinMin = TotalIdleTimeInMin;
                oee.PerformanceFactor = PerformanceFactor;
                oee.FgPartNo = fgPartNo;
                oee.ActualQty = actualQty;
                oee.DryRunQty = dryRunQty;
                oee.RejectionQty = rejectionQty;
                oee.ReworkQty = reworkQty;
                oee.TrialPartCount = trialQty;
                oee.WorkOrderNo = workOrderNo;
                oee.OpNo = opNo;
                oee.BdTime = MntTime;
                oee.TotalTimeInMinutes = totaltime;
                oee.MinorLossTime = MinorLossTime;
                oee.OkQty = Convert.ToInt32(OkQty);
                oee.PowerOffTimeInMinutes = PowerOffTime;
                oee.OperatorId = Convert.ToString(operatorId);
                db.UnitworkccsTblOeeoperatordetails.Add(oee);
                db.SaveChanges();
                res = true;
            }
            return res;
        }

        private int GetQuantiyOperator(int MachineID, string Correcteddate, int OperatorId, out int CuttingTime)
        {
            int TotalQty = 0;
            CuttingTime = 0;
            DateTime CorrectedDate = Convert.ToDateTime(Correcteddate);
            // string Correcteddate = CorrectedDate.ToString("yyyy-MM-dd");
            string NxtCorrecteddate = CorrectedDate.AddDays(1).ToString("yyyy-MM-dd");


            string StartTime = Correcteddate + " 06:00:00";
            string EndTime = NxtCorrecteddate + " 06:00:00";

            DateTime St = Convert.ToDateTime(StartTime);
            DateTime Et = Convert.ToDateTime(EndTime);

         //   var shiftdet = db.UnitworkccsTblshiftMstr.Where(m => m.ShiftName == shift).FirstOrDefault();

            // Based on 1st Machine
            var parametermasterlist = db.UnitworkccsParametersMaster.Where(m => m.MachineId == MachineID && m.CorrectedDate == CorrectedDate.Date /*&& m.Shift == shiftdet.ShiftId m.InsertedOn >= St && m.InsertedOn <= Et*/).ToList();
            var TopRow = parametermasterlist.OrderByDescending(m => m.ParameterId).FirstOrDefault();
            var LastRow = parametermasterlist.OrderBy(m => m.ParameterId).FirstOrDefault();
            if (TopRow != null && LastRow != null)
            {
                TotalQty = Convert.ToInt32(TopRow.PartsTotal - LastRow.PartsTotal);
                CuttingTime = Convert.ToInt32(TopRow.CuttingTime) - Convert.ToInt32(LastRow.CuttingTime);
            }
            return TotalQty;

        }

        private OEECalModel OEEDetailsOperator(int machineID, DateTime correctedDate, int operatorId)
        {
            OEECalModel objCal = new OEECalModel();
            decimal OperatingTime = 0;
            decimal LossTime = 0;
            decimal MinorLossTime = 0;
            decimal MntTime = 0;
            decimal SetupTime = 0;
            decimal SetupMinorTime = 0;
            decimal PowerOffTime = 0;
            decimal PowerONTime = 0;
            var machinedet = db.UnitworkccsTblmachinedetails.Where(m => m.IsDeleted == 0 && m.IsNormalWc == 0 && m.MachineId == machineID).FirstOrDefault();

            var GetModeDurations = db.UnitworkccsTbllivemode.Where(m => m.MachineId == machineID && m.CorrectedDate == correctedDate.Date && m.IsCompleted == 1 && m.ModeTypeEnd == 1 ).ToList();
            foreach (var ModeRow in GetModeDurations)
            {
                //GetCorrectedDate = ModeRow.CorrectedDate;
                if (ModeRow.ModeType == "PROD")
                {

                    OperatingTime += (decimal)(ModeRow.DurationInSec / 60.00);
                }
                else if (ModeRow.ModeType == "IDLE" && ModeRow.DurationInSec > 600)
                {
                    LossTime += (decimal)(ModeRow.DurationInSec / 60.00);
                    decimal LossDuration = (decimal)(ModeRow.DurationInSec / 60.00);
                    //if (ModeRow.LossCodeID != null)
                    // insertProdlosses(ProdRow.HMIID, (int)ModeRow.LossCodeID, LossDuration, CorrectedDate, MachineID);
                }
                else if (ModeRow.ModeType == "IDLE" && ModeRow.DurationInSec < 600)
                {
                    MinorLossTime += (decimal)(ModeRow.DurationInSec / 60.00);
                }
                else if (ModeRow.ModeType == "MNT")
                {
                    MntTime += (decimal)(ModeRow.DurationInSec / 60.00);
                }
                else if (ModeRow.ModeType == "POWEROFF")
                {
                    PowerOffTime += (decimal)(ModeRow.DurationInSec / 60.00);
                }
                else if (ModeRow.ModeType == "SETUP")
                {
                    try
                    {
                        SetupTime += (decimal)Convert.ToDateTime(ModeRow.LossCodeEnteredTime).Subtract(Convert.ToDateTime(ModeRow.StartTime)).TotalMinutes;
                        //SetupMinorTime += (decimal)(db.tblSetupMaints.Where(m => m.ModeID == ModeRow.ModeID).Select(m => m.MinorLossTime).First() / 60.00);
                    }
                    catch { }
                }
                else if (ModeRow.ModeType == "POWERON")
                {
                    PowerONTime += (decimal)(ModeRow.DurationInSec / 60.00);
                }

            }
            objCal.OperatingTime = OperatingTime;
            objCal.LossTime = LossTime;
            objCal.MinorLossTime = MinorLossTime;
            objCal.MntTime = MntTime;
            objCal.PowerOffTime = PowerOffTime;
            objCal.PowerONTime = PowerONTime;
            objCal.SetupTime = SetupTime;
            return objCal;
        }

        public bool BreakdownReport(int machineID, string correctdate)
        {
            // string correctdate = DateTime.Now.ToString("yyyy-MM-dd");
            DateTime correctedDate = Convert.ToDateTime(correctdate);
            //  int GetHour = System.DateTime.Now.Hour;
            // DateTime StartModeTime = Convert.ToDateTime(System.DateTime.Now.ToString("yyyy-MM-dd " + GetHour + ":00:00"));




            OEECalModel OEECal = BreakdownReportLiveModeData(machineID, correctedDate);
            decimal OperatingTime = OEECal.OperatingTime;
            decimal LossTime = OEECal.LossTime;
            decimal MinorLossTime = OEECal.MinorLossTime;
            decimal MntTime = OEECal.MntTime;
            decimal SetupTime = OEECal.SetupTime;

            decimal PowerOffTime = OEECal.PowerOffTime;
            decimal PowerONTime = OEECal.PowerONTime;

            bool Res = false;

            decimal TotalAvailableTime = 1440;

            decimal Utilization = 0;

            Utilization = ((OperatingTime + MinorLossTime) / (TotalAvailableTime));
            Utilization = Utilization * 100;

            Utilization = Math.Round(Utilization, 2);

            decimal IdleTime = LossTime + MinorLossTime;
            decimal BDTime = MntTime;





            decimal ElectricalMaintenance = 0;
            decimal MechanicalMaintenance = 0;
            decimal Production = 0;
            decimal HumanResource = 0;
            decimal Quality = 0;
            decimal ToolingStoppage = 0;
            decimal Planning = 0;


            decimal ElectricalMaintenance1 = 0;
            decimal MechanicalMaintenance1 = 0;
            decimal Production1 = 0;
            decimal HumanResource1 = 0;
            decimal Quality1 = 0;
            decimal ToolingStoppage1 = 0;
            decimal Planning1 = 0;

            double totalBreakDown = 0;

            double DryRunTime = 0;
            double totalDryRunTime = 0;
            var dryRundet = db.UnitworkccsTbldryrun.Where(m => m.MachineId == machineID && m.CorrectedDate == correctdate).ToList();
            foreach (var timee in dryRundet)
            {


                DateTime ticketCloseDate2 = Convert.ToDateTime(timee.EndDate);
                DateTime ticketOpenDate2 = Convert.ToDateTime(timee.StartDate);

                DryRunTime = (ticketCloseDate2 - ticketOpenDate2).TotalMinutes;

                totalDryRunTime += DryRunTime;

            }


            var ticketDet = db.UnitworkccsTblraisedticket.Where(m => m.MachineId == machineID && m.CorrectedDate == correctdate).ToList();
            if (ticketDet.Count > 0)
            {
                foreach (var item in ticketDet)
                {


                    double totalDownTime = 0;

                    //downtime and stopped 
                    if (item.ClassId == 1 && item.StatusId == 2)
                    {

                        DateTime ticketCloseDate2 = Convert.ToDateTime(item.TicketClosedDate);
                        DateTime ticketOpenDate2 = Convert.ToDateTime(item.TicketOpenDate);

                        totalDownTime = (ticketCloseDate2 - ticketOpenDate2).TotalMinutes;

                        totalBreakDown += totalDownTime;


                        if (item.CategoryId == 1)
                        {
                            ElectricalMaintenance += Convert.ToDecimal(totalDownTime);
                        }
                        else if (item.CategoryId == 2)
                        {
                            MechanicalMaintenance += Convert.ToDecimal(totalDownTime);
                        }
                        else if (item.CategoryId == 3)
                        {
                            Production += Convert.ToDecimal(totalDownTime);
                        }
                        else if (item.CategoryId == 4)
                        {
                            HumanResource += Convert.ToDecimal(totalDownTime);
                        }
                        else if (item.CategoryId == 5)
                        {
                            Quality += Convert.ToDecimal(totalDownTime);
                        }
                        else if (item.CategoryId == 6)
                        {
                            ToolingStoppage += Convert.ToDecimal(totalDownTime);
                        }
                        else if (item.CategoryId == 7)
                        {
                            Planning += Convert.ToDecimal(totalDownTime);
                        }


                    }

                    //downtime and running with issue
                    else if (item.ClassId == 1 && item.StatusId == 1)
                    {


                        DateTime ticketCloseDate2 = Convert.ToDateTime(item.TicketClosedDate);
                        DateTime ticketOpenDate2 = Convert.ToDateTime(item.TicketOpenDate);

                        totalDownTime = (ticketCloseDate2 - ticketOpenDate2).TotalMinutes;


                        totalBreakDown += totalDownTime;

                        if (item.CategoryId == 1)
                        {
                            ElectricalMaintenance1 += Convert.ToDecimal(totalDownTime);
                        }
                        else if (item.CategoryId == 2)
                        {
                            MechanicalMaintenance1 += Convert.ToDecimal(totalDownTime);
                        }
                        else if (item.CategoryId == 3)
                        {
                            Production1 += Convert.ToDecimal(totalDownTime);
                        }
                        else if (item.CategoryId == 4)
                        {
                            HumanResource1 += Convert.ToDecimal(totalDownTime);
                        }
                        else if (item.CategoryId == 5)
                        {
                            Quality1 += Convert.ToDecimal(totalDownTime);
                        }
                        else if (item.CategoryId == 6)
                        {
                            ToolingStoppage1 += Convert.ToDecimal(totalDownTime);
                        }
                        else if (item.CategoryId == 7)
                        {
                            Planning1 += Convert.ToDecimal(totalDownTime);
                        }



                    }




                }
                // Total Time(min)    Operating Time(min)    DryRun Time Setup Time(min)    Load Unload time(min)   Loss / IDLE Time(min)  Breakdown Time(min)    Power Off / Data Loss Time(min)    Utilization %



                Res = InsertBreakdownReport(correctdate, machineID, OperatingTime, (decimal)totalDryRunTime, LossTime, MntTime, MinorLossTime, PowerOffTime, (int)TotalAvailableTime, SetupTime, (decimal)Utilization, ElectricalMaintenance,
                                MechanicalMaintenance, Production, HumanResource, Quality, ToolingStoppage, Planning, ElectricalMaintenance1,
                                MechanicalMaintenance1, Production1, HumanResource1, Quality1, ToolingStoppage1, Planning1);

            }
            else
            {

                Res = InsertBreakdownReport(correctdate, machineID, OperatingTime, (decimal)totalDryRunTime, LossTime, MntTime, MinorLossTime, PowerOffTime, (int)TotalAvailableTime, SetupTime, (decimal)Utilization, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            }
            return Res;
        }

        private bool InsertBreakdownReport(string correctdate, int machineID, decimal OperatingTime, decimal totalDryRunTime, decimal LossTime, decimal MntTime, decimal MinorLossTime, decimal PowerOffTime, decimal TotalAvailableTime, decimal SetupTime, decimal Utilization, decimal ElectricalMaintenance,
                             decimal MechanicalMaintenance, decimal Production, decimal HumanResource, decimal Quality, decimal ToolingStoppage, decimal Planning, decimal ElectricalMaintenance1,
                              decimal MechanicalMaintenance1, decimal Production1, decimal HumanResource1, decimal Quality1, decimal ToolingStoppage1, decimal Planning1)
        {
            bool res = false;
            var breakDownd = db.UnitworkccsTblbreakdownReportdetails.Where(m => m.CorrectedDate == correctdate && m.MachineId == machineID).FirstOrDefault();
            if (breakDownd == null)
            {
                UnitworkccsTblbreakdownReportdetails bkd = new UnitworkccsTblbreakdownReportdetails();


                bkd.IsDeleted = 0;
                bkd.IsCreatedOn = DateTime.Now;

                bkd.MachineId = machineID;
                bkd.CorrectedDate = correctdate;

                bkd.OperatingTime = OperatingTime;
                bkd.DryRunTime = totalDryRunTime;
                bkd.LossOrIdleTime = LossTime;
                bkd.LoadUnloadTime = MinorLossTime;
                bkd.BreakdownTime = MntTime;
                bkd.PowerOffOrDataLossTime = PowerOffTime;
                bkd.TotalTime = TotalAvailableTime;
                bkd.SetUpTime = SetupTime;
                bkd.Utilization = Utilization;

                bkd.ElectricalMaintenance = ElectricalMaintenance;
                bkd.MechanicalMaintenance = MechanicalMaintenance;
                bkd.Production = Production;
                bkd.Quality = Quality;
                bkd.HumanResource = HumanResource;
                bkd.ToolingStoppage = ToolingStoppage;
                bkd.Planning = Planning;

                bkd.ElectricalMaintenance1 = ElectricalMaintenance1;
                bkd.MechanicalMaintenance1 = MechanicalMaintenance1;
                bkd.Production1 = Production1;
                bkd.Quality1 = Quality1;
                bkd.HumanResource1 = HumanResource1;
                bkd.ToolingStoppage1 = ToolingStoppage1;
                bkd.Planning1 = Planning1;



                db.UnitworkccsTblbreakdownReportdetails.Add(bkd);
                db.SaveChanges();
                res = true;
            }
            return res;
        }

        private OEECalModel BreakdownReportLiveModeData(int machineID, DateTime correctedDate)
        {
            OEECalModel objCal = new OEECalModel();
            decimal OperatingTime = 0;
            decimal LossTime = 0;
            decimal MinorLossTime = 0;
            decimal MntTime = 0;
            decimal SetupTime = 0;
            decimal SetupMinorTime = 0;
            decimal PowerOffTime = 0;
            decimal PowerONTime = 0;

            // string datet = correctedDate.ToString("yyyy-MM-dd");
            var machinedet = db.UnitworkccsTblmachinedetails.Where(m => m.IsDeleted == 0 && m.IsNormalWc == 0 && m.MachineId == machineID).FirstOrDefault();

            var GetModeDurations = db.UnitworkccsTbllivemode.Where(m => m.MachineId == machineID && m.CorrectedDate == correctedDate.Date && m.IsCompleted == 1 && m.ModeTypeEnd == 1).ToList();
            foreach (var ModeRow in GetModeDurations)
            {
                //GetCorrectedDate = ModeRow.CorrectedDate;
                if (ModeRow.ModeType == "PROD")
                {

                    OperatingTime += (decimal)(ModeRow.DurationInSec / 60.00);
                }
                else if (ModeRow.ModeType == "IDLE" && ModeRow.DurationInSec > 600)
                {
                    LossTime += (decimal)(ModeRow.DurationInSec / 60.00);
                    decimal LossDuration = (decimal)(ModeRow.DurationInSec / 60.00);
                    //if (ModeRow.LossCodeID != null)
                    // insertProdlosses(ProdRow.HMIID, (int)ModeRow.LossCodeID, LossDuration, CorrectedDate, MachineID);
                }
                else if (ModeRow.ModeType == "IDLE" && ModeRow.DurationInSec < 600)
                {
                    MinorLossTime += (decimal)(ModeRow.DurationInSec / 60.00);
                }
                else if (ModeRow.ModeType == "MNT")
                {
                    MntTime += (decimal)(ModeRow.DurationInSec / 60.00);
                }
                else if (ModeRow.ModeType == "POWEROFF")
                {
                    PowerOffTime += (decimal)(ModeRow.DurationInSec / 60.00);
                }
                else if (ModeRow.ModeType == "SETUP")
                {
                    try
                    {
                        SetupTime += (decimal)Convert.ToDateTime(ModeRow.LossCodeEnteredTime).Subtract(Convert.ToDateTime(ModeRow.StartTime)).TotalMinutes;
                        //SetupMinorTime += (decimal)(db.tblSetupMaints.Where(m => m.ModeID == ModeRow.ModeID).Select(m => m.MinorLossTime).First() / 60.00);
                    }
                    catch { }
                }
                else if (ModeRow.ModeType == "POWERON")
                {
                    PowerONTime += (decimal)(ModeRow.DurationInSec / 60.00);
                }

            }
            objCal.OperatingTime = OperatingTime;
            objCal.LossTime = LossTime;
            objCal.MinorLossTime = MinorLossTime;
            objCal.MntTime = MntTime;
            objCal.PowerOffTime = PowerOffTime;
            objCal.PowerONTime = PowerONTime;
            objCal.SetupTime = SetupTime;
            return objCal;
        }

    }
}
