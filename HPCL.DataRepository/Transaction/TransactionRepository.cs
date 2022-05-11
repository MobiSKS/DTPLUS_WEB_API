using Dapper;
using HPCL.DataModel.Transaction;
using HPCL.DataRepository.DBDapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.Transaction
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly DapperContext _context;
        public TransactionRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TransactionSalebyTerminalModelOutput>> SaleByTerminal([FromBody] TransactionSalebyTerminalModelInput ObjClass)
        {
            var procedureName = "UspSaleByTerminal";
            var parameters = new DynamicParameters();
            parameters.Add("Merchantid", ObjClass.Merchantid, DbType.String, ParameterDirection.Input);
            parameters.Add("Terminalid", ObjClass.Terminalid, DbType.String, ParameterDirection.Input);
            parameters.Add("Cardno", ObjClass.Cardno, DbType.String, ParameterDirection.Input);
            parameters.Add("Batchid", ObjClass.Batchid, DbType.Int64, ParameterDirection.Input);
            parameters.Add("Invoiceamount", ObjClass.Invoiceamount, DbType.Double, ParameterDirection.Input);
            parameters.Add("Transtype", ObjClass.Transtype, DbType.String, ParameterDirection.Input);
            parameters.Add("Invoiceid", ObjClass.Invoiceid, DbType.String, ParameterDirection.Input);
            parameters.Add("Invoicedate", ObjClass.Invoicedate, DbType.DateTime, ParameterDirection.Input);
            parameters.Add("Mobileno", ObjClass.Mobileno, DbType.String, ParameterDirection.Input);
            parameters.Add("Productid", ObjClass.Productid, DbType.Int32, ParameterDirection.Input);
            parameters.Add("Odometerreading", ObjClass.Odometerreading, DbType.String, ParameterDirection.Input);
            parameters.Add("OTP", ObjClass.OTP, DbType.String, ParameterDirection.Input);
            parameters.Add("Pin", ObjClass.Pin, DbType.String, ParameterDirection.Input);
            parameters.Add("Sourceid", ObjClass.Sourceid, DbType.String, ParameterDirection.Input);
            parameters.Add("CreatedBy", ObjClass.CreatedBy, DbType.String, ParameterDirection.Input);
            parameters.Add("Formfactor", ObjClass.Formfactor, DbType.Int32, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<TransactionSalebyTerminalModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<RechargeCCMSAccountModelOutput>> RechargeCCMSAccount([FromBody] RechargeCCMSAccountModelInput ObjClass)
        {
            var procedureName = "UspRechargeCCMSAccount";
            var parameters = new DynamicParameters();
            parameters.Add("Merchantid", ObjClass.Merchantid, DbType.String, ParameterDirection.Input);
            parameters.Add("Terminalid", ObjClass.Terminalid, DbType.String, ParameterDirection.Input);
            parameters.Add("Cardno", ObjClass.Cardno, DbType.String, ParameterDirection.Input);
            parameters.Add("Batchid", ObjClass.Batchid, DbType.Int64, ParameterDirection.Input);
            parameters.Add("Invoiceamount", ObjClass.Invoiceamount, DbType.Double, ParameterDirection.Input);
            parameters.Add("Transtype", ObjClass.Transtype, DbType.String, ParameterDirection.Input);
            parameters.Add("Invoiceid", ObjClass.Invoiceid, DbType.Int32, ParameterDirection.Input);
            parameters.Add("Invoicedate", ObjClass.Invoicedate, DbType.DateTime, ParameterDirection.Input);
            parameters.Add("Chequeno", ObjClass.Chequeno, DbType.String, ParameterDirection.Input);
            parameters.Add("MICR", ObjClass.MICR, DbType.String, ParameterDirection.Input);
            parameters.Add("MUtrno", ObjClass.MUtrno, DbType.String, ParameterDirection.Input);
            //parameters.Add("Paymentmode", ObjClass.Paymentmode, DbType.String, ParameterDirection.Input);
            //parameters.Add("Currency", ObjClass.Currency, DbType.String, ParameterDirection.Input);
            parameters.Add("Mobileno", ObjClass.Mobileno, DbType.String, ParameterDirection.Input);
            parameters.Add("OTP", ObjClass.OTP, DbType.String, ParameterDirection.Input);
            parameters.Add("Pin", ObjClass.Pin, DbType.String, ParameterDirection.Input);
            parameters.Add("Sourceid", ObjClass.Sourceid, DbType.Int32, ParameterDirection.Input);
            parameters.Add("Formfactor", ObjClass.Formfactor, DbType.Int32, ParameterDirection.Input);
            parameters.Add("CreatedBy", ObjClass.CreatedBy, DbType.String, ParameterDirection.Input);
            parameters.Add("CCN", ObjClass.CCN, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<RechargeCCMSAccountModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<GetBatchnoModelOutput>> GetBatchno([FromBody] GetBatchnoModelInput ObjClass)
        {
            var procedureName = "UspGetBatchno";
            var parameters = new DynamicParameters();
            parameters.Add("Merchantid", ObjClass.Merchantid, DbType.String, ParameterDirection.Input);
            parameters.Add("Terminalid", ObjClass.Terminalid, DbType.String, ParameterDirection.Input);
            parameters.Add("CreatedBy", ObjClass.CreatedBy, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetBatchnoModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }


        public async Task<IEnumerable<TransactionBalanceTransferModelOutput>> BalanceTransfer([FromBody] TransactionBalanceTransferModelInput ObjClass)
        {
            var procedureName = "UspBalanceTransfer";
            var parameters = new DynamicParameters();
            parameters.Add("Merchantid", ObjClass.Merchantid, DbType.String, ParameterDirection.Input);
            parameters.Add("Terminalid", ObjClass.Terminalid, DbType.String, ParameterDirection.Input);
            parameters.Add("CCN", ObjClass.CCN, DbType.String, ParameterDirection.Input);
            parameters.Add("Cardno", ObjClass.Cardno, DbType.String, ParameterDirection.Input);
            parameters.Add("Batchid", ObjClass.Batchid, DbType.Int64, ParameterDirection.Input);
            parameters.Add("Transtype", ObjClass.Transtype, DbType.String, ParameterDirection.Input);
            parameters.Add("Invoiceid", ObjClass.Invoiceid, DbType.String, ParameterDirection.Input);
            parameters.Add("Invoicedate", ObjClass.Invoicedate, DbType.DateTime, ParameterDirection.Input);
            parameters.Add("Invoiceamount", ObjClass.Invoiceamount, DbType.Double, ParameterDirection.Input);
            parameters.Add("Mobileno", ObjClass.Mobileno, DbType.String, ParameterDirection.Input);
            parameters.Add("OTP", ObjClass.OTP, DbType.String, ParameterDirection.Input);
            parameters.Add("Pin", ObjClass.Pin, DbType.String, ParameterDirection.Input);
            parameters.Add("Sourceid", ObjClass.Sourceid, DbType.Int32, ParameterDirection.Input);
            parameters.Add("Formfactor", ObjClass.Formfactor, DbType.Int32, ParameterDirection.Input);
            parameters.Add("CreatedBy", ObjClass.CreatedBy, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<TransactionBalanceTransferModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<TransactionGenerateOTPModelOutput>> GenerateOTP([FromBody] TransactionGenerateOTPModelInput ObjClass)
        {
            var procedureName = "UspGenerateOTP";
            var parameters = new DynamicParameters();
            parameters.Add("Merchantid", ObjClass.Merchantid, DbType.String, ParameterDirection.Input);
            parameters.Add("Terminalid", ObjClass.Terminalid, DbType.String, ParameterDirection.Input);
            parameters.Add("Mobileno", ObjClass.Mobileno, DbType.String, ParameterDirection.Input);
            parameters.Add("OTPtype", ObjClass.OTPtype, DbType.Int32, ParameterDirection.Input);
            parameters.Add("Useragent", ObjClass.Useragent, DbType.String, ParameterDirection.Input);
            parameters.Add("CreatedBy", ObjClass.CreatedBy, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<TransactionGenerateOTPModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<TransactionCardFeePaymentModelOutput>> CardFeePayment([FromBody] TransactionCardFeePaymentModelInput ObjClass)
        {
            var procedureName = "UspCardFeePayment";
            var parameters = new DynamicParameters();
            parameters.Add("Merchantid", ObjClass.Merchantid, DbType.String, ParameterDirection.Input);
            parameters.Add("Terminalid", ObjClass.Terminalid, DbType.String, ParameterDirection.Input);
            parameters.Add("Formno", ObjClass.Formno, DbType.String, ParameterDirection.Input);
            parameters.Add("Batchid", ObjClass.Batchid, DbType.Int64, ParameterDirection.Input);
            parameters.Add("Noofcards", ObjClass.Noofcards, DbType.Int32, ParameterDirection.Input);
            parameters.Add("Invoiceamount", ObjClass.Invoiceamount, DbType.Double, ParameterDirection.Input);
            parameters.Add("Transtype", ObjClass.Transtype, DbType.String, ParameterDirection.Input);
            parameters.Add("Invoiceid", ObjClass.Invoiceid, DbType.String, ParameterDirection.Input);
            parameters.Add("Invoicedate", ObjClass.Invoicedate, DbType.DateTime, ParameterDirection.Input);
            parameters.Add("Sourceid", ObjClass.Sourceid, DbType.String, ParameterDirection.Input);
            parameters.Add("CreatedBy", ObjClass.CreatedBy, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<TransactionCardFeePaymentModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }


        public async Task<IEnumerable<TranscationsCheckForBatchSettlementModelOutput>> CheckTranscationsForBatchSettlement([FromBody] TranscationsCheckForBatchSettlementModelInput ObjClass)
        {
            var dtDBR = new DataTable("TypeTranscationsForBatchSettlement");
            dtDBR.Columns.Add("Trantype", typeof(string));
            dtDBR.Columns.Add("Transcount", typeof(int));
            dtDBR.Columns.Add("Totalamount", typeof(double));

            if (ObjClass.ObjTranscationsForBatchSettlement != null)
            {
                foreach (TranscationsForBatchSettlement ObjDetail in ObjClass.ObjTranscationsForBatchSettlement)
                {
                    DataRow dr = dtDBR.NewRow();
                    dr["Trantype"] = ObjDetail.Trantype;
                    dr["Transcount"] = ObjDetail.Transcount;
                    dr["Totalamount"] = ObjDetail.Totalamount;
                    dtDBR.Rows.Add(dr);
                    dtDBR.AcceptChanges();
                }
            }

            var procedureName = "UspCheckTranscationsForBatchSettlement";
            var parameters = new DynamicParameters();
            parameters.Add("Merchantid", ObjClass.Merchantid, DbType.String, ParameterDirection.Input);
            parameters.Add("Terminalid", ObjClass.Terminalid, DbType.String, ParameterDirection.Input);
            parameters.Add("Batchid", ObjClass.Batchid, DbType.Int64, ParameterDirection.Input);
            parameters.Add("TypeCheckTranscationsForBatchSettlement", dtDBR, DbType.Object, ParameterDirection.Input);
            parameters.Add("CreatedBy", ObjClass.CreatedBy, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<TranscationsCheckForBatchSettlementModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }


        public async Task<IEnumerable<TransactionBatchSettlementModelOutput>> BatchSettlement([FromBody] TransactionBatchSettlementModelInput ObjClass)
        {
            var procedureName = "UspBatchSettlement";
            var parameters = new DynamicParameters();
            parameters.Add("Merchantid", ObjClass.Merchantid, DbType.String, ParameterDirection.Input);
            parameters.Add("Terminalid", ObjClass.Terminalid, DbType.String, ParameterDirection.Input);
            parameters.Add("Batchid", ObjClass.Batchid, DbType.Int64, ParameterDirection.Input);
            parameters.Add("CreatedBy", ObjClass.CreatedBy, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<TransactionBatchSettlementModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }
        
        public async Task<TransactionGetRegistrationProcessModelOutput> GetRegistrationParameters([FromBody] TransactionGetRegistrationProcessModelInput ObjClass)
        {
            var procedureName = "UspGetRegistrationProcess";
            var parameters = new DynamicParameters();
            parameters.Add("IACId", ObjClass.IACId, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            var result = await connection.QueryMultipleAsync(procedureName, parameters, commandType: CommandType.StoredProcedure);
            var storedProcedureResult = new TransactionGetRegistrationProcessModelOutput();
            storedProcedureResult.ObjGetRegistrationProcessMerchant = (List<TransactionGetRegistrationProcessMerchantModelOutput>)await result.ReadAsync<TransactionGetRegistrationProcessMerchantModelOutput>();
            storedProcedureResult.ObjGetRegistrationProcessTrans = (List<TransactionGetRegistrationProcessTransModelOutput>)await result.ReadAsync<TransactionGetRegistrationProcessTransModelOutput>();
            storedProcedureResult.ObjBanks = (List<TransactionBanksModelOutput>)await result.ReadAsync<TransactionBanksModelOutput>();
            storedProcedureResult.ObjFormFactors = (List<TransactionFormFactorsModelOutput>)await result.ReadAsync<TransactionFormFactorsModelOutput>();
            return storedProcedureResult;
        }



        public async Task<IEnumerable<TransactionReloadAccountModelOutput>> ReloadAccount([FromBody] TransactionReloadAccountModelInput ObjClass)
        {
            var procedureName = "UspReloadAccount";
            var parameters = new DynamicParameters();
            parameters.Add("Merchantid", ObjClass.Merchantid, DbType.String, ParameterDirection.Input);
            parameters.Add("Terminalid", ObjClass.Terminalid, DbType.String, ParameterDirection.Input);
            parameters.Add("Cardno", ObjClass.Cardno, DbType.String, ParameterDirection.Input);
            parameters.Add("Batchid", ObjClass.Batchid, DbType.Int64, ParameterDirection.Input);
            parameters.Add("Invoiceamount", ObjClass.Invoiceamount, DbType.Double, ParameterDirection.Input);
            parameters.Add("Transtype", ObjClass.Transtype, DbType.String, ParameterDirection.Input);
            parameters.Add("Invoiceid", ObjClass.Invoiceid, DbType.String, ParameterDirection.Input);
            parameters.Add("Invoicedate", ObjClass.Invoicedate, DbType.DateTime, ParameterDirection.Input);
            parameters.Add("Mobileno", ObjClass.Mobileno, DbType.String, ParameterDirection.Input);
            parameters.Add("Chequeno", ObjClass.Chequeno, DbType.String, ParameterDirection.Input);
            parameters.Add("MICR", ObjClass.MICR, DbType.String, ParameterDirection.Input);
            parameters.Add("OTP", ObjClass.OTP, DbType.String, ParameterDirection.Input);
            parameters.Add("Pin", ObjClass.Pin, DbType.String, ParameterDirection.Input);
            parameters.Add("Sourceid", ObjClass.Sourceid, DbType.Int32, ParameterDirection.Input);
            parameters.Add("CreatedBy", ObjClass.CreatedBy, DbType.String, ParameterDirection.Input);
            parameters.Add("Formfactor", ObjClass.Formfactor, DbType.Int32, ParameterDirection.Input);
            
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<TransactionReloadAccountModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }


        public async Task<IEnumerable<TransactionBalanceEnquiryModelOutput>> BalanceEnquiry([FromBody] TransactionBalanceEnquiryModelInput ObjClass)
        {
            var procedureName = "UspBalanceEnquiry";
            var parameters = new DynamicParameters();
            parameters.Add("Merchantid", ObjClass.Merchantid, DbType.String, ParameterDirection.Input);
            parameters.Add("Terminalid", ObjClass.Terminalid, DbType.String, ParameterDirection.Input);
            parameters.Add("Cardno", ObjClass.Cardno, DbType.String, ParameterDirection.Input);
            parameters.Add("Mobileno", ObjClass.Mobileno, DbType.String, ParameterDirection.Input);
            parameters.Add("OTP", ObjClass.OTP, DbType.String, ParameterDirection.Input);
            parameters.Add("Pin", ObjClass.Pin, DbType.String, ParameterDirection.Input);
            parameters.Add("Sourceid", ObjClass.Sourceid, DbType.Int32, ParameterDirection.Input);
            parameters.Add("Formfactor", ObjClass.Formfactor, DbType.Int32, ParameterDirection.Input);
            parameters.Add("CreatedBy", ObjClass.CreatedBy, DbType.String, ParameterDirection.Input);

            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<TransactionBalanceEnquiryModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<TransactionCCMSBalanceEnquiryModelOutput>> CCMSBalanceEnquiry([FromBody] TransactionCCMSBalanceEnquiryModelInput ObjClass)
        {
            var procedureName = "UspCCMSBalanceEnquiry";
            var parameters = new DynamicParameters();
            parameters.Add("Merchantid", ObjClass.Merchantid, DbType.String, ParameterDirection.Input);
            parameters.Add("Terminalid", ObjClass.Terminalid, DbType.String, ParameterDirection.Input);
            parameters.Add("CCN", ObjClass.CCN, DbType.String, ParameterDirection.Input);
            parameters.Add("Pin", ObjClass.Pin, DbType.String, ParameterDirection.Input);
            parameters.Add("Sourceid", ObjClass.Sourceid, DbType.Int32, ParameterDirection.Input);
            parameters.Add("Formfactor", ObjClass.Formfactor, DbType.Int32, ParameterDirection.Input);
            parameters.Add("CreatedBy", ObjClass.CreatedBy, DbType.String, ParameterDirection.Input);

            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<TransactionCCMSBalanceEnquiryModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }



    }
}
