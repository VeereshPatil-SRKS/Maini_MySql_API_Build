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
using static IFacilityMaini.EntityModels.LoginEntity;

namespace IFacilityMaini.DAL
{
    public class LoginDAL : ILogin
    {
        unitworksccsContext db = new unitworksccsContext();
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(LoginDAL));
        public static IConfiguration configuration;

        public LoginDAL(unitworksccsContext _db, IConfiguration _configuration)
        {
            db = _db;
            configuration = _configuration;
        }

        ///// <summary>
        ///// Login Details
        ///// </summary>
        ///// <param name="userName"></param>
        ///// <param name="password"></param>
        ///// <returns></returns>
        //public CommonResponse LoginDetails(string userName,string password)
        //{
        //    CommonResponse obj = new CommonResponse();
        //    try
        //    {
        //        var check = (from wf in db.TblOperatorDetails
        //                     where wf.UserName == userName && wf.Password == password && wf.IsDeleted == 0
        //                     select new
        //                     {
        //                         wf.OpId,
        //                         wf.OperatorName,
        //                         wf.RoleId,
        //                     }).FirstOrDefault();

        //        if(check != null)
        //        {
        //            obj.isStatus = true;
        //            obj.response = check;
        //        }
        //        else
        //        {
        //            obj.isStatus = false;
        //            obj.response = ResourceResponse.NoItemsFound;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        obj.isStatus = false;
        //        obj.response = ResourceResponse.FailureMessage;
        //    }
        //    return obj;
        //}

