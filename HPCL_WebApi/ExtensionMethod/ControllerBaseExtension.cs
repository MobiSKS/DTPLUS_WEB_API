namespace HPCL_WebApi.ExtensionMethod
{
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public static class ControllerBaseExtension
    {
        {
        }
        {
            ApiResponseMessage response = new ApiResponseMessage();
            response.Message = StatusInformation.Request_JSON_Body_Is_Null.ToString();
            response.Success = false;
            response.Internel_Status_Code = (int)StatusInformation.Request_JSON_Body_Is_Null;
            response.Status_Code = controller.BadRequest().StatusCode;
            response.Data = null;
            logger.LogInformation(controller.Request.Method + ":" + response.Message);
            return controller.BadRequest(response);


        }
        {
            ReturnGenerateTokenStatusOutput response = new ReturnGenerateTokenStatusOutput();
            response.Message = StatusInformation.Success.GetDisplayName();
            response.Method_Name = MethodName;
            response.Status_Code = controller.Ok().StatusCode;
            response.Internel_Status_Code = (int)StatusInformation.Success;
            response.Success = true;
            response.Token = TokenManager.GenerateToken(ObjClass.Useragent, ObjClass.Userip);
            response.Model_State = controller.ModelState;
            logger.LogInformation(response.Method_Name + ":" + response.Message);
            return controller.Ok(response);


        }
    }
}
