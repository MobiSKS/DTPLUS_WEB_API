using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace HPCL.Infrastructure.CommonClass
{

    public class Variables
    {
        private readonly IConfiguration _configuration;
        public Variables(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public static string FunGenerateStringUId()
        {
            byte[] bytBuffer = Guid.NewGuid().ToByteArray();
            return BitConverter.ToInt64(bytBuffer, 0).ToString();
        }
        //public string GetConnection()
        //{
        //    return ConfigurationManager.AppSettings["ConnectionString"].ToString();
        //}
        public bool Chk_APIKey_Validation(string API_Key)
        {
            if (API_Key == StrAPI_Key)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Chk_SecretKey_Validation(string Secret_Key)
        {
            if (Secret_Key == StrSecretKey)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Chk_API_Key_SecretKey_Validation(string API_Key, string Secret_Key)
        {
            if (Secret_Key == StrSecretKey && API_Key == StrAPI_Key)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static void PostSMSRequest(string Url, out string Result)
        {
            string Ststus;
            try
            {

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                Ststus = reader.ReadToEnd();
            }
            catch (Exception ex)
            {
                Ststus = ex.Message;
            }
            Result = Ststus;
        }

        public static bool IsPhoneNumber(string number)
        {
            //return Regex.Match(number, @"^(\+[6-9]{10})$").Success;
            string CheckMobileNo = number[..1];
            //string CheckMobileNo = number.Substring(0, 1);
            bool IsResult;
            if (CheckMobileNo.Contains('6') || CheckMobileNo.Contains('7') || CheckMobileNo.Contains('8') || CheckMobileNo.Contains('9'))
                IsResult = true;
            else
                IsResult = false;
            return IsResult;
        }

        public static string RightString(string value, int length)
        {
            //return value.Substring(value.Length - length);
            return value[^length..];
        }

        public string StrStoreCode
        {
            get
            {
                return _configuration.GetSection("TokenSettings:StoreCode").Value.ToString();
            }
        }

        public string StrSecretKey
        {
            get
            {

                return _configuration.GetSection("TokenSettings:SecretKey").Value.ToString();
            }
        }

        public string StrAPI_Key
        {
            get
            {
                return _configuration.GetSection("TokenSettings:API_Key").Value.ToString();
            }
        }

        public string StrAPI_HPCLConnectionString
        {
            get
            {
                return _configuration.GetSection("ConnectionStrings:HPCLConnectionString").Value.ToString();
            }
        }

        public static bool FunSendMail(string strEmailId, string strMailMessage, string strSubject)
        {
            try
            {

                MailMessage objMailMessage = new MailMessage();
                try
                {
                    objMailMessage.To.Add(strEmailId);
                    objMailMessage.From = new MailAddress("analytics@mloyal.com");
                    objMailMessage.Subject = strSubject;
                    objMailMessage.IsBodyHtml = true;
                    objMailMessage.Body = strMailMessage;
                    SmtpClient objSmtpClient = new SmtpClient
                    {
                        Host = "mail.mloyal.com",
                        Credentials = new NetworkCredential("analytics@mloyal.com", "2o!7AnAlyt!c")
                    };
                    objSmtpClient.Send(objMailMessage);
                }
                catch
                {

                }

                return true;
            }
            catch
            {
                return false;
            }

        }

        public static bool SendSMS(int SMSType, string CTID, string MobileNo, string CreatedBy, params string[] ButtonText)
        {
            // SMSType : 1 for OTP
            // SMSType : 2 for CustomerId and ControlCardNo

            string SQLGetSMS = "UspGetSMSConfiguration @CTID='" + CTID + "'";
            DataTable dtSMS = new DataTable();

            string SQLConnection = "server=180.179.222.161,21443;database=Dtplusnew;uid=datadesk_login;password=M0b1DataDeskDB6@82o;";
            SqlConnection conn = new SqlConnection(SQLConnection);
            conn.Open();
            SqlCommand cmd = new SqlCommand(SQLGetSMS, conn)
            {
                CommandTimeout = 0,
                CommandType = CommandType.Text
            };

            SqlDataAdapter Adp = new SqlDataAdapter(cmd);
            Adp.Fill(dtSMS);
            conn.Close();

            if (dtSMS.Rows.Count > 0)
            {
                string SenderId = dtSMS.Rows[0]["SenderId"].ToString();
                string SMSAPIURL = dtSMS.Rows[0]["SMSAPIURL"].ToString();
                string SMSText = dtSMS.Rows[0]["SMSText"].ToString();
                string HeaderTemplate = dtSMS.Rows[0]["HeaderTemplate"].ToString();

                if (SMSType == 1)
                    SMSText = SMSText.Replace("[OTP]", ButtonText[0]);

                if (SMSType == 2)

                    SMSText = SMSText.Replace("[CustId]", ButtonText[0]).Replace("[CntlCrNo]", ButtonText[1]);

                string URL = SMSAPIURL.Replace("[senderid]", SenderId).Replace("[mob]", MobileNo).Replace("[msg]", System.Web.HttpUtility.UrlEncode(SMSText)).Replace("[CTID]", CTID);
                string getmobileno = RightString(MobileNo, 10);
                bool checkNo = IsPhoneNumber(getmobileno);
                if (checkNo == true)
                {
                    string SMSOutput;
                    PostSMSRequest(URL, out SMSOutput);
                    string SMSStatus;
                    if ((SMSOutput.ToUpper().Contains("ACCEPTED")) || (SMSOutput.ToUpper().Contains("TRUE")) || (SMSOutput.ToUpper().Contains("SUCCESS"))
                     || (SMSOutput.ToUpper().Contains("DELIVER")) || (SMSOutput.ToUpper().Contains("SENT")))
                        SMSStatus = "Sent.";
                    else
                        SMSStatus = "Failed.";

                    string SqlInsert = "UspInsertSMSTextEntry @MobileNo='" + MobileNo + "',@HeaderTemplate='" + HeaderTemplate + "',@CTID='" + CTID
                        + "',@SMSText='" + SMSText + "',@SMSStatus='" + SMSStatus + "',@SMSStatusDesc='" + SMSOutput + "',@CreatedBy='" + CreatedBy + "'";

                    conn = new SqlConnection(SQLConnection);
                    conn.Open();
                    cmd = new SqlCommand(SqlInsert, conn)
                    {
                        CommandTimeout = 0,
                        CommandType = CommandType.Text
                    };
                    DataTable dtSMSSend = new DataTable();
                    Adp = new SqlDataAdapter(cmd);
                    Adp.Fill(dtSMSSend);
                    conn.Close();
                    if (dtSMSSend.Rows.Count > 0)
                    {
                        string Status = dtSMSSend.Rows[0]["Status"].ToString();
                        if (Status == "0")
                            return false;
                        else
                            return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }
    }
}
