using Dapper;
using HPCL.DataModel.ConfigureAlert;
using HPCL.DataRepository.DBDapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.ConfigureAlert
{
    public class ConfigureAlertRepository:IConfigureAlertRepository
    {
        private readonly DapperContext _context;
        public ConfigureAlertRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<GetSmsAlertForMultipleMobileDetailModelOutput> GetSmsAlertForMultipleMobile([FromBody] GetSmsAlertForMultipleMobileDetailModelInput ObjClass)
        {
            var procedureName = "UspGetSmsAlertForMultipleMobileDetail";
            var parameters = new DynamicParameters();
            parameters.Add("CustomerID", ObjClass.CustomerID, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            var result = await connection.QueryMultipleAsync(procedureName, parameters, commandType: CommandType.StoredProcedure);
            var storedProcedureResult = new GetSmsAlertForMultipleMobileDetailModelOutput();
            storedProcedureResult.CustomerDetail = (List<CustomerDetail>)await result.ReadAsync<CustomerDetail>();
            storedProcedureResult.CustomerMultipleMobileDetail = (List<SmsAlertForMultipleMobileDetail>)await result.ReadAsync<SmsAlertForMultipleMobileDetail>();
            
            return storedProcedureResult;
        }

        public async Task<IEnumerable<UpdateSmsAlertForMultipleMobileDetailModelOutput>> UpdateSmsAlertForMultipleMobileDetail([FromBody] UpdateSmsAlertForMultipleMobileDetailModelinput ObjClass)
        {

            var dtDBR = new DataTable("CustomerMultiMobile");
            dtDBR.Columns.Add("CustomerID", typeof(string));
            dtDBR.Columns.Add("MobileNo", typeof(string));
            dtDBR.Columns.Add("Name", typeof(string));
            dtDBR.Columns.Add("Designation", typeof(string));

            if(ObjClass.CustomerDetailForSmsAlert != null )
            {
                foreach (var ObjDetail in ObjClass.CustomerDetailForSmsAlert)
                {
                    

                    DataRow dr = dtDBR.NewRow();
                    dr["CustomerID"] = ObjDetail.CustomerID;
                    dr["MobileNo"] = ObjDetail.MobileNo;
                    dr["Name"] = ObjDetail.Name;
                    dr["Designation"] = ObjDetail.Designation;

                    //dr["CreatedBy"] = ObjDetail.CreatedBy;

                    dtDBR.Rows.Add(dr);
                    dtDBR.AcceptChanges();

                }
            }
            var procedureName = "UspUpdateSmsAlertForMultipleMobileDetail";
            var parameters = new DynamicParameters();
            parameters.Add("CustomerMultiMobile",dtDBR, DbType.Object, ParameterDirection.Input);
            parameters.Add("userId", ObjClass.Userid, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<UpdateSmsAlertForMultipleMobileDetailModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<DeleteSmsAlertForMultipleMobileDetailModelOutput>> DeleteSmsAlertForMultipleMobileDetail([FromBody] DeleteSmsAlertForMultipleMobileDetailModelInput ObjClass)
        {
            var procedureName = "UspDeleteSmsAlertForMultipleMobileDetail";
            var parameters = new DynamicParameters();
            parameters.Add("CustomerID",ObjClass.CustomerID , DbType.String, ParameterDirection.Input);
            parameters.Add("MobileNo", ObjClass.MobileNo, DbType.String, ParameterDirection.Input);

            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<DeleteSmsAlertForMultipleMobileDetailModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);


        }


    }
}
