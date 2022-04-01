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

        
       
        public Task<IEnumerable<VerifyMerchantByMerchantIdModelOutput>> VerifyMerchantByMerchantId([FromBody] VerifyMerchantByMerchantIdModelInput ObjClass);

        public Task<IEnumerable<VerifyMerchantByMerchantIdandRegionalIdModelOutput>> VerifyMerchantByMerchantIdandRegionalId([FromBody] VerifyMerchantByMerchantIdandRegionalIdModelInput ObjClass);



        public Task<IEnumerable<MerchantSearchMerchantModelOutput>> SearchMerchant([FromBody] MerchantSearchMerchantModelInput ObjClass);

        public Task<IEnumerable<MerchantGetMerchantStatusModelOutput>> GetMerchantStatus([FromBody] MerchantGetMerchantStatusModelInput ObjClass);
       
        public Task<IEnumerable<MerchantViewMerchantCautionLimitModelOutput>> ViewMerchantCautionLimit([FromBody] MerchantViewMerchantCautionLimitModelInput ObjClass);

        public Task<IEnumerable<MerchantSettlementDetailsModelOutput>> MerchantSettlementDetail([FromBody] MerchantSettlementDetailsModelInput ObjClass);

        public Task<IEnumerable<MerchantBatchDetailModelOutput>> MerchantBatchDetail([FromBody] MerchantBatchDetailModelInput ObjClass);

        public Task<IEnumerable<MerchantTransactionDetailModelOutput>> MerchantTransactionDetail([FromBody] MerchantTransactionDetailModelInput ObjClass);

        public Task<IEnumerable<MerchantSaleReloadDeltaDetailModelOutput>> MerchantSaleReloadDeltaDetail([FromBody] MerchantSaleReloadDeltaDetailModelInput ObjClass);

        public Task<IEnumerable<MerchantERPReloadSaleEarningDetailModelOutput>> MerchantERPReloadSaleEarningDetail([FromBody] MerchantERPReloadSaleEarningDetailModelInput ObjClass);

        public Task<IEnumerable<MerchantReceivablePayableDetailModelOutput>> MerchantReceivablePayableDetail([FromBody] MerchantReceivablePayableDetailModelInput ObjClass);

        public Task<IEnumerable<ValidateMerchantErpCodeModelOutput>> ValidateMerchantErpCode([FromBody] ValidateMerchantErpCodeModelInput ObjClass);


    }
}
