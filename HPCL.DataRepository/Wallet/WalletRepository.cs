using Dapper;
using HPCL.DataRepository.DBDapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using HPCL.DataModel.Wallet;

namespace HPCL.DataRepository.Wallet
{
    public class WalletRepository : IWalletRepository
    {
        private readonly DapperContext _context;
        public WalletRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<Allcardsbycustomerid> Getallcardsbycustomerid([FromBody] AllcardsbycustomeridInputModel ObjClass)
        {
            var procedureName = "Usp_Wallet_All_Cards_By_Customer_Id";
            var parameters = new DynamicParameters();
            parameters.Add("customer_id", ObjClass.Customer_id, DbType.String, ParameterDirection.Input);
            using (var connection = _context.CreateConnection())
            {
                var outresult = await connection.QueryFirstOrDefaultAsync<Allcardsbycustomerid>
                    (procedureName, parameters, commandType: CommandType.StoredProcedure);
                return outresult;
            }
        }
    }
}
