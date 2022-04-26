using Dapper;
using HPCL.DataModel.TMS;
using HPCL.DataRepository.DBDapper;
using HPCL.Infrastructure.CommonClass;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.TMS
{
    public class TMSRepository : ITMSRepository
    {
        private readonly DapperContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IConfiguration _configuration;
        public TMSRepository(DapperContext context, IHostingEnvironment hostingEnvironment, IConfiguration configuration) // , IConfiguration configuration
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
            _configuration = configuration;
        }
        public async Task<IEnumerable<GetEnrollTransportManagementSystemModelOutput>> GetEnrollTransportManagementSystem([FromBody] GetEnrollTransportManagementSystemModelInput ObjClass)
        {
            var procedureName = "UspGetEnrollTransportManagementSystem";
            var parameters = new DynamicParameters();
            parameters.Add("CustomerId", ObjClass.CustomerId, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetEnrollTransportManagementSystemModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }
        public async Task<IEnumerable<GetEnrollmentStatusModelOutput>> GetEnrollmentStatus([FromBody] GetEnrollmentStatusModelInput ObjClass)
        {
            var procedureName = "UspGetEnrollmentStatus";
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetEnrollmentStatusModelOutput>(procedureName, null, commandType: CommandType.StoredProcedure);

        }
        public async Task<GetEnrollVehicleModelOutput> GetEnrollVehicle([FromBody] GetEnrollVehicleModelInput ObjClass)
        {
            var procedureName = "UspGetEnrollVehicle";
            var parameters = new DynamicParameters();
            parameters.Add("CustomerId", ObjClass.CustomerId, DbType.String, ParameterDirection.Input);
            parameters.Add("EnrollmentStatus", ObjClass.EnrollmentStatus, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            var result = await connection.QueryMultipleAsync(procedureName, parameters, commandType: CommandType.StoredProcedure);
            var storedProcedureResult = new GetEnrollVehicleModelOutput();
            storedProcedureResult.ObjGetEnrollVehicleCustomerName = (List<GetEnrollVehicleCustomerNameModelOutput>)await result.ReadAsync<GetEnrollVehicleCustomerNameModelOutput>();
            storedProcedureResult.ObjGetEnrollVehicle = (List<GetStatusEnrollVehicleModelOutput>)await result.ReadAsync<GetStatusEnrollVehicleModelOutput>();
            return storedProcedureResult;
        }
        public async Task<IEnumerable<GetManageEnrollmentsModelOutput>> GetManageEnrollments([FromBody] GetManageEnrollmentsModelInput ObjClass)
        {
            var procedureName = "UspGetManageEnrollmentDetail";
            var parameters = new DynamicParameters();
            parameters.Add("CustomerID", ObjClass.CustomerId, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetManageEnrollmentsModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async void InsertAPIRequestResponse([FromBody] ApiRequestResponse ObjClass)
        {
            var procedureName = "UspInsertApiRequestResponse";
            var parameters = new DynamicParameters();
            parameters.Add("Request", ObjClass.request, DbType.String, ParameterDirection.Input);
            parameters.Add("Response", ObjClass.response, DbType.String, ParameterDirection.Input);
            parameters.Add("Apiurl", ObjClass.apiurl, DbType.String, ParameterDirection.Input);
            parameters.Add("UserId", ObjClass.UserId, DbType.String, ParameterDirection.Input);
            parameters.Add("TMSUserId", ObjClass.TMSUserId, DbType.String, ParameterDirection.Input);
            parameters.Add("CustomerId", ObjClass.CustomerId, DbType.String, ParameterDirection.Input);
            parameters.Add("@TMSStatus", ObjClass.TMSStatus, DbType.Int32, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            var res = await connection.QueryAsync<object>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<CargoFlRegisterTrucker>> GetCargoFlRegisterTruckerDetail([FromBody] string CustomerId)
        {
            var procedureName = "UspGetCargoFlRegisterTruckerDetail";
            var parameters = new DynamicParameters();
            parameters.Add("CustomerId", CustomerId, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<CargoFlRegisterTrucker>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<GetCustomerDetailForEnrollmentApprovalOutput>> GetCustomerDetailForEnrollmentApproval([FromBody] GetCustomerDetailForEnrollmentApprovalInput ObjClass)
        {
            var procedureName = "UspGetCustomerDetailForEnrollmentApproval";
            var parameters = new DynamicParameters();
            parameters.Add("CustomerID", ObjClass.CustomerID, DbType.String, ParameterDirection.Input);
            parameters.Add("TMSUserId", ObjClass.TMSUserId, DbType.String, ParameterDirection.Input);
            parameters.Add("FromDate", ObjClass.FromDate, DbType.String, ParameterDirection.Input);
            parameters.Add("ToDate", ObjClass.ToDate, DbType.String, ParameterDirection.Input);
            parameters.Add("TMSStatus", ObjClass.TMSStatus, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetCustomerDetailForEnrollmentApprovalOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }
        public async Task<IEnumerable<GetEnrollmentStatusModelOutput>> GetEnrollmentStatus()
        {
        var procedureName = "UspGetTMSEnrollmentStatus";
            var parameters = new DynamicParameters();
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetEnrollmentStatusModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }


        public async Task<IEnumerable<TMSUpdateEnrollmentStatusModelOutput>> TMSInsertCustomerTracking([FromBody] TMSUpdateEnrollmentStatusModelInput ObjClass, string Apiurl)
        {
            var dtDBR = new DataTable("CustomerTracking");
            dtDBR.Columns.Add("CustomerID", typeof(string));
            dtDBR.Columns.Add("TMSUserId", typeof(string));
            dtDBR.Columns.Add("TMSStatusID", typeof(int));
            dtDBR.Columns.Add("Remarks", typeof(string));
            dtDBR.Columns.Add("CreatedBy", typeof(string));



            if (ObjClass.TMSUpdateEnrollmentCustomerList != null)
            {
                foreach (TMSInsertEnrollmentApprovalCustomerTrackingInput ObjDetail in ObjClass.TMSUpdateEnrollmentCustomerList)
                {
                    string apiurl = string.Empty;

                    ApiRequestResponse response = new ApiRequestResponse();
                    CargoFlLoginResponse cargoFlLoginResponse = new CargoFlLoginResponse();
                    CargoFlLogin obj = new CargoFlLogin() { cargofl_userid = _configuration.GetSection("TMSSettings:CargoFLUser").Value};

                    string json = Variables.CallPostAPI(Apiurl + "v1/common/loginSuperUser", JsonConvert.SerializeObject(obj), "").Result;
                    if (!string.IsNullOrEmpty(json))
                    {
                        cargoFlLoginResponse = JsonConvert.DeserializeObject<CargoFlLoginResponse>(json);
                    }
                    //var dat = JObject.Parse(json);
                    response.apiurl = Apiurl + "v1/common/loginSuperUser";
                    response.request = JsonConvert.SerializeObject(obj);
                    response.response = json;
                    response.UserId = ObjDetail.CreatedBy;
                    InsertAPIRequestResponse(response);

                    if (cargoFlLoginResponse != null && !string.IsNullOrEmpty(cargoFlLoginResponse.access_token))
                    {
                        if (ObjDetail.TMSStatusID == "2")
                        {
                            apiurl = Apiurl + "v1/user/enableTrucker";
                        }
                        else if (ObjDetail.TMSStatusID == "3" || ObjDetail.TMSStatusID == "4")
                        {
                            apiurl = Apiurl + "v1/user/disableTrucker";
                        }


                        string res = Variables.CallPostAPI(apiurl, JsonConvert.SerializeObject(obj), cargoFlLoginResponse.access_token).Result;

                        response.apiurl = apiurl;
                        response.request = JsonConvert.SerializeObject(obj);


                        response.response = res;
                        CargoFlLoginResponse objResponce = new CargoFlLoginResponse();
                        if (string.IsNullOrEmpty(res))
                        {

                            objResponce = JsonConvert.DeserializeObject<CargoFlLoginResponse>(res);

                            response.TMSUserId = obj.cargofl_userid;
                            response.CustomerId = ObjDetail.CustomerID;

                        }

                        InsertAPIRequestResponse(response);
                        if (!string.IsNullOrEmpty(objResponce.message) && (objResponce.message.Trim().ToUpper() == "USER ENABLED SUCCESSFULLY") || objResponce.message.Trim().ToUpper() == "USER DISABLED SUCCESSFULLY")
                        {

                            DataRow dr = dtDBR.NewRow();
                            dr["Remarks"] = ObjDetail.Remarks;
                            dr["CustomerID"] = ObjDetail.CustomerID;
                            dr["TMSUserId"] = ObjDetail.TMSUserId;
                            dr["TMSStatusID"] = Convert.ToInt32(ObjDetail.TMSStatusID);

                            dr["CreatedBy"] = ObjDetail.CreatedBy;

                            dtDBR.Rows.Add(dr);
                            dtDBR.AcceptChanges();
                        }
                    }
                }
            }            
            var procedureName = "UspTMSInsertEnrollmentCustomerTracking";
            var parameters = new DynamicParameters();
            parameters.Add("CustomerTracking", dtDBR, DbType.Object, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<TMSUpdateEnrollmentStatusModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }



        public async Task<IEnumerable<GetEnrollVehicleManagementModeloutput>> GetEnrollVehicleManagementDetail([FromBody] GetEnrollVehicleManagementModelInput ObjClass)
        {
            var procedureName = "UspGetEnrollVehicleManagementDetail";
            var parameters = new DynamicParameters();
            parameters.Add("CustomerID", ObjClass.CustomerID, DbType.String, ParameterDirection.Input);
            parameters.Add("EnrollmentStatus", ObjClass.EnrollmentStatus, DbType.String, ParameterDirection.Input);
            parameters.Add("VehicleNo", ObjClass.VehicleNo, DbType.String, ParameterDirection.Input);
            parameters.Add("CardNo", ObjClass.CardNo, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetEnrollVehicleManagementModeloutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<GetEnrollVehicleManagementStatusOutput>> GetEnrollVehicleManagementStatus()
        {
            var procedureName = "UspGetVehicleEnrollmentStatus";
            var parameters = new DynamicParameters();
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetEnrollVehicleManagementStatusOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<InsertVehicleEnrollmentStatusOutput>> InsertVehicleEnrollmentStatus(InsertVehicleEnrollmentStatusInput ObjClass)
        {
            var dtDBR = new DataTable("CardVehicleDetail");
            dtDBR.Columns.Add("CustomerID", typeof(string));
            //dtDBR.Columns.Add("TMSUserId", typeof(string));
            dtDBR.Columns.Add("EnrollmentStatus", typeof(int));
            dtDBR.Columns.Add("CardNo", typeof(string));
            dtDBR.Columns.Add("VehicleNo", typeof(string));
            dtDBR.Columns.Add("CreatedBy", typeof(string));

            if (ObjClass.VehicleEnrollmentStatusList != null)
            {
                
                foreach (var item in ObjClass.VehicleEnrollmentStatusList)
                {                   

                    DataRow dr = dtDBR.NewRow();
                    dr["CustomerID"] = item.CustomerID;
                    dr["EnrollmentStatus"] = 1;
                    dr["CardNo"] = item.CardNo;
                    dr["VehicleNo"] =item.VehicleNo;
                    dr["CreatedBy"] = item.CreatedBy;

                    dtDBR.Rows.Add(dr);
                    dtDBR.AcceptChanges();


                }
               
            }
            var procedureName = "UspInsertVehicleEnrollmentStatus";
            var parameters = new DynamicParameters();
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<InsertVehicleEnrollmentStatusOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }
    }

}
