using HPCL.DataModel.Card;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.Card
{
    public interface ICardRepository
    {
        public Task<IEnumerable<ManageSearchCardsModelOutput>> SearchManageCard([FromBody] ManageSearchCardsModelInput ObjClass);
        public Task<GetCardLimtModelOutput> GetCardLimitFeatures([FromBody] GetCardLimtModelInput ObjClass);
        public Task<IEnumerable<UpdateMobileInCardModelOutput>> UpdateMobileInCard([FromBody] UpdateMobileInCardModelInput ObjClass);
        public Task<IEnumerable<UpdateServiveOnCardModelOutput>> UpdateServiveOnCard([FromBody] UpdateServiveOnCardModelInput ObjClass);
        public Task<IEnumerable<UpdateCardLimitsModelOutput>> UpdateCardLimits([FromBody] UpdateCardLimitsModelInput ObjClass);
        public Task<IEnumerable<UpdateCCMSLimitsModelOutput>> UpdateCCMSLimits([FromBody] UpdateCCMSLimitsModelInput ObjClass);
        public Task<GetCCMSLimitsModelOutput> GetCCMSLimits([FromBody] GetCCMSLimitsModelInput ObjClass);
        public Task<IEnumerable<GetCardLimitsModelOutput>> GetCardLimits([FromBody] GetCardLimitsModelInput ObjClass);
        public Task<IEnumerable<UpdateCCMSLimitForAllCardsModelOutput>> UpdateCCMSLimitForAllCards([FromBody] UpdateCCMSLimitForAllCardsModelInput ObjClass);
        public Task<IEnumerable<UpdateCardLimitForAllCardsModelOutput>> UpdateCardLimitForAllCards([FromBody] UpdateCardLimitForAllCardsModelInput ObjClass);
        public Task<IEnumerable<GetLimitMasterModelOutput>> GetCCMSLimitMaster([FromBody] GetLimitMasterModelInput ObjClass);
        public Task<IEnumerable<GetAllCardWithStatusModelOutput>> GetAllCardWithStatus([FromBody] GetAllCardWithStatusModelInput ObjClass);
        public Task<IEnumerable<UpdateCardStatusModelOutput>> UpdateCardStatus([FromBody] UpdateCardStatusModelInput ObjClass);
        public Task<IEnumerable<ViewCardLimitsModelOutput>> ViewCardLimits([FromBody] ViewCardLimitsModelInput ObjClass);
        public Task<IEnumerable<GetCCMSLimitsForAllCardsModelOutput>> GetCCMSLimitsForAllCards([FromBody] GetCCMSLimitsForAllCardsModelInput ObjClass);
        public Task<IEnumerable<AddCardModelOutput>> AddCard([FromBody] AddCardModelInput ObjClass);
        public Task<IEnumerable<UpdateMobileandFastagNoInCardModelOutput>> UpdateMobileandFastagNoInCard([FromBody] UpdateMobileandFastagNoInCardModelInput ObjClass);

        public Task<IEnumerable<BindPendingCustomerforCardModelOutput>> BindPendingCustomerForCardApproval([FromBody] BindPendingCustomerforCardModelInput ObjClass);

        public Task<IEnumerable<GetCardDetailForCardApprovalModelOutput>> GetCardDetailForCardApproval([FromBody] GetCardDetailForCardApprovalModelInput ObjClass);

        public Task<IEnumerable<ApproveRejectCardModelOutput>> ApproveRejectCard([FromBody] ApproveRejectCardModelInput ObjClass);

        public Task<IEnumerable<CardSearchMappingDetailModelOutput>> SearchCardMappingDetail([FromBody] CardSearchMappingDetailModelInput ObjClass);
        public Task<IEnumerable<CardSearchMappingDetailsWithBlankMobileModelOutput>> SearchCardMappingDetailsWithBlankMobile([FromBody] CardSearchMappingDetailsWithBlankMobileModelInput ObjClass);

        public Task<IEnumerable<GetCardtoCCMSBalanceTransferModelOutput>> GetCardtoCCMSBalanceTransfer([FromBody] GetCardtoCCMSBalanceTransferModelInput ObjClass);

        public Task<GetCcmsToCardBalanceTransferModelOutput> GetCCMSToCardBalanceTransfer([FromBody] GetCcmsToCardBalanceTransferModelInput ObjClass);

        public Task<IEnumerable<GetCardtoCardBalanceTransferModelOutput>> GetCardtoCardBalanceTransfer([FromBody] GetCardtoCardBalanceTransferModelInput ObjClass);

        public Task<IEnumerable<CardCheckVechileNoModelOutput>> CheckVechileNo([FromBody] CardCheckVechileNoModelInput ObjClass);

        public Task<IEnumerable<CheckFastagNoDuplicacyInCardModelOutput>> CheckFastagNoDuplicacyInCard([FromBody] CheckFastagNoDuplicacyInCardModelInput ObjClass);

        public Task<IEnumerable<AddOnCardModelOutput>> AddOnCard([FromBody] AddOnCardModelInput ObjClass);

        public Task<IEnumerable<CheckAddOnFormNumberModelOutput>> CheckAddOnFormNumber([FromBody] CheckAddOnFormNumberModelInput ObjClass);

        public Task<IEnumerable<BindPendingCustomerForAddOnCardApprovalModelOutput>> BindPendingCustomerForAddOnCardApproval([FromBody] BindPendingCustomerForAddOnCardApprovalModelInput ObjClass);

        public Task<IEnumerable<CardCheckMobileNoModelOutput>> CheckMobileNo([FromBody] CardCheckMobileNoModelInput ObjClass);
        public Task<IEnumerable<TransferAmountCCMSToCardModelOutput>> TransferAmountCCMSToCard([FromBody] TransferAmountCCMSToCardModelInput ObjClass);
        public Task<IEnumerable<TransferAmountCardToCCMSModeloutput>> TransferAmountCardToCCMS([FromBody] TransferAmountCardToCCMSModelInput ObjClass);
        public Task<IEnumerable<TransferAmountCardToCardModelOutput>> TransferAmountCardToCard([FromBody] TransferAmountCardToCardModelInput ObjClass);

        public Task<IEnumerable<CheckCardIdentifierNoModelOutput>> CheckCardIdentifierNo([FromBody] CheckCardIdentifierNoModelInput ObjClass);
        public Task<IEnumerable<GetCardsForLimitUpdateForSingleRechargeModelOutput>> GetCardsForLimitUpdateForSingleRecharge([FromBody] GetCardsForLimitUpdateForSingleRechargeModelInput ObjClass);
        public Task<IEnumerable<LimitUpdateForSingleRechargeCardModelOutput>> LimitUpdateForSingleRecharge([FromBody] LimitUpdateForSingleRechargeCardModelInput ObjClass);
        public Task<IEnumerable<GetDetailForCorpMultiRechargeLimitConfigModelOutput>> GetDetailForCorpMultiRechargeLimitConfig([FromBody] GetDetailForCorpMultiRechargeLimitConfigModelInput ObjClass);
        public Task<IEnumerable<CorpMultiRechargeLimitConfigModelOutput>> CorpMultiRechargeLimitConfig([FromBody] CorpMultiRechargeLimitConfigModelInput ObjClass);

        public Task<IEnumerable<EmergencyReplacementCardModelOutput>> GetDetailForEmergencyReplacementCards([FromBody] EmergencyReplacementCardModelInput ObjClass);

    }
}
