using HPCL.DataModel.RBE;
using HPCL.DataRepository.RBE;
using HPCL.Infrastructure.CommonClass;
using HPCL_WebApi.ActionFilters;
using HPCL_WebApi.ExtensionMethod;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HPCL_WebApi.Controllers
{
    [Route("api/dtplus/RBE")]
    [ApiController]
    public class RBEController : ControllerBase
    {
        private readonly ILogger<RBEController> _logger;

        private readonly IRBERepository _RBERepo;
        public RBEController(ILogger<RBEController> logger, IRBERepository RBERepo)
        {
            _logger = logger;
            _RBERepo = RBERepo;
        }
        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("change_rbe_mapping")]
        public async Task<IActionResult> ChangeRBEMapping([FromBody] ChangeRBEMappingModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _RBERepo.ChangeRBEMapping(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<ChangeRBEMappingModelOutput> item = result.Cast<ChangeRBEMappingModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("manage_rbe_user")]
        public async Task<IActionResult> ManageRBEUser([FromBody] ManageRBEUserModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _RBERepo.ManageRBEUser(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<ManageRBEUserModelOutput> item = result.Cast<ManageRBEUserModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_pending_rbe_consent")]
        public async Task<IActionResult> GetPendingRbeConsent([FromBody] GetPendingRbeConsentModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _RBERepo.GetPendingRbeConsent(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<GetPendingRbeConsentModelOutput> item = result.Cast<GetPendingRbeConsentModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("rbe_sent_otp_forgot_password")]
        public async Task<IActionResult> RbeSentOtpForgotPassword([FromBody] RbeSentOtpForgotPasswordModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _RBERepo.RbeSentOtpForgotPassword(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<RbeSentOtpForgotPasswordModelOutput> item = result.Cast<RbeSentOtpForgotPasswordModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("rbe_validate_forgot_password")]
        public async Task<IActionResult> RbeValidateForgotPassword([FromBody] RbeValidateForgotPasswordModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _RBERepo.RbeValidateForgotPassword(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<RbeValidateForgotPasswordModelOutput> item = result.Cast<RbeValidateForgotPasswordModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_rbe_dashboard")]
        public async Task<IActionResult> GetRbeDashboard([FromBody] GetRbeDashboardModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _RBERepo.GetRbeDashboard(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<GetRbeDashboardModelOutput> item = result.Cast<GetRbeDashboardModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_new_rbe_add_cards")]
        public async Task<IActionResult> GetNewRbeAddCards([FromBody] GetNewRbeAddCardsModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _RBERepo.GetNewRbeAddCards(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<GetNewRbeAddCardsModelOutput> item = result.Cast<GetNewRbeAddCardsModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_new_rbe_enroll_customers")]
        public async Task<IActionResult> GetNewRbeEnrollCustomers([FromBody] GetNewRbeEnrollCustomersModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _RBERepo.GetNewRbeEnrollCustomers(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<GetNewRbeEnrollCustomersModelOutput> item = result.Cast<GetNewRbeEnrollCustomersModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
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
                var result = await _RBERepo.GetRBEId(ObjClass);
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
        [Route("rbe_sent_otp_new_enroll_customer")]
        public async Task<IActionResult> RbeSentOtpNewEnrollCustomer([FromBody] RbeSentOtpNewEnrollCustomerModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _RBERepo.RbeSentOtpNewEnrollCustomer(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<RbeSentOtpNewEnrollCustomerModelOutput> item = result.Cast<RbeSentOtpNewEnrollCustomerModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("rbe_validate_otp_new_enroll_customer")]
        public async Task<IActionResult> RbeValidateOtpNewEnrollCustomer([FromBody] RbeValidateOtpNewEnrollCustomerModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _RBERepo.RbeValidateOtpNewEnrollCustomer(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<RbeValidateOtpNewEnrollCustomerModelOutput> item = result.Cast<RbeValidateOtpNewEnrollCustomerModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("bind_rbe_by_rbe_id")]
        public async Task<IActionResult> BindRBEbyRBEId([FromBody] BindRBEModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _RBERepo.BindRBEbyRBEId(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<BindRBEModelOutput> item = result.Cast<BindRBEModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("insert_rbe")]
        public async Task<IActionResult> InsertRBEOfficer([FromBody] InsertRBEModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _RBERepo.InsertRBE(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<InsertRBEModelOutput>().ToList()[0].Status == 1)
                    {

                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger, result.Cast<InsertRBEModelOutput>().ToList()[0].Reason);
                    }
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("update_rbe")]
        public async Task<IActionResult> UpdateRBEOfficer([FromBody] RBEUpdateModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _RBERepo.UpdateRBE(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<RBEUpdateModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<RBEUpdateModelOutput>().ToList()[0].Reason);
                    }

                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("upload_officer_kyc")]
        public async Task<IActionResult> UploadOfficerKYC([FromForm] RBEKYCModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _RBERepo.UploadRBEKYC(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<RBEKYCModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<RBEKYCModelOutput>().ToList()[0].Reason);
                    }

                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("check_rbe_mobile_no")]
        public async Task<IActionResult> CheckRBEMobileNo([FromBody] GetRBEMobilenoModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _RBERepo.CheckRBEMobileNo(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<GetRBEMobilenoModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<GetRBEMobilenoModelOutput>().ToList()[0].Reason);
                    }
                }
            }
        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("bind_rbe_detail")]
        public async Task<IActionResult> BindRBEDetail([FromBody] GetRBECreationApprovalModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _RBERepo.BindRBEDetail(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<GetRBECreationApprovalModelOutput> item = result.Cast<GetRBECreationApprovalModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_rbe_detail_by_user_name")]
        public async Task<IActionResult> GetRBEDetailbyUserName([FromBody] GetRBEDetailbyUserNameModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _RBERepo.GetRBEDetailbyUserName(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<GetRBEDetailbyUserNameModelOutput> item = result.Cast<GetRBEDetailbyUserNameModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("approve_reject_rbe")]
        public async Task<IActionResult> ApproveRejectRBE([FromBody] RBEApprovalRejectModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _RBERepo.ApproveRejectRBE(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<RBEApprovalRejectApprovalModelOutput>().ToList()[0].Status == 1)
                    {

                        string EmailSubject = "<p>Hi <b>" + result.Cast<RBEApprovalRejectApprovalModelOutput>().ToList()[0].FirstName + " "
                            + result.Cast<RBEApprovalRejectApprovalModelOutput>().ToList()[0].LastName + "<b></br> User Name : "
                               + ObjClass.UserName + " </br> Password : " + result.Cast<RBEApprovalRejectApprovalModelOutput>().ToList()[0].RBEOTP + " </p>";

                        Variables.FunSendMail(result.Cast<RBEApprovalRejectApprovalModelOutput>().ToList()[0].EmailId, EmailSubject, "RBE Details");

                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<RBEApprovalRejectApprovalModelOutput>().ToList()[0].Reason);
                    }
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("rbe_deviceid_reset_request")]
        public async Task<IActionResult> RBEDeviceIdResetRequest([FromBody] RBEDeviceIdResetRequestModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _RBERepo.RBEDeviceIdResetRequest(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<RBEDeviceIdResetRequestModelOutput> item = result.Cast<RBEDeviceIdResetRequestModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("rbe_mobile_change_request")]
        public async Task<IActionResult> RBEMobileChangeRequest([FromBody] RBEMobileChangeRequestModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _RBERepo.RBEMobileChangeRequest(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<RBEMobileChangeRequestModelOutput> item = result.Cast<RBEMobileChangeRequestModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("approve_reject_customer")]
        public async Task<IActionResult> RequestToChangeRBEMapping([FromBody] RequestToChangeRBEMappingModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _RBERepo.RequestToChangeRBEMapping(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<RequestToChangeRBEMappingModelOutput>().ToList()[0].Status == 1)
                    {                            
                        //    Variables.SendSMS(2, "1007862494411670929", result.Cast<RequestToChangeRBEMappingModelOutput>().ToList()[0].CommunicationMobileNo,
                        //         ObjClass.ApprovedBy, result.Cast<RequestToChangeRBEMappingModelOutput>().ToList()[0].CustomerID,
                        //         result.Cast<RequestToChangeRBEMappingModelOutput>().ToList()[0].ControlCardNo);               

                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<RequestToChangeRBEMappingModelOutput>().ToList()[0].Reason);
                    }
                }
            }
        }
    }
}
