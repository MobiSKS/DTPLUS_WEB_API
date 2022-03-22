using HPCL.DataModel.Merchant;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.Merchant
{
    public interface IMerchantRepository
    {
        public Task<IEnumerable<GetMerchantTypeModelOutput>> GetMerchantType([FromBody] GetMerchantTypeModelInput ObjClass);

        public Task<IEnumerable<GetMerchantOutletCategoryModelOutput>> GetOutletCategory([FromBody] GetMerchantOutletCategoryModelInput ObjClass);

        public Task<IEnumerable<MerchantGetSBUModelOutput>> GetSBU([FromBody] MerchantGetSBUModelInput ObjClass);

        public Task<IEnumerable<MerchantInsertModelOutput>> InsertMerchant([FromBody] MerchantInsertModelInput ObjClass);

        public Task<IEnumerable<MerchantUpdateModelOutput>> UpdateMerchant([FromBody] MerchantUpdateModelInput ObjClass);

        public Task<IEnumerable<MerchantApprovalRejectModelOutput>> ApproveRejectMerchant([FromBody] MerchantApprovalRejectModelInput ObjClass);

        public Task<IEnumerable<MerchantGetByMerchantIdModelOutput>> GetMerchantbyMerchantId([FromBody] MerchantGetByMerchantIdModelInput ObjClass);

        public Task<IEnumerable<MerchantGetByMerchantIdModelOutput>> GetMerchantbyERPCode([FromBody] MerchantGetByErpCodeModelInput ObjClass);

        public Task<IEnumerable<MerchantGetMerchantApprovalModelOutput>> GetMerchantApproval([FromBody] MerchantGetMerchantApprovalModelInput ObjClass);

        public Task<IEnumerable<RejectedMerchantModelOutput>> GetRejectedMerchant([FromBody] RejectedMerchantModelInput ObjClass);

        public Task<IEnumerable<MerchantSearchMerchantForCardCreationModelOutput>> SearchMerchantForCardCreation([FromBody] MerchantSearchMerchantForCardCreationModelInput ObjClass);

        public Task<IEnumerable<MerchantInsertOTCCustomerModelOutput>> InsertOTCCustomer([FromBody] MerchantInsertOTCCustomerModelInput ObjClass);

        public Task<IEnumerable<MerchantCheckAvailityCardOutput>> CheckAvailityOTCCard([FromBody] MerchantCheckAvailityCardInput ObjClass);

        public Task<IEnumerable<MerchantCheckAvailityCardOutput>> CheckAvailityTatkalCard([FromBody] MerchantCheckAvailityCardInput ObjClass);

        public Task<IEnumerable<MerchantCheckAvailityCardOutput>> CheckAvailityDriverCard([FromBody] MerchantCheckAvailityCardInput ObjClass);

        public Task<IEnumerable<MerchantGetAvailityCardOutput>> GetAvailityOTCCard([FromBody] MerchantGetAvailityCardInput ObjClass);

        public Task<IEnumerable<MerchantGetAvailityCardOutput>> GetAvailityTatkalCard([FromBody] MerchantGetAvailityCardInput ObjClass);

        public Task<IEnumerable<MerchantGetAvailityCardOutput>> GetAvailityDriverCard([FromBody] MerchantGetAvailityCardInput ObjClass);

        public Task<MerchantSearchForTerminalInstallationRequestModelOutput> SearchForTerminalInstallationRequest([FromBody] MerchantSearchForTerminalInstallationRequestModelInput ObjClass);

        public Task<IEnumerable<MerchantInsertAddonTerminalModelOutput>> InsertTerminalInstallationRequest([FromBody] MerchantInsertAddonTerminalModelInput ObjClass);

        public Task<IEnumerable<MerchantSearchForTerminalInstallationRequestCloseModelOutput>> SearchForTerminalInstallationRequestClose([FromBody] MerchantSearchForTerminalInstallationRequestCloseModelInput ObjClass);

        public Task<IEnumerable<MerchantGetReasonListModelOutput>> GetReasonList([FromBody] MerchantGetReasonListModelInput ObjClass);

        public Task<IEnumerable<MerchantUpdateTerminalInstallationRequestCloseModelOutput>> UpdateTerminalInstallationRequestClose([FromBody] MerchantUpdateTerminalInstallationRequestCloseModelInput ObjClass);

        public Task<IEnumerable<MerchantViewTerminalInstallationRequestStatusCloseModelOutput>> ViewTerminalInstallationRequestStatus([FromBody] MerchantViewTerminalInstallationRequestStatusCloseInput ObjClass);

        public Task<MerchantGetTerminalDeinstallationRequestModelOutput> GetTerminalDeinstallationRequest([FromBody] MerchantGetTerminalDeinstallationRequestModelInput ObjClass);

        public Task<IEnumerable<MerchantUpdateTerminalDeInstalRequestModelOutput>> UpdateTerminalDeInstalRequest([FromBody] MerchantUpdateTerminalDeInstalRequestModelInput ObjClass);

        public Task<IEnumerable<VerifyMerchantByMerchantIdModelOutput>> VerifyMerchantByMerchantId([FromBody] VerifyMerchantByMerchantIdModelInput ObjClass);

        public Task<IEnumerable<VerifyMerchantByMerchantIdandRegionalIdModelOutput>> VerifyMerchantByMerchantIdandRegionalId([FromBody] VerifyMerchantByMerchantIdandRegionalIdModelInput ObjClass);

        public Task<MerchantGetAllUnAllocatedCardsModelOutput> GetAllUnAllocatedCardsForOTCCard([FromBody] MerchantGetAllUnAllocatedCardsModelInput ObjClass);

        public Task<MerchantGetAllUnAllocatedCardsModelOutput> GetAllUnAllocatedCardsForDriverCard([FromBody] MerchantGetAllUnAllocatedCardsModelInput ObjClass);

        public Task<MerchantGetAllUnAllocatedCardsModelOutput> GetAllUnAllocatedCardsForTatkalCard([FromBody] MerchantGetAllUnAllocatedCardsModelInput ObjClass);

        public Task<IEnumerable<MerchantAllocatedCardsToMerchantModelOutput>> AllocatedOTCCardToMerchant([FromBody] MerchantAllocatedCardsToMerchantModelInput ObjClass);

        public Task<IEnumerable<MerchantAllocatedCardsToMerchantModelOutput>> AllocatedDriverCardToMerchant([FromBody] MerchantAllocatedCardsToMerchantModelInput ObjClass);

        public Task<IEnumerable<MerchantAllocatedCardsToMerchantModelOutput>> AllocatedTatkalCardToMerchant([FromBody] MerchantAllocatedCardsToMerchantModelInput ObjClass);

        public Task<IEnumerable<MerchantInsertDriverCardCustomerModelOutput>> InsertDriverCardCustomer([Microsoft.AspNetCore.Mvc.FromForm] MerchantInsertDriverCardCustomerModelInput ObjClass);

        public Task<IEnumerable<MerchantGetTerminalDeInstallationRequestCloseModelOutput>> GetTerminalDeInstallationRequestClose([FromBody] MerchantGetTerminalDeInstallationRequestCloseModelInput ObjClass);

        public Task<IEnumerable<MerchantTerminalDeInstalUpdateRequestCloseModelOutput>> TerminalDeInstalUpdateRequestClose([FromBody] MerchantTerminalDeInstalUpdateRequestCloseModelInput ObjClass);

        public Task<IEnumerable<MerchantGetTerminalInstallationRequestApprovalModelOutput>> GetTerminalInstallationRequestApproval([FromBody] MerchantGetTerminalInstallationRequestApprovalModelInput ObjClass);

        public Task<IEnumerable<MerchantUpdateTerminalInstallationRequestApprovalModelOutput>> InsertTerminalInstallationRequestApproval([FromBody] MerchantUpdateTerminalInstallationRequestApprovalModelInput ObjClass);

        public Task<IEnumerable<MerchantViewRequestedCardModelOutput>> ViewRequestedOTCCard([FromBody] MerchantViewRequestedCardModelInput ObjClass);

        public Task<IEnumerable<MerchantViewRequestedCardModelOutput>> ViewRequestedTatkalCard([FromBody] MerchantViewRequestedCardModelInput ObjClass);

        public Task<IEnumerable<MerchantViewRequestedCardModelOutput>> ViewRequestedDriverCard([FromBody] MerchantViewRequestedCardModelInput ObjClass);

        public Task<IEnumerable<MerchantInsertDealerWiseCardRequestModelOutput>> InsertDealerWiseOTCCardRequest([FromBody] MerchantInsertDealerWiseCardRequestModelInput ObjClass);

        public Task<IEnumerable<MerchantInsertDealerWiseCardRequestModelOutput>> InsertDealerWiseTatkalCardRequest([FromBody] MerchantInsertDealerWiseCardRequestModelInput ObjClass);

        public Task<IEnumerable<MerchantInsertDealerWiseCardRequestModelOutput>> InsertDealerWiseDriverCardRequest([FromBody] MerchantInsertDealerWiseCardRequestModelInput ObjClass);

        public Task<MerchantViewCardMerchantAllocationModelOutput> ViewOTCCardMerchantAllocation([FromBody] MerchantViewCardMerchantAllocationModelInput ObjClass);

        public Task<MerchantViewCardMerchantAllocationModelOutput> ViewTatkalCardMerchantAllocation([FromBody] MerchantViewCardMerchantAllocationModelInput ObjClass);

        public Task<MerchantViewCardMerchantAllocationModelOutput> ViewDriverCardMerchantAllocation([FromBody] MerchantViewCardMerchantAllocationModelInput ObjClass);

        public Task<IEnumerable<MerchantGetTerminalDeInstallationRequestApprovalModelOutput>> GetTerminalDeInstallationRequestApproval([FromBody] MerchantGetTerminalDeInstallationRequestApprovalModelInput ObjClass);

        public Task<IEnumerable<MerchantInsertTerminalDeInstallationRequestApprovalModelOutput>> InsertTerminalDeInstallationRequestApproval([FromBody] MerchantInsertTerminalDeInstallationRequestApprovalModelInput ObjClass);

        public Task<IEnumerable<MerchantGetTerminalDeInstallationRequestAuthorizationModelOutput>> GetTerminalDeInstallationRequestAuthorization([FromBody] MerchantGetTerminalDeInstallationRequestAuthorizationModelInput ObjClass);

        public Task<IEnumerable<MerchantInsertTerminalDeInstallationRequestAuthorizationModelOutput>> InsertTerminalDeInstallationRequestAuthorization([FromBody] MerchantInsertTerminalDeInstallationRequestAuthorizationModelInput ObjClass);

        public Task<IEnumerable<MerchantViewTerminalDeInstallationRequestStatusModelOutput>> ViewTerminalDeInstallationRequestStatus([FromBody] MerchantViewTerminalDeInstallationRequestStatusModelInput ObjClass);

        public Task<IEnumerable<MerchantGetProblematicDeinstalledToDeinstalledModelOutput>> GetProblematicDeinstalledToDeinstalled([FromBody] MerchantGetProblematicDeinstalledToDeinstalledModelInput ObjClass);

        public Task<IEnumerable<MerchantInsertProblematicDeinstalledToDeinstalledModelOutput>> InsertProblematicDeinstalledToDeinstalled([FromBody] MerchantInsertProblematicDeinstalledToDeinstalledModelInput ObjClass);

        public Task<IEnumerable<MerchantGetManageTerminalDetailsModelOutput>> GetManageTerminalDetails([FromBody] MerchantGetManageTerminalDetailsModelInput ObjClass);

        public Task<IEnumerable<MerchantSearchMerchantModelOutput>> SearchMerchant([FromBody] MerchantSearchMerchantModelInput ObjClass);

        public Task<IEnumerable<MerchantSearchTerminalModelOutput>> SearchTerminal([FromBody] MerchantSearchTerminalModelInput ObjClass);

        public Task<IEnumerable<MerchantGetMerchantStatusModelOutput>> GetMerchantStatus([FromBody] MerchantGetMerchantStatusModelInput ObjClass);

        public Task<IEnumerable<MerchantGetTerminalTypeModelOutput>> GetTerminalType([FromBody] MerchantGetTerminalTypeModelInput ObjClass);

    
        public Task<IEnumerable<MerchantInsertALCustomerModelOutput>> InsertALCustomer([FromBody] MerchantInsertALCustomerModelInput ObjClass);

        public  Task<IEnumerable<MerchantInsertDealerWiseALOTCCardRequestModelOutput>> InsertDealerWiseALOTCCardRequest([FromBody] MerchantInsertDealerWiseALOTCCardRequestModelInput ObjClass);

        public Task<IEnumerable<MerchantGetAvailityALOTCCardCardOutput>> GetAvailityALOTCCard([FromBody] MerchantGetAvailityALOTCCardCardInput ObjClass);

        public Task<IEnumerable<MerchantViewMerchantCautionLimitModelOutput>> ViewMerchantCautionLimit([FromBody] MerchantViewMerchantCautionLimitModelInput ObjClass);

        public Task<IEnumerable<MerchantSettlementDetailsModelOutput>> MerchantSettlementDetail([FromBody] MerchantSettlementDetailsModelInput ObjClass);

        public Task<IEnumerable<MerchantBatchDetailModelOutput>> MerchantBatchDetail([FromBody] MerchantBatchDetailModelInput ObjClass);

        public  Task<MerchantTerminalDetailModelOutput> TerminalDetail([FromBody] MerchantTerminalDetailModelInput ObjClass);

        public Task<IEnumerable<MerchantTransactionDetailModelOutput>> MerchantTransactionDetail([FromBody] MerchantTransactionDetailModelInput ObjClass);
    }
}
