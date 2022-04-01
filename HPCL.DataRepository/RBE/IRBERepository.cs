using HPCL.DataModel.RBE;
using System;
using System.Collections.Generic;
using System.Text;
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



    }
}
