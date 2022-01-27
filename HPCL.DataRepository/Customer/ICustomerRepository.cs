using HPCL.DataModel.Customer;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.Customer
{
    public interface ICustomerRepository
    {
        public Task<IEnumerable<GetCustomerTypeModelOutput>> GetCustomerType([FromBody] GetCustomerTypeModelInput ObjClass);
        public Task<IEnumerable<GetCustomerSubTypeModelOutput>> GetCustomerSubType([FromBody] GetCustomerSubTypeModelInput ObjClass);
        public Task<IEnumerable<GetCustomerTBEntityNameModelOutput>> GetTBEntityName([FromBody] GetCustomerTBEntityNameModelInput ObjClass);
        public Task<IEnumerable<GetCustomerSecretQuestionModelOutput>> GetSecretQuestion([FromBody] GetCustomerSecretQuestionModelInput ObjClass);
        public Task<IEnumerable<GetCustomerTypeOfFleetModelOutput>> GetTypeOfFleet([FromBody] GetCustomerTypeOfFleetModelInput ObjClass);
        public Task<IEnumerable<CustomerInsertModelOutput>> InsertCustomer([FromBody] CustomerInsertModelInput ObjClass);
    }

}
