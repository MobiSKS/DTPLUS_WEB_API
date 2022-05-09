﻿using HPCL.DataRepository.DBDapper;
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
            //var jsonInput = Newtonsoft.Json.JsonConvert.SerializeObject(input);
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

        public static IActionResult Fail(this ControllerBase controller, object input, object data, ILogger logger)
        {
            //var jsonInput = Newtonsoft.Json.JsonConvert.SerializeObject(input);
            string MethodName = controller.ControllerContext.ActionDescriptor.ActionName;
            string MessageStr = StatusInformation.Fail.GetDisplayName().ToString();

            ApiResponseMessage response = new ApiResponseMessage
            {
                Message = MessageStr,
                Success = false,
                Internel_Status_Code = (int)StatusInformation.Fail,
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

            if (Message == "Vehicle No. already exists. Please enter different Vehicle No.")
            {
                ResponseMessage = StatusInformation.Vechile_No.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Vechile_No;
            }

            if (Message == "Invalid Approval Status")
            {
                ResponseMessage = StatusInformation.Invalid_Approval_Status.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Invalid_Approval_Status;
            }

            if (Message == "Invalid Status Found")
            {
                ResponseMessage = StatusInformation.Invalid_Status_Found.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Invalid_Status_Found;
            }

            if (Message == "You can create only one or two terminal at the time of merchant creation")
            {
                ResponseMessage = StatusInformation.Terminal_Creation.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Terminal_Creation;
            }


            if (Message == "ErpCode is already registered")
            {
                ResponseMessage = StatusInformation.ErpCode_already_registered.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.ErpCode_already_registered;
            }

            if (Message == "MerchantId is already registered")
            {
                ResponseMessage = StatusInformation.Merchant_already_registered.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Merchant_already_registered;
            }
           
            if (Message == "Failed due to one time transcation limit")
            {
                ResponseMessage = StatusInformation.Failed_due_to_one_time_Transcation_limit.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Failed_due_to_one_time_Transcation_limit;
            }

            if (Message == "Failed due to day transcation limit")
            {
                ResponseMessage = StatusInformation.Failed_due_to_day_transcation_limit.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Failed_due_to_day_transcation_limit;
            }

            if (Message == "Failed due to monthly transcation limit")
            {
                ResponseMessage = StatusInformation.Failed_due_to_monthly_transcation_limit.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Failed_due_to_monthly_transcation_limit;
            }


            if (Message == "Failed due to transcation error")
            {
                ResponseMessage = StatusInformation.Failed_due_to_transcation_error.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Failed_due_to_transcation_error;
            }


            if (Message == "Failed due to insufficient balance in card")
            {
                ResponseMessage = StatusInformation.Failed_due_to_insufficient_balance_in_card.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Failed_due_to_insufficient_balance_in_card;
            }


            if (Message == "Failed due to one time CCCMS limit")
            {
                ResponseMessage = StatusInformation.Failed_due_to_one_time_CCCMS_limit.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Failed_due_to_one_time_CCCMS_limit;
            }

            if (Message == "Failed due to daily CCCMS limit")
            {
                ResponseMessage = StatusInformation.Failed_due_to_daily_CCCMS_limit.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Failed_due_to_daily_CCCMS_limit;
            }

            if (Message == "Failed due to monthly CCCMS limit")
            {
                ResponseMessage = StatusInformation.Failed_due_to_monthly_CCCMS_limit.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Failed_due_to_monthly_CCCMS_limit;
            }

            if (Message == "Failed due to yearly CCCMS limit")
            {
                ResponseMessage = StatusInformation.Failed_due_to_yearly_CCCMS_limit.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Failed_due_to_yearly_CCCMS_limit;
            }


            if (Message == "Invalid sale type")
            {
                ResponseMessage = StatusInformation.Invalid_sale_type.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Invalid_sale_type;
            }


            if (Message == "Officer is not active")
            {
                ResponseMessage = StatusInformation.Officer_is_not_active.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Officer_is_not_active;
            }

            if (Message == "Customer is not active")
            {
                ResponseMessage = StatusInformation.Customer_is_not_active.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Customer_is_not_active;
            }


            if (Message == "Service is not active at this card")
            {
                ResponseMessage = StatusInformation.Service_is_not_active_at_this_card.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Service_is_not_active_at_this_card;
            }


            if (Message == "Service is not active at this merchant")
            {
                ResponseMessage = StatusInformation.Service_is_not_active_at_this_merchant.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Service_is_not_active_at_this_merchant;
            }


            if (Message == "Card is not active")
            {
                ResponseMessage = StatusInformation.Card_is_not_active.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Card_is_not_active;
            }

            if (Message == "Terminal is not active")
            {
                ResponseMessage = StatusInformation.Terminal_is_not_active.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Terminal_is_not_active;
            }

            if (Message == "Merchant is not active")
            {
                ResponseMessage = StatusInformation.Merchant_is_not_active.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Merchant_is_not_active;
            }

            if (Message == "Details no found")
            {
                ResponseMessage = StatusInformation.Details_no_found.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Details_no_found;
            }

            if (Message == "RBE ID or RBE Name does not exist")
            {
                ResponseMessage = StatusInformation.RBE_ID_or_RBE_Name_does_not_exist.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.RBE_ID_or_RBE_Name_does_not_exist;
            }

            if (Message == "Customer Reference no not found")
            {
                ResponseMessage = StatusInformation.Customer_Reference_no_not_found.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Customer_Reference_no_not_found;
            }

            if (Message == "Form Number already exists")
            {
                ResponseMessage = StatusInformation.Form_Number_is_already_exits.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Form_Number_is_already_exits;
            }

            if (Message == "Pancard is already exits")
            {
                ResponseMessage = StatusInformation.Pancard_is_already_present.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Pancard_is_already_present;
            }

            if (Message == "Mobile No. already exists. Please enter different Mobile No.")
            {
                ResponseMessage = StatusInformation.Mobile_No_is_already_present_Please_pass_different_Mobileno.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Mobile_No_is_already_present_Please_pass_different_Mobileno;
            }

            if (Message == "Card No is already present.Please pass different Card no")
            {
                ResponseMessage = StatusInformation.Card_No_is_already_present_Please_pass_different_Cardno.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Card_No_is_already_present_Please_pass_different_Cardno;
            }

            if (Message == "No any card is available for mapping")
            {
                ResponseMessage = StatusInformation.No_any_card_is_available_for_mapping.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.No_any_card_is_available_for_mapping;
            }

            if (Message == "Please try again")
            {
                ResponseMessage = StatusInformation.Please_try_again.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Please_try_again;
            }

            if (Message == "Not found")
            {
                ResponseMessage = StatusInformation.Not_found.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Not_found;
            }

            if (Message == "Trans Type Mismatched")
            {
                ResponseMessage = StatusInformation.Trans_Type_Mismatched.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Trans_Type_Mismatched;
            }

            if (Message == "Batch Already Settled")
            {
                ResponseMessage = StatusInformation.Batch_Already_Settled.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Batch_Already_Settled;
            }

            if (Message == "Transaction Mismatched")
            {
                ResponseMessage = StatusInformation.Transaction_Mismatched.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Transaction_Mismatched;
            }

            if (Message == "Zonal Office not found")
            {
                ResponseMessage = StatusInformation.Zonal_Office_not_found.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Zonal_Office_not_found;
            }

            if (Message == "Regional Office not found")
            {
                ResponseMessage = StatusInformation.Regional_Office_not_found.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Regional_Office_not_found;
            }

            if (Message == "Country Region not found")
            {
                ResponseMessage = StatusInformation.Country_Region_not_found.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Country_Region_not_found;
            }

            if (Message == "State not found")
            {
                ResponseMessage = StatusInformation.State_not_found.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.State_not_found;
            }

            if (Message == "District not found")
            {
                ResponseMessage = StatusInformation.District_not_found.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.District_not_found;
            }

            if (Message == "City not found")
            {
                ResponseMessage = StatusInformation.City_not_found.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.City_not_found;
            }

            if (Message == "Country not found")
            {
                ResponseMessage = StatusInformation.Country_not_found.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Country_not_found;
            }

            if (Message == "Country Zone not found")
            {
                ResponseMessage = StatusInformation.Country_Zone_not_found.GetDisplayName().ToString();
                IntResponseMessage = (int)StatusInformation.Country_Zone_not_found;
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
            string MessageStr = StatusInformation.Fail.GetDisplayName().ToString();
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