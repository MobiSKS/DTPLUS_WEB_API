using HPCL.Infrastructure.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Web.Http.Results;
using static HPCL.Infrastructure.CommonClass.StatusMessage;

namespace HPCL_WebApi.ActionFilters
{
    public class CustomerAPIAuthenticationFilter : Attribute, IAuthorizationFilter
    {
        public class Root
        {
            public string Username;
            public string Password;
        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            HttpRequest request = context.HttpContext.Request;
            var descriptor = context.ActionDescriptor as ControllerActionDescriptor;
            var actionName = descriptor.ActionName;

            var bodyStr = "";
            var req = context.HttpContext.Request;

            // Allows using several time the stream in ASP.Net Core
            // req.EnableRewind();

            // Arguments: Stream, Encoding, detect encoding, buffer size 
            // AND, the most important: keep stream opened
            using (StreamReader reader = new StreamReader(req.Body, Encoding.UTF8, true, 1024, true))
            {
                bodyStr = reader.ReadToEnd();
            }

            // Rewind, so the core is not lost when it looks the body for the request
            //req.Body.Position = 0;


            // var body = reader.ReadToEnd();
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };
            bodyStr = bodyStr.Replace("'", "''");
            Root objObject = JsonConvert.DeserializeObject<Root>(bodyStr, settings);

            string username = objObject.Username;
            string password = objObject.Password;

            string authorization = request.Headers["Authorization"];
            if (string.IsNullOrEmpty(authorization))
            {
                context.Result = new JsonResult
                     (
                     new RouteValueDictionary(new CustomerAPIAuthenticationFailureResult("Not authorized to Access this API.", request, actionName).Execute()
                     ));
            }
        }

        public class CustomerAPIAuthenticationFailureResult
        {
            public string ReasonPhrase = string.Empty;
            public string MethodName = string.Empty;
            public HttpRequest Request { get; set; }

            public CustomerAPIAuthenticationFailureResult(string reasonphrase, HttpRequest request, string methodName)
            {
                MethodName = methodName;
                ReasonPhrase = reasonphrase;
                Request = request;
            }

            public CustomerAPIReponseMessage Execute()
            {

                CustomerAPIReponseMessage response = new CustomerAPIReponseMessage
                {
                    responseCode = "0",
                    responseMessage = ReasonPhrase
                };
                return (response);

            }
        }
    }
}
