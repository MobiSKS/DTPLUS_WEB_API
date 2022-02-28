﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using HPCL_WebApi.ExtensionMethod;
using HPCL_WebApi.ActionFilters;
using HPCL.DataModel.Customer;
using System.Linq;
using HPCL.DataRepository.Customer;
using HPCL.Infrastructure.CommonClass;

namespace HPCL_WebApi.Controllers
{

    [ApiController]
    [Route("/api/dtplus/customer")]
    public class CustomerController : ControllerBase
    {
        private readonly ILogger<CustomerController> _logger;

        private readonly ICustomerRepository _customerRepo;
        public CustomerController(ILogger<CustomerController> logger, ICustomerRepository customerRepo)
        {
            _logger = logger;
            _customerRepo = customerRepo;
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_customer_type")]
        public async Task<IActionResult> GetCustomerType([FromBody] GetCustomerTypeModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _customerRepo.GetCustomerType(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    return this.OkCustom(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_customer_sub_type")]
        public async Task<IActionResult> GetCustomerSubType([FromBody] GetCustomerSubTypeModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _customerRepo.GetCustomerSubType(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    return this.OkCustom(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_tbentity_name")]
        public async Task<IActionResult> GetTBEntityName([FromBody] GetCustomerTBEntityNameModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _customerRepo.GetTBEntityName(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    return this.OkCustom(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_secret_question")]
        public async Task<IActionResult> GetSecretQuestion([FromBody] GetCustomerSecretQuestionModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _customerRepo.GetSecretQuestion(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    return this.OkCustom(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_type_of_fleet")]
        public async Task<IActionResult> GetTypeOfFleet([FromBody] GetCustomerTypeOfFleetModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _customerRepo.GetTypeOfFleet(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    return this.OkCustom(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("insert_customer")]
        public async Task<IActionResult> InsertCustomer([FromBody] CustomerInsertModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _customerRepo.InsertCustomer(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<CustomerInsertModelOutput>().ToList()[0].Status == 1)
                    {

                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<CustomerInsertModelOutput>().ToList()[0].Reason);
                    }
                }
            }
        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("update_customer")]
        public async Task<IActionResult> UpdateCustomer([FromBody] CustomerUpdateModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _customerRepo.UpdateCustomer(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<CustomerUpdateModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<CustomerUpdateModelOutput>().ToList()[0].Reason);
                    }
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("view_online_form_status")]
        public async Task<IActionResult> ViewOnlineFormStatus([FromBody] CustomerViewOnlineFormStatusModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                if (ObjClass == null)
                {
                    return this.BadRequestCustom(ObjClass, null, _logger);
                }
                else
                {
                    var result = await _customerRepo.ViewOnlineFormStatus(ObjClass);
                    if (result == null)
                    {
                        return this.NotFoundCustom(ObjClass, null, _logger);
                    }
                    else
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                }
            }
        }

        [HttpPost]
        //[ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("upload_customer_kyc")]
        public async Task<IActionResult> UploadCustomerKYC([Microsoft.AspNetCore.Mvc.FromForm] CustomerKYCModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _customerRepo.UploadCustomerKYC(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<CustomerKYCModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<CustomerKYCModelOutput>().ToList()[0].Reason);
                    }

                }
            }
        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("approve_reject_customer")]
        public async Task<IActionResult> ApproveRejectCustomer([FromBody] CustomerApprovalModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _customerRepo.ApproveRejectCustomer(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<CustomerApprovalModelOutput>().ToList()[0].Status == 1)
                    {
                        if (result.Cast<CustomerApprovalModelOutput>().ToList()[0].SendStatus == 4)
                        {
                            string EmailSubject = "<p>Hi <b>" + result.Cast<CustomerApprovalModelOutput>().ToList()[0].FirstName + " "
                                + result.Cast<CustomerApprovalModelOutput>().ToList()[0].LastName + "<b></br> User Name : "
                                + result.Cast<CustomerApprovalModelOutput>().ToList()[0].CustomerID + " </br> Password : "
                                + result.Cast<CustomerApprovalModelOutput>().ToList()[0].Password + " </p>";

                            Variables.SendSMS(2, "1007862494411670929", result.Cast<CustomerApprovalModelOutput>().ToList()[0].CommunicationMobileNo,
                                 ObjClass.ApprovedBy, result.Cast<CustomerApprovalModelOutput>().ToList()[0].CustomerID,
                                 result.Cast<CustomerApprovalModelOutput>().ToList()[0].ControlCardNo);

                            Variables.FunSendMail(result.Cast<CustomerApprovalModelOutput>().ToList()[0].EmailId, EmailSubject, "Customer Details");
                        }


                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<CustomerApprovalModelOutput>().ToList()[0].Reason);
                    }
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_vehicle_type")]
        public async Task<IActionResult> GetVehicleType([FromBody] CustomerGetVehicleTypeModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _customerRepo.GetVehicleType(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    return this.OkCustom(ObjClass, result, _logger);
                }
            }
        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("approve_reject_fee_waiver")]
        public async Task<IActionResult> ApproveRejectFeewaiver([FromBody] CustomerFeewaiverApprovalModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _customerRepo.ApproveRejectFeewaiver(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<CustomerFeewaiverApprovalModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<CustomerFeewaiverApprovalModelOutput>().ToList()[0].Reason);
                    }
                }
            }
        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_approve_fee_waiver_detail")]
        public async Task<IActionResult> GetApproveFeeWaiverDetail([FromBody] GetApproveFeeWaiverDetailModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _customerRepo.GetApproveFeeWaiverDetail(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    return this.OkCustom(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_name_and_form_number_by_reference_no")]
        public async Task<IActionResult> GetNameandFormNumberbyReferenceNo([FromBody] CustomerGetCustomerReferenceNoModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _customerRepo.GetNameandFormNumberbyReferenceNo(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    return this.OkCustom(ObjClass, result, _logger);
                }
            }
        }



        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_customer_by_customer_id")]
        public async Task<IActionResult> GetCustomerByCustomerId([FromBody] CustomerGetByCustomerIdModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _customerRepo.GetCustomerByCustomerId(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    return this.OkCustom(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_customer_detail")]
        public async Task<IActionResult> GetCustomerDetails([FromBody] CustomerDetailsModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _customerRepo.GetCustomerDetails(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    return this.OkCustom(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_raw_customer_detail")]
        public async Task<IActionResult> GetRawCustomerDetails([FromBody] CustomerDetailsModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _customerRepo.GetRawCustomerDetails(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    return this.OkCustom(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_rbe_id")]
        public async Task<IActionResult> GetRBEId([FromBody] RBEGetModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _customerRepo.GetRBEId(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<RBEGetModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<RBEGetModelOutput>().ToList()[0].Reason);
                    }
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("bind_pending_customer")]
        public async Task<IActionResult> BindPendingCustomer([FromBody] BindPendingCustomerModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _customerRepo.BindPendingCustomer(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    return this.OkCustom(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("bind_unverfied_customer")]
        public async Task<IActionResult> BindUnverfiedCustomer([FromBody] BindPendingCustomerModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _customerRepo.BindUnverfiedCustomer(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    return this.OkCustom(ObjClass, result, _logger);
                }
            }
        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("send_otp_consent")]
        public async Task<IActionResult> SendOTPConsent([FromBody] SendOTPConsentModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _customerRepo.SendOTPConsent(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    return this.OkCustom(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("validate_otp_consent")]
        public async Task<IActionResult> ValidateOTPConsent([FromBody] ValidateOTPConsentModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _customerRepo.ValidateOTPConsent(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    return this.OkCustom(ObjClass, result, _logger);
                }
            }
        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_pending_customer_detail_by_form_number")]
        public async Task<IActionResult> GetPendingCustomerDetailbyFormNumber([FromBody] CustomerDetailsbyFormNumberModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _customerRepo.GetPendingCustomerDetailbyFormNumber(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    return this.OkCustom(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_unverfied_customer_detail_by_form_number")]
        public async Task<IActionResult> GetUnverfiedCustomerDetailbyFormNumber([FromBody] CustomerDetailsbyFormNumberModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _customerRepo.GetUnverfiedCustomerDetailbyFormNumber(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    return this.OkCustom(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_form_number")]
        public async Task<IActionResult> GetFormNumber([FromBody] GetFormNumberModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _customerRepo.GetFormNumber(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    return this.OkCustom(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("check_form_number")]
        public async Task<IActionResult> CheckFormNumber([FromBody] CheckFormNumberModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _customerRepo.CheckFormNumber(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    return this.OkCustom(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("check_mobile_number")]
        public async Task<IActionResult> CheckMobileNumber([FromBody] CheckMobileNumberModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _customerRepo.CheckMobileNumber(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<CheckMobileNumberModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<CheckMobileNumberModelOutput>().ToList()[0].Reason);
                    }
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("check_email_id")]
        public async Task<IActionResult> CheckEmailId([FromBody] CheckEmailIdModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _customerRepo.CheckEmailId(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<CheckEmailIdModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<CheckEmailIdModelOutput>().ToList()[0].Reason);
                    }

                }
            }
        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_control_card_number")]
        public async Task<IActionResult> GetControlCardNumber([FromBody] GetControlCardNumberModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _customerRepo.GetControlCardNumber(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    return this.OkCustom(ObjClass, result, _logger);
                }
            }
        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("check_pan_card")]
        public async Task<IActionResult> CheckPancard([FromBody] CustomerCheckPancardModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _customerRepo.CheckPancard(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<CustomerCheckPancardModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<CustomerCheckPancardModelOutput>().ToList()[0].Reason);
                    }

                }
            }
        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_merchant_for_card_mapping")]
        public async Task<IActionResult> GetMerchantForCardMapping([FromBody] CustomerGetMerchantForCardMappingModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _customerRepo.GetMerchantForCardMapping(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    return this.OkCustom(ObjClass, result, _logger);
                }
            }
        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_card_list_from_customer_id")]
        public async Task<IActionResult> GetCardListFromCustomerId([FromBody] CustomerGetCardListFromCustomerIdModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _customerRepo.GetCardListFromCustomerId(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    return this.OkCustom(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_customer_details_for_mapping_card_merchant")]
        public async Task<IActionResult> GetCustomerDetailsForMappingCardMerchant([FromBody] CustomerGetCustomerDetailsForMappingCardMerchantModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _customerRepo.GetCustomerDetailsForMappingCardMerchant(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    return this.OkCustom(ObjClass, result, _logger);
                }
            }
        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("insert_otc_card_request")]
        public async Task<IActionResult> InsertOTCCardRequest([FromBody] CustomerCardRequestEntryModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _customerRepo.InsertOTCCardRequest(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<CustomerCardRequestEntryModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<CustomerCardRequestEntryModelOutput>().ToList()[0].Reason);
                    }

                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("insert_tatkal_card_request")]
        public async Task<IActionResult> InsertTatkalCardRequest([FromBody] CustomerCardRequestEntryModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _customerRepo.InsertTatkalCardRequest(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<CustomerCardRequestEntryModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<CustomerCardRequestEntryModelOutput>().ToList()[0].Reason);
                    }

                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("insert_driver_card_request")]
        public async Task<IActionResult> InsertDriverCardRequest([FromBody] CustomerCardRequestEntryModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _customerRepo.InsertDriverCardRequest(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<CustomerCardRequestEntryModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<CustomerCardRequestEntryModelOutput>().ToList()[0].Reason);
                    }

                }
            }
        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("add_customer_card_merchant_mapping")]
        public async Task<IActionResult> AddCustomerCardMerchantMapping([FromBody] CustomerAddCustomerCardMerchantMappingModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _customerRepo.AddCustomerCardMerchantMapping(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<CustomerAddCustomerCardMerchantMappingModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<CustomerAddCustomerCardMerchantMappingModelOutput>().ToList()[0].Reason);
                    }

                }
            }
        }

    }

}
