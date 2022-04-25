using HPCL.DataModel.CustomerAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.CustomerAPI
{
    public interface ICustomerAPIRepository
    {
        Task<IEnumerable<CustomerAPICheckVechileNoModelOutput>> CustomerAPICheckVechileNo([FromBody] CustomerAPICheckVechileNoModelInput ObjClass);
    }
}
