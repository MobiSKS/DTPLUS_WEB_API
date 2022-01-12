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
#pragma warning disable IDE0052 // Remove unread private members
        private readonly ILogger<LoggingFilterAttribute> _logger;
#pragma warning restore IDE0052 // Remove unread private members
        public LoggingFilterAttribute(ILogger<LoggingFilterAttribute> logger)
        {
            _logger = logger;
        }
        //public override void OnActionExecuting(HttpActionContext filterContext)
        //{
        //    GlobalConfiguration.Configuration.Services.Replace(typeof(ITraceWriter), new NLogger());
        //    var trace = GlobalConfiguration.Configuration.Services.GetTraceWriter();
        //    NLog.MappedDiagnosticsLogicalContext.Set("methodName", filterContext.ActionDescriptor.ActionName);
        //    trace.Info(filterContext.Request, "Controller : " + filterContext.ControllerContext.ControllerDescriptor.ControllerType.FullName + Environment.NewLine + "Action : " + filterContext.ActionDescriptor.ActionName, "JSON", filterContext.ActionArguments);

        //    if (filterContext.ModelState.IsValid == false)
        //    {
        //        filterContext.Response = MessageHelper.Message(filterContext.Request, HttpStatusCode.OK, false, (int)StatusInformation.Manadatory_Feild_Required, null, filterContext.ModelState);
        //    }
        //}
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var logger = NLog.Web.NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();
            var descriptor = filterContext.ActionDescriptor as ControllerActionDescriptor;
            var actionName = descriptor.ActionName;
            var controllerName = descriptor.ControllerName;
            //IList<string> countries = new List<string>
            //{
            //    "New Zealand",
            //    "Australia",
            //    "Denmark",
            //    "China"
            //};
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
            // Do something after the action executes.
        }

        //public override void OnActionExecuted(HttpActionExecutedContext filterContext)
        //{
        //    GlobalConfiguration.Configuration.Services.Replace(typeof(ITraceWriter), new NLogger());
        //    var trace = GlobalConfiguration.Configuration.Services.GetTraceWriter();
        //    NLog.MappedDiagnosticsLogicalContext.Set("methodName", filterContext.ActionContext.ActionDescriptor.ActionName);
        //    trace.Info(filterContext.Request, "Controller : "
        //        + filterContext.ActionContext.ControllerContext.ControllerDescriptor.ControllerType.FullName
        //        + Environment.NewLine + "Action : "
        //        + filterContext.ActionContext.ActionDescriptor.ActionName, "JSON", filterContext.ActionContext.ActionArguments);
        //}
    }
}
