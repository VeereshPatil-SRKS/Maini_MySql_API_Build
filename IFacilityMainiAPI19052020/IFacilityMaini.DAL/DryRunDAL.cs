using IFacilityMaini.DAL.App_Start;
using IFacilityMaini.DAL.Resource;
using IFacilityMaini.DBModels;
using IFacilityMaini.Interface;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.DryRunEntity;

namespace IFacilityMaini.DAL
{
    public class DryRunDAL : IDryRun
    {
        unitworksccsContext db = new unitworksccsContext();
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(DryRunDAL));
        public static IConfiguration configuration;

        public DryRunDAL(unitworksccsContext _db, IConfiguration _configuration)
        {
            db = _db;
            configuration = _configuration;
        }

        /// <summary>
        /// Add Dry Run
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public CommonResponseWithIds AddDryRun(DryRunDetails data)
        {
            CommonResponseWithIds obj = new CommonResponseWithIds();
            try
            {
                CommonFunction commonFunction = new CommonFunction();
                string shift = commonFunction.GetCurrentShift();
                string correctedDate = commonFunction.GetCorrectedDate();

                var roleId = db.TblOperatorDetails.Where(m => m.OpId == data.userId).Select(m => m.RoleId).FirstOrDefault();
                var check = db.TblDryRun.Where(m => m.MachineId == data.machineId && m.FgPartId == data.fgPartId && m.EndDate == null && roleId == 11).FirstOrDefault();
                if (check == null)
                {
                    TblDryRun tblDryRun = new TblDryRun();
                    tblDryRun.FgPartId = data.fgPartId;
                    tblDryRun.MachineId = data.machineId;
                    tblDryRun.StartDate = DateTime.Now;
                    tblDryRun.CreatedOn = DateTime.Now;
                    tblDryRun.CorrectedDate = correctedDate;
                    tblDryRun.IsDeleted = 0;
                    tblDryRun.Shift = shift;
                    db.TblDryRun.Add(tblDryRun);
                    db.SaveChanges();
                    obj.isStatus = true;
                    obj.response = ResourceResponse.AddedSuccessMessage;
                    obj.id = tblDryRun.DryRunId;
                }
            }
            catch (Exception)
            {
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        /// <summary>
        /// Close Dry Run
        /// </summary>
        /// <param name="dryRunId"></param>
        /// <returns></returns>
        public CommonResponse CloseDryRun(int dryRunId, int userId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var roleId = db.TblOperatorDetails.Where(m => m.OpId == userId).Select(m => m.RoleId).FirstOrDefault();
                var check = db.TblDryRun.Where(m => m.DryRunId == dryRunId && roleId == 11).FirstOrDefault();
                if (check != null)
                {
                    check.EndDate = DateTime.Now;
                    db.SaveChanges();
                    obj.isStatus = true;
                    obj.response = "Dry Run Closed";
                }
            }
            catch (Exception)
            {
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        /// <summary>
        /// Automatic Close Dry Run
        /// </summary>
        /// <param name="dryRunId"></param>
        /// <returns></returns>
        public CommonResponse AutomaticCloseDryRun(int dryRunId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = db.TblDryRun.Where(m => m.DryRunId == dryRunId).FirstOrDefault();
                if (check != null)
                {
                    DateTime currentDateTime = DateTime.Now;
                    DateTime dryRunStartDateTime = Convert.ToDateTime(check.StartDate);

                    string minutes = (Math.Truncate(currentDateTime.Subtract(dryRunStartDateTime).TotalMinutes)).ToString();
                    int min = Convert.ToInt32(minutes);
                    if (min > 15)
                    {
                        check.EndDate = DateTime.Now;
                        db.SaveChanges();
                        obj.isStatus = true;
                        obj.response = "Dry Run Closed";
                    }
                }
            }
            catch (Exception)
            {
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }
    }
}
