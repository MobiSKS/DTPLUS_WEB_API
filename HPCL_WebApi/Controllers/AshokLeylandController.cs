using HPCL.DataModel.AshokLeyland;
using HPCL.DataRepository.AshokLeyland;
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
    [Route("api/dtplus/ashokleyland")]
    [ApiController]
    public class AshokLeylandController : ControllerBase
    {
        private readonly ILogger<AshokLeylandController> _logger;

        private readonly IAshokLeylandRepository _ALRepo;
        public AshokLeylandController(ILogger<AshokLeylandController> logger, IAshokLeylandRepository ALRepo)
        {
            _logger = logger;
            _ALRepo = ALRepo;
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("insert_al_dealer_enrollment")]
        public async Task<IActionResult> InsertALDealerEnrollment([FromBody] ALDealerEnrollmentModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _ALRepo.InsertALDealerEnrollment(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<ALDealerEnrollmentModelOutput>().ToList()[0].Status == 1)
                    {

                        string EmailSubject = "<p>Hi <b>" + ObjClass.DealerName + " <b></br> User Name : "
                            + ObjClass.DealerCode + " </br> Password : " + result.Cast<ALDealerEnrollmentModelOutput>().ToList()[0].Password + " </p>";

                        Variables.FunSendMail(ObjClass.EmailId, EmailSubject, " Details");

                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger, result.Cast<ALDealerEnrollmentModelOutput>().ToList()[0].Reason);
                    }
                }
            }
        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("update_al_dealer_enrollment")]
        public async Task<IActionResult> UpdateALDealerEnrollment([FromBody] UpdateALDealerEnrollmentModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _ALRepo.UpdateALDealerEnrollment(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<UpdateALDealerEnrollmentModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger, result.Cast<UpdateALDealerEnrollmentModelOutput>().ToList()[0].Reason);
                    }
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_al_dealer_detail")]
        public async Task<IActionResult> GetALDealerDetail([FromBody] GetDealerNameModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _ALRepo.GetALDealerDetail(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<GetDealerNameModelOutput> item = result.Cast<GetDealerNameModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("check_dealer_code")]
        public async Task<IActionResult> CheckDealerCode([FromBody] CheckDealerCodeModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _ALRepo.CheckDealerCode(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<CheckDealerCodeModelOutput> item = result.Cast<CheckDealerCodeModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("insert_al_customer")]
        public async Task<IActionResult> InsertALCustomer([FromBody] InsertALCustomerModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _ALRepo.InsertALCustomer(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<InsertALCustomerModelOutput>().ToList()[0].Status == 1)
                    {

                        string EmailSubject = "<p>Hi <b>" + ObjClass.IndividualOrgName + "</br> User Name : "
                                + result.Cast<InsertALCustomerModelOutput>().ToList()[0].CustomerID + " </br> Password : "
                                + result.Cast<InsertALCustomerModelOutput>().ToList()[0].Password + " </p>";

                        Variables.FunSendMail(ObjClass.CommunicationEmailid, EmailSubject, "AL OTC Customer Details");

                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<InsertALCustomerModelOutput>().ToList()[0].Reason);
                    }
                }
            }

        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("insert_dealer_wise_al_otc_card_request")]
        public async Task<IActionResult> InsertDealerWiseALOTCCardRequest([FromBody] InsertDealerWiseALOTCCardRequestModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _ALRepo.InsertDealerWiseALOTCCardRequest(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<InsertDealerWiseALOTCCardRequestModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<InsertDealerWiseALOTCCardRequestModelOutput>().ToList()[0].Reason);
                    }


                }
            }

        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_availity_al_otc_card")]
        public async Task<IActionResult> GetAvailityALOTCCard([FromBody] GetAvailityALOTCCardCardInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _ALRepo.GetAvailityALOTCCard(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<GetAvailityALOTCCardCardOutput> item = result.Cast<GetAvailityALOTCCardCardOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }

        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("view_al_otc_card_dealer_allocation")]
        public async Task<IActionResult> ViewALOTCCardDealerAllocation([FromBody] ALViewCardDealerAllocationModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _ALRepo.ViewALOTCCardDealerAllocation(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.ObjALViewCardDetail.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }

        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_al_addon_otc_card_mapping_customer_details")]
        public async Task<IActionResult> GetAlAddonOTCCardMappingCustomerDetails([FromBody] GetAlAddonOTCCardMappingCustomerDetailsModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _ALRepo.GetAlAddonOTCCardMappingCustomerDetails(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.GetCustomerNameAndNameOnCardOutput.Count > 0 && result.GetCustomerStatusOutput.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_al_sales_exe_empid_addon_otc_card_mapping")]
        public async Task<IActionResult> GetAlSalesExeEmpIdAddOnOTCCardMapping([FromBody] GetAlSalesExeEmpIdAddOnOTCCardMappingModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _ALRepo.GetAlSalesExeEmpIdAddOnOTCCardMapping(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<GetAlSalesExeEmpIdAddOnOTCCardMappingModelOutput> item = result.Cast<GetAlSalesExeEmpIdAddOnOTCCardMappingModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("al_addon_otc_card")]
        public async Task<IActionResult> AlAddOnOTCCard([FromBody] AlAddOnOTCCardModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _ALRepo.AlAddOnOTCCard(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<AlAddOnOTCCardModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<AlAddOnOTCCardModelOutput>().ToList()[0].Reason);
                    }
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_al_verify_customer_document")]
        public async Task<IActionResult> GetALVerifyCustomerDocument([FromBody] ALVerifyCustomerDocumentModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _ALRepo.GetALVerifyCustomerDocument(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<GetALVerifyCustomerDocumentModelOutput> item = result.Cast<GetALVerifyCustomerDocumentModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }
        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_al_upload_kyc_document")]
        public async Task<IActionResult> GetALUploadKycDocument([FromBody] GetALUploadKycDocumentsModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _ALRepo.GetALUploadKycDocument(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<GetALUploadKycDocumentsModelOutput> item = result.Cast<GetALUploadKycDocumentsModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("insert_al_customer_kyc")]
        public async Task<IActionResult> InsertALCustomerKYC([FromBody] InsertALCustomerKYCModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _ALRepo.InsertALCustomerKYC(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<InsertALCustomerKYCModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<InsertALCustomerKYCModelOutput>().ToList()[0].Reason);
                    }


                }
            }

        }

        ////////
        ///
        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_al_customer_detail_for_verification")]
        public async Task<IActionResult> GetAlCustomerDetailForVerification([FromBody] GetAlCustomerDetailForVerificationModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _ALRepo.GetAlCustomerDetailForVerification(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<GetAlCustomerDetailForVerificationModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<GetAlCustomerDetailForVerificationModelOutput>().ToList()[0].Reason);
                    }


                }
            }

        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("update_al_customerstatus")]
        public async Task<IActionResult> UpdateALCustomerStatus([FromBody] UpdateALCustomerStatusModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _ALRepo.UpdateALCustomerStatus(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<UpdateALCustomerStatusModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<UpdateALCustomerStatusModelOutput>().ToList()[0].Reason);
                    }


                }
            }
        }
    }

}