        /// <summary>
        /// Login Details
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public CommonResponse LoginDetails(LoginTrackerdetails data)
        {
            CommonResponse obj = new CommonResponse();
            CommonFunction commonFunction = new CommonFunction();
            try
            {
                string shift = commonFunction.GetCurrentShift();
                string correctedDate = commonFunction.GetCorrectedDate();
                int machineId = data.machineId;

                CommonResponse commonResponse = new CommonResponse();
                List<LoginOperatorDet> loginOperatorDetsList = new List<LoginOperatorDet>();

                var loginTrackerDet = commonFunction.GetLoginTrackerDetailsLastRow(correctedDate, data.machineId);

                if (loginTrackerDet == null)
                {
                    var check = (from wf in db.TblOperatorDetails
                                 where wf.UserName == data.userName && wf.Password == data.password && wf.IsDeleted == 0
                                 select new
                                 {
                                     wf.OpId,
                                     wf.OperatorName,
                                     wf.RoleId,
                                 }).FirstOrDefault();

                    if (check != null)
                    {
                        if (check.RoleId == 6 && data.pageName == "operatorPage")
                        {
                            LoginTrackerDetails loginTrackerDetails = new LoginTrackerDetails();
                            loginTrackerDetails.MachineId = machineId;
                            loginTrackerDetails.OperatorId = check.OpId;
                            loginTrackerDetails.LoginDateTime = DateTime.Now;
                            loginTrackerDetails.IsLoggedIn = true;
                            loginTrackerDetails.Shift = shift;
                            loginTrackerDetails.CorrectedDate = correctedDate;
                            db.LoginTrackerDetails.Add(loginTrackerDetails);
                            db.SaveChanges();

                            LoginOperatorDet loginOperatorDet = new LoginOperatorDet();
                            loginOperatorDet.opId = check.OpId;
                            loginOperatorDet.operatorName = check.OperatorName;
                            loginOperatorDet.roleId = check.RoleId;
                            loginOperatorDet.machineName = db.Tblmachinedetails.Where(m => m.MachineId == machineId).Select(m => m.MachineName).FirstOrDefault();
                            DateTime LoginDateTime = Convert.ToDateTime(loginTrackerDetails.LoginDateTime);
                            loginOperatorDet.loginTime = LoginDateTime.ToString("yyyy-MM-dd HH:mm:ss");
                            loginOperatorDet.shift = loginTrackerDetails.Shift;
                            loginOperatorDet.correctedDate = loginTrackerDetails.CorrectedDate;
                            loginOperatorDetsList.Add(loginOperatorDet);

                            obj.isStatus = true;
                            obj.response = loginOperatorDetsList;
                        }
                        else if (check.RoleId == 9 && data.pageName == "ticketManagement")
                        {
                            LoginTrackerDetails loginTrackerDetails = new LoginTrackerDetails();
                            loginTrackerDetails.MachineId = machineId;
                            loginTrackerDetails.OperatorId = check.OpId;
                            loginTrackerDetails.LoginDateTime = DateTime.Now;
                            loginTrackerDetails.IsLoggedIn = true;
                            loginTrackerDetails.Shift = shift;
                            loginTrackerDetails.CorrectedDate = correctedDate;
                            db.LoginTrackerDetails.Add(loginTrackerDetails);
                            db.SaveChanges();

                            LoginOperatorDet loginOperatorDet = new LoginOperatorDet();
                            loginOperatorDet.opId = check.OpId;
                            loginOperatorDet.operatorName = check.OperatorName;
                            loginOperatorDet.roleId = check.RoleId;
                            loginOperatorDet.machineName = db.Tblmachinedetails.Where(m => m.MachineId == machineId).Select(m => m.MachineName).FirstOrDefault();
                            DateTime LoginDateTime = Convert.ToDateTime(loginTrackerDetails.LoginDateTime);
                            loginOperatorDet.loginTime = LoginDateTime.ToString("yyyy-MM-dd HH:mm:ss");
                            loginOperatorDet.shift = loginTrackerDetails.Shift;
                            loginOperatorDet.correctedDate = loginTrackerDetails.CorrectedDate;
                            loginOperatorDetsList.Add(loginOperatorDet);

                            obj.isStatus = true;
                            obj.response = loginOperatorDetsList;
                        }
                        else
                        {
                            obj.isStatus = false;
                            obj.response = "Not Authorized User";
                        }
                    }
                    else
                    {
                        obj.isStatus = false;
                        obj.response = ResourceResponse.NoItemsFound;
                    }
                }
                else
                {
                    obj.isStatus = false;
                    obj.response = "Already Logged In";
                }
            }
            catch (Exception e)
            {
                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        /// <summary>
        /// Logout
        /// </summary>
        /// <param name="machineId"></param>
        /// <returns></returns>
        public CommonResponse Logout(int machineId, int operatorId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                CommonFunction commonFunction = new CommonFunction();
                string correctedDate = commonFunction.GetCorrectedDate();
                var check = commonFunction.GetLoginTrackerDetails(correctedDate, machineId, operatorId);
                if (check != null)
                {
                    check.LogoutDateTime = DateTime.Now;
                    check.IsLoggedIn = false;
                    db.LoginTrackerDetails.Update(check);
                    db.SaveChanges();
                    obj.isStatus = true;
                    obj.response = "Logout Successfully";
                }
            }
            catch (Exception e)
            {
                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        /// <summary>
        /// Maintainance Login Details
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public CommonResponse MaintainanceLoginDetails(string userName, string password)
        {
            CommonResponse obj = new CommonResponse();
            CommonFunction commonFunction = new CommonFunction();
            try
            {
                var check = (from wf in db.TblOperatorDetails
                             where wf.UserName == userName && wf.Password == password && wf.RoleId == 9
                             select new
                             {
                                 OperatorName = wf.OperatorName,
                                 OpId = wf.OpId,
                                 RoleId = wf.RoleId
                             }).FirstOrDefault();
                if (check != null)
                {
                    obj.isStatus = true;
                    obj.response = check;
                }
                else
                {
                    obj.isStatus = false;
                    obj.response = "Not Authorized User";
                }
            }
            catch (Exception e)
            {
                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        /// <summary>
        /// Admin Login Details
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public CommonResponseWithUserName AdminLoginDetails(string userName, string password)
        {
            CommonResponseWithUserName obj = new CommonResponseWithUserName();
            CommonFunction commonFunction = new CommonFunction();
            try
            {
                var check = (from wf in db.TblOperatorDetails
                             where wf.UserName == userName && wf.Password == password && wf.RoleId == 11
                             select new
                             {
                                 OperatorName = wf.OperatorName,
                                 OpId = wf.OpId,
                                 RoleId = wf.RoleId
                             }).FirstOrDefault();
                if (check != null)
                {
                    obj.isStatus = true;
                    obj.response = check;
                    obj.id = check.OpId;
                    obj.userName = check.OperatorName;
                }
                else
                {
                    obj.isStatus = false;
                    obj.response = "Not Authorized User";
                }
            }
            catch (Exception e)
            {
                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        /// <summary>
        /// Login
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public CommonResponse Login(string userName, string password)
        {
            CommonResponse obj = new CommonResponse();
            CommonFunction commonFunction = new CommonFunction();
            try
            {
                var check = (from wf in db.TblOperatorDetails
                             where wf.UserName == userName && wf.Password == password
                             select new
                             {
                                 OperatorName = wf.OperatorName,
                                 OpId = wf.OpId,
                                 RoleId = wf.RoleId
                             }).FirstOrDefault();
                if (check != null)
                {
                    obj.isStatus = true;
                    obj.response = check;
                }
                else
                {
                    obj.isStatus = false;
                    obj.response = "Not Authorized User";
                }
            }
            catch (Exception e)
            {
                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }
    }
}
