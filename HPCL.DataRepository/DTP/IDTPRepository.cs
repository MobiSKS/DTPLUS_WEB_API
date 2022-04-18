using HPCL.DataModel.DTP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.DTP
{
    public interface IDTPRepository
    {
        public Task<IEnumerable<GetBlockUnBlockCustomerCCMSAccountByCustomerIdModelOutput>> GetBlockUnBlockCustomerCCMSAccountByCustomerId([FromBody] GetBlockUnBlockCustomerCCMSAccountByCustomerIdModelInput ObjClass);

        public Task<IEnumerable<BlockUnBlockCustomerCCMSAccountOutput>> BlockUnBlockCustomerCCMSAccount([FromBody] BlockUnBlockCustomerCCMSAccountInput ObjClass);

    }
}
