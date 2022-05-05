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
    }

   
}
