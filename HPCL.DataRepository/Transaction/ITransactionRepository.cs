using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using HPCL.DataModel.Transaction;

namespace HPCL.DataRepository.Transaction
{
    public interface ITransactionRepository
    {
        public Task<object> User_Login([FromBody] TransactionModel ObjUser);
    }
}
