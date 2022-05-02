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

    }
}
