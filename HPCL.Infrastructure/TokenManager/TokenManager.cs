using HPCL.Infrastructure.Extension;
using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Web.Http.ModelBinding;
using static HPCL.Infrastructure.CommonClass.StatusMessage;
using Microsoft.OpenApi.Extensions;
using HPCL.DataRepository.Account;
using HPCL.Infrastructure.CommonClass;
using HPCL.DataModel.Account;

namespace HPCL.Infrastructure.TokenManager
{

    public class TokenManager
    {


        //private static string Secret = Guid.NewGuid().ToString();
        public static string Secret = string.Empty;
        public static string GenerateToken(string Useragent, string Userip)
        {
            byte[] key = Convert.FromBase64String(Secret);
            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(key);
            SecurityTokenDescriptor descriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                      new Claim(ClaimTypes.Name, Useragent)
                }),
                Expires = DateTime.UtcNow.AddMinutes(300),
                Issuer = Userip,
                Audience = Userip,
                SigningCredentials = new SigningCredentials(securityKey,
                SecurityAlgorithms.HmacSha256Signature)
            };

            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            JwtSecurityToken token = handler.CreateJwtSecurityToken(descriptor);
            return handler.WriteToken(token);
        }
        public static ClaimsPrincipal GetPrincipal(string token, string Useragent, string Userip)
        {
            try
            {
                JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
                JwtSecurityToken jwtToken = (JwtSecurityToken)tokenHandler.ReadToken(token);
                if (jwtToken == null)
                    return null;
                byte[] key = Convert.FromBase64String(Secret);
                TokenValidationParameters parameters = new TokenValidationParameters()
                {
                    NameClaimType = Useragent,
                    RequireExpirationTime = true,
                    ValidateIssuer = true,
                    ValidateIssuerSigningKey = true,
                    ValidateAudience = true,
                    ValidIssuer = Userip,
                    ValidAudience = Userip,
                    IssuerSigningKey = new SymmetricSecurityKey(key)
                };


                ClaimsPrincipal principal = tokenHandler.ValidateToken(token, parameters, out SecurityToken securityToken);
                return principal;


            }
            catch
            {
                return null;
            }
        }
        public static string ValidateToken(string token, string Useragent, string Userip)
        {
            ClaimsPrincipal principal = GetPrincipal(token, Useragent, Userip);
            if (principal == null)
                return null;
            ClaimsIdentity identity;
            try
            {
                identity = (ClaimsIdentity)principal.Identity;
            }
            catch (NullReferenceException)
            {
                return null;
            }
            Claim usernameClaim = identity.FindFirst(ClaimTypes.Name);
            string username = usernameClaim.Value;
            return username;
        }

        public static bool Return_Key(HttpRequest request, Variables ObjVariable, IAccountRepository accountRepo, out string UserMessage, int Header_Parameter_Value, out int Status_Code, string Useragent, string Userip, string Method_Name, string Userid)
        {
            bool IsResult = false;
            string Secret_Key = string.Empty;
            string StrMessage = string.Empty;
            int IntStatusCode = 0;
            try
            {
                string API_Key;
                if (Header_Parameter_Value == 0)
                {
                    API_Key = request.GetHeader("API_Key");
                    Secret_Key = request.GetHeader("Secret_Key");

                    if (API_Key == "" && Secret_Key != "")
                    {
                        StrMessage = StatusInformation.API_Key_Is_Null.GetDisplayName();
                        IntStatusCode = (int)StatusInformation.API_Key_Is_Null;
                        IsResult = false;
                    }
                    else if (API_Key != "" && Secret_Key == "")
                    {
                        StrMessage = StatusInformation.Secret_Key_Is_Null.GetDisplayName();
                        IntStatusCode = (int)StatusInformation.Secret_Key_Is_Null;
                        IsResult = false;
                    }

                    else if (API_Key == "" && Secret_Key == "")
                    {
                        StrMessage = StatusInformation.API_Key_Secret_Key_Is_Null.GetDisplayName();
                        IntStatusCode = (int)StatusInformation.API_Key_Secret_Key_Is_Null;
                        IsResult = false;
                    }
                    else
                    {
                        bool IsAPI_Key_Validate = ObjVariable.Chk_API_Key_SecretKey_Validation(API_Key, Secret_Key);
                        if (IsAPI_Key_Validate == true)
                        {
                            IsResult = true;
                            StrMessage = StatusInformation.Success.GetDisplayName();
                            IntStatusCode = (int)StatusInformation.Success;
                        }

                        else
                        {
                            IsResult = false;
                            StrMessage = StatusInformation.API_Key_Is_Secret_Key_Invalid.GetDisplayName();
                            IntStatusCode = (int)StatusInformation.API_Key_Is_Secret_Key_Invalid;
                        }
                    }


                }

                if (Header_Parameter_Value == 1)
                {
                    API_Key = request.GetHeader("API_Key");

                    if (API_Key == "")
                    {
                        StrMessage = StatusInformation.API_Key_Is_Null.GetDisplayName();
                        IntStatusCode = (int)StatusInformation.API_Key_Is_Null;
                        IsResult = false;
                    }
                    else
                    {
                        bool IsAPI_Key_Validate = ObjVariable.Chk_APIKey_Validation(API_Key);
                        if (IsAPI_Key_Validate == true)
                        {
                            IsResult = true;
                            StrMessage = StatusInformation.Success.GetDisplayName();
                            IntStatusCode = (int)StatusInformation.Success;
                        }
                        else
                        {
                            IsResult = false;
                            StrMessage = StatusInformation.API_Key_Is_Invalid.GetDisplayName();
                            IntStatusCode = (int)StatusInformation.API_Key_Is_Invalid;
                        }

                    }


                }

                if (Header_Parameter_Value == 2)
                {

                    API_Key = request.GetHeader("Secret_Key");
                    if (Secret_Key == "")
                    {
                        StrMessage = StatusInformation.Secret_Key_Is_Null.GetDisplayName();
                        IntStatusCode = (int)StatusInformation.Secret_Key_Is_Null;
                        IsResult = false;
                    }
                    else
                    {
                        bool IsSecret_Key_Validate = ObjVariable.Chk_SecretKey_Validation(Secret_Key);
                        if (IsSecret_Key_Validate == true)
                        {
                            StrMessage = StatusInformation.Success.GetDisplayName();
                            IntStatusCode = (int)StatusInformation.Success;
                            IsResult = true;
                        }
                        else
                        {
                            StrMessage = StatusInformation.Secret_Key_Is_Invalid.GetDisplayName();
                            IntStatusCode = (int)StatusInformation.Secret_Key_Is_Invalid;
                            IsResult = false;
                        }

                    }
                }
            }
            catch
            {
                StrMessage = StatusInformation.Internel_Error.GetDisplayName();
                IntStatusCode = (int)StatusInformation.Internel_Error;
                IsResult = false;
            }


            if (IsResult == true)
            {
                if (Useragent == null)
                    Useragent = "";

                if (Userip == null)
                    Userip = "";

                if (Userid == null)
                    Userid = "";

                if (Userid == "")
                    Userid = DateTime.Now.ToString("yyyyMMddHHmmss");

                if (Useragent != "" && Userip != "" && Userid != "")
                {
                    AccountModel objAccountModel = new AccountModel
                    {
                        MethodName = Method_Name,
                        Useragent = Useragent,
                        Userid = Userid,
                        Userip = Userip
                    };
                    accountRepo.GenerateToken(objAccountModel);
                    IsResult = true;
                }
                else
                {
                    IsResult = false;
                    StrMessage = StatusInformation.User_Agentor_User_IP_User_Id_is_null.GetDisplayName();
                    IntStatusCode = (int)StatusInformation.User_Agentor_User_IP_User_Id_is_null;
                }
            }

            UserMessage = StrMessage;
            Status_Code = IntStatusCode;
            return IsResult;
        }





    }
}
