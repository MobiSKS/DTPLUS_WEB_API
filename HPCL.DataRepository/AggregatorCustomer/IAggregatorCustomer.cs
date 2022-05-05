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

        public Task<IEnumerable<AggregatorCustomerUpdateModelOutput>> UpdateAggregatorCustomer([FromBody] AggregatorCustomerUpdateModelInput ObjClass);

        public Task<IEnumerable<AggregatorCustomerKYCModelOutput>> UploadAggregatorCustomerKYC([FromBody] AggregatorCustomerKYCModelInput ObjClass);

        public Task<IEnumerable<AggregatorCustomerApprovalModelOutput>> ApproveRejectAggregatorCustomer([FromBody] AggregatorCustomerApprovalModelInput ObjClass);

        public Task<IEnumerable<AggregatorCustomerFeewaiverApprovalModelOutput>> ApproveRejectAggregatorFeewaiver([FromBody] AggregatorCustomerFeewaiverApprovalModelInput ObjClass);

        public Task<GetApproveAggregatorFeeWaiverDetailModelOutput> GetApproveAggregatorFeeWaiverDetail([FromBody] GetApproveAggregatorFeeWaiverDetailModelInput ObjClass);

    }
}
