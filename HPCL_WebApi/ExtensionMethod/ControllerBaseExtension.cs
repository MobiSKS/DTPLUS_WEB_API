using HPCL.DataRepository.DBDapper;
using HPCL.Infrastructure.Response;
using HPCL.Infrastructure.TokenManager;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using static HPCL.Infrastructure.CommonClass.StatusMessage;
namespace HPCL_WebApi.ExtensionMethod
{
    public static class ControllerBaseExtension
    {
        public static IActionResult OkCustom(this ControllerBase controller, object input, object data, ILogger logger)
        {
            var jsonInput = Newtonsoft.Json.JsonConvert.SerializeObject(input);
            ApiResponseMessage response = new ApiResponseMessage
            {
                Message = StatusInformation.Success.ToString(),
                Success = true,
                Internel_Status_Code = (int)StatusInformation.Success,
                Status_Code = controller.Ok().StatusCode,
                Data = data,
                Method_Name = controller.ControllerContext.ActionDescriptor.ActionName
            };
            logger.LogInformation(response.Method_Name + " :: JSON INPUT " + jsonInput.ToString() + ":" + response.Message);
            return controller.Ok(response);
        }

        public static IActionResult FailCustom(this ControllerBase controller, object input, object data, ILogger logger, string Message)
        {
            string ResponseMessage = StatusInformation.Fail.GetDisplayName();
            int IntResponseMessage = (int)StatusInformation.Fail;
            if (Message == "Mobile No is already exits")
            {
                ResponseMessage = StatusInformation.Mobile_Number_Card_Already_Exists.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Mobile_Number_Card_Already_Exists;
            }
            if (Message == "Username or Emp Id is already exits")
            {
                ResponseMessage = StatusInformation.Username_or_Emp_Id_is_already_exits.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Username_or_Emp_Id_is_already_exits;
            }
            if (Message == "Email Id is already exits")
            {
                ResponseMessage = StatusInformation.Email_Id_is_already_present.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Email_Id_is_already_present;
            }

            if (Message == "Officer not exits")
            {
                ResponseMessage = StatusInformation.Officer_not_exits.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Officer_not_exits;
            }

            if (Message == "Location already mapped")
            {
                ResponseMessage = StatusInformation.Location_already_mapped.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Location_already_mapped;
            }

            if (Message == "Location not exits")
            {
                ResponseMessage = StatusInformation.Location_not_exits.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Location_not_exits;
            }

            if (Message == "Username available")
            {
                ResponseMessage = StatusInformation.Username_available.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Username_available;
            }

            if (Message == "Username exits")
            {
                ResponseMessage = StatusInformation.Username_exits.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Username_exits;
            }


            var jsonInput = Newtonsoft.Json.JsonConvert.SerializeObject(input);
            ApiResponseMessage response = new ApiResponseMessage
            {
                Message = ResponseMessage,
                Success = false,
                Internel_Status_Code = IntResponseMessage,
                Status_Code = controller.Ok().StatusCode,
                Data = data,
                Method_Name = controller.ControllerContext.ActionDescriptor.ActionName
            };
            logger.LogInformation(response.Method_Name + " :: JSON INPUT " + jsonInput.ToString() + ":" + response.Message);
            return controller.Ok(response);
        }
        public static IActionResult BadRequestCustom(this ControllerBase controller, object input, object data, ILogger logger)
        {
            var jsonInput = Newtonsoft.Json.JsonConvert.SerializeObject(input);
            ApiResponseMessage response = new ApiResponseMessage
            {
                Message = StatusInformation.Request_JSON_Body_Is_Null.ToString(),
                Success = false,
                Internel_Status_Code = (int)StatusInformation.Request_JSON_Body_Is_Null,
                Status_Code = controller.BadRequest().StatusCode,
                Data = data,
                Method_Name = controller.ControllerContext.ActionDescriptor.ActionName
            };
            logger.LogInformation(controller.Request.Method + " :: JSON INPUT " + jsonInput.ToString() + ":" + response.Message);
            return controller.BadRequest(response);

        }
        public static IActionResult NotFoundCustom(this ControllerBase controller, object input, object data, ILogger logger)
        {
            var jsonInput = Newtonsoft.Json.JsonConvert.SerializeObject(input);
            ApiResponseMessage response = new ApiResponseMessage
            {
                Message = StatusInformation.Fail.ToString(),
                Success = false,
                Status_Code = controller.NotFound().StatusCode,
                Internel_Status_Code = (int)StatusInformation.Fail,
                Data = data,
                Method_Name = controller.ControllerContext.ActionDescriptor.ActionName
            };
            logger.LogInformation(controller.Request.Method + " :: JSON INPUT " + jsonInput.ToString() + ":" + response.Message);
            return controller.NotFound(response);

        }

        public static IActionResult OkToken(this ControllerBase controller, ILogger logger, object input, GenerateTokenInput ObjClass)
        {
            var jsonInput = Newtonsoft.Json.JsonConvert.SerializeObject(input);
            ReturnGenerateTokenStatusOutput response = new ReturnGenerateTokenStatusOutput
            {
                Message = StatusInformation.Success.GetDisplayName(),
                Method_Name = controller.ControllerContext.ActionDescriptor.ActionName,
                Status_Code = controller.Ok().StatusCode,
                Internel_Status_Code = (int)StatusInformation.Success,
                Success = true,
                Token = TokenManager.GenerateToken(ObjClass.Useragent, ObjClass.Userip),
                Model_State = controller.ModelState
            };
            logger.LogInformation(response.Method_Name + " :: JSON INPUT " + jsonInput.ToString() + ":" + response.Message);
            return controller.Ok(response);

        }
        public static IActionResult BadRequestToken(this ControllerBase controller, ILogger logger, object input)
        {
            var jsonInput = Newtonsoft.Json.JsonConvert.SerializeObject(input);
            ReturnGenerateTokenStatusOutput response = new ReturnGenerateTokenStatusOutput
            {
                Message = StatusInformation.Request_JSON_Body_Is_Null.ToString(),
                Method_Name = controller.ControllerContext.ActionDescriptor.ActionName,
                Status_Code = controller.BadRequest().StatusCode,
                Internel_Status_Code = (int)StatusInformation.Request_JSON_Body_Is_Null,
                Success = false,
                Token = string.Empty,
                Model_State = controller.ModelState
            };
            logger.LogInformation(response.Method_Name + " :: JSON INPUT " + jsonInput.ToString() + ":" + response.Message);
            return controller.BadRequest(response);

        }
    }
}