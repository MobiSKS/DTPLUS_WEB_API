using Dapper;
using HPCL.DataModel.Card;
using HPCL.DataRepository.DBDapper;
using HPCL.Infrastructure.CommonClass;
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

            var dtDBR = new DataTable("TypeUpdateCardLimits");
            dtDBR.Columns.Add("Cardno", typeof(string));
            dtDBR.Columns.Add("Cashpurse", typeof(float));
            dtDBR.Columns.Add("Saletxn", typeof(int));
            dtDBR.Columns.Add("Dailysale", typeof(int));
            dtDBR.Columns.Add("Monthlysale", typeof(int));

            var procedureName = "UspUpdateCardLimits";
            var parameters = new DynamicParameters();

            //parameters.Add("Cardno", ObjClass.Cardno, DbType.String, ParameterDirection.Input);
            //parameters.Add("Cashpurse", ObjClass.Cashpurse, DbType.Double, ParameterDirection.Input);
            //parameters.Add("Saletxn", ObjClass.Saletxn, DbType.Int32, ParameterDirection.Input);
            //parameters.Add("Dailysale", ObjClass.Dailysale, DbType.Int32, ParameterDirection.Input);
            //parameters.Add("Monthlysale", ObjClass.Monthlysale, DbType.Int32, ParameterDirection.Input);

            foreach (CardLimitsModelInput ObjCardLimits in ObjClass.ObjCardLimits)
            {
                DataRow dr = dtDBR.NewRow();
                dr["Cardno"] = ObjCardLimits.Cardno;
                dr["Cashpurse"] = ObjCardLimits.Cashpurse;
                dr["Saletxn"] = ObjCardLimits.Saletxn;
                dr["Dailysale"] = ObjCardLimits.Dailysale;
                dr["Monthlysale"] = ObjCardLimits.Monthlysale;

                dtDBR.Rows.Add(dr);
                dtDBR.AcceptChanges();
            }

            parameters.Add("TypeUpdateCardLimits", dtDBR, DbType.Object, ParameterDirection.Input);
            parameters.Add("ModifiedBy", ObjClass.ModifiedBy, DbType.String, ParameterDirection.Input);
            parameters.Add("UserAgent", ObjClass.Useragent, DbType.String, ParameterDirection.Input);
            parameters.Add("Userid", ObjClass.Userid, DbType.String, ParameterDirection.Input);
            parameters.Add("Userip", ObjClass.Userip, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<UpdateCardLimitsModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<UpdateCCMSLimitsModelOutput>> UpdateCCMSLimits([FromBody] UpdateCCMSLimitsModelInput ObjClass)
        {

            var dtDBR = new DataTable("TypeUpdateCCMSLimits");
            dtDBR.Columns.Add("Cardno", typeof(string));
            dtDBR.Columns.Add("Limittype", typeof(int));
            dtDBR.Columns.Add("Amount", typeof(float));
            dtDBR.Columns.Add("MobileNo", typeof(string));


            var procedureName = "UspUpdateCCMSLimits";
            var parameters = new DynamicParameters();
            //parameters.Add("Cardno", ObjClass.Cardno, DbType.String, ParameterDirection.Input);
            //parameters.Add("Limittype", ObjClass.Limittype, DbType.Int32, ParameterDirection.Input);
            //parameters.Add("Amount", ObjClass.Amount, DbType.Double, ParameterDirection.Input);

            parameters.Add("ModifiedBy", ObjClass.ModifiedBy, DbType.String, ParameterDirection.Input);
            parameters.Add("UserAgent", ObjClass.Useragent, DbType.String, ParameterDirection.Input);
            parameters.Add("Userid", ObjClass.Userid, DbType.String, ParameterDirection.Input);
            parameters.Add("Userip", ObjClass.Userip, DbType.String, ParameterDirection.Input);

            foreach (CCMSLimitsModelInput ObjCardLimits in ObjClass.ObjCCMSLimits)
            {
                DataRow dr = dtDBR.NewRow();
                dr["Cardno"] = ObjCardLimits.Cardno;
                dr["Limittype"] = ObjCardLimits.Limittype;
                dr["Amount"] = ObjCardLimits.Amount;
                dr["MobileNo"] = ObjCardLimits.MobileNo;
                dtDBR.Rows.Add(dr);
                dtDBR.AcceptChanges();
            }

            parameters.Add("TypeUpdateCCMSLimits", dtDBR, DbType.Object, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<UpdateCCMSLimitsModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<GetCCMSLimitsModelOutput> GetCCMSLimits([FromBody] GetCCMSLimitsModelInput ObjClass)
        {
            var procedureName = "UspGetCCMSLimits";
            var parameters = new DynamicParameters();
            parameters.Add("Customerid", ObjClass.Customerid, DbType.String, ParameterDirection.Input);
            parameters.Add("Cardno", ObjClass.Cardno, DbType.String, ParameterDirection.Input);
            parameters.Add("Mobileno", ObjClass.Mobileno, DbType.String, ParameterDirection.Input);
            parameters.Add("VechileNo", ObjClass.VechileNo, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            var result = await connection.QueryMultipleAsync(procedureName, parameters, commandType: CommandType.StoredProcedure);

            var storedProcedureResult = new GetCCMSLimitsModelOutput();
            storedProcedureResult.CCMSBalanceDetail = (List<GetCCMSLimitsForAllCardsModelOutput>)await result.ReadAsync<GetCCMSLimitsForAllCardsModelOutput>(); ;
            storedProcedureResult.CCMSBasicDetail = (List<CCMSLimitsModelOutput>)await result.ReadAsync<CCMSLimitsModelOutput>(); ;
            return storedProcedureResult;
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

        public async Task<IEnumerable<ViewCardLimitsModelOutput>> ViewCardLimits([FromBody] ViewCardLimitsModelInput ObjClass)
        {
            var procedureName = "UspGetCustomerAllCardAllLimits";
            var parameters = new DynamicParameters();
            parameters.Add("Customerid", ObjClass.Customerid, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<ViewCardLimitsModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }


        public async Task<IEnumerable<GetCCMSLimitsForAllCardsModelOutput>> GetCCMSLimitsForAllCards([FromBody] GetCCMSLimitsForAllCardsModelInput ObjClass)
        {
            var procedureName = "UspGetCCMSLimitsForAllCards";
            var parameters = new DynamicParameters();
            parameters.Add("Customerid", ObjClass.Customerid, DbType.String, ParameterDirection.Input);
            parameters.Add("Statusflag", ObjClass.Statusflag, DbType.Int32, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetCCMSLimitsForAllCardsModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }


        public async Task<IEnumerable<AddCardModelOutput>> AddCard([FromBody] AddCardModelInput ObjClass)
        {
            var dtDBR = new DataTable("UserDTNoofCards");
            dtDBR.Columns.Add("CardIdentifier", typeof(string));
            dtDBR.Columns.Add("VechileNo", typeof(string));
            dtDBR.Columns.Add("VehicleMake", typeof(string));
            dtDBR.Columns.Add("VehicleType", typeof(int));
            dtDBR.Columns.Add("YearOfRegistration", typeof(int));

            var procedureName = "UspAddCard";
            var parameters = new DynamicParameters();
            parameters.Add("CustomerReferenceNo", ObjClass.CustomerReferenceNo, DbType.Int64, ParameterDirection.Input);
            parameters.Add("NoOfCards", ObjClass.NoOfCards, DbType.Int32, ParameterDirection.Input);
            parameters.Add("RBEId", ObjClass.RBEId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("FeePaymentsCollectFeeWaiver", ObjClass.FeePaymentsCollectFeeWaiver, DbType.Int16, ParameterDirection.Input);
            parameters.Add("FeePaymentNo", ObjClass.FeePaymentNo, DbType.String, ParameterDirection.Input);
            parameters.Add("FeePaymentDate", ObjClass.FeePaymentDate, DbType.DateTime, ParameterDirection.Input);

            if (ObjClass.NoOfCards > 0 && ObjClass.ObjCardDetail != null)
            {
                foreach (CardDetail ObjCardDetails in ObjClass.ObjCardDetail)
                {
                    DataRow dr = dtDBR.NewRow();
                    dr["CardIdentifier"] = ObjCardDetails.CardIdentifier;
                    dr["VechileNo"] = ObjCardDetails.VechileNo;
                    dr["VehicleMake"] = ObjCardDetails.VehicleMake;
                    dr["VehicleType"] = ObjCardDetails.VehicleType;
                    dr["YearOfRegistration"] = ObjCardDetails.YearOfRegistration;

                    dtDBR.Rows.Add(dr);
                    dtDBR.AcceptChanges();
                }
            }
            parameters.Add("CardDetails", dtDBR, DbType.Object, ParameterDirection.Input);
            parameters.Add("CreatedBy", ObjClass.CreatedBy, DbType.String, ParameterDirection.Input);
            parameters.Add("CardPreference", ObjClass.CardPreference, DbType.String, ParameterDirection.Input);
            parameters.Add("ReferenceId", Variables.FunGenerateStringUId(), DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<AddCardModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }


        public async Task<IEnumerable<UpdateMobileandFastagNoInCardModelOutput>> UpdateMobileandFastagNoInCard([FromBody] UpdateMobileandFastagNoInCardModelInput ObjClass)
        {
            var dtDBR = new DataTable("TypeUpdateMobileInCard");
            dtDBR.Columns.Add("Cardno", typeof(string));
            dtDBR.Columns.Add("Mobileno", typeof(string));
            dtDBR.Columns.Add("FastagNo", typeof(string));

            var procedureName = "UspUpdateMobileandFastagNoInCard";
            var parameters = new DynamicParameters();

            if (ObjClass.ObjUpdateMobileandFastagNoInCard != null)
            {
                foreach (UpdateMobileandFastagNoInCard ObjCardDetails in ObjClass.ObjUpdateMobileandFastagNoInCard)
                {
                    DataRow dr = dtDBR.NewRow();
                    dr["Cardno"] = ObjCardDetails.Cardno;
                    dr["Mobileno"] = ObjCardDetails.Mobileno;
                    dr["FastagNo"] = ObjCardDetails.FastagNo;
                    dtDBR.Rows.Add(dr);
                    dtDBR.AcceptChanges();
                }
            }

            parameters.Add("UpdateMobileInCard", dtDBR, DbType.Object, ParameterDirection.Input);
            parameters.Add("ModifiedBy", ObjClass.ModifiedBy, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<UpdateMobileandFastagNoInCardModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }


       

    }
}
