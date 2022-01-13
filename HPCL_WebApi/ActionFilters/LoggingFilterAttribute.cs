using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using NLog;
using System;

namespace HPCL_WebApi.ActionFilters
{
    public class LoggingFilterAttribute : IActionFilter
    {
        private readonly ILogger<LoggingFilterAttribute> _logger;
        public LoggingFilterAttribute(ILogger<LoggingFilterAttribute> logger)
        {
            _logger = logger;
        }
      
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var logger = NLog.Web.NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();
            var descriptor = filterContext.ActionDescriptor as ControllerActionDescriptor;
            var actionName = descriptor.ActionName;
            var controllerName = descriptor.ControllerName;
                     //            string json = JsonConvert.SerializeObject(countries, Formatting.Indented, new JsonSerializerSettings
            //            {
            //                TraceWriter = new NLogTraceWriter()
            //            });
            //NLogTraceWriter
            //NLogTraceWriter nLogTraceWriter = new NLogTraceWriter();
            //nLogTraceWriter.
            //NLogTraceWriter.
            //GlobalConfiguration.Configuration.Services.Replace(typeof(ITraceWriter), new NLogger());
            //var trace = GlobalConfiguration.Configuration.Services.GetTraceWriter();

            MappedDiagnosticsLogicalContext.Set("methodName", actionName);
            var jsonInput = Newtonsoft.Json.JsonConvert.SerializeObject(filterContext.ActionArguments);
            logger.Info("Controller : " + controllerName + Environment.NewLine + "Action : " + actionName+ "JSON Input"+ jsonInput.ToString ());
          
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            var logger = NLog.Web.NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();
            var descriptor = context.ActionDescriptor as ControllerActionDescriptor;
            var actionName = descriptor.ActionName;
            var controllerName = descriptor.ControllerName;
            var result = context.Result;
            MappedDiagnosticsLogicalContext.Set("methodName", actionName);
            var jsonInput = Newtonsoft.Json.JsonConvert.SerializeObject(result);
            logger.Info("Controller : " + controllerName + Environment.NewLine + "Action : " + actionName + "JSON OutPut" + jsonInput.ToString());
        }

    }
}
