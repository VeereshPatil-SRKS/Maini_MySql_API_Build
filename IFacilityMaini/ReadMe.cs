using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IFacilityMaini
{
    public class ReadMe
    {

        /*  
        *  D:\Suhas\Live Projects\SAMSFRC\SAMSFRC\ReadMe.cs
        *   Installation packages for new project and setup
        *   
        *   ---for sql server
        *   
        *   vs > Scaffold-DbContext "Server=DESKTOP-R067I08\SQLEXPRESS;Database=unitworksccs;user id=sa;password=srks4$;" Microsoft.EntityFrameworkCore.SqlServer -f
        *   
        *   vs > Scaffold-DbContext "Server=SRKSDEV007\SQLEXPRESS;Database=unitworksccs;user id=sa;password=srks4$;" Microsoft.EntityFrameworkCore.SqlServer -f
        *   
        *   
        *   
        *   -------------- For token implementation ----------------------
        *   
        *   vs > Install-Package Microsoft.AspNetCore.Http -Version 2.2.2
        *   vs > Install-Package Microsoft.AspNetCore.Http.Features -Version 2.2.0
        *   vs > Install-Package Microsoft.AspNetCore.Http.Abstractions -Version 2.2.0
        *   vs > Install-Package Microsoft.AspNetCore.WebUtilities -Version 2.2.0
        *   
        *   vs > Install-Package Microsoft.EntityFrameworkCore -Version 2.2.6
        *   vs > Install-Package Microsoft.EntityFrameworkCore.Tools -Version 2.2.6
        *   vs > Install-Package MySql.Data.EntityFrameworkCore -Version 8.0.15 -- my sql
        *   vs > Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 2.2.6 -- sql
        *   vs > Install-Package Microsoft.AspNetCore.Mvc.Formatters.Xml -Version 2.2.0
        *   
        *   vs > Install-Package Swashbuckle.AspNetCore
        *   vs > Install-Package Microsoft.Owin.Security.Cookies -Version 4.0.1
        *   vs > Install-Package Microsoft.Owin.Security.OAuth -Version 4.0.1
        *   vs > Install-Package Microsoft.AspNet.WebApi.Owin -Version 5.2.7
        *   vs > Install-Package Microsoft.AspNet.WebApi.Core -Version 5.2.7
        *   vs > Install-Package Microsoft.Owin.Cors -Version 4.0.1
        *   
        *   
        *   
        *   --------------For logging exception --------------
        *   
        *   vs > Install-Package log4net -Version 2.0.8 
        *   vs > Install-Package Microsoft.Extensions.Logging.Log4Net.AspNetCore -Version 2.2.10
        *   
        *    ----------------Below Code is used to get all level messages of Log4net------------------
        *   Referred from below link
        *   https://stackoverflow.com/questions/46169606/how-to-use-log4net-in-asp-net-core-2-0
        *   
        *   Loggers may be assigned levels. Levels are instances of the log4net.Core.Level class. The following levels are defined in order of increasing priority:
        *   
        *  ALL
        *  DEBUG
        *  INFO
        *  WARN
        *  ERROR
        *  FATAL
        *  OFF
        *   
        *   
        * <?xml version="1.0" encoding="utf-8" ?>
          <log4net>
           <appender name="RollingLogFileAppender" type="log4net.Appender.RollingFileAppender">
           <lockingModel type="log4net.Appender.FileAppender+MinimalLock"/>
           <file value="C:\Logger\" />
           <datePattern value="yyyy-MM-dd.'txt'"/>
           <staticLogFileName value="false"/>
           <appendToFile value="true"/>
           <rollingStyle value="Date"/>
           <maxSizeRollBackups value="100"/>
           <maximumFileSize value="15MB"/>
           <layout type="log4net.Layout.PatternLayout">
           <conversionPattern value="%date [%thread] %-5level App  %newline %message %newline %newline"/>
           </layout>
           </appender>
           <root>
           <level value="ALL"/>
           <appender-ref ref="RollingLogFileAppender"/>
           </root>
          </log4net>
        *   
        *   
        *   
        *    ---------------Below Code is used to to get only Error messages of Log4net------------------
        *    
        *    add this >   <threshold value="Error" /> after <appender></appender> tag
        *    
        *  To call it in a Class use
          --- private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof("Class name of Respective class"));
          we can use that log variable to append error messages to the file as
          log.Error(ex)
        
        */

    }
}
