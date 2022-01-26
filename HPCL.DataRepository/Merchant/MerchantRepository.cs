using Dapper;
using HPCL.DataModel.Merchant;
using HPCL.DataRepository.DBDapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.Merchant
{
    public class MerchantRepository : IMerchantRepository
    {
        private readonly DapperContext _context;
        public MerchantRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<GetMerchantTypeModelOutput>> GetMerchantType([FromBody] GetMerchantTypeModelInput ObjClass)
        {
            //
            var procedureName = "UspGetMerchantType";
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetMerchantTypeModelOutput>(procedureName, null, commandType: CommandType.StoredProcedure);

        }

        public async Task<IEnumerable<GetMerchantOutletCategoryModelOutput>> GetOutletCategory([FromBody] GetMerchantOutletCategoryModelInput ObjClass)
        {
            
            var procedureName = "UspGetOutletCategory";
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetMerchantOutletCategoryModelOutput>(procedureName, null, commandType: CommandType.StoredProcedure);

        }

        public async Task<IEnumerable<MerchantGetSBUModelOutput>> GetSBU([FromBody] MerchantGetSBUModelInput ObjClass)
        {
            var procedureName = "UspGetSBU";
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<MerchantGetSBUModelOutput>(procedureName, null, commandType: CommandType.StoredProcedure);

        }
    }
}
