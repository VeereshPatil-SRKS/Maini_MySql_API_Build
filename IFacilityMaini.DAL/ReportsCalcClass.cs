using IFacilityMaini.DBModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace IFacilityMaini.DAL
{
   public class ReportsCalcClass
    {
        public class ProdDetAndon
        {
            unitworksccsContext Serverdb = new unitworksccsContext();

            public ProdDetAndon()
            {

            }

            public void insertProdDet(int MachineID, DateTime CorrectedDate)
            {
                try
                {
                    var getProdList = Serverdb.UnitworkccsTblworkorderentry.Where(m => m.MachineId == MachineID && m.CorrectedDate == CorrectedDate.Date).OrderBy(m => m.Wostart).ToList();

                    foreach (var ProdRow in getProdList)
                    {
                        var GetEntry = Serverdb.UnitworkccsTblProdandondisp.Where(m => m.Woid == ProdRow.Hmiid).FirstOrDefault();
                        if (GetEntry == null)
                        {
                            DateTime ProdStartTime = ProdRow.Wostart;
                            DateTime ProdEndtime = DateTime.Now;
                            try
                            {
                                if (ProdRow.Woend.HasValue)
                                {
                                    ProdEndtime = Convert.ToDateTime(ProdRow.Woend);
                                }
                            }
                            catch { }

                            int OperatingTime = 0;
                            int LossTime = 0;
                            int MinorLossTime = 0;
                            int MntTime = 0;
                            int SetupTime = 0;
                            int SetupMinorTime = 0;
                            int PowerOffTime = 0;

                            #region Logic to get the Mode Durations between a Production Order which are completed
                            var GetModeDurations = Serverdb.UnitworkccsTbllivemode.Where(m => m.MachineId == MachineID && m.StartTime >= ProdStartTime && m.StartTime < ProdEndtime && m.EndTime > ProdStartTime && m.EndTime < ProdEndtime && m.IsCompleted == 1 && m.ModeTypeEnd == 1).ToList();
                            foreach (var ModeRow in GetModeDurations)
                            {
                                if (ModeRow.ModeType == "PROD")
                                {
                                    OperatingTime += (int)(ModeRow.DurationInSec / 60);
                                }
                                else if (ModeRow.ModeType == "IDLE" && ModeRow.DurationInSec > 600)
                                {
                                    LossTime += (int)(ModeRow.DurationInSec / 60);
                                }
                                else if (ModeRow.ModeType == "IDLE" && ModeRow.DurationInSec < 600)
                                {
                                    MinorLossTime += (int)(ModeRow.DurationInSec / 60);
                                }
                                else if (ModeRow.ModeType == "MNT")
                                {
                                    MntTime += (int)(ModeRow.DurationInSec / 60);
                                }
                                else if (ModeRow.ModeType == "POWEROFF")
                                {
                                    PowerOffTime += (int)(ModeRow.DurationInSec / 60);
                                }
                                else if (ModeRow.ModeType == "SETUP")
                                {
                                    try
                                    {
                                        SetupTime += (int)(Convert.ToDateTime(ModeRow.LossCodeEnteredTime).Subtract(Convert.ToDateTime(ModeRow.StartTime)).TotalSeconds / 60);
                                        SetupMinorTime += (int)(Serverdb.UnitworkccsTblsetupmaint.Where(m => m.ModeId == ModeRow.ModeId).Select(m => m.MinorLossTime).First() / 60);
                                    }
                                    catch { }
                                }
                            }
                            #endregion

                            #region Logic to get the Mode Duration if the Production is still Running.
                            if (ProdRow.IsFinished == 0)
                            {
                                var getRunningMode = Serverdb.UnitworkccsTbllivemode.Where(m => m.MachineId == MachineID && m.IsCompleted == 0).OrderByDescending(m => m.ModeId).First();
                                if (getRunningMode.ModeType == "PROD")
                                {
                                    OperatingTime += (int)(DateTime.Now.Subtract(Convert.ToDateTime(getRunningMode.StartTime)).TotalSeconds / 60);
                                }
                                else if (getRunningMode.ModeType == "IDLE")
                                {
                                    LossTime += (int)(DateTime.Now.Subtract(Convert.ToDateTime(getRunningMode.StartTime)).TotalSeconds / 60);
                                }
                                else if (getRunningMode.ModeType == "MNT")
                                {
                                    MntTime += (int)(DateTime.Now.Subtract(Convert.ToDateTime(getRunningMode.StartTime)).TotalSeconds / 60);
                                }
                                else if (getRunningMode.ModeType == "POWEROFF")
                                {
                                    PowerOffTime += (int)(DateTime.Now.Subtract(Convert.ToDateTime(getRunningMode.StartTime)).TotalSeconds / 60);
                                }
                                else if (getRunningMode.ModeType == "SETUP")
                                {
                                    try
                                    {
                                        SetupTime += (int)(Convert.ToDateTime(getRunningMode.LossCodeEnteredTime).Subtract(Convert.ToDateTime(getRunningMode.StartTime)).TotalSeconds / 60);
                                        SetupMinorTime += (int)(Serverdb.UnitworkccsTblsetupmaint.Where(m => m.ModeId == getRunningMode.ModeId).Select(m => m.MinorLossTime).First() / 60);
                                    }
                                    catch { }
                                }
                            }
                            #endregion

                            #region Logic to get the Mode Duration Which Was started before this Production and Ended during this Production
                            var GetEndModeDuration = Serverdb.UnitworkccsTbllivemode.Where(m => m.MachineId == MachineID && m.StartTime < ProdStartTime && m.EndTime > ProdStartTime && m.EndTime < ProdEndtime && m.IsCompleted == 1 && m.ModeTypeEnd == 1).FirstOrDefault();
                            if (GetEndModeDuration != null)
                            {
                                if (GetEndModeDuration.ModeType == "PROD")
                                {
                                    OperatingTime += (int)(Convert.ToDateTime(GetEndModeDuration.EndTime).Subtract(Convert.ToDateTime(ProdStartTime)).TotalSeconds / 60);
                                }
                                else if (GetEndModeDuration.ModeType == "IDLE")
                                {
                                    LossTime += (int)(Convert.ToDateTime(GetEndModeDuration.EndTime).Subtract(Convert.ToDateTime(ProdStartTime)).TotalSeconds / 60);
                                }
                                else if (GetEndModeDuration.ModeType == "MNT")
                                {
                                    MntTime += (int)(Convert.ToDateTime(GetEndModeDuration.EndTime).Subtract(Convert.ToDateTime(ProdStartTime)).TotalSeconds / 60);
                                }
                                else if (GetEndModeDuration.ModeType == "POWEROFF")
                                {
                                    PowerOffTime += (int)(Convert.ToDateTime(GetEndModeDuration.EndTime).Subtract(Convert.ToDateTime(ProdStartTime)).TotalSeconds / 60);
                                }
                                else if (GetEndModeDuration.ModeType == "SETUP")
                                {
                                    try
                                    {
                                        SetupTime += (int)(Convert.ToDateTime(GetEndModeDuration.LossCodeEnteredTime).Subtract(Convert.ToDateTime(GetEndModeDuration.StartTime)).TotalSeconds / 60);
                                        SetupMinorTime += (int)(Serverdb.UnitworkccsTblsetupmaint.Where(m => m.ModeId == GetEndModeDuration.ModeId).Select(m => m.MinorLossTime).First() / 60);
                                    }
                                    catch { }
                                }
                            }
                            #endregion

                            #region Logic to get the Mode Duration Which Was Started during the Production and Ended after the Production
                            var GetStartModeDuration = Serverdb.UnitworkccsTbllivemode.Where(m => m.MachineId == MachineID && m.StartTime >= ProdStartTime && m.EndTime >= ProdStartTime && m.StartTime < ProdEndtime && m.EndTime > ProdEndtime && m.IsCompleted == 1 && m.ModeTypeEnd == 1).FirstOrDefault();
                            if (GetStartModeDuration != null)
                            {
                                if (GetStartModeDuration.ModeType == "PROD")
                                {
                                    OperatingTime += (int)(Convert.ToDateTime(GetStartModeDuration.EndTime).Subtract(Convert.ToDateTime(ProdStartTime)).TotalSeconds / 60);
                                }
                                else if (GetStartModeDuration.ModeType == "IDLE")
                                {
                                    LossTime += (int)(Convert.ToDateTime(GetStartModeDuration.EndTime).Subtract(Convert.ToDateTime(ProdStartTime)).TotalSeconds / 60);
                                }
                                else if (GetStartModeDuration.ModeType == "MNT")
                                {
                                    MntTime += (int)(Convert.ToDateTime(GetStartModeDuration.EndTime).Subtract(Convert.ToDateTime(ProdStartTime)).TotalSeconds / 60);
                                }
                                else if (GetStartModeDuration.ModeType == "POWEROFF")
                                {
                                    PowerOffTime += (int)(Convert.ToDateTime(GetStartModeDuration.EndTime).Subtract(Convert.ToDateTime(ProdStartTime)).TotalSeconds / 60);
                                }
                                else if (GetStartModeDuration.ModeType == "SETUP")
                                {
                                    try
                                    {
                                        SetupTime += (int)(Convert.ToDateTime(GetStartModeDuration.LossCodeEnteredTime).Subtract(Convert.ToDateTime(GetStartModeDuration.StartTime)).TotalSeconds / 60);
                                        SetupMinorTime += (int)(Serverdb.UnitworkccsTblsetupmaint.Where(m => m.ModeId == GetStartModeDuration.ModeId).Select(m => m.MinorLossTime).First() / 60);
                                    }
                                    catch { }
                                }
                            }
                            #endregion

                            double TotalTime = ProdEndtime.Subtract(ProdStartTime).TotalMinutes;
                            decimal UtilPercent = (decimal)Math.Round(OperatingTime / TotalTime * 100, 2);
                            if (UtilPercent > 100)
                            {
                                UtilPercent = 100;
                            }

                            UnitworkccsTblProdandondisp PRA = new UnitworkccsTblProdandondisp();
                            PRA.MachineId = MachineID;
                            PRA.Woid = ProdRow.Hmiid;
                            PRA.CorrectedDate = CorrectedDate.Date;
                            PRA.TotalLoss = LossTime + MinorLossTime - SetupMinorTime;
                            PRA.TotalOperatingTime = OperatingTime;
                            PRA.TotalSetup = SetupTime + SetupMinorTime;
                            PRA.UtilPercent = UtilPercent;
                            PRA.InsertedOn = DateTime.Now;
                            Serverdb.UnitworkccsTblProdandondisp.Add(PRA);
                            Serverdb.SaveChanges();
                        }
                        //else if (GetEntry.UnitworkccsTblworkorderentry.IsFinished == 0)
                        //{
                        //    DateTime ProdStartTime = ProdRow.Wostart;
                        //    DateTime ProdEndtime = DateTime.Now;
                        //    try
                        //    {
                        //        if (ProdRow.Woend.HasValue)
                        //        {
                        //            ProdEndtime = Convert.ToDateTime(ProdRow.Woend);
                        //        }
                        //    }
                        //    catch { }

                        //    decimal OperatingTime = 0;
                        //    decimal LossTime = 0;
                        //    decimal MinorLossTime = 0;
                        //    decimal MntTime = 0;
                        //    decimal SetupTime = 0;
                        //    decimal SetupMinorTime = 0;
                        //    decimal PowerOffTime = 0;

                        //    #region Logic to get the Mode Durations between a Production Order which are completed
                        //    var GetModeDurations = Serverdb.UnitworkccsTbllivemode.Where(m => m.MachineId == MachineID && m.StartTime >= ProdStartTime && m.StartTime <= ProdEndtime && m.EndTime >= ProdStartTime && m.EndTime <= ProdEndtime && m.IsCompleted == 1 && m.ModeTypeEnd == 1).ToList();
                        //    foreach (var ModeRow in GetModeDurations)
                        //    {
                        //        if (ModeRow.ModeType == "PROD")
                        //        {
                        //            OperatingTime += (decimal)(ModeRow.DurationInSec / 60.00);
                        //        }
                        //        else if (ModeRow.ModeType == "IDLE" && ModeRow.DurationInSec > 600)
                        //        {
                        //            LossTime += (decimal)(ModeRow.DurationInSec / 60.00);
                        //        }
                        //        else if (ModeRow.ModeType == "IDLE" && ModeRow.DurationInSec < 600)
                        //        {
                        //            MinorLossTime += (decimal)(ModeRow.DurationInSec / 60.00);
                        //        }
                        //        else if (ModeRow.ModeType == "MNT")
                        //        {
                        //            MntTime += (decimal)(ModeRow.DurationInSec / 60.00);
                        //        }
                        //        else if (ModeRow.ModeType == "POWEROFF")
                        //        {
                        //            PowerOffTime += (decimal)(ModeRow.DurationInSec / 60.00);
                        //        }
                        //        else if (ModeRow.ModeType == "SETUP")
                        //        {
                        //            try
                        //            {
                        //                SetupTime += (decimal)(Convert.ToDateTime(ModeRow.LossCodeEnteredTime).Subtract(Convert.ToDateTime(ModeRow.StartTime)).TotalSeconds / 60);
                        //                SetupMinorTime += (decimal)(Serverdb.UnitworkccsTblsetupmaint.Where(m => m.ModeId == ModeRow.ModeId).Select(m => m.MinorLossTime).First() / 60);
                        //            }
                        //            catch { }
                        //        }
                        //    }
                        //    #endregion

                        //    #region Logic to get the Mode Duration if the Production is still Running.
                        //    if (ProdRow.IsFinished == 0)
                        //    {
                        //        var getRunningMode = Serverdb.UnitworkccsTbllivemode.Where(m => m.MachineId == MachineID && m.IsCompleted == 0).OrderByDescending(m => m.ModeId).First();
                        //        if (getRunningMode.ModeType == "PROD")
                        //        {
                        //            OperatingTime += (decimal)(DateTime.Now.Subtract(Convert.ToDateTime(getRunningMode.StartTime)).TotalSeconds / 60);
                        //        }
                        //        else if (getRunningMode.ModeType == "IDLE")
                        //        {
                        //            LossTime += (decimal)(DateTime.Now.Subtract(Convert.ToDateTime(getRunningMode.StartTime)).TotalSeconds / 60);
                        //        }
                        //        else if (getRunningMode.ModeType == "MNT")
                        //        {
                        //            MntTime += (decimal)(DateTime.Now.Subtract(Convert.ToDateTime(getRunningMode.StartTime)).TotalSeconds / 60);
                        //        }
                        //        else if (getRunningMode.ModeType == "POWEROFF")
                        //        {
                        //            PowerOffTime += (decimal)(DateTime.Now.Subtract(Convert.ToDateTime(getRunningMode.StartTime)).TotalSeconds / 60);
                        //        }
                        //    }
                        //    #endregion

                        //    #region Logic to get the Mode Duration Which Was started before this Production and Ended during this Production
                        //    var GetEndModeDuration = Serverdb.UnitworkccsTbllivemode.Where(m => m.MachineId == MachineID && m.StartTime < ProdStartTime && m.EndTime >= ProdStartTime && m.EndTime <= ProdEndtime && m.IsCompleted == 1 && m.ModeTypeEnd == 1).FirstOrDefault();
                        //    if (GetEndModeDuration != null)
                        //    {
                        //        if (GetEndModeDuration.ModeType == "PROD")
                        //        {
                        //            OperatingTime += (decimal)(Convert.ToDateTime(GetEndModeDuration.EndTime).Subtract(Convert.ToDateTime(ProdStartTime)).TotalSeconds / 60);
                        //        }
                        //        else if (GetEndModeDuration.ModeType == "IDLE")
                        //        {
                        //            LossTime += (decimal)(Convert.ToDateTime(GetEndModeDuration.EndTime).Subtract(Convert.ToDateTime(ProdStartTime)).TotalSeconds / 60);
                        //        }
                        //        else if (GetEndModeDuration.ModeType == "MNT")
                        //        {
                        //            MntTime += (decimal)(Convert.ToDateTime(GetEndModeDuration.EndTime).Subtract(Convert.ToDateTime(ProdStartTime)).TotalSeconds / 60);
                        //        }
                        //        else if (GetEndModeDuration.ModeType == "POWEROFF")
                        //        {
                        //            PowerOffTime += (decimal)(Convert.ToDateTime(GetEndModeDuration.EndTime).Subtract(Convert.ToDateTime(ProdStartTime)).TotalSeconds / 60);
                        //        }
                        //    }
                        //    #endregion

                        //    #region Logic to get the Mode Duration Which Was Started during the Production and Ended Before the Production End
                        //    var GetStartModeDuration = Serverdb.UnitworkccsTbllivemode.Where(m => m.MachineId == MachineID && m.StartTime >= ProdStartTime && m.EndTime >= ProdStartTime && m.StartTime <= ProdEndtime && m.EndTime > ProdEndtime && m.IsCompleted == 1 && m.ModeTypeEnd == 1).FirstOrDefault();
                        //    if (GetStartModeDuration != null)
                        //    {
                        //        if (GetStartModeDuration.ModeType == "PROD")
                        //        {
                        //            OperatingTime += (decimal)(Convert.ToDateTime(GetStartModeDuration.EndTime).Subtract(Convert.ToDateTime(ProdStartTime)).TotalSeconds / 60);
                        //        }
                        //        else if (GetStartModeDuration.ModeType == "IDLE")
                        //        {
                        //            LossTime += (decimal)(Convert.ToDateTime(GetStartModeDuration.EndTime).Subtract(Convert.ToDateTime(ProdStartTime)).TotalSeconds / 60);
                        //        }
                        //        else if (GetStartModeDuration.ModeType == "MNT")
                        //        {
                        //            MntTime += (decimal)(Convert.ToDateTime(GetStartModeDuration.EndTime).Subtract(Convert.ToDateTime(ProdStartTime)).TotalSeconds / 60);
                        //        }
                        //        else if (GetStartModeDuration.ModeType == "POWEROFF")
                        //        {
                        //            PowerOffTime += (decimal)(Convert.ToDateTime(GetStartModeDuration.EndTime).Subtract(Convert.ToDateTime(ProdStartTime)).TotalSeconds / 60);
                        //        }
                        //    }
                        //    #endregion

                        //    double TotalTime = ProdEndtime.Subtract(ProdStartTime).TotalMinutes;
                        //    decimal UtilPercent = (Decimal)Math.Round((double)OperatingTime / TotalTime * 100, 2);
                        //    if (UtilPercent > 100)
                        //    {
                        //        UtilPercent = 100;
                        //    }

                        //    UnitworkccsTblProdandondisp PRA = Serverdb.UnitworkccsTblProdandondisp.Where(m => m.ProdDashboardId == GetEntry.ProdDashboardId).First();
                        //    //PRA.MachineID = MachineID;
                        //    //PRA.WOID = ProdRow.HMIID;
                        //    //PRA.CorrectedDate = CorrectedDate.Date;
                        //    PRA.TotalLoss = (Decimal)Math.Round(LossTime + MinorLossTime - SetupMinorTime, 2);
                        //    PRA.TotalOperatingTime = (Decimal)Math.Round(OperatingTime, 2);
                        //    PRA.TotalSetup = (Decimal)Math.Round(SetupTime + SetupMinorTime, 2);
                        //    PRA.UtilPercent = UtilPercent;
                        //    //  Serverdb.Entry(PRA).State = System.Data.Entity.EntityState.Modified;
                        //    Serverdb.Entry(PRA).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                        //    Serverdb.SaveChanges();
                        //}
                    }
                }
                catch (Exception e)
                {

                }
            }

            #region Old logic Get Production Data for Man Machine Ticket.
            //public void insertManMacProd(int MachineID, DateTime CorrectedDate)
            //{
            //    decimal OperatingTime = 0;
            //    decimal LossTime = 0;
            //    decimal MinorLossTime = 0;
            //    decimal MntTime = 0;
            //    decimal SetupTime = 0;
            //    decimal SetupMinorTime = 0;
            //    decimal PowerOffTime = 0;
            //    try
            //    {
            //        var getProdList = Serverdb.tblworkorderentries.Where(m => m.MachineID == MachineID && m.CorrectedDate == CorrectedDate.Date).OrderBy(m => m.WOStart).ToList();
            //        if (getProdList.Count != 0)
            //        {
            //            foreach (var ProdRow in getProdList)
            //            {
            //                var GetEntry = Serverdb.tbl_ProdManMachine.Where(m => m.WOID == ProdRow.HMIID).FirstOrDefault();
            //                if (GetEntry == null)
            //                {
            //                    DateTime ProdStartTime = ProdRow.WOStart;
            //                    DateTime ProdEndtime = DateTime.Now;
            //                    try
            //                    {
            //                        if (ProdRow.WOEnd.HasValue)
            //                        {
            //                            ProdEndtime = Convert.ToDateTime(ProdRow.WOEnd);
            //                        }
            //                    }
            //                    catch { }



            //                    #region Logic to get the Mode Durations between a Production Order which are completed
            //                    var GetModeDurations = Serverdb.UnitworkccsTbllivemode.Where(m => m.MachineID == MachineID && m.StartTime >= ProdStartTime && m.StartTime < ProdEndtime && m.EndTime > ProdStartTime && m.EndTime <= ProdEndtime && m.IsCompleted == 1 && m.ModeTypeEnd == 1).ToList();
            //                    foreach (var ModeRow in GetModeDurations)
            //                    {
            //                        if (ModeRow.ModeType == "PROD")
            //                        {
            //                            OperatingTime += (decimal)(ModeRow.DurationInSec / 60.00);
            //                        }
            //                        else if (ModeRow.ModeType == "IDLE" && ModeRow.DurationInSec > 600)
            //                        {
            //                            LossTime += (decimal)(ModeRow.DurationInSec / 60.00);
            //                            decimal LossDuration = (decimal)(ModeRow.DurationInSec / 60.00);
            //                            if (ModeRow.LossCodeID != null)
            //                                insertProdlosses(ProdRow.HMIID, (int)ModeRow.LossCodeID, LossDuration, CorrectedDate, MachineID);
            //                        }
            //                        else if (ModeRow.ModeType == "IDLE" && ModeRow.DurationInSec < 600)
            //                        {
            //                            MinorLossTime += (decimal)(ModeRow.DurationInSec / 60.00);
            //                        }
            //                        else if (ModeRow.ModeType == "MNT")
            //                        {
            //                            MntTime += (decimal)(ModeRow.DurationInSec / 60.00);
            //                        }
            //                        else if (ModeRow.ModeType == "POWEROFF")
            //                        {
            //                            PowerOffTime += (decimal)(ModeRow.DurationInSec / 60.00);
            //                        }
            //                        else if (ModeRow.ModeType == "SETUP")
            //                        {
            //                            try
            //                            {
            //                                SetupTime += (decimal)Convert.ToDateTime(ModeRow.LossCodeEnteredTime).Subtract(Convert.ToDateTime(ModeRow.StartTime)).TotalMinutes;
            //                                SetupMinorTime += (decimal)(Serverdb.UnitworkccsTblsetupmaints.Where(m => m.ModeID == ModeRow.ModeID).Select(m => m.MinorLossTime).First() / 60.00);
            //                            }
            //                            catch { }
            //                        }
            //                    }
            //                    #endregion

            //                    #region Logic to get the Mode Duration Which Was started before this Production and Ended during this Production
            //                    var GetEndModeDuration = Serverdb.UnitworkccsTbllivemode.Where(m => m.MachineID == MachineID && m.StartTime < ProdStartTime && m.EndTime > ProdStartTime && m.EndTime <= ProdEndtime && m.IsCompleted == 1 && m.ModeTypeEnd == 1).FirstOrDefault();
            //                    if (GetEndModeDuration != null)
            //                    {
            //                        if (GetEndModeDuration.ModeType == "PROD")
            //                        {
            //                            OperatingTime += (decimal)(Convert.ToDateTime(GetEndModeDuration.EndTime).Subtract(Convert.ToDateTime(ProdStartTime)).TotalSeconds / 60.00);
            //                        }
            //                        else if (GetEndModeDuration.ModeType == "IDLE")
            //                        {
            //                            LossTime += (decimal)(Convert.ToDateTime(GetEndModeDuration.EndTime).Subtract(Convert.ToDateTime(ProdStartTime)).TotalSeconds / 60.00);
            //                            decimal LossDuration = (decimal)(Convert.ToDateTime(GetEndModeDuration.EndTime).Subtract(Convert.ToDateTime(ProdStartTime)).TotalSeconds / 60.00);
            //                            if (GetEndModeDuration.LossCodeID != null)
            //                                insertProdlosses(ProdRow.HMIID, (int)GetEndModeDuration.LossCodeID, LossDuration, CorrectedDate, MachineID);
            //                            //insertProdlosses(WOID, LossID, LossDuration, CorrectedDate);
            //                        }
            //                        else if (GetEndModeDuration.ModeType == "MNT")
            //                        {
            //                            MntTime += (decimal)(Convert.ToDateTime(GetEndModeDuration.EndTime).Subtract(Convert.ToDateTime(ProdStartTime)).TotalSeconds / 60.00);
            //                        }
            //                        else if (GetEndModeDuration.ModeType == "POWEROFF")
            //                        {
            //                            PowerOffTime += (decimal)(Convert.ToDateTime(GetEndModeDuration.EndTime).Subtract(Convert.ToDateTime(ProdStartTime)).TotalSeconds / 60.00);
            //                        }
            //                    }
            //                    #endregion

            //                    #region Logic to get the Mode Duration Which Was Started during the Production and Ended after the Production
            //                    var GetStartModeDuration = Serverdb.UnitworkccsTbllivemode.Where(m => m.MachineID == MachineID && m.StartTime >= ProdStartTime && m.EndTime >= ProdStartTime && m.StartTime < ProdEndtime && m.EndTime > ProdEndtime && m.IsCompleted == 1 && m.ModeTypeEnd == 1).FirstOrDefault();
            //                    if (GetStartModeDuration != null)
            //                    {
            //                        if (GetStartModeDuration.ModeType == "PROD")
            //                        {
            //                            OperatingTime += (decimal)(Convert.ToDateTime(ProdEndtime).Subtract(Convert.ToDateTime(GetStartModeDuration.StartTime)).TotalSeconds / 60.00);
            //                        }
            //                        else if (GetStartModeDuration.ModeType == "IDLE")
            //                        {
            //                            LossTime += (decimal)(Convert.ToDateTime(ProdEndtime).Subtract(Convert.ToDateTime(GetStartModeDuration.StartTime)).TotalSeconds / 60.00);
            //                            decimal LossDuration = (decimal)(Convert.ToDateTime(ProdEndtime).Subtract(Convert.ToDateTime(GetStartModeDuration.StartTime)).TotalSeconds / 60.00);
            //                            if (GetStartModeDuration.LossCodeID != null)
            //                                insertProdlosses(ProdRow.HMIID, (int)GetStartModeDuration.LossCodeID, LossDuration, CorrectedDate, MachineID);
            //                            //insertProdlosses(WOID, LossID, LossDuration, CorrectedDate);
            //                        }
            //                        else if (GetStartModeDuration.ModeType == "MNT")
            //                        {
            //                            MntTime += (decimal)(Convert.ToDateTime(ProdEndtime).Subtract(Convert.ToDateTime(GetStartModeDuration.StartTime)).TotalSeconds / 60.00);
            //                        }
            //                        else if (GetStartModeDuration.ModeType == "POWEROFF")
            //                        {
            //                            PowerOffTime += (decimal)(Convert.ToDateTime(ProdEndtime).Subtract(Convert.ToDateTime(GetStartModeDuration.StartTime)).TotalSeconds / 60.00);
            //                        }
            //                    }
            //                    #endregion

            //                    int TotlaQty = ProdRow.Total_Qty;
            //                    if (TotlaQty == 0)
            //                        TotlaQty = 1;
            //                    decimal GetOptime = OperatingTime;
            //                    if (GetOptime == 0)
            //                    {
            //                        GetOptime = 1;
            //                    }
            //                    decimal IdealCycleTimeVal = 0;
            //                    var IdealCycTime = Serverdb.tblparts.Where(m => m.FGCode == ProdRow.FGCode && m.OperationNo == ProdRow.OperationNo).FirstOrDefault();
            //                    if (IdealCycTime != null)
            //                        IdealCycleTimeVal = IdealCycTime.IdealCycleTime;
            //                    double TotalTime = ProdEndtime.Subtract(ProdStartTime).TotalMinutes;
            //                    decimal UtilPercent = (decimal)Math.Round((double)OperatingTime / TotalTime * 100, 2);
            //                    decimal Quality = (decimal)Math.Round((double)ProdRow.Yield_Qty / TotlaQty * 100, 2);
            //                    decimal Performance = (decimal)Math.Round((double)IdealCycleTimeVal * (double)ProdRow.Total_Qty / (double)GetOptime * 100, 2);
            //                    int PerformanceFactor = (int)IdealCycleTimeVal * ProdRow.Total_Qty;
            //                    tbl_ProdManMachine PRA = new tbl_ProdManMachine();
            //                    PRA.MachineID = MachineID;
            //                    PRA.WOID = ProdRow.HMIID;
            //                    PRA.CorrectedDate = CorrectedDate.Date;
            //                    PRA.TotalLoss = LossTime;
            //                    PRA.TotalOperatingTime = Math.Round(OperatingTime, 2);
            //                    PRA.TotalSetup = Math.Round(SetupTime + SetupMinorTime, 2);
            //                    PRA.TotalMinorLoss = Math.Round(MinorLossTime - SetupMinorTime, 2);
            //                    PRA.TotalSetupMinorLoss = Math.Round(SetupMinorTime, 2);
            //                    PRA.TotalPowerLoss = Math.Round(PowerOffTime, 2);
            //                    PRA.UtilPercent = Math.Round(UtilPercent, 2);
            //                    PRA.QualityPercent = Math.Round(Quality, 2);
            //                    PRA.PerformancePerCent = Math.Round(Performance, 2);
            //                    PRA.PerfromaceFactor = PerformanceFactor;
            //                    PRA.InsertedOn = DateTime.Now;
            //                    Serverdb.tbl_ProdManMachine.Add(PRA);
            //                    Serverdb.SaveChanges();
            //                }
            //            }
            //        }
            //        else
            //        {
            //            var prodman = Serverdb.tbl_ProdManMachine.Where(m => m.CorrectedDate == CorrectedDate && m.MachineID == MachineID).ToList();
            //            if (prodman.Count == 0)
            //            {
            //                var GetModeDurations = Serverdb.UnitworkccsTbllivemode.Where(m => m.MachineID == MachineID && m.CorrectedDate == CorrectedDate && m.IsCompleted == 1 && m.ModeTypeEnd == 1).ToList();
            //                foreach (var ModeRow in GetModeDurations)
            //                {
            //                    if (ModeRow.ModeType == "PROD")
            //                    {
            //                        OperatingTime += (decimal)(ModeRow.DurationInSec / 60.00);
            //                    }
            //                    else if (ModeRow.ModeType == "IDLE" && ModeRow.DurationInSec > 600)
            //                    {
            //                        LossTime += (decimal)(ModeRow.DurationInSec / 60.00);
            //                        decimal LossDuration = (decimal)(ModeRow.DurationInSec / 60.00);
            //                        //if (ModeRow.LossCodeID != null)
            //                        //    insertProdlosses(ProdRow.HMIID, (int)ModeRow.LossCodeID, LossDuration, CorrectedDate, MachineID);
            //                    }
            //                    else if (ModeRow.ModeType == "IDLE" && ModeRow.DurationInSec < 600)
            //                    {
            //                        MinorLossTime += (decimal)(ModeRow.DurationInSec / 60.00);
            //                    }
            //                    else if (ModeRow.ModeType == "MNT")
            //                    {
            //                        MntTime += (decimal)(ModeRow.DurationInSec / 60.00);
            //                    }
            //                    else if (ModeRow.ModeType == "POWEROFF")
            //                    {
            //                        PowerOffTime += (decimal)(ModeRow.DurationInSec / 60.00);
            //                    }
            //                    else if (ModeRow.ModeType == "SETUP")
            //                    {
            //                        try
            //                        {
            //                            SetupTime += (decimal)Convert.ToDateTime(ModeRow.LossCodeEnteredTime).Subtract(Convert.ToDateTime(ModeRow.StartTime)).TotalMinutes;
            //                            SetupMinorTime += (decimal)(Serverdb.UnitworkccsTblsetupmaints.Where(m => m.ModeID == ModeRow.ModeID).Select(m => m.MinorLossTime).First() / 60.00);
            //                        }
            //                        catch { }
            //                    }
            //                }

            //                //#region Logic to get the Mode Duration Which Was started before this Production and Ended during this Production
            //                //var GetEndModeDuration = Serverdb.UnitworkccsTbllivemode.Where(m => m.MachineID == MachineID && m.CorrectedDate == CorrectedDate && m.IsCompleted == 1 && m.ModeTypeEnd == 1).FirstOrDefault();
            //                //if (GetEndModeDuration != null)
            //                //{
            //                //    if (GetEndModeDuration.ModeType == "PROD")
            //                //    {
            //                //        OperatingTime += (decimal)(ModeRow.DurationInSec / 60.00);
            //                //        // OperatingTime += (decimal)(Convert.ToDateTime(GetEndModeDuration.EndTime).Subtract(Convert.ToDateTime(ProdStartTime)).TotalSeconds / 60.00);
            //                //    }
            //                //    else if (GetEndModeDuration.ModeType == "IDLE")
            //                //    {
            //                //        LossTime += (decimal)(Convert.ToDateTime(GetEndModeDuration.EndTime).Subtract(Convert.ToDateTime(ProdStartTime)).TotalSeconds / 60.00);
            //                //        decimal LossDuration = (decimal)(Convert.ToDateTime(GetEndModeDuration.EndTime).Subtract(Convert.ToDateTime(ProdStartTime)).TotalSeconds / 60.00);
            //                //        if (GetEndModeDuration.LossCodeID != null)
            //                //            insertProdlosses(ProdRow.HMIID, (int)GetEndModeDuration.LossCodeID, LossDuration, CorrectedDate, MachineID);
            //                //        //insertProdlosses(WOID, LossID, LossDuration, CorrectedDate);
            //                //    }
            //                //    else if (GetEndModeDuration.ModeType == "MNT")
            //                //    {
            //                //        MntTime += (decimal)(Convert.ToDateTime(GetEndModeDuration.EndTime).Subtract(Convert.ToDateTime(ProdStartTime)).TotalSeconds / 60.00);
            //                //    }
            //                //    else if (GetEndModeDuration.ModeType == "POWEROFF")
            //                //    {
            //                //        PowerOffTime += (decimal)(Convert.ToDateTime(GetEndModeDuration.EndTime).Subtract(Convert.ToDateTime(ProdStartTime)).TotalSeconds / 60.00);
            //                //    }
            //                //}
            //                //#endregion

            //                //#region Logic to get the Mode Duration Which Was Started during the Production and Ended after the Production
            //                //var GetStartModeDuration = Serverdb.UnitworkccsTbllivemode.Where(m => m.MachineID == MachineID && m.StartTime >= ProdStartTime && m.EndTime >= ProdStartTime && m.StartTime < ProdEndtime && m.EndTime > ProdEndtime && m.IsCompleted == 1 && m.ModeTypeEnd == 1).FirstOrDefault();
            //                //if (GetStartModeDuration != null)
            //                //{
            //                //    if (GetStartModeDuration.ModeType == "PROD")
            //                //    {
            //                //        OperatingTime += (decimal)(Convert.ToDateTime(ProdEndtime).Subtract(Convert.ToDateTime(GetStartModeDuration.StartTime)).TotalSeconds / 60.00);
            //                //    }
            //                //    else if (GetStartModeDuration.ModeType == "IDLE")
            //                //    {
            //                //        LossTime += (decimal)(Convert.ToDateTime(ProdEndtime).Subtract(Convert.ToDateTime(GetStartModeDuration.StartTime)).TotalSeconds / 60.00);
            //                //        decimal LossDuration = (decimal)(Convert.ToDateTime(ProdEndtime).Subtract(Convert.ToDateTime(GetStartModeDuration.StartTime)).TotalSeconds / 60.00);
            //                //        if (GetStartModeDuration.LossCodeID != null)
            //                //            insertProdlosses(ProdRow.HMIID, (int)GetStartModeDuration.LossCodeID, LossDuration, CorrectedDate, MachineID);
            //                //        //insertProdlosses(WOID, LossID, LossDuration, CorrectedDate);
            //                //    }
            //                //    else if (GetStartModeDuration.ModeType == "MNT")
            //                //    {
            //                //        MntTime += (decimal)(Convert.ToDateTime(ProdEndtime).Subtract(Convert.ToDateTime(GetStartModeDuration.StartTime)).TotalSeconds / 60.00);
            //                //    }
            //                //    else if (GetStartModeDuration.ModeType == "POWEROFF")
            //                //    {
            //                //        PowerOffTime += (decimal)(Convert.ToDateTime(ProdEndtime).Subtract(Convert.ToDateTime(GetStartModeDuration.StartTime)).TotalSeconds / 60.00);
            //                //    }
            //                //}
            //                //#endregion
            //                int partscount = 0;
            //                var partcount = Serverdb.tblpartscountandcuttings.Where(m => m.MachineID == MachineID && m.CorrectedDate == CorrectedDate).ToList();
            //                if (partcount != null)
            //                {
            //                    foreach (var partcountdet in partcount)
            //                    {
            //                        partscount = partscount + partcountdet.PartCount;
            //                    }
            //                    double Total_Qty = partscount;
            //                    int TotlaQty = (int)Total_Qty;
            //                    if (TotlaQty == 0)
            //                        TotlaQty = 1;
            //                    decimal GetOptime = OperatingTime;
            //                    if (GetOptime == 0)
            //                    {
            //                        GetOptime = 1;
            //                    }
            //                    decimal IdealCycleTimeVal = 60;
            //                    double TotalTime = 24;
            //                    //double TotalTime = ProdEndtime.Subtract(ProdStartTime).TotalMinutes;
            //                    decimal UtilPercent = (decimal)Math.Round((double)OperatingTime / TotalTime * 100, 2) / 100;
            //                    //decimal Quality = (decimal)Math.Round((double)ProdRow.Yield_Qty / TotlaQty * 100, 2);
            //                    decimal Quality = 100;
            //                    decimal Performance = (decimal)Math.Round((double)IdealCycleTimeVal * Total_Qty / (double)GetOptime * 100, 2)/100;
            //                    int PerformanceFactor = (int)IdealCycleTimeVal * (int)Total_Qty;
            //                    tbl_ProdManMachine PRA = new tbl_ProdManMachine();
            //                    PRA.MachineID = MachineID;
            //                    //PRA.WOID = ProdRow.HMIID;
            //                    PRA.WOID = 8;
            //                    PRA.CorrectedDate = CorrectedDate.Date;
            //                    PRA.TotalLoss = LossTime;
            //                    PRA.TotalOperatingTime = OperatingTime;
            //                    PRA.TotalSetup = Math.Round(SetupTime + SetupMinorTime, 2);
            //                    PRA.TotalSetup = Math.Round(SetupTime + SetupMinorTime, 2);
            //                    PRA.TotalMinorLoss = Math.Round(MinorLossTime - SetupMinorTime, 2);
            //                    PRA.TotalSetupMinorLoss = Math.Round(SetupMinorTime, 2);
            //                    PRA.TotalPowerLoss = Math.Round(PowerOffTime, 2);
            //                    PRA.UtilPercent = Math.Round(UtilPercent, 2);
            //                    PRA.QualityPercent = Math.Round(Quality, 2);
            //                    PRA.PerformancePerCent = Math.Round(Performance, 2);
            //                    PRA.PerfromaceFactor = PerformanceFactor;
            //                    PRA.InsertedOn = DateTime.Now;
            //                    Serverdb.tbl_ProdManMachine.Add(PRA);
            //                    Serverdb.SaveChanges();
            //                }
            //                else { }
            //            }
            //            else { }
            //        }

            //    }

            //    catch (Exception e)
            //    {
            //    }
            //}
            #endregion

            // Get Production Data for Man Machine Ticket.
            public void insertManMacProd(int MachineID, DateTime CorrectedDate)
            {
                decimal OperatingTime = 0;
                decimal LossTime = 0;
                decimal MinorLossTime = 0;
                decimal MntTime = 0;
                decimal SetupTime = 0;
                decimal SetupMinorTime = 0;
                decimal PowerOffTime = 0;
                double NetAvailableTime = 0;
                double AvailabilityPercentage = 0;
                double PerformancePercentage = 0;
                double Quality = 0;
                decimal ActualQty = 0;
                decimal plannedCycleTime = 0;
                decimal OkQty = 0;
                int rejQty = 0;
                int reworkQty = 0;
                int trial = 0;
                double TotalAvailableTime = 0;
                decimal plannedCycleTimeInMin = 0;
                double totalDowntime = 0;
                string correctedDate = CorrectedDate.ToString("yyyy-MM-dd");

                string shift = GetCurrentShift();
                try
                {
                    var getProdList = Serverdb.UnitworkccsTblfgpartnodet.Where(m => m.MachineId == MachineID && m.CorrectedDate == correctedDate && m.IsClosed == 1).OrderBy(m => m.StartDate).ToList();
                    if (getProdList.Count != 0)
                    {
                        foreach (var ProdRow in getProdList)
                        {
                            var GetEntry = Serverdb.UnitworkccsTblProdmanmachine.Where(m => m.Woid == ProdRow.FgPartId).FirstOrDefault();
                            if (GetEntry == null)
                            {
                                DateTime ProdStartTime = (DateTime)ProdRow.StartDate;
                                DateTime ProdEndtime = DateTime.Now;
                                try
                                {
                                    if (ProdRow.ClosedDate.HasValue)
                                    {
                                        ProdEndtime = Convert.ToDateTime(ProdRow.ClosedDate);
                                    }
                                }
                                catch { }



                                #region Logic to get the Mode Durations between a Production Order which are completed
                                var GetModeDurations = Serverdb.UnitworkccsTbllivemode.Where(m => m.MachineId == MachineID && m.StartTime >= ProdStartTime && m.StartTime < ProdEndtime && m.EndTime > ProdStartTime && m.EndTime <= ProdEndtime && m.IsCompleted == 1 && m.ModeTypeEnd == 1).ToList();
                                foreach (var ModeRow in GetModeDurations)
                                {
                                    if (ModeRow.ModeType == "PROD")
                                    {
                                        OperatingTime += (decimal)(ModeRow.DurationInSec / 60.00);
                                    }
                                    else if (ModeRow.ModeType == "IDLE" && ModeRow.DurationInSec > 600)
                                    {
                                        LossTime += (decimal)(ModeRow.DurationInSec / 60.00);
                                        decimal LossDuration = (decimal)(ModeRow.DurationInSec / 60.00);
                                        if (ModeRow.LossCodeId != null)
                                            insertProdlosses(ProdRow.FgPartId, (int)ModeRow.LossCodeId, LossDuration, CorrectedDate, MachineID);
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
                                            SetupMinorTime += (decimal)(Serverdb.UnitworkccsTblsetupmaint.Where(m => m.ModeId == ModeRow.ModeId).Select(m => m.MinorLossTime).First() / 60.00);
                                        }
                                        catch { }
                                    }
                                }
                                #endregion

                                #region Logic to get the Mode Duration Which Was started before this Production and Ended during this Production
                                var GetEndModeDuration = Serverdb.UnitworkccsTbllivemode.Where(m => m.MachineId == MachineID && m.StartTime < ProdStartTime && m.EndTime > ProdStartTime && m.EndTime <= ProdEndtime && m.IsCompleted == 1 && m.ModeTypeEnd == 1).FirstOrDefault();
                                if (GetEndModeDuration != null)
                                {
                                    if (GetEndModeDuration.ModeType == "PROD")
                                    {
                                        OperatingTime += (decimal)(Convert.ToDateTime(GetEndModeDuration.EndTime).Subtract(Convert.ToDateTime(ProdStartTime)).TotalSeconds / 60.00);
                                    }
                                    else if (GetEndModeDuration.ModeType == "IDLE")
                                    {
                                        LossTime += (decimal)(Convert.ToDateTime(GetEndModeDuration.EndTime).Subtract(Convert.ToDateTime(ProdStartTime)).TotalSeconds / 60.00);
                                        decimal LossDuration = (decimal)(Convert.ToDateTime(GetEndModeDuration.EndTime).Subtract(Convert.ToDateTime(ProdStartTime)).TotalSeconds / 60.00);
                                        if (GetEndModeDuration.LossCodeId != null)
                                            insertProdlosses(ProdRow.FgPartId, (int)GetEndModeDuration.LossCodeId, LossDuration, CorrectedDate, MachineID);
                                        //insertProdlosses(WOID, LossID, LossDuration, CorrectedDate);
                                    }
                                    else if (GetEndModeDuration.ModeType == "MNT")
                                    {
                                        MntTime += (decimal)(Convert.ToDateTime(GetEndModeDuration.EndTime).Subtract(Convert.ToDateTime(ProdStartTime)).TotalSeconds / 60.00);
                                    }
                                    else if (GetEndModeDuration.ModeType == "POWEROFF")
                                    {
                                        PowerOffTime += (decimal)(Convert.ToDateTime(GetEndModeDuration.EndTime).Subtract(Convert.ToDateTime(ProdStartTime)).TotalSeconds / 60.00);
                                    }
                                }
                                #endregion

                                #region Logic to get the Mode Duration Which Was Started during the Production and Ended after the Production
                                var GetStartModeDuration = Serverdb.UnitworkccsTbllivemode.Where(m => m.MachineId == MachineID && m.StartTime >= ProdStartTime && m.EndTime >= ProdStartTime && m.StartTime < ProdEndtime && m.EndTime > ProdEndtime && m.IsCompleted == 1 && m.ModeTypeEnd == 1).FirstOrDefault();
                                if (GetStartModeDuration != null)
                                {
                                    if (GetStartModeDuration.ModeType == "PROD")
                                    {
                                        OperatingTime += (decimal)(Convert.ToDateTime(ProdEndtime).Subtract(Convert.ToDateTime(GetStartModeDuration.StartTime)).TotalSeconds / 60.00);
                                    }
                                    else if (GetStartModeDuration.ModeType == "IDLE")
                                    {
                                        LossTime += (decimal)(Convert.ToDateTime(ProdEndtime).Subtract(Convert.ToDateTime(GetStartModeDuration.StartTime)).TotalSeconds / 60.00);
                                        decimal LossDuration = (decimal)(Convert.ToDateTime(ProdEndtime).Subtract(Convert.ToDateTime(GetStartModeDuration.StartTime)).TotalSeconds / 60.00);
                                        if (GetStartModeDuration.LossCodeId != null)
                                            insertProdlosses(ProdRow.FgPartId, (int)GetStartModeDuration.LossCodeId, LossDuration, CorrectedDate, MachineID);
                                        //insertProdlosses(WOID, LossID, LossDuration, CorrectedDate);
                                    }
                                    else if (GetStartModeDuration.ModeType == "MNT")
                                    {
                                        MntTime += (decimal)(Convert.ToDateTime(ProdEndtime).Subtract(Convert.ToDateTime(GetStartModeDuration.StartTime)).TotalSeconds / 60.00);
                                    }
                                    else if (GetStartModeDuration.ModeType == "POWEROFF")
                                    {
                                        PowerOffTime += (decimal)(Convert.ToDateTime(ProdEndtime).Subtract(Convert.ToDateTime(GetStartModeDuration.StartTime)).TotalSeconds / 60.00);
                                    }
                                }
                                #endregion

                                int TotlaQty = (int)ProdRow.TargetQty;
                                if (TotlaQty == 0)
                                    TotlaQty = 1;
                                decimal GetOptime = OperatingTime;
                                if (GetOptime == 0)
                                {
                                    GetOptime = 1;
                                }

                                //#region Performance

                                //using (unitworksccsEntities db1 = new unitworksccsEntities())
                                //{
                                //    DateTime currentDate = DateTime.Now;
                                //    var shiftStartTime = db1.tblshift_mstr.Where(m => m.ShiftName == shift).Select(m => m.StartTime).FirstOrDefault();
                                //    var shiftStartDateTime = correctedDate + " " + shiftStartTime;
                                //    DateTime shiftDateTime = Convert.ToDateTime(shiftStartDateTime);

                                //    TotalAvailableTime = (currentDate - shiftDateTime).TotalMinutes;
                                //    //TotalAvailableTime = (currentDate - shiftDateTime).TotalMinutes;
                                //    //var plannedbrks = db.Tblplannedbreak.Where(m => m.IsDeleted == 0).ToList();

                                //    //foreach (var row in plannedbrks)
                                //    //{
                                //    //    plannedBrkDurationinMin += Convert.ToDateTime(correctedDate + " " + row.EndTime).Subtract(Convert.ToDateTime(correctedDate + " " + row.StartTime)).TotalMinutes;
                                //    //}

                                //    var checkTicket = db1.tblRaisedTickets.Where(m => m.machineId == MachineID && (m.status == 1 || m.status == 2 || m.status == 3) && m.ticketOpenDate != null && m.ticketClosedDate == null && m.ticketNo.Contains("Downtime-Stopped-BDS")).OrderByDescending(m => m.ticketId).FirstOrDefault();

                                //    if (checkTicket != null)
                                //    {
                                //        DateTime ticketCloseDate = DateTime.Now;
                                //        DateTime ticketOpenDate = Convert.ToDateTime(checkTicket.ticketOpenDate);

                                //        totalDowntime = (ticketCloseDate - ticketOpenDate).TotalMinutes;
                                //    }
                                //    else
                                //    {
                                //        var checkTicketTime = db1.tblRaisedTickets.Where(m => m.machineId == MachineID && m.status == 4 && m.ticketOpenDate != null && m.ticketClosedDate != null && m.ticketNo.Contains("Downtime-Stopped-BDS")).OrderByDescending(m => m.ticketId).FirstOrDefault();

                                //        if (checkTicketTime != null)
                                //        {
                                //            DateTime ticketCloseDate = Convert.ToDateTime(checkTicketTime.ticketClosedDate);
                                //            DateTime ticketOpenDate = Convert.ToDateTime(checkTicketTime.ticketOpenDate);

                                //            totalDowntime = (ticketCloseDate - ticketOpenDate).TotalMinutes;

                                //        }
                                //    }

                                //    NetAvailableTime = TotalAvailableTime - totalDowntime;
                                //    //var parametermasterlistLast = db1.parameters_master.Where(m => m.MachineID == MachineID && m.CorrectedDate == CorrectedDate).ToList();

                                //    //var TopRowLast = parametermasterlistLast.OrderByDescending(m => m.ParameterID).FirstOrDefault();
                                //    //var RowLast = parametermasterlistLast.OrderBy(m => m.ParameterID).FirstOrDefault();

                                //    //if (TopRowLast != null && RowLast != null)
                                //    //{
                                //    //    ActualQty = Convert.ToInt32(TopRowLast.PartsTotal - RowLast.PartsTotal);
                                //    //}
                                //    var parametermasterlistLast = Serverdb.tblpartscountandcuttings.Where(m => m.CorrectedDate == CorrectedDate && m.MachineID == MachineID).ToList().Sum(m => m.OkQty);

                                //    ActualQty = parametermasterlistLast;


                                //}


                                ////ActualQty = ActualQty * Convert.ToInt32(ProdRow.noOfPartsPerCycle);

                                //var partsDet = Serverdb.tblPlanLinkageMasters.Where(m => m.isDeleted == 0 && m.planLinkageId == ProdRow.planLinkageId && m.operation == ProdRow.operationNo).FirstOrDefault();
                                //if (partsDet != null)
                                //{
                                //    if (partsDet.unit == "Minutes")
                                //    {
                                //        plannedCycleTime = Convert.ToDecimal(partsDet.idealCycleTime);
                                //        plannedCycleTimeInMin = Math.Round((60 / plannedCycleTime), 2);
                                //    }
                                //    else if (partsDet.unit == "Seconds")
                                //    {
                                //        plannedCycleTime = Convert.ToDecimal(partsDet.idealCycleTime);
                                //        plannedCycleTimeInMin = Math.Round((3600 / plannedCycleTime), 2);
                                //    }
                                //}


                                //trial = GetTrialCount(MachineID, correctedDate);


                                //decimal performanceNumerator = ((ActualQty - trial) * plannedCycleTimeInMin);

                                //double performanceDenominator = NetAvailableTime;

                                //#endregion

                                //#region Quality

                                //rejQty = GetRejectionDetails(MachineID, correctedDate);
                                //reworkQty = GetReworkDetails(MachineID, correctedDate);

                                //OkQty = ActualQty - rejQty - reworkQty - trial;

                                //decimal qualityDenominator = OkQty + rejQty + reworkQty;

                                //if (OkQty < 0)
                                //{
                                //    OkQty = 0;
                                //}

                                //#endregion

                                //if (NetAvailableTime == 0)
                                //{
                                //    AvailabilityPercentage = 0;
                                //}
                                //else
                                //{
                                //    //AvailabilityPercentage = Math.Round(((double)OperatingTime / NetAvailableTime), 2) * 100;
                                //    AvailabilityPercentage = Math.Round(((double)NetAvailableTime / TotalAvailableTime), 2) * 100;
                                //}

                                //if (AvailabilityPercentage >= 100)
                                //{
                                //    AvailabilityPercentage = 100;
                                //}

                                //if (performanceNumerator == 0)
                                //{
                                //    PerformancePercentage = 0;
                                //}
                                //else
                                //{
                                //    PerformancePercentage = Math.Round(((double)performanceNumerator / (double)performanceDenominator), 2) * 100;
                                //}

                                //if (qualityDenominator == 0)
                                //{
                                //    Quality = 0;
                                //}
                                //else
                                //{
                                //    Quality = Math.Round(((double)OkQty / (double)qualityDenominator), 2) * 100;
                                //}

                                double TotalTime = ProdEndtime.Subtract(ProdStartTime).TotalMinutes;
                                decimal UtilPercent = /*(decimal)Math.Round((double)OperatingTime / TotalTime * 100, 2);*/Convert.ToDecimal(AvailabilityPercentage);
                                decimal Performance = Convert.ToDecimal(PerformancePercentage);
                                int PerformanceFactor = (int)plannedCycleTime * (int)ProdRow.TargetQty;
                                UnitworkccsTblProdmanmachine PRA = new UnitworkccsTblProdmanmachine();
                                PRA.MachineId = MachineID;
                                PRA.Woid = ProdRow.FgPartId;
                                PRA.CorrectedDate = CorrectedDate.Date;
                                PRA.TotalLoss = LossTime;
                                PRA.TotalOperatingTime = Math.Round(OperatingTime, 2);
                                PRA.TotalSetup = Math.Round(SetupTime + SetupMinorTime, 2);
                                PRA.TotalMinorLoss = Math.Round(MinorLossTime - SetupMinorTime, 2);
                                PRA.TotalSetupMinorLoss = Math.Round(SetupMinorTime, 2);
                                PRA.TotalPowerLoss = Math.Round(PowerOffTime, 2);
                                PRA.UtilPercent = Math.Round(UtilPercent, 2);
                                PRA.QualityPercent = Convert.ToDecimal(Math.Round(Quality, 2));
                                PRA.PerformancePerCent = Math.Round(Performance, 2);
                                PRA.PerfromaceFactor = PerformanceFactor;
                                PRA.InsertedOn = DateTime.Now;
                                Serverdb.UnitworkccsTblProdmanmachine.Add(PRA);
                                Serverdb.SaveChanges();
                            }
                        }
                    }
                    else
                    {
                        var prodman = Serverdb.UnitworkccsTblProdmanmachine.Where(m => m.CorrectedDate == CorrectedDate && m.MachineId == MachineID).ToList();
                        if (prodman.Count == 0)
                        {
                            var GetModeDurations = Serverdb.UnitworkccsTbllivemode.Where(m => m.MachineId == MachineID && m.CorrectedDate == CorrectedDate && m.IsCompleted == 1 && m.ModeTypeEnd == 1).ToList();
                            foreach (var ModeRow in GetModeDurations)
                            {
                                if (ModeRow.ModeType == "PROD")
                                {
                                    OperatingTime += (decimal)(ModeRow.DurationInSec / 60.00);
                                }
                                else if (ModeRow.ModeType == "IDLE" && ModeRow.DurationInSec > 600)
                                {
                                    LossTime += (decimal)(ModeRow.DurationInSec / 60.00);
                                    decimal LossDuration = (decimal)(ModeRow.DurationInSec / 60.00);
                                    //if (ModeRow.LossCodeID != null)
                                    //    insertProdlosses(ProdRow.HMIID, (int)ModeRow.LossCodeID, LossDuration, CorrectedDate, MachineID);
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
                                        SetupMinorTime += (decimal)(Serverdb.UnitworkccsTblsetupmaint.Where(m => m.ModeId == ModeRow.ModeId).Select(m => m.MinorLossTime).First() / 60.00);
                                    }
                                    catch { }
                                }
                            }


                            int partscount = 0;


                            //var partcount = Serverdb.tblpartscountandcuttings.Where(m => m.MachineID == MachineID && m.CorrectedDate == CorrectedDate).ToList();
                            //if (partcount != null)
                            //{
                            //    foreach (var partcountdet in partcount)
                            //    {
                            //        partscount = partscount + partcountdet.PartCount;
                            //    }
                            //    double Total_Qty = partscount;
                            //    int TotlaQty = (int)Total_Qty;
                            //    if (TotlaQty == 0)
                            //        TotlaQty = 1;
                            //    decimal GetOptime = OperatingTime;
                            //    if (GetOptime == 0)
                            //    {
                            //        GetOptime = 1;
                            //    }
                            //    decimal IdealCycleTimeVal = 60;
                            //    double TotalTime = 24;
                            //    //double TotalTime = ProdEndtime.Subtract(ProdStartTime).TotalMinutes;
                            //    decimal UtilPercent = (decimal)Math.Round((double)OperatingTime / TotalTime * 100, 2) / 100;
                            //    //decimal Quality = (decimal)Math.Round((double)ProdRow.Yield_Qty / TotlaQty * 100, 2);
                            //    Quality = 100;
                            //    decimal Performance = (decimal)Math.Round((double)IdealCycleTimeVal * Total_Qty / (double)GetOptime * 100, 2) / 100;
                            //    int PerformanceFactor = (int)IdealCycleTimeVal * (int)Total_Qty;
                            //    UnitworkccsTblProdmanmachine PRA = new UnitworkccsTblProdmanmachine();
                            //    PRA.MachineId = MachineID;
                            //    //PRA.WOID = ProdRow;
                            //    PRA.Woid = 8;
                            //    PRA.CorrectedDate = CorrectedDate.Date;
                            //    PRA.TotalLoss = LossTime;
                            //    PRA.TotalOperatingTime = OperatingTime;
                            //    PRA.TotalSetup = Math.Round(SetupTime + SetupMinorTime, 2);
                            //    PRA.TotalSetup = Math.Round(SetupTime + SetupMinorTime, 2);
                            //    PRA.TotalMinorLoss = Math.Round(MinorLossTime - SetupMinorTime, 2);
                            //    PRA.TotalSetupMinorLoss = Math.Round(SetupMinorTime, 2);
                            //    PRA.TotalPowerLoss = Math.Round(PowerOffTime, 2);
                            //    PRA.UtilPercent = Math.Round(UtilPercent, 2);
                            //    PRA.QualityPercent = Convert.ToDecimal(Math.Round(Quality, 2));
                            //    PRA.PerformancePerCent = Math.Round(Performance, 2);
                            //    PRA.PerfromaceFactor = PerformanceFactor;
                            //    PRA.InsertedOn = DateTime.Now;
                            //    Serverdb.UnitworkccsTblProdmanmachine.Add(PRA);
                            //    Serverdb.SaveChanges();
                            //}
                            //else { }
                        }
                        else { }
                    }
                }

                catch (Exception e)
                {
                }
            }

            public string GetCurrentShift()
            {
                string shift = "";
                #region Get Shift
                DateTime Time = DateTime.Now;
                TimeSpan Tm = new TimeSpan(Time.Hour, Time.Minute, Time.Second);

                string correctedDate = DateTime.Now.ToString("yyyy-MM-dd");
                List<ShiftList> UnitworkccsTblshiftMstr = ShiftList1(correctedDate);

                var shiftDetaild = UnitworkccsTblshiftMstr.Where(m => m.shiftStartDateTime <= Time && m.shiftEndDateTime >= Time).FirstOrDefault();
                var shiftDetails = Serverdb.UnitworkccsTblshiftMstr.Where(m => m.ShiftId == shiftDetaild.shfitId).FirstOrDefault();

                if (shiftDetails != null)
                {
                    shift = shiftDetails.ShiftName;
                }

                #endregion
                return shift;
            }

            public int GetRejectionDetails(int machineId, string correctedDate, string shift)
            {
                int qty = 0;
                var dbCheck = Serverdb.UnitworkccsTblrejectiondetails.Where(m => m.CorrectedDate == correctedDate && m.MachineId == machineId && m.Shift == shift).Select(m => m.DefectQty).Sum();
                if (dbCheck != null)
                {
                    qty = Convert.ToInt32(dbCheck);
                }
                return qty;
            }

            public int GetReworkDetails(int machineId, string correctedDate, string shift)
            {
                int qty = 0;
                var dbCheck = Serverdb.UnitworkccsTblreworkdetails.Where(m => m.CorrectedDate == correctedDate && m.MachineId == machineId && m.Shift == shift).Select(m => m.DefectQty).Sum();
                if (dbCheck != null)
                {
                    qty = Convert.ToInt32(dbCheck);
                }
                return qty;
            }

            public int GetTrialCount(int machineId, string correctedDate, string shift)
            {
                int Actual1 = 0;
                var dbCheck = Serverdb.UnitworkccsTbltrialpartcount.Where(m => m.MachineId == machineId && m.CorrectedDate == correctedDate && m.Shift == shift).Sum(m => m.TrialPartCount);
                if (dbCheck != null)
                {
                    Actual1 = dbCheck.Value;
                }
                return Actual1;
            }

            public int? GetDryRunCount(int machineId, string correctedDate, string shift)
            {

                int? Actual = 0;
                int? dryRun = Serverdb.UnitworkccsTbldryrun.Where(m => m.MachineId == machineId && m.CorrectedDate == correctedDate && m.Shift == shift).Sum(m => m.PartCount);
                if (dryRun != null)
                {
                    Actual = dryRun;
                }
                return Actual;
            }



            public int GetRejectionDetails2(int machineId, string correctedDate, int opeatorId, string shift)
            {
                int qty = 0;
                var dbCheck = Serverdb.UnitworkccsTblrejectiondetails.Where(m => m.CorrectedDate == correctedDate && m.MachineId == machineId && m.OperatorId == opeatorId && m.Shift == shift).Select(m => m.DefectQty).Sum();
                if (dbCheck != null)
                {
                    qty = Convert.ToInt32(dbCheck);
                }
                return qty;
            }

            public int GetReworkDetails2(int machineId, string correctedDate, int opeatorId, string shift)
            {
                int qty = 0;
                var dbCheck = Serverdb.UnitworkccsTblreworkdetails.Where(m => m.CorrectedDate == correctedDate && m.MachineId == machineId && m.OperatorId == opeatorId && m.Shift == shift).Select(m => m.DefectQty).Sum();
                if (dbCheck != null)
                {
                    qty = Convert.ToInt32(dbCheck);
                }
                return qty;
            }

            public int GetTrialCount2(int machineId, string correctedDate, int opeatorId, string shift)
            {
                int Actual1 = 0;
                var dbCheck = Serverdb.UnitworkccsTbltrialpartcount.Where(m => m.MachineId == machineId && m.CorrectedDate == correctedDate && m.Shift == shift).Sum(m => m.TrialPartCount);
                if (dbCheck != null)
                {
                    Actual1 = dbCheck.Value;
                }
                return Actual1;
            }

            public int? GetDryRunCount2(int machineId, string correctedDate, int opeatorId, string shift)
            {

                int? Actual = 0;
                int? dryRun = Serverdb.UnitworkccsTbldryrun.Where(m => m.MachineId == machineId && m.CorrectedDate == correctedDate && m.Shift == shift).Sum(m => m.PartCount);
                if (dryRun != null)
                {
                    Actual = dryRun;
                }
                return Actual;
            }

            public int GetRejectionDetails1(int machineId, string correctedDate)
            {
                int qty = 0;
                var dbCheck = Serverdb.UnitworkccsTblrejectiondetails.Where(m => m.CorrectedDate == correctedDate && m.MachineId == machineId).Select(m => m.DefectQty).Sum();
                if (dbCheck != null)
                {
                    qty = Convert.ToInt32(dbCheck);
                }
                return qty;
            }

            public int GetReworkDetails1(int machineId, string correctedDate)
            {
                int qty = 0;
                var dbCheck = Serverdb.UnitworkccsTblreworkdetails.Where(m => m.CorrectedDate == correctedDate && m.MachineId == machineId).Select(m => m.DefectQty).Sum();
                if (dbCheck != null)
                {
                    qty = Convert.ToInt32(dbCheck);
                }
                return qty;
            }

            public int GetTrialCount1(int machineId, string correctedDate)
            {
                int Actual1 = 0;
                var dbCheck = Serverdb.UnitworkccsTbltrialpartcount.Where(m => m.MachineId == machineId && m.CorrectedDate == correctedDate).Sum(m => m.TrialPartCount);
                if (dbCheck != null)
                {
                    Actual1 = dbCheck.Value;
                }
                return Actual1;
            }

            public int? GetDryRunCount1(int machineId, string correctedDate)
            {

                int? Actual = 0;
                int? dryRun = Serverdb.UnitworkccsTbldryrun.Where(m => m.MachineId == machineId && m.CorrectedDate == correctedDate).Sum(m => m.PartCount);
                if (dryRun != null)
                {
                    Actual = dryRun;
                }
                return Actual;
            }

            public List<ShiftList> ShiftList1(string correctedDate)
            {
                List<ShiftList> shiftLists = new List<ShiftList>();
                try
                {
                    var shiftDetails = Serverdb.UnitworkccsTblshiftMstr.ToList();
                    int i = 1;
                    foreach (var item in shiftDetails)
                    {
                        ShiftList shiftList = new ShiftList();
                        shiftList.shfitId = item.ShiftId;
                        shiftList.shiftName = item.ShiftName;

                        switch (i)
                        {
                            case 1:
                                string datee = DateTime.Now.Date.ToShortDateString();
                                string date1 = correctedDate + " " + item.StartTime;
                                string dateee = Convert.ToDateTime(correctedDate).ToShortDateString();
                                string date2 = dateee + " " + item.EndTime;
                                shiftList.shiftStartDateTime = Convert.ToDateTime(date1);
                                shiftList.shiftEndDateTime = Convert.ToDateTime(date2);
                                break;
                            case 2:
                                string datee1 = DateTime.Now.Date.ToShortDateString();
                                string date11 = correctedDate + " " + item.StartTime;
                                string dateee1 = Convert.ToDateTime(correctedDate).ToShortDateString();
                                string date21 = dateee1 + " " + item.EndTime;
                                shiftList.shiftStartDateTime = Convert.ToDateTime(date11);
                                shiftList.shiftEndDateTime = Convert.ToDateTime(date21);
                                break;
                            case 3:
                                string datee2 = DateTime.Now.Date.ToShortDateString();
                                string date12 = correctedDate + " " + item.StartTime;
                                string dateee2 = Convert.ToDateTime(correctedDate).Date.AddDays(1).ToShortDateString();
                                string date22 = dateee2 + " " + item.EndTime;
                                shiftList.shiftStartDateTime = Convert.ToDateTime(date12);
                                shiftList.shiftEndDateTime = Convert.ToDateTime(date22);
                                break;
                            default: break;
                        }

                        shiftLists.Add(shiftList);
                        i++;
                    }
                }
                catch (Exception ex)
                {
                }

                return shiftLists;
            }

            //Insert Losses Data for Man Machine Ticket.
            public void insertProdlosses(int WOID, int LossID, decimal LossDuration, DateTime CorrectedDate, int MachineID)
            {
                var Presentloss = Serverdb.UnitworkccsTblProdorderlosses.Where(m => m.Woid == WOID && m.LossId == LossID).FirstOrDefault();
                if (Presentloss == null)
                {
                    UnitworkccsTblProdorderlosses PRA = new UnitworkccsTblProdorderlosses();
                    PRA.LossId = LossID;
                    if (LossID != 0)
                    {
                        var GetLossDet = Serverdb.UnitworkccsTbllossescodes.Find(LossID);
                        if (GetLossDet.LossCodesLevel1Id == null)
                        {
                            PRA.LossCodeL1id = LossID;
                        }
                        else
                        {
                            PRA.LossCodeL1id = (int)GetLossDet.LossCodesLevel1Id;
                            PRA.LossId = (int)GetLossDet.LossCodesLevel1Id;
                        }
                        if (GetLossDet.LossCodesLevel2Id != null)
                            PRA.LossCodeL2id = (int)GetLossDet.LossCodesLevel2Id;
                    }
                    //PRA.MachineID = MachineID;
                    PRA.Woid = WOID;
                    PRA.CorrectedDate = CorrectedDate.Date;
                    PRA.LossDuration = (int)LossDuration;
                    PRA.MachineId = MachineID;
                    Serverdb.UnitworkccsTblProdorderlosses.Add(PRA);
                    Serverdb.SaveChanges();
                }
                else
                {
                    Presentloss.LossDuration = (int)(Presentloss.LossDuration + LossDuration);
                    Serverdb.Entry(Presentloss).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    Serverdb.SaveChanges();
                }
            }

            public class ShiftList
            {
                public int shfitId { get; set; }
                public string shiftName { get; set; }
                public DateTime shiftStartDateTime { get; set; }
                public DateTime shiftEndDateTime { get; set; }
            }
        }
    }
}
