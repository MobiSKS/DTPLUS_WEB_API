

namespace HPCL_WebApi.ExtensionMethod
{
    using HPCL.Infrastructure.Response;
    using HPCL.Infrastructure.TokenManager;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using Microsoft.OpenApi.Extensions;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using static HPCL.Infrastructure.CommonClass.StatusMessage;

    public static class ControllerBaseExtension
    {


        public static IActionResult OkCustom(this ControllerBase controller, object data, ILogger logger)
        {
            ApiResponseMessage response = new ApiResponseMessage();
            response.Message = StatusInformation.Success.ToString();
            response.Success = true;
            response.Status_Code = controller.Ok().StatusCode;
            response.Data = data;
            logger.LogInformation(response.Method_Name + ":" + response.Message);
            return controller.Ok (response);

        }
        public static IActionResult BadRequestCustom(this ControllerBase controller ,object data , ILogger logger)
        {
            ApiResponseMessage response = new ApiResponseMessage();
            response.Message = StatusInformation.Request_JSON_Body_Is_Null.ToString();
            response.Success = false;
            response.Status_Code = controller.BadRequest().StatusCode;
            response.Data = null;
            logger.LogInformation(controller.Request.Method + ":" + response.Message);
            return controller.BadRequest(response);

        }
        public static IActionResult NotFoundCustom(this ControllerBase controller ,object data, ILogger logger)
        {
            ApiResponseMessage response = new ApiResponseMessage();
            response.Message = StatusInformation.Fail.ToString();
            response.Success = false;
            response.Status_Code = controller.NotFound().StatusCode;
            response.Data = data;
            logger.LogInformation(controller.Request.Method + ":" + response.Message);
            return controller.NotFound(response);

        }

        public static IActionResult OkToken(this ControllerBase controller, ILogger logger , GenerateTokenInput ObjClass,string MethodName)
        {
            ReturnGenerateTokenStatusOutput response = new ReturnGenerateTokenStatusOutput();
            response.Message = StatusInformation.Success.GetDisplayName();
            response.Method_Name = MethodName;
            response.Status_Code = (int)StatusInformation.Success;
            response.Success = true;
            response.Token = TokenManager.GenerateToken(ObjClass.Useragent, ObjClass.Userip);
            response.Model_State = controller.ModelState;
            logger.LogInformation(response.Method_Name + ":" + response.Message);
            return controller.Ok(response);

        }
        public static IActionResult BadRequestToken(this ControllerBase controller, ILogger logger, string MethodName,string UserMessage,long IntStatusCode)
        {
            ReturnGenerateTokenStatusOutput response = new ReturnGenerateTokenStatusOutput();
            response.Message = UserMessage;
            response.Method_Name = MethodName;
            response.Status_Code = IntStatusCode;
            response.Success = false;
            response.Token = string.Empty;
            response.Model_State = controller.ModelState;
            logger.LogInformation(MethodName + ":" + response.Message);
            return controller.BadRequest(response);

        }
    }
}
