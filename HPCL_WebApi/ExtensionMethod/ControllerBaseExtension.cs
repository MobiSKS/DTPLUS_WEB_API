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
            string MethodName = controller.ControllerContext.ActionDescriptor.ActionName;
            string MessageStr = StatusInformation.Success.ToString();
            ApiResponseMessage response = new ApiResponseMessage
            {
                Message = MessageStr,
                Success = true,
                Internel_Status_Code = (int)StatusInformation.Success,
                Status_Code = controller.Ok().StatusCode,
                Data = data,
                Method_Name = MethodName
            };
           // logger.LogInformation(MethodName + " :: JSON INPUT " + jsonInput.ToString() + ":" + MessageStr);
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

            if (Message == "Customer Id is already registered")
            {
                ResponseMessage = StatusInformation.Customer_Id_Already_Exists.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Customer_Id_Already_Exists;
            }

            if (Message == "Please enter 10 digit mobile number")
            {
                ResponseMessage = StatusInformation.Enter_10_Digit_Mobile_Number.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Enter_10_Digit_Mobile_Number;
            }


            if (Message == "Please check - non numeric value")
            {
                ResponseMessage = StatusInformation.Non_Numeric_Value.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Non_Numeric_Value;
            }

            if (Message == "Invalid mobile number.Please pass valid mobile number")
            {
                ResponseMessage = StatusInformation.Mobile_Number_Start_With_6_7_8_9.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Mobile_Number_Start_With_6_7_8_9;
            }

            if (Message == "Customer not found")
            {
                ResponseMessage = StatusInformation.Customer_not_found.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Customer_not_found;
            }

            if (Message == "Card Not Found")
            {
                ResponseMessage = StatusInformation.Card_Not_Found.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Card_Not_Found;
            }

            //var jsonInput = Newtonsoft.Json.JsonConvert.SerializeObject(input);
            //string MethodName = controller.ControllerContext.ActionDescriptor.ActionName;
            //string MessageStr = ResponseMessage;

            ApiResponseMessage response = new ApiResponseMessage
            {
                Message = ResponseMessage,
                Success = false,
                Internel_Status_Code = IntResponseMessage,
                Status_Code = controller.Ok().StatusCode,
                Data = data,
                Method_Name = controller.ControllerContext.ActionDescriptor.ActionName
            };
          //  logger.LogInformation(MethodName + " :: JSON INPUT " + jsonInput.ToString() + ":" + MessageStr);
            return controller.Ok(response);
        }
        public static IActionResult BadRequestCustom(this ControllerBase controller, object input, object data, ILogger logger)
        {
            //var jsonInput = Newtonsoft.Json.JsonConvert.SerializeObject(input);
            //string MethodName = controller.ControllerContext.ActionDescriptor.ActionName;
            string MessageStr = StatusInformation.Request_JSON_Body_Is_Null.ToString();

            ApiResponseMessage response = new ApiResponseMessage
            {
                Message = MessageStr,
                Success = false,
                Internel_Status_Code = (int)StatusInformation.Request_JSON_Body_Is_Null,
                Status_Code = controller.BadRequest().StatusCode,
                Data = data,
                Method_Name = controller.ControllerContext.ActionDescriptor.ActionName
            };
           // logger.LogInformation(MethodName + " :: JSON INPUT " + jsonInput.ToString() + ":" + MessageStr);
            return controller.BadRequest(response);

        }
        public static IActionResult NotFoundCustom(this ControllerBase controller, object input, object data, ILogger logger)
        {
            var jsonInput = Newtonsoft.Json.JsonConvert.SerializeObject(input);
            string MethodName = controller.ControllerContext.ActionDescriptor.ActionName;
            string MessageStr = StatusInformation.Fail.ToString();
            ApiResponseMessage response = new ApiResponseMessage
            {
                Message = MessageStr,
                Success = false,
                Status_Code = controller.NotFound().StatusCode,
                Internel_Status_Code = (int)StatusInformation.Fail,
                Data = data,
                Method_Name = controller.ControllerContext.ActionDescriptor.ActionName
            };
           // logger.LogInformation(MethodName + " :: JSON INPUT " + jsonInput.ToString() + ":" + MessageStr);
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
           // logger.LogInformation(response.Method_Name + " :: JSON INPUT " + jsonInput.ToString() + ":" + response.Message);
            return controller.Ok(response);

        }
        public static IActionResult BadRequestToken(this ControllerBase controller, ILogger logger, object input)
        {
            var jsonInput = Newtonsoft.Json.JsonConvert.SerializeObject(input);
            string MethodName = controller.ControllerContext.ActionDescriptor.ActionName;
            string MessageStr = StatusInformation.Request_JSON_Body_Is_Null.ToString();
            ReturnGenerateTokenStatusOutput response = new ReturnGenerateTokenStatusOutput
            {
                Message = MessageStr,
                Method_Name = controller.ControllerContext.ActionDescriptor.ActionName,
                Status_Code = controller.BadRequest().StatusCode,
                Internel_Status_Code = (int)StatusInformation.Request_JSON_Body_Is_Null,
                Success = false,
                Token = string.Empty,
                Model_State = controller.ModelState
            };
           // logger.LogInformation(MethodName + " :: JSON INPUT " + jsonInput.ToString() + ":" + MessageStr);
            return controller.BadRequest(response);

        }
    }
}