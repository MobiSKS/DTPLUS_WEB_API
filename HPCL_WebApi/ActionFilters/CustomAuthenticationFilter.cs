using System;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using HPCL.Infrastructure.Response;
using Microsoft.AspNetCore.Mvc.Filters;
using IAuthorizationFilter = Microsoft.AspNetCore.Mvc.Filters.IAuthorizationFilter;
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
                context.Result = new JsonResult
                     (
                     new RouteValueDictionary(new AuthenticationFailureResult("Missing Authorization Header", request, actionName).Execute()
                     ));
            }

            if (authorization.StartsWith("Bearer ", StringComparison.OrdinalIgnoreCase))
            {
                //string token = authorization.Substring("Bearer ".Length).Trim();
                string token = authorization["Bearer ".Length..].Trim();
                if (string.IsNullOrEmpty(token))
                {
                    context.Result = new JsonResult
                   (
                   new RouteValueDictionary(new AuthenticationFailureResult("Missing Token", request, actionName).Execute()
                   ));
                }
            }
            else
            {
                context.Result = new JsonResult
                  (
                  new RouteValueDictionary(new AuthenticationFailureResult("Invalid Authorization Scheme", request, actionName).Execute()
                  ));
            }

            context.HttpContext.Request.Headers.TryGetValue("API_Key", out var HAPI_Key);
            string API_Key = HAPI_Key.ToString();
            context.HttpContext.Request.Headers.TryGetValue("SecretKey", out _);
            //string SecretKey = HSecretKey.ToString();

            if (API_Key == "")
            {
                context.Result = new JsonResult
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

            context.Result = new JsonResult
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
                ApiResponseMessage response = new ApiResponseMessage
                {
                    Status_Code = (int)HttpStatusCode.Unauthorized,
                    Message = "Token Expired",
                    Success = false,
                    Method_Name = MethodName,
                    Data = new { Message = ReasonPhrase },
                    Model_State = null
                };
                return (response);

            }



        }
    }


}