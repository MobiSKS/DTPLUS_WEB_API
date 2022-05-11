using HPCL.DataModel.AggregatorCustomer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.AggregatorCustomer
{
    public interface IAggregatorCustomerRepository
    {
        public Task<IEnumerable<AggregatorCustomerInsertModelOutput>> InsertAggregatorCustomer([FromBody] AggregatorCustomerInsertModelInput ObjClass);

        public Task<IEnumerable<AggregatorNormalFleetCustomerModelOutput>> InsertAggregatorNormalFleetCustomer([FromBody] AggregatorNormalFleetCustomerModelInput ObjClass);

        public Task<IEnumerable<AggregatorCustomerUpdateModelOutput>> UpdateAggregatorCustomer([FromBody] AggregatorCustomerUpdateModelInput ObjClass);

        public Task<IEnumerable<AggregatorCustomerKYCModelOutput>> UploadAggregatorCustomerKYC([FromBody] AggregatorCustomerKYCModelInput ObjClass);

        public Task<IEnumerable<AggregatorCustomerApprovalModelOutput>> ApproveRejectAggregatorCustomer([FromBody] AggregatorCustomerApprovalModelInput ObjClass);

        public Task<IEnumerable<AggregatorCustomerFeewaiverApprovalModelOutput>> ApproveRejectAggregatorFeewaiver([FromBody] AggregatorCustomerFeewaiverApprovalModelInput ObjClass);

        public Task<GetApproveAggregatorFeeWaiverDetailModelOutput> GetApproveAggregatorFeeWaiverDetail([FromBody] GetApproveAggregatorFeeWaiverDetailModelInput ObjClass);

        public Task<IEnumerable<AggregatorCustomerGetCustomerReferenceNoModelOutput>> GetAggregatorNameandFormNumberbyReferenceNo([FromBody] AggregatorCustomerGetCustomerReferenceNoModelInput ObjClass);

        public Task<IEnumerable<AggregatorCustomerGetCustomerReferenceNoModelOutput>> GetAggregatorNameandFormNumberbyReferenceNoforAddCard([FromBody] AggregatorCustomerGetCustomerReferenceNoModelInput ObjClass);

        public Task<AggregatorCustomerDetailsModelOutput> GetAggregatorCustomerDetails([FromBody] AggregatorCustomerDetailsModelInput ObjClass);

        public Task<AggregatorCustomerDetailsModelOutput> GetAggregatorCustomerByCustomerId([FromBody] AggregatorCustomerGetByCustomerIdModelInput ObjClass);

        public Task<AggregatorCustomerDetailsModelOutput> GetRawAggregatorCustomerDetails([FromBody] AggregatorCustomerDetailsModelInput ObjClass);

        public Task<IEnumerable<BindPendingAggregatorCustomerModelOutput>> BindPendingAggregatorCustomer([FromBody] BindPendingAggregatorCustomerModelInput ObjClass);

        public Task<IEnumerable<BindPendingAggregatorCustomerModelOutput>> BindUnverfiedAggregatorCustomer([FromBody] BindPendingAggregatorCustomerModelInput ObjClass);

        public Task<AggregatorCustomerDetailsModelOutput> GetUnverfiedAggregatorCustomerDetailbyFormNumber([FromBody] AggregatorCustomerDetailsbyFormNumberModelInput ObjClass);

        public Task<IEnumerable<AggregatorCustomerGetCustomerNameModelOutput>> GetAggregatorCustomerNameByCustomerId([FromBody] AggregatorCustomerGetByCustomerIdModelInput ObjClass);

        public Task<IEnumerable<AggregatorCustomerGetCustomerDetailsForSearchModelOutput>> GetAggregatorCustomerDetailsForSearch([FromBody] AggregatorCustomerGetByCustomerIdModelInput ObjClass);

        public Task<SearchAggregatorCustomerandCardFormModelOutput> SearchAggregatorCustomerandCardForm([FromBody] SearchAggregatorCustomerandCardFormModelInput ObjClass);

        public Task<IEnumerable<GetAggregatorNameandFormNumberbyCustomerIdModelOutput>> GetAggregatorNameandFormNumberbyCustomerId([FromBody] GetAggregatorNameandFormNumberbyCustomerIdModelInput ObjClass);

        public Task<IEnumerable<AggregatorCustomerAddOnUserModelOutput>> AggregatorCustomerAddOnUser([FromBody] AggregatorCustomerAddOnUserModelInput ObjClass);


    }
}
