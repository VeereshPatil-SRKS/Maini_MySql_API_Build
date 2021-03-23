using IFacilityMaini.DAL.App_Start;
using System;
using System.Collections.Generic;
using System.Text;
using static IFacilityMaini.EntityModels.EmployeeShiftDetailsEntity;

namespace IFacilityMaini.DAL
{
    public static class TemplateGenerator
    {
        public static string GetHTMLString(DownloadPdf data)
        {
            CommonFunction commonFunction = new CommonFunction();
            var employees = commonFunction.GetEmployeeDetails(data);

            var sb = new StringBuilder();
            sb.Append(@"
                <html>
                    <head></head>
                    <body>
                        <div class='header'><h1> Shiftwise Employee Details</h1></div>
                        <table align='center'>
                            <tr>
                                <th> Employee Name</th>
                                <th> Employee Id </th>
                                <th> Cell </th>
                                <th> SubCell </th>
                                <th> DepartMent </th>
                                <th> Designation </th>
                                <th> Shift </th>
                                <th> FromDate </th>
                                <th> ToDate </th>
                                <th> Machines </th>
                            </tr>");

            foreach (var item in employees)
            {
                //sb.AppendFormat(@"
                //<tr>
                //    <td>{0}</td>
                //    <td>{1}</td>
                //    <td>{2}</td>
                //    <td>{3}</td>
                //    <td>{4}</td>
                //    <td>{5}</td>
                //    <td>{6}</td>
                //    <td>{7}</td>
                //</tr>", item.employeeName, item.Cell, item.subCell, item.department, item.designation, item.shift, item.fromDate, item.toDate);

                sb.Append("<tr>");
                sb.Append("<td>" + item.employeeName + "</td>");
                sb.Append("<td>" + item.employeeNo + "</td>");
                sb.Append("<td>" + item.Cell + "</td>");
                sb.Append("<td>" + item.subCell + "</td>");
                sb.Append("<td>" + item.department + "</td>");
                sb.Append("<td>" + item.designation + "</td>");
                sb.Append("<td>" + item.shift + "</td>");
                sb.Append("<td>" + item.fromDate + "</td>");
                sb.Append("<td>" + item.toDate + "</td>");
                sb.Append("<td><ul>");
                foreach(var i in item.machinesList)
                {
                    sb.Append("<li>" + i.machineName + "</li>");
                }
                sb.Append("</ul></td></tr>");
            }

            sb.Append(@"
                        </table>
                        </body>
                        </html>");

            return sb.ToString();
        }
    }
}
