using HPCL.DataModel.Transaction;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.Transaction
{
    public interface ITransactionRepository
    {
        public Task<IEnumerable<TransactionSalebyTerminalModelOutput>> SaleByTerminal([FromBody] TransactionSalebyTerminalModelInput ObjClass);
        public Task<IEnumerable<RechargeCCMSAccountModelOutput>> RechargeCCMSAccount([FromBody] RechargeCCMSAccountModelInput ObjClass);
        public Task<IEnumerable<GetBatchnoModelOutput>> GetBatchno([FromBody] GetBatchnoModelInput ObjClass);

        public Task<IEnumerable<TransactionBalanceTransferModelOutput>> BalanceTransfer([FromBody] TransactionBalanceTransferModelInput ObjClass);

        public Task<IEnumerable<TransactionGenerateOTPModelOutput>> GenerateOTP([FromBody] TransactionGenerateOTPModelInput ObjClass);

        public Task<IEnumerable<TransactionCardFeePaymentModelOutput>> CardFeePayment([FromBody] TransactionCardFeePaymentModelInput ObjClass);

        public Task<IEnumerable<TranscationsCheckForBatchSettlementModelOutput>> CheckTranscationsForBatchSettlement([FromBody] TranscationsCheckForBatchSettlementModelInput ObjClass);

        public Task<IEnumerable<TransactionBatchSettlementModelOutput>> BatchSettlement([FromBody] TransactionBatchSettlementModelInput ObjClass);
    }
}
