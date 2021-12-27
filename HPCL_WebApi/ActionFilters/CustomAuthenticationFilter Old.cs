//using HPCL.DataModel;
//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.Configuration;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Net.Http.Headers;
//using System.Threading;
//using System.Threading.Tasks;
//using System.Web.Http;
//using System.Web.Http.Filters;
//using System.Web.Http.ModelBinding;
//using System.Web.Http.Results;
//using Microsoft.Extensions.Configuration;
//using HPCL.Infrastructure.CommonClass;
//using HPCL.Infrastructure.TokenManager;
//using Microsoft.AspNetCore.Mvc;
//using HPCL.Infrastructure.Response;

//namespace HPCL_WebApi.ActionFilters
//{

//    public class CustomAuthenticationFilter : AuthorizeAttribute, IAuthenticationFilter
//    {

//        private readonly IConfiguration _configuration;
//        private readonly Variables ObjVariable;

//        //public CustomAuthenticationFilter(IConfiguration configuration)
//        //{
//        //    _configuration = configuration;
//        //    ObjVariable = new Variables(configuration);
//        //}

//#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
//        public async Task AuthenticateAsync(HttpAuthenticationContext context, CancellationToken cancellationToken)
//#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
//        {
            
//            HttpRequestMessage request = context.Request;
//            AuthenticationHeaderValue authorization = request.Headers.Authorization;

//            //var myModel = context.ActionContext.Request.Content.ReadAsStringAsync();

//            Task<string> content = context.ActionContext.Request.Content.ReadAsStringAsync();
//            string jsonData = content.Result;

//            var settings = new JsonSerializerSettings
//            {
//                NullValueHandling = NullValueHandling.Ignore,
//                MissingMemberHandling = MissingMemberHandling.Ignore
//            };

//            jsonData = jsonData.Replace("'", "''");
//            BaseClass objObject = JsonConvert.DeserializeObject<BaseClass>(jsonData, settings);

//            if (authorization == null)
//            {
//                context.ErrorResult = (IHttpActionResult)new AuthenticationFailureResult("Missing Authorization Header", request);
//                return;
//            }
//            if (authorization.Scheme != "Bearer")
//            {
//                context.ErrorResult = (IHttpActionResult)new AuthenticationFailureResult("Invalid Authorization Scheme", request);
//                return;
//            }

//            if (String.IsNullOrEmpty(authorization.Parameter))
//            {
//                context.ErrorResult = (IHttpActionResult)new AuthenticationFailureResult("Missing Token", request);
//                return;
//            }



//            string API_Key = string.Empty;
//            if (request.Headers.Contains("API_Key"))
//            {
//                IEnumerable<string> headerValues = request.Headers.GetValues("API_Key");
//                API_Key = headerValues.FirstOrDefault();
//            }

//            if (API_Key == "")
//            {
//                context.ErrorResult = (IHttpActionResult)new AuthenticationFailureResult("API Key is null.Please pass API Key", request);
//            }
//            else
//            {
//                string API_Key_Check = "3C25F265-F86D-419D-9A04-EA74A503C197"; //ObjVariable.StrAPI_Key;
//                if (API_Key == API_Key_Check)
//                {
//                    context.Principal = TokenManager.GetPrincipal(authorization.Parameter, objObject.Useragent, objObject.Userip);
//                    if (context.Principal == null)
//                    {
//                        context.ErrorResult = (IHttpActionResult)new AuthenticationFailureResult("Unauthorized Access", request);
//                    }
//                }
//                else
//                {
//                    context.ErrorResult = (IHttpActionResult)new AuthenticationFailureResult("API key is invalid", request);
//                }
//            }
//        }

//        public async Task ChallengeAsync(HttpAuthenticationChallengeContext context, CancellationToken cancellationToken)
//        {
//            var result = await context.Result.ExecuteAsync(cancellationToken);
//            if (result.StatusCode == HttpStatusCode.Unauthorized)
//            {
//                result.Headers.WwwAuthenticate.Add(new AuthenticationHeaderValue("Basic", "realm=localhost"));
//            }
//            context.Result = new ResponseMessageResult(result);
//        }

//        public class AuthenticationFailureResult 
//        {
//            public string ReasonPhrase = string.Empty;
//            public HttpRequestMessage Request { get; set; }

//            public AuthenticationFailureResult(string reasonphrase, HttpRequestMessage request)
//            {
//                ReasonPhrase = reasonphrase;
//                Request = request;
//            }
//            public Task<ApiResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
//            {
//                return Task.FromResult(Execute());
//            }

//            public ApiResponseMessage Execute()
//            {
//                ApiResponseMessage response = new ApiResponseMessage();

//                response.Status_Code = (int)HttpStatusCode.Unauthorized;
//                response.Message = "Token Expired";
//                response.Success = false;
//                response.Method_Name = Request.GetActionDescriptor().ActionName;
//                response.Data = new { Message = ReasonPhrase };
//                response.Model_State = null;
//                return (response);

//            }



//        }

//    }
//}