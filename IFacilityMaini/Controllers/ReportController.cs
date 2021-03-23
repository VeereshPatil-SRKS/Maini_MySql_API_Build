using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IFacilityMaini.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.ReportEntity;

namespace IFacilityMaini.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IReport report;
        public ReportController(IReport _report)
        {
            report = _report;
        }

        /// <summary>
        /// Get Fg Part Details
        /// </summary>
        /// <param name="machineId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Report/ViewMultiplePlant")]
        public async Task<IActionResult> ViewMultiplePlant()
        {
            CommonResponse response = report.ViewMultiplePlant();
            return Ok(response);
        }

        [HttpGet]
        [Route("Report/ViewMultiShift")]
        public async Task<IActionResult> ViewMultiShift()
        {
            CommonResponse response = report.ViewMultiShift();
            return Ok(response);
        }



        [HttpGet]
        [Route("Report/ViewMultipleMachines")]
        public async Task<IActionResult> ViewMultipleMachines(int plantId, string category)
        {
            CommonResponse response = report.ViewMultipleMachines(plantId, category);
            return Ok(response);
        }


        [HttpPost]
        [Route("Report/OEEReport1")]

        public async Task<IActionResult> OEEReport1(OEEdetails data)

        {
            CommonResponse response = new CommonResponse();

            response = report.OEEReport1(data);
            return Ok(response);
        }




        [HttpPost]
        [Route("Report/OEEReportShiftwise")]

        public async Task<IActionResult> OEEReportShiftwise(OEEdetailsShiftwise data)

        {
            CommonResponse response = new CommonResponse();

            response = report.OEEReportShiftwise(data);
            return Ok(response);
        }




        [HttpGet]
        [Route("Report/ViewMultiEmployees")]
        public async Task<IActionResult> ViewMultiEmployees()
        {
            CommonResponse response = report.ViewMultiEmployees();
            return Ok(response);
        }




        [HttpGet]
        [Route("Report/ViewMultiEmployeesMachines")]
        public async Task<IActionResult> ViewMultiEmployeesMachines(string empId)
        {
            CommonResponse response = report.ViewMultiEmployeesMachines(empId);
            return Ok(response);
        }




        [HttpPost]
        [Route("Report/OEEReportOperator")]

        public async Task<IActionResult> OEEReportOperator(OEEdetailsOperator data)

        {
            CommonResponse response = new CommonResponse();

            response = report.OEEReportOperator(data);
            return Ok(response);
        }

        [HttpPost]
        [Route("Report/BreakdownReport")]

        public async Task<IActionResult> BreakdownReport(breakdownReportDet data)

        {
            CommonResponse response = new CommonResponse();

            response = report.BreakdownReport(data);
            return Ok(response);
        }

    }
}