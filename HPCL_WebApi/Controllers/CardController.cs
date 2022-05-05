using HPCL.DataModel.Card;
using HPCL.DataRepository.Card;
using HPCL_WebApi.ActionFilters;
using HPCL_WebApi.ExtensionMethod;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HPCL_WebApi.Controllers
{
    [ApiController]
    [Route("/api/dtplus/card")]
    public class CardController : ControllerBase
    {
        private readonly ILogger<CardController> _logger;

        private readonly ICardRepository _cardRepo;

        public CardController(ILogger<CardController> logger, ICardRepository cardRepo)
        {
            _logger = logger;
            _cardRepo = cardRepo;
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("search_manage_card")]
        public async Task<IActionResult> SearchManageCard([FromBody] ManageSearchCardsModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _cardRepo.SearchManageCard(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<ManageSearchCardsModelOutput> item = result.Cast<ManageSearchCardsModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_card_limit_features")]
        public async Task<IActionResult> GetCardLimitFeatures([FromBody] GetCardLimtModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _cardRepo.GetCardLimitFeatures(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {

                    if (result.GetCardsDetails.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("update_mobile_in_card")]
        public async Task<IActionResult> UpdateMobileInCard([FromBody] UpdateMobileInCardModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _cardRepo.UpdateMobileInCard(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<UpdateMobileInCardModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<UpdateMobileInCardModelOutput>().ToList()[0].Reason);
                    }
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("update_mobile_and_fastag_no_in_card")]
        public async Task<IActionResult> UpdateMobileandFastagNoInCard([FromBody] UpdateMobileandFastagNoInCardModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _cardRepo.UpdateMobileandFastagNoInCard(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<UpdateMobileandFastagNoInCardModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<UpdateMobileandFastagNoInCardModelOutput>().ToList()[0].Reason);
                    }
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("update_service_on_card")]
        public async Task<IActionResult> UpdateServiveOnCard([FromBody] UpdateServiveOnCardModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _cardRepo.UpdateServiveOnCard(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<UpdateServiveOnCardModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<UpdateServiveOnCardModelOutput>().ToList()[0].Reason);
                    }
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("update_card_limits")]
        public async Task<IActionResult> UpdateCardLimits([FromBody] UpdateCardLimitsModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _cardRepo.UpdateCardLimits(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<UpdateCardLimitsModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<UpdateCardLimitsModelOutput>().ToList()[0].Reason);
                    }
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("update_ccms_limits")]
        public async Task<IActionResult> UpdateCCMSLimits([FromBody] UpdateCCMSLimitsModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _cardRepo.UpdateCCMSLimits(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<UpdateCCMSLimitsModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<UpdateCCMSLimitsModelOutput>().ToList()[0].Reason);
                    }
                }
            }
        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_ccms_limit")]
        public async Task<IActionResult> GetCCMSLimits([FromBody] GetCCMSLimitsModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _cardRepo.GetCCMSLimits(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.CCMSBasicDetail.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_card_limit")]
        public async Task<IActionResult> GetCardLimits([FromBody] GetCardLimitsModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _cardRepo.GetCardLimits(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<GetCardLimitsModelOutput> item = result.Cast<GetCardLimitsModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_ccms_limit_for_all_cards")]
        public async Task<IActionResult> GetCCMSLimitsForAllCards([FromBody] GetCCMSLimitsForAllCardsModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _cardRepo.GetCCMSLimitsForAllCards(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<GetCCMSLimitsForAllCardsModelOutput> item = result.Cast<GetCCMSLimitsForAllCardsModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("update_ccms_limit_for_all_cards")]
        public async Task<IActionResult> UpdateCCMSLimitForAllCards([FromBody] UpdateCCMSLimitForAllCardsModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _cardRepo.UpdateCCMSLimitForAllCards(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<UpdateCCMSLimitForAllCardsModelOutput> item = result.Cast<UpdateCCMSLimitForAllCardsModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }



        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("update_limit_for_all_cards")]
        public async Task<IActionResult> UpdateCardLimitForAllCards([FromBody] UpdateCardLimitForAllCardsModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _cardRepo.UpdateCardLimitForAllCards(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<UpdateCardLimitForAllCardsModelOutput> item = result.Cast<UpdateCardLimitForAllCardsModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_ccms_limit_master")]
        public async Task<IActionResult> GetCCMSLimitMaster([FromBody] GetLimitMasterModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _cardRepo.GetCCMSLimitMaster(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<GetLimitMasterModelOutput> item = result.Cast<GetLimitMasterModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_all_card_with_status")]
        public async Task<IActionResult> GetAllCardWithStatus([FromBody] GetAllCardWithStatusModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _cardRepo.GetAllCardWithStatus(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<GetAllCardWithStatusModelOutput> item = result.Cast<GetAllCardWithStatusModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("update_card_status")]
        public async Task<IActionResult> UpdateCardStatus([FromBody] UpdateCardStatusModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _cardRepo.UpdateCardStatus(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<UpdateCardStatusModelOutput> item = result.Cast<UpdateCardStatusModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("view_card_limits")]
        public async Task<IActionResult> ViewCardLimits([FromBody] ViewCardLimitsModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _cardRepo.ViewCardLimits(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<ViewCardLimitsModelOutput> item = result.Cast<ViewCardLimitsModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("add_card")]
        public async Task<IActionResult> AddCard([FromBody] AddCardModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _cardRepo.AddCard(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<AddCardModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<AddCardModelOutput>().ToList()[0].Reason);
                    }
                }
            }
        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("bind_pending_customer_for_card_approval")]
        public async Task<IActionResult> BindPendingCustomerForCardApproval([FromBody] BindPendingCustomerforCardModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _cardRepo.BindPendingCustomerForCardApproval(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<BindPendingCustomerforCardModelOutput> item = result.Cast<BindPendingCustomerforCardModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        //[ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_card_detail_for_card_approval")]
        public async Task<IActionResult> GetCardDetailForCardApproval([FromBody] GetCardDetailForCardApprovalModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _cardRepo.GetCardDetailForCardApproval(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<GetCardDetailForCardApprovalModelOutput> item = result.Cast<GetCardDetailForCardApprovalModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("approve_reject_card")]
        public async Task<IActionResult> ApproveRejectCard([FromBody] ApproveRejectCardModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _cardRepo.ApproveRejectCard(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<ApproveRejectCardModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<ApproveRejectCardModelOutput>().ToList()[0].Reason);
                    }
                }
            }
        }



        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("search_card_mapping_detail")]
        public async Task<IActionResult> SearchCardMappingDetail([FromBody] CardSearchMappingDetailModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _cardRepo.SearchCardMappingDetail(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<CardSearchMappingDetailModelOutput> item = result.Cast<CardSearchMappingDetailModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("search_card_mapping_details_with_blank_mobile")]
        public async Task<IActionResult> SearchCardMappingDetailsWithBlankMobile([FromBody] CardSearchMappingDetailsWithBlankMobileModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _cardRepo.SearchCardMappingDetailsWithBlankMobile(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<CardSearchMappingDetailsWithBlankMobileModelOutput> item = result.Cast<CardSearchMappingDetailsWithBlankMobileModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_card_to_ccms_balance_transfer")]
        public async Task<IActionResult> GetCardtoCCMSBalanceTransfer([FromBody] GetCardtoCCMSBalanceTransferModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _cardRepo.GetCardtoCCMSBalanceTransfer(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<GetCardtoCCMSBalanceTransferModelOutput> item = result.Cast<GetCardtoCCMSBalanceTransferModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_ccms_to_card_balance_transfer")]
        public async Task<IActionResult> GetCCMSToCardBalanceTransfer([FromBody] GetCcmsToCardBalanceTransferModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _cardRepo.GetCCMSToCardBalanceTransfer(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.ObjCcmsToCardBalanceTransferDetail.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_card_to_card_balance_transfer")]
        public async Task<IActionResult> GetCardtoCardBalanceTransfer([FromBody] GetCardtoCardBalanceTransferModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _cardRepo.GetCardtoCardBalanceTransfer(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<GetCardtoCardBalanceTransferModelOutput> item = result.Cast<GetCardtoCardBalanceTransferModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("check_vechile_no")]
        public async Task<IActionResult> CheckVechileNo([FromBody] CardCheckVechileNoModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _cardRepo.CheckVechileNo(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<CardCheckVechileNoModelOutput> item = result.Cast<CardCheckVechileNoModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("check_fastag_no_duplicacy_in_card")]
        public async Task<IActionResult> CheckFastagNoDuplicacyInCard([FromBody] CheckFastagNoDuplicacyInCardModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _cardRepo.CheckFastagNoDuplicacyInCard(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<CheckFastagNoDuplicacyInCardModelOutput> item = result.Cast<CheckFastagNoDuplicacyInCardModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("add_addon_card")]
        public async Task<IActionResult> AddOnCard([FromBody] AddOnCardModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _cardRepo.AddOnCard(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<AddOnCardModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<AddOnCardModelOutput>().ToList()[0].Reason);
                    }
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("check_addon_formnumber")]
        public async Task<IActionResult> CheckAddOnFormNumber([FromBody] CheckAddOnFormNumberModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _cardRepo.CheckAddOnFormNumber(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<CheckAddOnFormNumberModelOutput> item = result.Cast<CheckAddOnFormNumberModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("bind_pending_customer_for_addon_card_approval")]
        public async Task<IActionResult> BindPendingCustomerForAddOnCardApproval([FromBody] BindPendingCustomerForAddOnCardApprovalModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _cardRepo.BindPendingCustomerForAddOnCardApproval(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<BindPendingCustomerForAddOnCardApprovalModelOutput> item = result.Cast<BindPendingCustomerForAddOnCardApprovalModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("check_mobile_no")]
        public async Task<IActionResult> CheckMobileNo([FromBody] CardCheckMobileNoModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _cardRepo.CheckMobileNo(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<CardCheckMobileNoModelOutput> item = result.Cast<CardCheckMobileNoModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("Transfer_Amount_CCMS_To_Card")]
        public async Task<IActionResult> TransferAmountCCMSToCard([FromBody] TransferAmountCCMSToCardModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _cardRepo.TransferAmountCCMSToCard(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<TransferAmountCCMSToCardModelOutput> item = result.Cast<TransferAmountCCMSToCardModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }
        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("Transfer_Amount_Card_To_CCMS")]
        public async Task<IActionResult> TransferAmountCardToCCMS([FromBody] TransferAmountCardToCCMSModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _cardRepo.TransferAmountCardToCCMS(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<TransferAmountCardToCCMSModeloutput> item = result.Cast<TransferAmountCardToCCMSModeloutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("Transfer_Amount_Card_To_Card")]
        public async Task<IActionResult> TransferAmountCardToCCMS([FromBody] TransferAmountCardToCardModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _cardRepo.TransferAmountCardToCard(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<TransferAmountCardToCardModelOutput> item = result.Cast<TransferAmountCardToCardModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("check_card_identifier_no")]
        public async Task<IActionResult> CheckCardIdentifierNo([FromBody] CheckCardIdentifierNoModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _cardRepo.CheckCardIdentifierNo(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<CheckCardIdentifierNoModelOutput> item = result.Cast<CheckCardIdentifierNoModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_cards_for_limit_update_for_single_recharge")]

        public async Task<IActionResult> GetCardsForLimitUpdateForSingleRecharge([FromBody] GetCardsForLimitUpdateForSingleRechargeModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _cardRepo.GetCardsForLimitUpdateForSingleRecharge(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<GetCardsForLimitUpdateForSingleRechargeModelOutput> item = result.Cast<GetCardsForLimitUpdateForSingleRechargeModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("limit_update_for_single_recharge")]
        public async Task<IActionResult> LimitUpdateForSingleRecharge([FromBody] LimitUpdateForSingleRechargeCardModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _cardRepo.LimitUpdateForSingleRecharge(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<LimitUpdateForSingleRechargeCardModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<LimitUpdateForSingleRechargeCardModelOutput>().ToList()[0].Reason);
                    }
                }
            }
        }

        [HttpPost]
        //[ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_detail_for_corp_multi_recharge_limit_config")]

        public async Task<IActionResult> GetDetailForCorpMultiRechargeLimitConfig([FromBody] GetDetailForCorpMultiRechargeLimitConfigModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _cardRepo.GetDetailForCorpMultiRechargeLimitConfig(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<GetDetailForCorpMultiRechargeLimitConfigModelOutput> item = result.Cast<GetDetailForCorpMultiRechargeLimitConfigModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }

        }
    }
}
