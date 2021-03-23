using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DinkToPdf;
using DinkToPdf.Contracts;
using IFacilityMaini.DAL;
using IFacilityMaini.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Logical;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.EmployeeShiftDetailsEntity;

namespace IFacilityMaini.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class EmployeeShiftDetailsController : ControllerBase
    {
        private readonly IEmployeeShiftDetails empshift;
        private readonly IConverter converter;
        public EmployeeShiftDetailsController(IEmployeeShiftDetails _empshift,IConverter _converter)
        {
            empshift = _empshift;
            converter = _converter;
        }

        /// <summary>
        /// View Multiple Operator
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("EmployeeShift/ViewMultipleOperator")]
        public async Task<IActionResult> ViewMultipleOperator()
        {
            CommonResponse response = empshift.ViewMultipleOperator();
            return Ok(response);
        }

        [HttpGet]
        [Route("EmployeeShift/ViewShifts")]
        public async Task<IActionResult> ViewShifts()
        {
            CommonResponse response = empshift.ViewShifts();
            return Ok(response);
        }

        [HttpGet]
        [Route("EmployeeShift/ViewMultipleMachines")]
        public async Task<IActionResult> ViewMultipleMachines()
        {
            CommonResponse response = empshift.ViewMultipleMachines();
            return Ok(response);
        }

        [HttpPost]
        [Route("EmployeeShift/AddUpdateEmployeeShift")]
        public async Task<IActionResult> AddUpdateEmployeeShift(AddUpdateOperatorShift data)
        {
            CommonResponse response = empshift.AddUpdateEmployeeShift(data);
            return Ok(response);
        }

        /// <summary>
        /// View Multiple Operator
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("EmployeeShift/ViewMultipleOperatorShift")]
        public async Task<IActionResult> ViewMultipleOperatorShift()
        {
            CommonResponse response = empshift.ViewMultipleOperatorShift();
            return Ok(response);
        }

        /// <summary>
        /// View Multiple Operator By Id
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("EmployeeShift/ViewMultipleOperatorShiftById")]
        public async Task<IActionResult> ViewMultipleOperatorShiftById(int Id)
        {
            CommonResponse response = empshift.ViewMultipleOperatorShiftById(Id);
            return Ok(response);
        }

        /// <summary>
        /// Delete Operator
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("EmployeeShift/DeleteOperatorShift")]
        public async Task<IActionResult> DeleteOperatorShift(int Id)
        {
            CommonResponse response = empshift.DeleteOperatorShift(Id);
            return Ok(response);
        }


        [HttpPost]
        [Route("EmployeeShift/UploadOperatorsShift")]
        public async Task<IActionResult> UploadOperatorsShift(AddUpdateOperatorShiftExcel data)
        {
            CommonResponse response = empshift.UploadOperatorsShift(data);
            return Ok(response);
        }

        [HttpPost]
        [Route("EmployeeShift/DownLoadOperatorsShiftDetails")]
        public async Task<IActionResult> DownLoadOperatorsShiftDetails()
        {
            CommonResponse response = empshift.DownLoadOperatorsShiftDetails();
            return Ok(response);
        }
    }
}