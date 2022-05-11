using HPCL.DataModel.Transaction;
using HPCL.DataRepository.Transaction;
using HPCL.Infrastructure.CommonClass;
using HPCL_WebApi.ActionFilters;
using HPCL_WebApi.ExtensionMethod;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HPCL_WebApi.Controllers
{
    [ApiController]
    [Route("/api/dtplus/transaction")]

    public class TransactionController : ControllerBase
    {
        private readonly ILogger<TransactionController> _logger;

        private readonly ITransactionRepository _transRepo;

        public TransactionController(ILogger<TransactionController> logger, ITransactionRepository transRepo)
        {
            _logger = logger;
            _transRepo = transRepo;
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("sale_by_terminal")]
        public async Task<IActionResult> SaleByTerminal([FromBody] TransactionSalebyTerminalModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _transRepo.SaleByTerminal(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<TransactionSalebyTerminalModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<TransactionSalebyTerminalModelOutput>().ToList()[0].Reason);
                    }
                }
            }
        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("recharge_ccms_account")]
        public async Task<IActionResult> RechargeCCMSAccount([FromBody] RechargeCCMSAccountModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _transRepo.RechargeCCMSAccount(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<RechargeCCMSAccountModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<RechargeCCMSAccountModelOutput>().ToList()[0].Reason);
                    }
                }
            }
        }

        //[HttpPost]
        //[ServiceFilter(typeof(CustomAuthenticationFilter))]
        //[Route("get_batch_no")]
        //public async Task<IActionResult> GetBatchno([FromBody] GetBatchnoModelInput ObjClass)
        //{
        //    if (ObjClass == null)
        //    {
        //        return this.BadRequestCustom(ObjClass, null, _logger);
        //    }
        //    else
        //    {
        //        var result = await _transRepo.GetBatchno(ObjClass);
        //        if (result == null)
        //        {
        //            return this.NotFoundCustom(ObjClass, null, _logger);
        //        }
        //        else
        //        {
        //            if (result.Cast<GetBatchnoModelOutput>().ToList()[0].Status == 1)
        //            {
        //                return this.OkCustom(ObjClass, result, _logger);
        //            }
        //            else
        //            {
        //                return this.FailCustom(ObjClass, result, _logger,
        //                    result.Cast<GetBatchnoModelOutput>().ToList()[0].Reason);
        //            }
        //        }
        //    }
        //}

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("balance_transfer")]
        public async Task<IActionResult> BalanceTransfer([FromBody] TransactionBalanceTransferModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _transRepo.BalanceTransfer(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<TransactionBalanceTransferModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<TransactionBalanceTransferModelOutput>().ToList()[0].Reason);
                    }
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("generate_otp")]
        public async Task<IActionResult> GenerateOTP([FromBody] TransactionGenerateOTPModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _transRepo.GenerateOTP(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<TransactionGenerateOTPModelOutput>().ToList()[0].Status == 1)
                    {

                        Variables.SendSMS(1, "1007241399399538955", ObjClass.Mobileno, ObjClass.CreatedBy, result.Cast<TransactionGenerateOTPModelOutput>().ToList()[0].OTP);

                        return this.OkCustom(ObjClass, result, _logger);

                        #region OldRegion
                        //SMSSendInputModel ObjSend = new SMSSendInputModel();
                        //ObjSend.CTID = "1007241399399538955";
                        //ObjSend.Userid = ObjClass.Userid;
                        //ObjSend.Useragent = ObjClass.Useragent;
                        //ObjSend.Userip = ObjClass.Userip;
                        //var resultSMS = await _smsRepos.SendSMSTemplate(ObjSend);

                        //string SenderId = resultSMS.Cast<SMSSendOutputModel>().ToList()[0].SenderId;
                        //string SMSAPIURL = resultSMS.Cast<SMSSendOutputModel>().ToList()[0].SMSAPIURL;
                        //string SMSText = resultSMS.Cast<SMSSendOutputModel>().ToList()[0].SMSText;
                        //string HeaderTemplate = resultSMS.Cast<SMSSendOutputModel>().ToList()[0].HeaderTemplate;
                        //string OTP = result.Cast<TransactionGenerateOTPModelOutput>().ToList()[0].OTP;

                        //InsertSMSTextEntryInputModel ObjInsertSMSTextEntry = new InsertSMSTextEntryInputModel();
                        //ObjInsertSMSTextEntry.Userid = ObjClass.Userid;
                        //ObjInsertSMSTextEntry.Useragent = ObjClass.Useragent;
                        //ObjInsertSMSTextEntry.Userip = ObjClass.Userip;

                        //ObjInsertSMSTextEntry.MobileNo = ObjClass.Mobileno;
                        //ObjInsertSMSTextEntry.HeaderTemplate = HeaderTemplate;
                        //ObjInsertSMSTextEntry.CTID = ObjSend.CTID;
                        //ObjInsertSMSTextEntry.CreatedBy = ObjClass.CreatedBy;
                        //ObjInsertSMSTextEntry.SMSText = SMSText.Replace("[OTP]", OTP);
                        //string URL = SMSAPIURL.Replace("[senderid]", SenderId).Replace("[mob]",
                        //ObjClass.Mobileno.ToString()).Replace("[msg]", System.Web.HttpUtility.UrlEncode(ObjInsertSMSTextEntry.SMSText));

                        //string getmobileno = Variables.RightString(ObjClass.Mobileno.ToString(), 10);
                        //bool checkNo = Variables.IsPhoneNumber(getmobileno);
                        //if (checkNo == true)
                        //{
                        //    string SMSOutput;
                        //    Variables.PostSMSRequest(URL, out SMSOutput);
                        //    if ((SMSOutput.ToUpper().Contains("ACCEPTED")) || (SMSOutput.ToUpper().Contains("TRUE")) || (SMSOutput.ToUpper().Contains("SUCCESS"))
                        //     || (SMSOutput.ToUpper().Contains("DELIVER")) || (SMSOutput.ToUpper().Contains("SENT")))
                        //        ObjInsertSMSTextEntry.SMSStatus = "Sent.";
                        //    else
                        //        ObjInsertSMSTextEntry.SMSStatus = "Failed.";

                        //    ObjInsertSMSTextEntry.SMSStatusDesc = SMSOutput;
                        //    await _smsRepos.InsertSMSTextEntry(ObjInsertSMSTextEntry);

                        //    return this.OkCustom(ObjClass, result, _logger);
                        //}
                        //else
                        //{
                        //    Dictionary<string, object> Body = new Dictionary<string, object>();
                        //    Body.Add("Reason", "Invalid mobile number.Please pass valid mobile number");
                        //    Body.Add("Status", 1012);
                        //    return this.FailCustom(ObjClass, Body, _logger, "Invalid mobile number");
                        //}
                        #endregion
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<TransactionGenerateOTPModelOutput>().ToList()[0].Reason);
                    }
                }
            }
        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("card_fee_payment")]
        public async Task<IActionResult> CardFeePayment([FromBody] TransactionCardFeePaymentModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _transRepo.CardFeePayment(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<TransactionCardFeePaymentModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<TransactionCardFeePaymentModelOutput>().ToList()[0].Reason);
                    }
                }
            }
        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("check_transcations_for_batch_settlement")]
        public async Task<IActionResult> CheckTranscationsForBatchSettlement([FromBody] TranscationsCheckForBatchSettlementModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _transRepo.CheckTranscationsForBatchSettlement(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<TranscationsCheckForBatchSettlementModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<TranscationsCheckForBatchSettlementModelOutput>().ToList()[0].Reason);
                    }
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_registration_parameters")]
        public async Task<IActionResult> GetRegistrationParameters([FromBody] TransactionGetRegistrationProcessModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _transRepo.GetRegistrationParameters(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.ObjGetRegistrationProcessMerchant.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        //[HttpPost]
        //[ServiceFilter(typeof(CustomAuthenticationFilter))]
        //[Route("batch_settlement")]
        //public async Task<IActionResult> BatchSettlement([FromBody] TransactionBatchSettlementModelInput ObjClass)
        //{
        //    if (ObjClass == null)
        //    {
        //        return this.BadRequestCustom(ObjClass, null, _logger);
        //    }
        //    else
        //    {
        //        var result = await _transRepo.BatchSettlement(ObjClass);
        //        if (result == null)
        //        {
        //            return this.NotFoundCustom(ObjClass, null, _logger);
        //        }
        //        else
        //        {
        //            if (result.Cast<TransactionBatchSettlementModelOutput>().ToList()[0].Status == 1)
        //            {
        //                return this.OkCustom(ObjClass, result, _logger);
        //            }
        //            else
        //            {
        //                return this.FailCustom(ObjClass, result, _logger,
        //                    result.Cast<TransactionBatchSettlementModelOutput>().ToList()[0].Reason);
        //            }
        //        }
        //    }
        //}

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("reload_account")]
        public async Task<IActionResult> ReloadAccount([FromBody] TransactionReloadAccountModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _transRepo.ReloadAccount(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<TransactionReloadAccountModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<TransactionReloadAccountModelOutput>().ToList()[0].Reason);
                    }
                }
            }
        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("balance_enquiry")]
        public async Task<IActionResult> BalanceEnquiry([FromBody] TransactionBalanceEnquiryModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _transRepo.BalanceEnquiry(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<TransactionBalanceEnquiryModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<TransactionBalanceEnquiryModelOutput>().ToList()[0].Reason);
                    }
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("ccms_balance_enquiry")]
        public async Task<IActionResult> CCMSBalanceEnquiry([FromBody] TransactionCCMSBalanceEnquiryModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _transRepo.CCMSBalanceEnquiry(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<TransactionCCMSBalanceEnquiryModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<TransactionCCMSBalanceEnquiryModelOutput>().ToList()[0].Reason);
                    }
                }
            }
        }
    }
}
