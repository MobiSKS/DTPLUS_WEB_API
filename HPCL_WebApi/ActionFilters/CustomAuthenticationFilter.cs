using HPCL.DataModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Filters;
using System.Web.Http.ModelBinding;
using System.Web.Http.Results;
using Microsoft.Extensions.Configuration;
using HPCL.Infrastructure.CommonClass;
using HPCL.Infrastructure.TokenManager;
using Microsoft.AspNetCore.Mvc;
using HPCL.Infrastructure.Response;
using Microsoft.AspNetCore.Mvc.Filters;
using IAuthorizationFilter = Microsoft.AspNetCore.Mvc.Filters.IAuthorizationFilter;
using Microsoft.Extensions.Primitives;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Controllers;

namespace HPCL_WebApi.ActionFilters
{

    public class CustomAuthenticationFilter : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            // string authString;
            HttpRequest request = context.HttpContext.Request;
            var descriptor = context.ActionDescriptor as ControllerActionDescriptor;
            var actionName = descriptor.ActionName;

            string authorization = request.Headers["Authorization"];
            if (string.IsNullOrEmpty(authorization))
            {
                context.Result = new Microsoft.AspNetCore.Mvc.JsonResult
                     (
                     new RouteValueDictionary(new AuthenticationFailureResult("Missing Authorization Header", request, actionName).Execute()
                     ));
            }

            if (authorization.StartsWith("Bearer ", StringComparison.OrdinalIgnoreCase))
            {
                string token = authorization.Substring("Bearer ".Length).Trim();
                if (String.IsNullOrEmpty(token))
                {
                    context.Result = new Microsoft.AspNetCore.Mvc.JsonResult
                   (
                   new RouteValueDictionary(new AuthenticationFailureResult("Missing Token", request, actionName).Execute()
                   ));
                }
            }
            else
            {
                context.Result = new Microsoft.AspNetCore.Mvc.JsonResult
                  (
                  new RouteValueDictionary(new AuthenticationFailureResult("Invalid Authorization Scheme", request, actionName).Execute()
                  ));
            }

            context.HttpContext.Request.Headers.TryGetValue("API_Key", out var HAPI_Key);
            string API_Key = HAPI_Key.ToString();
            context.HttpContext.Request.Headers.TryGetValue("SecretKey", out var HSecretKey);
            string SecretKey = HSecretKey.ToString();

            if (API_Key == "")
            {
                context.Result = new Microsoft.AspNetCore.Mvc.JsonResult
                  (
                  new RouteValueDictionary(new AuthenticationFailureResult("API Key is null.Please pass API Key", request, actionName).Execute()
                  ));
            }
            //else
            //{
            //    string API_Key_Check = "3C25F265-F86D-419D-9A04-EA74A503C197"; //ObjVariable.StrAPI_Key;
            //    if (API_Key == API_Key_Check)
            //    {
            //        context.Principal = TokenManager.GetPrincipal(authorization.Parameter, objObject.Useragent, objObject.Userip);
            //        if (context.Principal == null)
            //        {
            //            context.ErrorResult = (IHttpActionResult)new AuthenticationFailureResult("Unauthorized Access", request);
            //        }
            //    }
            //    else
            //    {
            //        context.ErrorResult = (IHttpActionResult)new AuthenticationFailureResult("API key is invalid", request);
            //    }
            //}
            // }

            context.Result = new Microsoft.AspNetCore.Mvc.JsonResult
                 (
                 new RouteValueDictionary(new AuthenticationFailureResult("API key is invalid", request, actionName).Execute()
                 ));
        }

        public class AuthenticationFailureResult
        {
            public string ReasonPhrase = string.Empty;
            public string MethodName = string.Empty;
            public HttpRequest Request { get; set; }

            public AuthenticationFailureResult(string reasonphrase, HttpRequest request, string methodName)
            {
                MethodName = methodName;
                ReasonPhrase = reasonphrase;
                Request = request;
            }

            public ApiResponseMessage Execute()
            {
                ApiResponseMessage response = new ApiResponseMessage();
                response.Status_Code = (int)HttpStatusCode.Unauthorized;
                response.Message = "Token Expired";
                response.Success = false;
                response.Method_Name = MethodName;
                response.Data = new { Message = ReasonPhrase };
                response.Model_State = null;
                return (response);

            }



        }
    }


}