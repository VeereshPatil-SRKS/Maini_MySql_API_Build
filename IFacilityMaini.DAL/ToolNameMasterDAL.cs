using IFacilityMaini.DAL.Helpers;
using IFacilityMaini.DAL.Resource;
using IFacilityMaini.DBModels;
using IFacilityMaini.EntityModels;
using IFacilityMaini.Interface;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static IFacilityMaini.EntityModels.CommonEntity;

namespace IFacilityMaini.DAL
{
    public class ToolNameMasterDAL : IToolNameMaster
    {
        unitworksccsContext db = new unitworksccsContext();
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(ToolNameMasterDAL));
        public static IConfiguration configuration;
        private readonly AppSettings appSettings;

        public ToolNameMasterDAL(unitworksccsContext _db, IConfiguration _configuration, IOptions<AppSettings> _appSettings)
        {
            db = _db;
            configuration = _configuration;
            appSettings = _appSettings.Value;
        }
        /// <summary>
        /// AddUpdateToolNameMaster
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public CommonResponse AddUpdateToolNameMaster(ToolNameMasterEntity data)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = db.UnitworkccsToolnamemaster.Where(m => m.ToolId == data.toolId && m.IsDeleted == 0).FirstOrDefault();
                if (check == null)
                {
                    UnitworkccsToolnamemaster unitworkccsToolNameMasterDet = new UnitworkccsToolnamemaster();
                    unitworkccsToolNameMasterDet.ToolName = data.toolName;
                    unitworkccsToolNameMasterDet.ToolDesc = data.toolDesc;
                    unitworkccsToolNameMasterDet.IsDeleted = 0;
                    unitworkccsToolNameMasterDet.CreatedOn = DateTime.Now;
                    db.UnitworkccsToolnamemaster.Add(unitworkccsToolNameMasterDet);
                    db.SaveChanges();

                    obj.isStatus = true;
                    obj.response = ResourceResponse.AddedSuccessMessage;
                }
                else
                {
                    check.ToolName = data.toolName;
                    check.ToolDesc = data.toolDesc;
                    check.ModifiedOn = DateTime.Now;
                    check.ModifiedBy = 2;
                    db.SaveChanges();

                    obj.isStatus = true;
                    obj.response = ResourceResponse.UpdatedSuccessMessage;
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
        /// ViewToolNameMaster
        /// </summary>
        /// <returns></returns>
        public CommonResponse ViewToolNameMaster()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsToolnamemaster
                             where wf.IsDeleted == 0
                             select new
                             {
                                 toolId = wf.ToolId,
                                 toolName = wf.ToolName,
                                 toolDesc = wf.ToolDesc
                             }).ToList();


                if (check.Count > 0)
                {

                    obj.isStatus = true;
                    obj.response = check;
                }
                else
                {
                    obj.isStatus = false;
                    obj.response = "No Items Found";
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
        /// ViewToolNameMasterById
        /// </summary>
        /// <param name="toolId"></param>
        /// <returns></returns>
        public CommonResponse ViewToolNameMasterById(int toolId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsToolnamemaster
                             where wf.IsDeleted == 0 && wf.ToolId == toolId
                             select new
                             {
                                 toolId = wf.ToolId,
                                 toolName = wf.ToolName,
                                 toolDesc = wf.ToolDesc
                             }).ToList();


                if (check.Count > 0)
                {

                    obj.isStatus = true;
                    obj.response = check;
                }
                else
                {
                    obj.isStatus = false;
                    obj.response = "No Items Found";
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
        /// DeleteToolNameMaster
        /// </summary>
        /// <param name="toolId"></param>
        /// <returns></returns>
        public CommonResponse DeleteToolNameMaster(int toolId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = db.UnitworkccsToolnamemaster.Where(m => m.ToolId == toolId && m.IsDeleted == 0).FirstOrDefault();
                if (check != null)
                {
                    check.IsDeleted = 1;
                    check.ModifiedBy = 3;
                    check.ModifiedOn = DateTime.Now;
                    db.SaveChanges();

                    obj.isStatus = true;
                    obj.response = ResourceResponse.DeletedSuccessMessage;
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
