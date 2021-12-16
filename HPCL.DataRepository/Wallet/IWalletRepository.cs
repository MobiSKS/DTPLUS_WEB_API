using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using HPCL.DataModel.Wallet;
//using static HPCL.DataModel.Login;

namespace HPCL.DataRepository.Wallet
{
    public interface IWalletRepository
    {
        public Task<Allcardsbycustomerid> Getallcardsbycustomerid([FromBody] AllcardsbycustomeridInputModel ObjClass);
    }
}
