using Dapper;
using HPCL.DataModel.Card;
using HPCL.DataRepository.DBDapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.Card
{
    public class CardRepository : ICardRepository
    {
        private readonly DapperContext _context;
        public CardRepository(DapperContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<ManageSearchCardsModelOutput>> SearchManageCard([FromBody] ManageSearchCardsModelInput ObjClass)
        {
            var procedureName = "UspGetCardInfo";
            var parameters = new DynamicParameters();
            parameters.Add("Customerid", ObjClass.Customerid, DbType.String, ParameterDirection.Input);
            parameters.Add("Cardno", ObjClass.Cardno, DbType.String, ParameterDirection.Input);
            parameters.Add("Mobileno", ObjClass.Mobileno, DbType.String, ParameterDirection.Input);
            parameters.Add("Vehiclenumber", ObjClass.Vehiclenumber, DbType.String, ParameterDirection.Input);
            parameters.Add("Statusflag", ObjClass.Statusflag, DbType.Int32, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<ManageSearchCardsModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<GetCardLimtModelOutput> GetCardLimitFeatures([FromBody] GetCardLimtModelInput ObjClass)
        {
            var procedureName = "UspGetCardFeatures";
            var parameters = new DynamicParameters();
            parameters.Add("Cardno", ObjClass.Cardno, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            var result = await connection.QueryMultipleAsync(procedureName, parameters, commandType: CommandType.StoredProcedure);
            var storedProcedureResult = new GetCardLimtModelOutput();
            storedProcedureResult.GetCardsDetails = (List<GetCardsDetailsModelOutput>)await result.ReadAsync<GetCardsDetailsModelOutput>(); ;
            storedProcedureResult.GetCardLimt = (List<CardLimtModelOutput>)await result.ReadAsync<CardLimtModelOutput>(); ;
            //storedProcedureResult.CardReminingLimt = (List<CardReminingLimtModelOutput>)await result.ReadAsync<CardReminingLimtModelOutput>();
            //storedProcedureResult.CardReminingCCMSLimt = (List<CardReminingCCMSLimtModelOutput>)await result.ReadAsync<CardReminingCCMSLimtModelOutput>();
            storedProcedureResult.CardServices = (List<CardServicesModelOutput>)await result.ReadAsync<CardServicesModelOutput>(); ;
            return storedProcedureResult;
        }

        public async Task<IEnumerable<UpdateMobileInCardModelOutput>> UpdateMobileInCard([FromBody] UpdateMobileInCardModelInput ObjClass)
        {
            var procedureName = "UspUpdateMobileInCard";
            var parameters = new DynamicParameters();
            parameters.Add("Cardno", ObjClass.Cardno, DbType.String, ParameterDirection.Input);
            parameters.Add("Mobileno", ObjClass.Mobileno, DbType.String, ParameterDirection.Input);
            parameters.Add("ModifiedBy", ObjClass.ModifiedBy, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<UpdateMobileInCardModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<UpdateServiveOnCardModelOutput>> UpdateServiveOnCard([FromBody] UpdateServiveOnCardModelInput ObjClass)
        {
            var procedureName = "UspUpdateServiveOnCard";
            var parameters = new DynamicParameters();
            parameters.Add("CustomerID", ObjClass.CustomerID, DbType.String, ParameterDirection.Input);
            parameters.Add("Cardno", ObjClass.Cardno, DbType.String, ParameterDirection.Input);
            parameters.Add("Serviceid", ObjClass.Serviceid, DbType.Int32, ParameterDirection.Input);
            parameters.Add("Flag", ObjClass.Flag, DbType.Int32, ParameterDirection.Input);
            parameters.Add("CreatedBy", ObjClass.CreatedBy, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<UpdateServiveOnCardModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<UpdateCardLimitsModelOutput>> UpdateCardLimits([FromBody] UpdateCardLimitsModelInput ObjClass)
        {
            var procedureName = "UspUpdateCardLimits";
            var parameters = new DynamicParameters();
            parameters.Add("Cardno", ObjClass.Cardno, DbType.String, ParameterDirection.Input);
            parameters.Add("Cashpurse", ObjClass.Cashpurse, DbType.Double, ParameterDirection.Input);
            parameters.Add("Saletxn", ObjClass.Saletxn, DbType.Int32, ParameterDirection.Input);
            parameters.Add("Dailysale", ObjClass.Dailysale, DbType.Int32, ParameterDirection.Input);
            parameters.Add("Monthlysale", ObjClass.Monthlysale, DbType.Int32, ParameterDirection.Input);
            parameters.Add("ModifiedBy", ObjClass.ModifiedBy, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<UpdateCardLimitsModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<UpdateCCMSLimitsModelOutput>> UpdateCCMSLimits([FromBody] UpdateCCMSLimitsModelInput ObjClass)
        {
            var procedureName = "UspUpdateCCMSLimits";
            var parameters = new DynamicParameters();
            parameters.Add("Cardno", ObjClass.Cardno, DbType.String, ParameterDirection.Input);
            parameters.Add("Limittype", ObjClass.Limittype, DbType.Int32, ParameterDirection.Input);
            parameters.Add("Amount", ObjClass.Amount, DbType.Double, ParameterDirection.Input);
            parameters.Add("ModifiedBy", ObjClass.ModifiedBy, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<UpdateCCMSLimitsModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<GetCCMSLimitsModelOutput>> GetCCMSLimits([FromBody] GetCCMSLimitsModelInput ObjClass)
        {
            var procedureName = "UspGetCCMSLimits";
            var parameters = new DynamicParameters();
            parameters.Add("Customerid", ObjClass.Customerid, DbType.String, ParameterDirection.Input);
            parameters.Add("Cardno", ObjClass.Cardno, DbType.String, ParameterDirection.Input);
            parameters.Add("Mobileno", ObjClass.Mobileno, DbType.String, ParameterDirection.Input);
            parameters.Add("Statusflag", ObjClass.Statusflag, DbType.Int32, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetCCMSLimitsModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }
        
        public async Task<IEnumerable<GetCardLimitsModelOutput>> GetCardLimits([FromBody] GetCardLimitsModelInput ObjClass)
        {
            var procedureName = "UspGetCardLimits";
            var parameters = new DynamicParameters();
            parameters.Add("Customerid", ObjClass.Customerid, DbType.String, ParameterDirection.Input);
            parameters.Add("Cardno", ObjClass.Cardno, DbType.String, ParameterDirection.Input);
            parameters.Add("Mobileno", ObjClass.Mobileno, DbType.String, ParameterDirection.Input);
            parameters.Add("Statusflag", ObjClass.Statusflag, DbType.Int32, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetCardLimitsModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }


        public async Task<IEnumerable<UpdateCCMSLimitForAllCardsModelOutput>> UpdateCCMSLimitForAllCards([FromBody] UpdateCCMSLimitForAllCardsModelInput ObjClass)
        {
            var procedureName = "UspUpdateCCMSLimitForAllCards";
            var parameters = new DynamicParameters();
            parameters.Add("CustomerID", ObjClass.CustomerID, DbType.String, ParameterDirection.Input);
            parameters.Add("Limittype", ObjClass.Limittype, DbType.Int32, ParameterDirection.Input);
            parameters.Add("Amount", ObjClass.Amount, DbType.Double, ParameterDirection.Input);
            parameters.Add("ModifiedBy", ObjClass.ModifiedBy, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<UpdateCCMSLimitForAllCardsModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<UpdateCardLimitForAllCardsModelOutput>> UpdateCardLimitForAllCards([FromBody] UpdateCardLimitForAllCardsModelInput ObjClass)
        {
            var procedureName = "UspUpdateCardLimitForAllCards";
            var parameters = new DynamicParameters();
            parameters.Add("CustomerID", ObjClass.CustomerID, DbType.String, ParameterDirection.Input);
            parameters.Add("Cashpurse", ObjClass.Cashpurse, DbType.Double, ParameterDirection.Input);
            parameters.Add("Saletxn", ObjClass.Saletxn, DbType.Int32, ParameterDirection.Input);
            parameters.Add("Dailysale", ObjClass.Dailysale, DbType.Int32, ParameterDirection.Input);
            parameters.Add("Monthlysale", ObjClass.Monthlysale, DbType.Int32, ParameterDirection.Input);
            parameters.Add("ModifiedBy", ObjClass.ModifiedBy, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<UpdateCardLimitForAllCardsModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<GetLimitMasterModelOutput>> GetCCMSLimitMaster([FromBody] GetLimitMasterModelInput ObjClass)
        {
            var procedureName = "UspGetCCMSLimitMaster";
            var parameters = new DynamicParameters();
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetLimitMasterModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }


        public async Task<IEnumerable<GetAllCardWithStatusModelOutput>> GetAllCardWithStatus([FromBody] GetAllCardWithStatusModelInput ObjClass)
        {
            var procedureName = "UspGetAllCardWithStatus";
            var parameters = new DynamicParameters();
            parameters.Add("Customerid", ObjClass.Customerid, DbType.String, ParameterDirection.Input);
            parameters.Add("Cardno", ObjClass.Cardno, DbType.String, ParameterDirection.Input);
            parameters.Add("Mobileno", ObjClass.Mobileno, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetAllCardWithStatusModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<UpdateCardStatusModelOutput>> UpdateCardStatus([FromBody] UpdateCardStatusModelInput ObjClass)
        {
            var procedureName = "UspUpdateCardStatus";
            var parameters = new DynamicParameters();
            parameters.Add("Cardno", ObjClass.Cardno, DbType.String, ParameterDirection.Input);
            parameters.Add("Statusflag", ObjClass.Statusflag, DbType.Int32, ParameterDirection.Input);
            parameters.Add("ModifiedBy", ObjClass.ModifiedBy, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<UpdateCardStatusModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }


    }
}
