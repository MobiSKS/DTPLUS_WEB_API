using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using HPCL.DataModel.Login;
//using static HPCL.DataModel.Login;

namespace HPCL.DataRepository.EncryptRequest
{
    public interface IEncryptRequestRepository
    {
        public Task<object> EncryptRequest([FromBody] LoginModel ObjUser);
    }
}
