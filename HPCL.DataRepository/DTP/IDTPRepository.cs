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
        public Task<IEnumerable<CardBalanceTransferModelOutput>> CardBalanceTransfer([FromBody] CardBalanceTransferModelInput ObjClass);
       
        public Task<IEnumerable<InsertTeamMappingModelOutput>> InsertTeamMapping([FromBody] InsertTeamMappingModelInput ObjClass);
        public Task<IEnumerable<GetTeamMappingModelOutput>> GetTeamMapping([FromBody] GetTeamMappingModelInput ObjClass);
        public Task<IEnumerable<UpdateTeamMappingModelOutput>> UpdateTeamMapping([FromBody] UpdateTeamMappingModelInput ObjClass);
        public Task<IEnumerable<DeleteHTeamMappingModelOutput>> DeleteTeamMapping([FromBody] DeleteTeamMappingModelInput ObjClass);
    }
}
