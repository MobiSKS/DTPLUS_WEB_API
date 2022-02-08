﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HPCL.Infrastructure.CommonClass
{
    public class StatusMessage
    {
        public enum StatusInformation
        {
            [Display(Name = "Record Found")] Success = 1000,
            [Display(Name = "Record Not Found")] Fail = 1001,
            [Display(Name = "API Key and Secret Key is null.Please Pass API Key and Secret Key")] API_Key_Secret_Key_Is_Null = 1002,
            [Display(Name = "API Key is Null.Please Pass API Key")] API_Key_Is_Null = 1003,
            [Display(Name = "Secret Key is Null.Please pass Secret Key")] Secret_Key_Is_Null = 1004,
            [Display(Name = "Please Try Again")] Internel_Error = 1005,
            [Display(Name = "API Key or Secret Key is Invalid")] API_Key_Is_Secret_Key_Invalid = 1006,
            [Display(Name = "API Key is Invalid")] API_Key_Is_Invalid = 1007,
            [Display(Name = "Secret Key is Invalid")] Secret_Key_Is_Invalid = 1008,
            [Display(Name = "Exception Code")] Exception_Code = 1009,
            [Display(Name = "Enter 10 Digit Mobile Number")] Enter_10_Digit_Mobile_Number = 1010,
            [Display(Name = "Non Numeric Value")] Non_Numeric_Value = 1011,
            [Display(Name = "Mobile Number Start With 6,7,8,9")] Mobile_Number_Start_With_6_7_8_9 = 1012,
            [Display(Name = "Mobile Number Card Already Exists")] Mobile_Number_Card_Already_Exists = 1013,
            [Display(Name = "Customer Id Already Exists")] Customer_Id_Already_Exists = 1014,
            [Display(Name = "Customer Type is Not Match With Our Master")] Customer_Type_Is_Not_Match_With_Our_Master = 1015,
            [Display(Name = "User Agent or User IP or User Id is Null")] User_Agentor_User_IP_User_Id_is_null = 1016,
            [Display(Name = "Request JSON Body Is Null")] Request_JSON_Body_Is_Null = 1017,
            [Display(Name = "Role Created Successfully")] Success_Message_Manage_Role_Creation = 1018,
            [Display(Name = "Role Added or Edited Successfully")] Success_Message_Add_Edit_Manage_Role_Creation = 1019,
            [Display(Name = "HPCL User Location Role Created Successfully")] Success_Message_Hpcl_User_Loc_Role_Creation = 1020,
            [Display(Name = "Admin User Approved Successfully")] Success_Message_Approve_Admin_User = 1021,
            [Display(Name = "Mail Sent Succesfully")] Success_Message_Forgot_Password = 1022,
            [Display(Name = "Logout Successfully")] Success_Message_Change_Password = 1023,
            [Display(Name = "Card Added Successfully")] Success_ADD_CARD = 1024,
            [Display(Name = "Manadatory Feild Required")] Manadatory_Feild_Required = 1025,
            [Display(Name = "Database Response")] Database_Response = 1026,
            [Display(Name = "User was deactivated")] User_deactivate = 1027,
            [Display(Name = "Customer was deactivate")] Customer_deactivate = 1028,
            [Display(Name = "Merchant was deactivate")] Merchant_deactivate = 1029,
            [Display(Name = "Transaction Success")] Transaction_Success = 1030,
            [Display(Name = "Transaction Failed")] Transaction_Failed = 1031,
            [Display(Name = "Vechile No is already present.Please pass different vechile no")] Vechile_No = 1032,
            [Display(Name = "Email Id is already exits")] Email_Id_is_already_present = 1033,
            [Display(Name = "Username or Emp Id is already exits")] Username_or_Emp_Id_is_already_exits = 1034,
            [Display(Name = "Officer not exits")] Officer_not_exits = 1035,
            [Display(Name = "Location already mapped")] Location_already_mapped = 1036,
            [Display(Name = "Location not exits")] Location_not_exits = 1037,
            [Display(Name = "Username available")] Username_available = 1038,
            [Display(Name = "Username exits")] Username_exits = 1039,
            [Display(Name = "Customer not found")] Customer_not_found = 1040,
            [Display(Name = "Card Not Found")] Card_Not_Found = 1041,
            [Display(Name = "Invalid Approval Status")] Invalid_Approval_Status = 1042,
            [Display(Name = "Invalid Status Found")] Invalid_Status_Found = 1043,
            [Display(Name = "You can create only one or two terminal at the time of merchant creation")] Terminal_Creation = 1044,
            [Display(Name = "ErpCode is already registered")] ErpCode_already_registered = 1045,
            [Display(Name = "Merchant is already registered")] Merchant_already_registered = 1046,

            [Display(Name = "Failed due to one time transcation limit")] Failed_due_to_one_time_Transcation_limit = 1047,
            [Display(Name = "Failed due to day transcation limit")] Failed_due_to_day_transcation_limit = 1048,
            [Display(Name = "Failed due to monthly transcation limit")] Failed_due_to_monthly_transcation_limit = 1049,
            [Display(Name = "Failed due to transcation error")] Failed_due_to_transcation_error = 1050,
            [Display(Name = "Failed due to insufficient balance in card")] Failed_due_to_insufficient_balance_in_card = 1051,
            [Display(Name = "Failed due to one time CCCMS limit")] Failed_due_to_one_time_CCCMS_limit = 1052,
            [Display(Name = "Failed due to daily CCCMS limit")] Failed_due_to_daily_CCCMS_limit = 1053,
            [Display(Name = "Failed due to monthly CCCMS limit")] Failed_due_to_monthly_CCCMS_limit = 1055,
            [Display(Name = "Failed due to yearly CCCMS limit")] Failed_due_to_yearly_CCCMS_limit = 1056,
            [Display(Name = "Invalid sale type")] Invalid_sale_type = 1057,
            [Display(Name = "Customer is not active")] Customer_is_not_active = 1058,
            [Display(Name = "Service is not active at this card")] Service_is_not_active_at_this_card = 1059,
            [Display(Name = "Service is not active at this merchant")] Service_is_not_active_at_this_merchant = 1060,
            [Display(Name = "Card is not active")] Card_is_not_active = 1061,
            [Display(Name = "Terminal is not active")] Terminal_is_not_active = 1062,
            [Display(Name = "Merchant is not active")] Merchant_is_not_active = 1063,
            None = int.MaxValue
        }

    }
}