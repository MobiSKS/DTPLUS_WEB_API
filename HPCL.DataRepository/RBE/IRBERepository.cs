using HPCL.DataModel.RBE;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.RBE
{
    public interface IRBERepository
    {
        public Task<IEnumerable<ChangeRBEMappingModelOutput>> ChangeRBEMapping([FromBody] ChangeRBEMappingModelInput ObjClass);

        public Task<IEnumerable<ManageRBEUserModelOutput>> ManageRBEUser([FromBody] ManageRBEUserModelInput ObjClass);

        public Task<IEnumerable<GetPendingRbeConsentModelOutput>> GetPendingRbeConsent([FromBody] GetPendingRbeConsentModelInput ObjClass);

        public Task<IEnumerable<RbeSentOtpForgotPasswordModelOutput>> RbeSentOtpForgotPassword([FromBody] RbeSentOtpForgotPasswordModelInput ObjClass);

        public Task<IEnumerable<RbeValidateForgotPasswordModelOutput>> RbeValidateForgotPassword([FromBody] RbeValidateForgotPasswordModelInput ObjClass);

        public Task<IEnumerable<GetRbeDashboardModelOutput>> GetRbeDashboard([FromBody] GetRbeDashboardModelInput ObjClass);

        public Task<IEnumerable<GetNewRbeAddCardsModelOutput>> GetNewRbeAddCards([FromBody] GetNewRbeAddCardsModelInput ObjClass);

        public Task<IEnumerable<GetNewRbeEnrollCustomersModelOutput>> GetNewRbeEnrollCustomers([FromBody] GetNewRbeEnrollCustomersModelInput ObjClass);

        public Task<IEnumerable<RBEGetModelOutput>> GetRBEId([FromBody] RBEGetModelInput ObjClass);

        public Task<IEnumerable<RbeSentOtpNewEnrollCustomerModelOutput>> RbeSentOtpNewEnrollCustomer([FromBody] RbeSentOtpNewEnrollCustomerModelInput ObjClass);

        public Task<IEnumerable<RbeValidateOtpNewEnrollCustomerModelOutput>> RbeValidateOtpNewEnrollCustomer([FromBody] RbeValidateOtpNewEnrollCustomerModelInput ObjClass);

        public Task<IEnumerable<BindRBEModelOutput>> BindRBEbyRBEId([FromBody] BindRBEModelInput ObjClass);

        public Task<IEnumerable<InsertRBEModelOutput>> InsertRBE([FromBody] InsertRBEModelInput ObjClass);

        public Task<IEnumerable<RBEUpdateModelOutput>> UpdateRBE([FromBody] RBEUpdateModelInput ObjClass);

        public Task<IEnumerable<RBEKYCModelOutput>> UploadRBEKYC([Microsoft.AspNetCore.Mvc.FromForm] RBEKYCModelInput ObjClass);

        public Task<IEnumerable<GetRBEMobilenoModelOutput>> CheckRBEMobileNo([FromBody] GetRBEMobilenoModelInput ObjClass);

        public Task<IEnumerable<GetRBECreationApprovalModelOutput>> BindRBEDetail([FromBody] GetRBECreationApprovalModelInput ObjClass);

        public Task<IEnumerable<GetRBEDetailbyUserNameModelOutput>> GetRBEDetailbyUserName([FromBody] GetRBEDetailbyUserNameModelInput ObjClass);

        public Task<IEnumerable<RBEApprovalRejectApprovalModelOutput>> ApproveRejectRBE([FromBody] RBEApprovalRejectModelInput ObjClass);

        public Task<IEnumerable<RBEDeviceIdResetRequestModelOutput>> RBEDeviceIdResetRequest([FromBody] RBEDeviceIdResetRequestModelInput ObjClass);
       
        public Task<IEnumerable<GetRBEMobileChangeRequestModelOutput>> GetRBEMobileChangeRequest([FromBody] GetRBEMobileChangeRequestModelInput ObjClass);
       
        public Task<IEnumerable<RequestToChangeRBEMappingModelOutput>> RequestToChangeRBEMapping([FromBody] RequestToChangeRBEMappingModelInput ObjClass);
       
        public Task<IEnumerable<ValidateOtpRBEMappingModelOutput>> ValidateOtpRBEMapping([FromBody] ValidateOtpRBEMappingModelInput ObjClass);

        public Task<IEnumerable<GetApproveChangeRBEMappingModelOutput>> GetApproveChangeRBEMapping([FromBody] GetApproveChangeRBEMappingModelInput ObjClass);

        public Task<IEnumerable<GetRbeMappingStatusModelOutput>> GetRbeMappingStatus([FromBody] GetRbeMappingStatusModelInput ObjClass);

        public Task<IEnumerable<ApproveRejectChangedRbeMappingModelOutput>> ApproveRejectChangedRbeMapping([FromBody] ApproveRejectChangedRbeMappingModelInput ObjClass);


        public Task<IEnumerable<SendOtpChangeRBEMobileModelOutput>> SendOtpChangeRBEMobile([FromBody] SendOtpChangeRBEMobileModelInput ObjClass);

        public Task<IEnumerable<ValidateOtpChangeRbeMobileModelOutput>> ValidateOtpChangeRbeMobile([FromBody] ValidateOtpChangeRbeMobileModelInput ObjClass);

        public Task<IEnumerable<GetApproveChangedRBEMobileModelOutput>> GetApproveChangedRBEMobile([FromBody] GetApproveChangedRBEMobileModelInput ObjClass);

        public Task<IEnumerable<ApproveRejectChangedRbeMobileModelOutput>> ApproveRejectChangedRbeMobile([FromBody] ApproveRejectChangedRbeMobileModelInput ObjClass);


    }
}
