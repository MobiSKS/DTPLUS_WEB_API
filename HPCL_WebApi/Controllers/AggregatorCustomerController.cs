using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using HPCL_WebApi.ExtensionMethod;
using HPCL_WebApi.ActionFilters;
using HPCL.DataModel.AggregatorCustomer;
using System.Linq;
using HPCL.DataRepository.AggregatorCustomer;
using HPCL.Infrastructure.CommonClass;
using System.Collections.Generic;

namespace HPCL_WebApi.Controllers
{
    [ApiController]
    [Route("/api/dtplus/aggregatorcustomer")]
    public class AggregatorCustomerController : Controller
    {
        private readonly ILogger<AggregatorCustomerController> _logger;

        private readonly IAggregatorCustomerRepository _aggregatorCustomerRepo;

        public AggregatorCustomerController(ILogger<AggregatorCustomerController> logger, IAggregatorCustomerRepository aggregatorRepo)
        {
            _logger = logger;
            _aggregatorCustomerRepo = aggregatorRepo;
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("insert_aggregator_customer")]
        public async Task<IActionResult> InsertAggregatorCustomer([FromBody] AggregatorCustomerInsertModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _aggregatorCustomerRepo.InsertAggregatorCustomer(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<AggregatorCustomerInsertModelOutput>().ToList()[0].Status == 1)
                    {

                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<AggregatorCustomerInsertModelOutput>().ToList()[0].Reason);
                    }
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("update_aggregator_customer")]
        public async Task<IActionResult> UpdateAggregatorCustomer([FromBody] AggregatorCustomerUpdateModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _aggregatorCustomerRepo.UpdateAggregatorCustomer(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<AggregatorCustomerUpdateModelOutput>().ToList()[0].Status == 1)
                    {

                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<AggregatorCustomerUpdateModelOutput>().ToList()[0].Reason);
                    }
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("insert_aggregator_normal_fleet_customer")]
        public async Task<IActionResult> InsertAggregatorNormalFleetCustomer([FromBody] AggregatorNormalFleetCustomerModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _aggregatorCustomerRepo.InsertAggregatorNormalFleetCustomer(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<AggregatorNormalFleetCustomerModelOutput>().ToList()[0].Status == 1)
                    {

                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<AggregatorNormalFleetCustomerModelOutput>().ToList()[0].Reason);
                    }
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("upload_aggregator_customer_kyc")]
        public async Task<IActionResult> UploadCustomerKYC([Microsoft.AspNetCore.Mvc.FromForm] AggregatorCustomerKYCModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _aggregatorCustomerRepo.UploadAggregatorCustomerKYC(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<AggregatorCustomerKYCModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<AggregatorCustomerKYCModelOutput>().ToList()[0].Reason);
                    }

                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("approve_reject_aggregator_customer")]
        public async Task<IActionResult> ApproveRejectAggregatorCustomer([FromBody] AggregatorCustomerApprovalModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _aggregatorCustomerRepo.ApproveRejectAggregatorCustomer(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<AggregatorCustomerApprovalModelOutput>().ToList()[0].Status == 1)
                    {
                        if (result.Cast<AggregatorCustomerApprovalModelOutput>().ToList()[0].SendStatus == 4)
                        {
                            string EmailSubject = "<p>Hi <b>" + result.Cast<AggregatorCustomerApprovalModelOutput>().ToList()[0].FirstName + " "
                                + result.Cast<AggregatorCustomerApprovalModelOutput>().ToList()[0].LastName + "<b></br> User Name : "
                                + result.Cast<AggregatorCustomerApprovalModelOutput>().ToList()[0].CustomerID + " </br> Password : "
                                + result.Cast<AggregatorCustomerApprovalModelOutput>().ToList()[0].Password + " </p>";

                            Variables.SendSMS(2, "1007862494411670929", result.Cast<AggregatorCustomerApprovalModelOutput>().ToList()[0].CommunicationMobileNo,
                                 ObjClass.ApprovedBy, result.Cast<AggregatorCustomerApprovalModelOutput>().ToList()[0].CustomerID,
                                 result.Cast<AggregatorCustomerApprovalModelOutput>().ToList()[0].ControlCardNo);

                            Variables.FunSendMail(result.Cast<AggregatorCustomerApprovalModelOutput>().ToList()[0].EmailId, EmailSubject, "Customer Details");
                        }


                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<AggregatorCustomerApprovalModelOutput>().ToList()[0].Reason);
                    }
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_approve_aggregator_fee_waiver_detail")]
        public async Task<IActionResult> GetApproveAggregatorFeeWaiverDetail([FromBody] GetApproveAggregatorFeeWaiverDetailModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _aggregatorCustomerRepo.GetApproveAggregatorFeeWaiverDetail(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.GetApproveAggregatorFeeWaiverBasicDetail.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_aggregator_name_and_form_number_by_reference_no")]
        public async Task<IActionResult> GetAggregatorNameandFormNumberbyReferenceNo([FromBody] AggregatorCustomerGetCustomerReferenceNoModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _aggregatorCustomerRepo.GetAggregatorNameandFormNumberbyReferenceNo(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<AggregatorCustomerGetCustomerReferenceNoModelOutput> item = result.Cast<AggregatorCustomerGetCustomerReferenceNoModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_aggregator_name_and_form_number_by_reference_no_for_add_card")]
        public async Task<IActionResult> GetAggregatorNameandFormNumberbyReferenceNoforAddCard([FromBody] AggregatorCustomerGetCustomerReferenceNoModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _aggregatorCustomerRepo.GetAggregatorNameandFormNumberbyReferenceNoforAddCard(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<AggregatorCustomerGetCustomerReferenceNoModelOutput> item = result.Cast<AggregatorCustomerGetCustomerReferenceNoModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_aggregator_customer_by_customer_id")]
        public async Task<IActionResult> GetAggregatorCustomerByCustomerId([FromBody] AggregatorCustomerGetByCustomerIdModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _aggregatorCustomerRepo.GetAggregatorCustomerByCustomerId(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.GetAggregatorCustomerDetails.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_aggregator_customer_detail")]
        public async Task<IActionResult> GetAggregatorCustomerDetails([FromBody] AggregatorCustomerDetailsModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _aggregatorCustomerRepo.GetAggregatorCustomerDetails(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.GetAggregatorCustomerDetails.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_raw_aggregator_customer_detail")]
        public async Task<IActionResult> GetRawAggregatorCustomerDetails([FromBody] AggregatorCustomerDetailsModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _aggregatorCustomerRepo.GetRawAggregatorCustomerDetails(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.GetAggregatorCustomerDetails.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("bind_pending_aggregator_customer")]
        public async Task<IActionResult> BindPendingAggregatorCustomer([FromBody] BindPendingAggregatorCustomerModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _aggregatorCustomerRepo.BindPendingAggregatorCustomer(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<BindPendingAggregatorCustomerModelOutput> item = result.Cast<BindPendingAggregatorCustomerModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("bind_unverfied_aggregator_customer")]
        public async Task<IActionResult> BindUnverfiedCustomer([FromBody] BindPendingAggregatorCustomerModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _aggregatorCustomerRepo.BindUnverfiedAggregatorCustomer(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<BindPendingAggregatorCustomerModelOutput> item = result.Cast<BindPendingAggregatorCustomerModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_unverfied_aggregator_customer_detail_by_form_number")]
        public async Task<IActionResult> GetUnverfiedAggregatorCustomerDetailbyFormNumber([FromBody] AggregatorCustomerDetailsbyFormNumberModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _aggregatorCustomerRepo.GetUnverfiedAggregatorCustomerDetailbyFormNumber(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.GetAggregatorCustomerDetails.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_aggregator_customer_name_by_customer_id")]
        public async Task<IActionResult> GetAggregatorCustomerNameByCustomerId([FromBody] AggregatorCustomerGetByCustomerIdModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _aggregatorCustomerRepo.GetAggregatorCustomerNameByCustomerId(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<AggregatorCustomerGetCustomerNameModelOutput> item = result.Cast<AggregatorCustomerGetCustomerNameModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_aggregator_customer_details_for_search")]
        public async Task<IActionResult> GetAggregatorCustomerDetailsForSearch([FromBody] AggregatorCustomerGetByCustomerIdModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _aggregatorCustomerRepo.GetAggregatorCustomerDetailsForSearch(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<AggregatorCustomerGetCustomerDetailsForSearchModelOutput> item = result.Cast<AggregatorCustomerGetCustomerDetailsForSearchModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("search_aggregator_customer_and_card_form")]
        public async Task<IActionResult> SearchAggregatorCustomerandCardForm([FromBody] SearchAggregatorCustomerandCardFormModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _aggregatorCustomerRepo.SearchAggregatorCustomerandCardForm(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.GetAggregatorCustomerSearchOutput.Count > 0 && result.GetAggregatorCardSearchOutput.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_aggregator_name_and_formnumber_by_customerid")]
        public async Task<IActionResult> GetAggregatorNameandFormNumberbyCustomerId([FromBody] GetAggregatorNameandFormNumberbyCustomerIdModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _aggregatorCustomerRepo.GetAggregatorNameandFormNumberbyCustomerId(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<GetAggregatorNameandFormNumberbyCustomerIdModelOutput> item = result.Cast<GetAggregatorNameandFormNumberbyCustomerIdModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("aggregator_customer_add_on_user")]
        public async Task<IActionResult> AggregatorCustomerAddOnUser([FromBody] AggregatorCustomerAddOnUserModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _aggregatorCustomerRepo.AggregatorCustomerAddOnUser(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<AggregatorCustomerAddOnUserModelOutput> item = result.Cast<AggregatorCustomerAddOnUserModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }
    }

}
