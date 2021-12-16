using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using HPCL.DataModel.Login;
//using static HPCL.DataModel.Login;

namespace HPCL.DataRepository.Merchant
{
    public interface IMerchantRepository
    {
        public Task<object> SearchMerchant([FromBody] LoginModel ObjUser);
    }
}
