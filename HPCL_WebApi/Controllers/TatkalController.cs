using HPCL.DataModel.Merchant;
using HPCL.DataModel.Tatkal;
using HPCL.DataModel.ZonalOffice;
using HPCL.DataRepository.Tatkal;
using HPCL.DataRepository.ZonalOffice;
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
    [Route("api/dtplus/tatkal")]
    [ApiController]
    public class TatkalController : ControllerBase
    {
        private readonly ILogger<TatkalController> _logger;

        private readonly ITatkalRepository _TatkalRepo;
        public TatkalController(ILogger<TatkalController> logger, ITatkalRepository TatkalRepo)
        {
            _logger = logger;
            _TatkalRepo = TatkalRepo;
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("check_availity_tatkal_card")]
        public async Task<IActionResult> CheckAvailityTatkalCard([FromBody] MerchantCheckAvailityCardInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _TatkalRepo.CheckAvailityTatkalCard(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<MerchantCheckAvailityCardOutput> item = result.Cast<MerchantCheckAvailityCardOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }

        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_availity_tatkal_card")]
        public async Task<IActionResult> GetAvailityTatkalCard([FromBody] MerchantGetAvailityCardInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _TatkalRepo.GetAvailityTatkalCard(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<MerchantGetAvailityCardOutput> item = result.Cast<MerchantGetAvailityCardOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }

        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_all_un_allocated_cards_for_tatkal_card")]
        public async Task<IActionResult> GetAllUnAllocatedCardsForTatkalCard([FromBody] MerchantGetAllUnAllocatedCardsModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _TatkalRepo.GetAllUnAllocatedCardsForTatkalCard(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.ObjNoOfUnAllocatedCard.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }

        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("allocated_tatkal_card_to_merchant")]
        public async Task<IActionResult> AllocatedTatkalCardToMerchant([FromBody] MerchantAllocatedCardsToMerchantModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _TatkalRepo.AllocatedTatkalCardToMerchant(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<MerchantAllocatedCardsToMerchantModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<MerchantAllocatedCardsToMerchantModelOutput>().ToList()[0].Reason);
                    }


                }
            }

        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("view_requested_tatkal_card")]
        public async Task<IActionResult> ViewRequestedTatkalCard([FromBody] MerchantViewRequestedCardModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _TatkalRepo.ViewRequestedTatkalCard(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<MerchantViewRequestedCardModelOutput> item = result.Cast<MerchantViewRequestedCardModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }

        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("insert_dealer_wise_tatkal_card_request")]
        public async Task<IActionResult> InsertDealerWiseTatkalCardRequest([FromBody] MerchantInsertDealerWiseCardRequestModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _TatkalRepo.InsertDealerWiseTatkalCardRequest(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<MerchantInsertDealerWiseCardRequestModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<MerchantInsertDealerWiseCardRequestModelOutput>().ToList()[0].Reason);
                    }


                }
            }

        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("view_tatkal_card_merchant_allocation")]
        public async Task<IActionResult> ViewTatkalCardMerchantAllocation([FromBody] MerchantViewCardMerchantAllocationModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _TatkalRepo.ViewTatkalCardMerchantAllocation(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.ObjMerchantViewCardDetail.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }

        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("insert_tatkal_card_customer")]
        public async Task<IActionResult> InsertTatkalCustomer([FromBody] InsertTatkalCustomerModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _TatkalRepo.InsertTatkalCustomer(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<InsertTatkalCustomerModelOutput>().ToList()[0].Status == 1)
                    {

                        string EmailSubject = "<p>Hi <b>" + ObjClass.IndividualOrgName + "</br> User Name : "
                                + result.Cast<InsertTatkalCustomerModelOutput>().ToList()[0].CustomerID + " </br> Password : "
                                + result.Cast<InsertTatkalCustomerModelOutput>().ToList()[0].Password + " </p>";

                        Variables.FunSendMail(ObjClass.CommunicationEmailid, EmailSubject, "OTC Customer Details");

                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<InsertTatkalCustomerModelOutput>().ToList()[0].Reason);
                    }
                }
            }

        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_tatkal_card_allocation_activation")]
        public async Task<IActionResult> GetTatkalCardAllocationActivation([FromBody] GetCardAllocationActivationModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _TatkalRepo.GetTatkalCardAllocationActivation(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<GetCardAllocationActivationModelOutput> item = result.Cast<GetCardAllocationActivationModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("insert_tatkal_card_request")]
        public async Task<IActionResult> InsertTatkalCardRequest([FromBody] CardRequestEntryModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _TatkalRepo.InsertTatkalCardRequest(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<CardRequestEntryModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<CardRequestEntryModelOutput>().ToList()[0].Reason);
                    }

                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("map_tatkal_cards_to_tatkal_customer")]
        public async Task<IActionResult> MapTatkalCardsToTatkalCustomer([FromBody] MapTatkalCardsToTatkalCustomerModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _TatkalRepo.MapTatkalCardsToTatkalCustomer(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.ObjGetCardDetailsTatkalCardsToTatkalCustomer.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }

        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("update_map_tatkal_cards_to_tatkal_customer")]
        public async Task<IActionResult> UpdateMapTatkalCardsToTatkalCustomer([FromBody] UpdateMapTatkalCardsToTatkalCustomerModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _TatkalRepo.UpdateMapTatkalCardsToTatkalCustomer(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<UpdateMapTatkalCardsToTatkalCustomerModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<UpdateMapTatkalCardsToTatkalCustomerModelOutput>().ToList()[0].Reason);
                    }

                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("view_tatkal_cards")]
        public async Task<IActionResult> ViewTatkalCards([FromBody] ViewTatkalCardsModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _TatkalRepo.ViewTatkalCards(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<ViewTatkalCardsModelOutput> item = result.Cast<ViewTatkalCardsModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("validate_tatkal_customer_with_region")]
        public async Task<IActionResult> ValidateTatkalCustomerWithRegion([FromBody] ValidateTatkalCustomerWithRegionModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _TatkalRepo.ValidateTatkalCustomerWithRegion(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<ValidateTatkalCustomerWithRegionModelOutput> item = result.Cast<ValidateTatkalCustomerWithRegionModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

    }

}
