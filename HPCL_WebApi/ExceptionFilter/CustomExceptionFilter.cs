using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace HPCL_WebApi.ExceptionFilter
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            HttpStatusCode statusCode = (context.Exception as WebException != null &&
                        ((HttpWebResponse)(context.Exception as WebException).Response) != null) ?
                         ((HttpWebResponse)(context.Exception as WebException).Response).StatusCode
                         : getErrorCode(context.Exception.GetType());
            string errorMessage = context.Exception.Message;
            string customErrorMessage = "Custom Error";
            string stackTrace = context.Exception.StackTrace;

            HttpResponse response = context.HttpContext.Response;
            response.StatusCode = (int)statusCode;
            response.ContentType = "application/json";
            var result = JsonConvert.SerializeObject(
                new
                {
                    message = customErrorMessage,
                    isError = true,
                    errorMessage = errorMessage,
                    errorCode = statusCode,
                    model = string.Empty
                });
            #region Logging  
            //if (ConfigurationHelper.GetConfig()[ConfigurationHelper.environment].ToLower() != "dev")  
            //{  
            //    LogMessage objLogMessage = new LogMessage()  
            //    {  
            //        ApplicationName = ConfigurationHelper.GetConfig()["ApplicationName"].ToString(),  
            //        ComponentType = (int) ComponentType.Server,  
            //        ErrorMessage = errorMessage,  
            //        LogType = (int) LogType.EventViewer,  
            //        ErrorStackTrace = stackTrace,  
            //        UserName = Common.GetAccNameDev(context.HttpContext)  
            //    };  
            //    LogError(objLogMessage, LogEntryType.Error);  
            //}  
            #endregion Logging  
            response.ContentLength = result.Length;
            response.WriteAsync(result);
        }


        private HttpStatusCode getErrorCode(Type exceptionType)
        {
            ExceptionsEnum tryParseResult;
            if (Enum.TryParse<ExceptionsEnum>(exceptionType.Name, out tryParseResult))
            {
                switch (tryParseResult)
                {
                    case ExceptionsEnum.NullReferenceException:
                        return HttpStatusCode.LengthRequired;

                    case ExceptionsEnum.FileNotFoundException:
                        return HttpStatusCode.NotFound;

                    case ExceptionsEnum.OverflowException:
                        return HttpStatusCode.RequestedRangeNotSatisfiable;

                    case ExceptionsEnum.OutOfMemoryException:
                        return HttpStatusCode.ExpectationFailed;

                    case ExceptionsEnum.InvalidCastException:
                        return HttpStatusCode.PreconditionFailed;

                    case ExceptionsEnum.ObjectDisposedException:
                        return HttpStatusCode.Gone;

                    case ExceptionsEnum.UnauthorizedAccessException:
                        return HttpStatusCode.Unauthorized;

                    case ExceptionsEnum.NotImplementedException:
                        return HttpStatusCode.NotImplemented;

                    case ExceptionsEnum.NotSupportedException:
                        return HttpStatusCode.NotAcceptable;

                    case ExceptionsEnum.InvalidOperationException:
                        return HttpStatusCode.MethodNotAllowed;

                    case ExceptionsEnum.TimeoutException:
                        return HttpStatusCode.RequestTimeout;

                    case ExceptionsEnum.ArgumentException:
                        return HttpStatusCode.BadRequest;

                    case ExceptionsEnum.StackOverflowException:
                        return HttpStatusCode.RequestedRangeNotSatisfiable;

                    case ExceptionsEnum.FormatException:
                        return HttpStatusCode.UnsupportedMediaType;

                    case ExceptionsEnum.IOException:
                        return HttpStatusCode.NotFound;

                    case ExceptionsEnum.IndexOutOfRangeException:
                        return HttpStatusCode.ExpectationFailed;

                    default:
                        return HttpStatusCode.InternalServerError;
                }
            }
            else
            {
                return HttpStatusCode.InternalServerError;
            }
        }
    }
}
