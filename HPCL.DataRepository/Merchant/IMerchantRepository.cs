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

        public Task<IEnumerable<GetMerchantTypeModelOutput>> GetReasonList([FromBody] MerchantGetReasonListModelInput ObjClass);

        public Task<IEnumerable<MerchantUpdateTerminalInstallationRequestCloseModelOutput>> UpdateTerminalInstallationRequestClose([FromBody] MerchantUpdateTerminalInstallationRequestCloseModelInput ObjClass);

        public Task<IEnumerable<MerchantViewTerminalInstallationRequestStatusCloseModelOutput>> ViewTerminalInstallationRequestStatus([FromBody] MerchantViewTerminalInstallationRequestStatusCloseInput ObjClass);
    }
}
