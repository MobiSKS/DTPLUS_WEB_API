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

        public async Task<CardLimtModelOutput> GetCardLimitFeatures([FromBody] CardLimtModelInput ObjClass)
        {
            var procedureName = "UspGetCardFeatures";
            var parameters = new DynamicParameters();
            parameters.Add("Cardno", ObjClass.Cardno, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            var result = await connection.QueryMultipleAsync(procedureName, parameters, commandType: CommandType.StoredProcedure);
            var tblCardLimtModelOutput = await result.ReadAsync<GetCardLimtModelOutput>();
            var tblCardReminingLimtModelOutput = await result.ReadAsync<CardReminingLimtModelOutput>();
            var tblCardReminingCCMSLimtModelOutput = await result.ReadAsync<CardReminingCCMSLimtModelOutput>();
            var tblCardServicesModelOutput = await result.ReadAsync<CardServicesModelOutput>();
            var storedProcedureResult = new CardLimtModelOutput();
            storedProcedureResult.GetCardLimtModel = (List<GetCardLimtModelOutput>)tblCardLimtModelOutput;
            storedProcedureResult.CardReminingLimt = (List<CardReminingLimtModelOutput>)tblCardReminingLimtModelOutput;
            storedProcedureResult.CardReminingCCMSLimt = (List<CardReminingCCMSLimtModelOutput>)tblCardReminingCCMSLimtModelOutput;
            storedProcedureResult.CardServices = (List<CardServicesModelOutput>)tblCardServicesModelOutput;
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
            parameters.Add("Customerid", ObjClass.Customerid, DbType.Int64, ParameterDirection.Input);
            parameters.Add("Cardno", ObjClass.Cardno, DbType.String, ParameterDirection.Input);
            parameters.Add("Serviceid", ObjClass.Serviceid, DbType.String, ParameterDirection.Input);
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
            parameters.Add("Onetime", ObjClass.Onetime, DbType.Double, ParameterDirection.Input);
            parameters.Add("Daily", ObjClass.Daily, DbType.Int32, ParameterDirection.Input);
            parameters.Add("Monthly", ObjClass.Monthly, DbType.Int32, ParameterDirection.Input);
            parameters.Add("Yearly", ObjClass.Yearly, DbType.Int32, ParameterDirection.Input);
            parameters.Add("ModifiedBy", ObjClass.ModifiedBy, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<UpdateCardLimitsModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<UpdateCCMSLimitsModelOutput>> UpdateCCMSLimits([FromBody] UpdateCCMSLimitsModelInput ObjClass)
        {
            var procedureName = "UspUpdateCCMSLimits";
            var parameters = new DynamicParameters();
            parameters.Add("Cardno", ObjClass.Cardno, DbType.String, ParameterDirection.Input);
            parameters.Add("Onetime", ObjClass.Onetime, DbType.Double, ParameterDirection.Input);
            parameters.Add("Daily", ObjClass.Daily, DbType.Int32, ParameterDirection.Input);
            parameters.Add("Monthly", ObjClass.Monthly, DbType.Int32, ParameterDirection.Input);
            parameters.Add("Yearly", ObjClass.Yearly, DbType.Int32, ParameterDirection.Input);
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

    }
}
