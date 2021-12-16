using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using HPCL.DataModel.User;
//using static HPCL.DataModel.Login;

namespace HPCL.DataRepository.User
{
    public interface IUserRepository
    {
        public Task<object> User_Login([FromBody] UserModel ObjUser);
    }
}
