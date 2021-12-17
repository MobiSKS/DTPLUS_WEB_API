using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using HPCL.DataModel.Account;
using HPCL.DataModel.Login;
//using static HPCL.DataModel.Login;

namespace HPCL.DataRepository.Account
{
    public interface IAccountRepository
    {
        public bool GenerateToken(AccountModel ObjUser);
    }
}
