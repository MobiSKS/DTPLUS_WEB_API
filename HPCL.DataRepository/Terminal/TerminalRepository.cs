using Dapper;
using HPCL.DataModel.Merchant;
using HPCL.DataRepository.DBDapper;
using HPCL.Infrastructure.CommonClass;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.Terminal
{
    public class TerminalRepository: ITerminalRepository
    {
        private readonly DapperContext _context;
        public TerminalRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<MerchantSearchForTerminalInstallationRequestModelOutput> SearchForTerminalInstallationRequest([FromBody] MerchantSearchForTerminalInstallationRequestModelInput ObjClass)
        {
            var procedureName = "UspSearchForTerminalInstallationRequest";
            var parameters = new DynamicParameters();
            parameters.Add("MerchantId", ObjClass.MerchantId, DbType.String, ParameterDirection.Input);
            parameters.Add("ZonalOfficeId", ObjClass.ZonalOfficeId, DbType.String, ParameterDirection.Input);
            parameters.Add("RegionalOfficeId", ObjClass.RegionalOfficeId, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            var result = await connection.QueryMultipleAsync(procedureName, parameters, commandType: CommandType.StoredProcedure);

            var storedProcedureResult = new MerchantSearchForTerminalInstallationRequestModelOutput();
            storedProcedureResult.ObjMerchantDetail = (List<MerchantDetailOutput>)await result.ReadAsync<MerchantDetailOutput>();
            storedProcedureResult.ObjTerminalDetail = (List<TerminalDetailOutput>)await result.ReadAsync<TerminalDetailOutput>();
            storedProcedureResult.ObjStatusDetail = (List<StatusOutput>)await result.ReadAsync<StatusOutput>();
            return storedProcedureResult;

        }

        public async Task<IEnumerable<MerchantInsertAddonTerminalModelOutput>> InsertTerminalInstallationRequest([FromBody] MerchantInsertAddonTerminalModelInput ObjClass)
        {
            var procedureName = "UspInsertAddonTerminal";
            var parameters = new DynamicParameters();
            parameters.Add("MerchantId", ObjClass.MerchantId, DbType.String, ParameterDirection.Input);
            parameters.Add("TerminalTypeRequested ", ObjClass.TerminalTypeRequested, DbType.String, ParameterDirection.Input);
            parameters.Add("CreatedBy", ObjClass.CreatedBy, DbType.String, ParameterDirection.Input);
            parameters.Add("Useragent", ObjClass.Useragent, DbType.String, ParameterDirection.Input);
            parameters.Add("Userid", ObjClass.Userid, DbType.String, ParameterDirection.Input);
            parameters.Add("Userip", ObjClass.Userip, DbType.String, ParameterDirection.Input);
            parameters.Add("ReferenceId", Variables.FunGenerateStringUId(), DbType.String, ParameterDirection.Input);
            parameters.Add("TerminalIssuanceType", ObjClass.TerminalIssuanceType, DbType.String, ParameterDirection.Input);
            parameters.Add("Justification", ObjClass.Justification, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<MerchantInsertAddonTerminalModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);

        }

        public async Task<IEnumerable<MerchantSearchForTerminalInstallationRequestCloseModelOutput>> SearchForTerminalInstallationRequestClose([FromBody] MerchantSearchForTerminalInstallationRequestCloseModelInput ObjClass)
        {
            var procedureName = "UspSearchForTerminalInstallationRequestClose";
            var parameters = new DynamicParameters();
            parameters.Add("FromDate", ObjClass.FromDate, DbType.String, ParameterDirection.Input);
            parameters.Add("ToDate", ObjClass.ToDate, DbType.String, ParameterDirection.Input);
            parameters.Add("MerchantId", ObjClass.MerchantId, DbType.String, ParameterDirection.Input);
            parameters.Add("TerminalId", ObjClass.TerminalId, DbType.String, ParameterDirection.Input);
            parameters.Add("ZonalOfficeId", ObjClass.ZonalOfficeId, DbType.String, ParameterDirection.Input);
            parameters.Add("RegionalOfficeId", ObjClass.RegionalOfficeId, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<MerchantSearchForTerminalInstallationRequestCloseModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<MerchantGetReasonListModelOutput>> GetReasonList([FromBody] MerchantGetReasonListModelInput ObjClass)
        {
            var procedureName = "UspGetReasonList";
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<MerchantGetReasonListModelOutput>(procedureName, null, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<MerchantUpdateTerminalInstallationRequestCloseModelOutput>> UpdateTerminalInstallationRequestClose([FromBody] MerchantUpdateTerminalInstallationRequestCloseModelInput ObjClass)
        {
            var dtDBR = new DataTable("TypeMerchantTerminalMap");
            dtDBR.Columns.Add("MerchantId", typeof(string));
            dtDBR.Columns.Add("TerminalId", typeof(string));


            if (ObjClass.ObjMerchantTerminalInstallationRequestCloseDetail != null)
            {
                foreach (MerchantTerminalInstallationRequestCloseModelInput ObjDetail in ObjClass.ObjMerchantTerminalInstallationRequestCloseDetail)
                {
                    DataRow dr = dtDBR.NewRow();
                    dr["MerchantId"] = ObjDetail.MerchantId;
                    dr["TerminalId"] = ObjDetail.TerminalId;
                    dtDBR.Rows.Add(dr);
                    dtDBR.AcceptChanges();
                }
            }

            var procedureName = "UspUpdateTerminalInstallationRequestClose";
            var parameters = new DynamicParameters();
            parameters.Add("ReasonId", ObjClass.ReasonId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("ModifiedBy", ObjClass.ModifiedBy, DbType.String, ParameterDirection.Input);
            parameters.Add("UpdateTerminalInstReq", dtDBR, DbType.Object, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<MerchantUpdateTerminalInstallationRequestCloseModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }


        public async Task<IEnumerable<MerchantViewTerminalInstallationRequestStatusCloseModelOutput>> ViewTerminalInstallationRequestStatus([FromBody] MerchantViewTerminalInstallationRequestStatusCloseInput ObjClass)
        {
            var procedureName = "UspViewTerminalInstallationRequestStatus";
            var parameters = new DynamicParameters();
            parameters.Add("FromDate", ObjClass.FromDate, DbType.String, ParameterDirection.Input);
            parameters.Add("ToDate", ObjClass.ToDate, DbType.String, ParameterDirection.Input);
            parameters.Add("MerchantId", ObjClass.MerchantId, DbType.String, ParameterDirection.Input);
            parameters.Add("TerminalId", ObjClass.TerminalId, DbType.String, ParameterDirection.Input);
            parameters.Add("ZonalOfficeId", ObjClass.ZonalOfficeId, DbType.String, ParameterDirection.Input);
            parameters.Add("RegionalOfficeId", ObjClass.RegionalOfficeId, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<MerchantViewTerminalInstallationRequestStatusCloseModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);

        }



        public async Task<MerchantGetTerminalDeinstallationRequestModelOutput> GetTerminalDeinstallationRequest([FromBody] MerchantGetTerminalDeinstallationRequestModelInput ObjClass)
        {
            var procedureName = "UspGetTerminalDeinstallationRequest";
            var parameters = new DynamicParameters();
            parameters.Add("MerchantId", ObjClass.MerchantId, DbType.String, ParameterDirection.Input);
            parameters.Add("TerminalId", ObjClass.TerminalId, DbType.String, ParameterDirection.Input);
            parameters.Add("ZonalOfficeId", ObjClass.ZonalOfficeId, DbType.String, ParameterDirection.Input);
            parameters.Add("RegionalOfficeId", ObjClass.RegionalOfficeId, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            var result = await connection.QueryMultipleAsync(procedureName, parameters, commandType: CommandType.StoredProcedure);

            var storedProcedureResult = new MerchantGetTerminalDeinstallationRequestModelOutput();
            storedProcedureResult.ObjMerchantDeinstallationDetail = (List<MerchantDeinstallationDetailOutput>)await result.ReadAsync<MerchantDeinstallationDetailOutput>();
            storedProcedureResult.ObjTerminalDeinstallationDetail = (List<TerminalDeinstallationDetailOutput>)await result.ReadAsync<TerminalDeinstallationDetailOutput>();
            return storedProcedureResult;

        }


        public async Task<IEnumerable<MerchantUpdateTerminalDeInstalRequestModelOutput>> UpdateTerminalDeInstalRequest([FromBody] MerchantUpdateTerminalDeInstalRequestModelInput ObjClass)
        {
            var dtDBR = new DataTable("TypeTerminalIds");
            dtDBR.Columns.Add("TerminalId", typeof(string));


            if (ObjClass.ObjUpdateTerminalDeInstalRequest != null)
            {
                foreach (UpdateTerminalDeInstalRequestModelInput ObjDetail in ObjClass.ObjUpdateTerminalDeInstalRequest)
                {
                    DataRow dr = dtDBR.NewRow();
                    dr["TerminalId"] = ObjDetail.TerminalId;
                    dtDBR.Rows.Add(dr);
                    dtDBR.AcceptChanges();
                }
            }

            var procedureName = "UspTerminalDeInstalUpdateRequest";
            var parameters = new DynamicParameters();
            parameters.Add("MerchantId", ObjClass.MerchantId, DbType.String, ParameterDirection.Input);
            parameters.Add("DeinstallationType", ObjClass.DeinstallationType, DbType.String, ParameterDirection.Input);
            parameters.Add("Comments", ObjClass.Comments, DbType.String, ParameterDirection.Input);
            parameters.Add("ModifiedBy", ObjClass.ModifiedBy, DbType.String, ParameterDirection.Input);
            parameters.Add("UpdateTerminalDeInstReq", dtDBR, DbType.Object, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<MerchantUpdateTerminalDeInstalRequestModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<MerchantGetTerminalDeInstallationRequestCloseModelOutput>> GetTerminalDeInstallationRequestClose([FromBody] MerchantGetTerminalDeInstallationRequestCloseModelInput ObjClass)
        {
            var procedureName = "UspGetTerminalDeInstallationRequestClose";
            var parameters = new DynamicParameters();
            parameters.Add("FromDate", ObjClass.FromDate, DbType.String, ParameterDirection.Input);
            parameters.Add("ToDate", ObjClass.ToDate, DbType.String, ParameterDirection.Input);
            parameters.Add("MerchantId", ObjClass.MerchantId, DbType.String, ParameterDirection.Input);
            parameters.Add("TerminalId", ObjClass.TerminalId, DbType.String, ParameterDirection.Input);
            parameters.Add("ZonalOfficeId", ObjClass.ZonalOfficeId, DbType.String, ParameterDirection.Input);
            parameters.Add("RegionalOfficeId", ObjClass.RegionalOfficeId, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<MerchantGetTerminalDeInstallationRequestCloseModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<MerchantTerminalDeInstalUpdateRequestCloseModelOutput>> TerminalDeInstalUpdateRequestClose([FromBody] MerchantTerminalDeInstalUpdateRequestCloseModelInput ObjClass)
        {
            var dtDBR = new DataTable("TypeMerchantTerminalMap");
            dtDBR.Columns.Add("MerchantId", typeof(string));
            dtDBR.Columns.Add("TerminalID", typeof(string));


            if (ObjClass.ObjMerchantTerminalMapInput != null)
            {
                foreach (MerchantTerminalMapInput ObjDetail in ObjClass.ObjMerchantTerminalMapInput)
                {
                    DataRow dr = dtDBR.NewRow();
                    dr["MerchantId"] = ObjDetail.MerchantId;
                    dr["TerminalID"] = ObjDetail.TerminalID;
                    dtDBR.Rows.Add(dr);
                    dtDBR.AcceptChanges();
                }
            }

            var procedureName = "UspTerminalDeInstalUpdateRequestClose";
            var parameters = new DynamicParameters();
            parameters.Add("Status", ObjClass.Status, DbType.String, ParameterDirection.Input);
            parameters.Add("Comments", ObjClass.Comments, DbType.String, ParameterDirection.Input);
            parameters.Add("ModifiedBy", ObjClass.ModifiedBy, DbType.String, ParameterDirection.Input);
            parameters.Add("UpdateTerminalDeInstReqClose", dtDBR, DbType.Object, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<MerchantTerminalDeInstalUpdateRequestCloseModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<MerchantGetTerminalInstallationRequestApprovalModelOutput>> GetTerminalInstallationRequestApproval([FromBody] MerchantGetTerminalInstallationRequestApprovalModelInput ObjClass)
        {
            var procedureName = "UspGetTerminalInstallationRequestApproval";
            var parameters = new DynamicParameters();
            parameters.Add("FromDate", ObjClass.FromDate, DbType.String, ParameterDirection.Input);
            parameters.Add("ToDate", ObjClass.ToDate, DbType.String, ParameterDirection.Input);
            parameters.Add("Category", ObjClass.Category, DbType.String, ParameterDirection.Input);
            parameters.Add("ZonalOfficeId", ObjClass.ZonalOfficeId, DbType.String, ParameterDirection.Input);
            parameters.Add("RegionalOfficeId", ObjClass.RegionalOfficeId, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<MerchantGetTerminalInstallationRequestApprovalModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }


        public async Task<IEnumerable<MerchantUpdateTerminalInstallationRequestApprovalModelOutput>> InsertTerminalInstallationRequestApproval([FromBody] MerchantUpdateTerminalInstallationRequestApprovalModelInput ObjClass)
        {
            var dtDBR = new DataTable("TypeMerchantTerminalMap");
            dtDBR.Columns.Add("MerchantId", typeof(string));
            dtDBR.Columns.Add("TerminalID", typeof(string));


            if (ObjClass.ObjMerchantTerminalInsertInput != null)
            {
                foreach (MerchantTerminalInsertInput ObjDetail in ObjClass.ObjMerchantTerminalInsertInput)
                {
                    DataRow dr = dtDBR.NewRow();
                    dr["MerchantId"] = ObjDetail.MerchantId;
                    dr["TerminalID"] = ObjDetail.TerminalID;
                    dtDBR.Rows.Add(dr);
                    dtDBR.AcceptChanges();
                }
            }

            var procedureName = "UspUpdateTerminalInstallationRequestApproval";
            var parameters = new DynamicParameters();
            parameters.Add("Remark", ObjClass.Remark, DbType.String, ParameterDirection.Input);
            parameters.Add("Action", ObjClass.Action, DbType.String, ParameterDirection.Input);
            parameters.Add("ModifiedBy", ObjClass.ModifiedBy, DbType.String, ParameterDirection.Input);
            parameters.Add("UpdateTerminalInstReq", dtDBR, DbType.Object, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<MerchantUpdateTerminalInstallationRequestApprovalModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }


        public async Task<IEnumerable<MerchantGetTerminalDeInstallationRequestApprovalModelOutput>> GetTerminalDeInstallationRequestApproval([FromBody] MerchantGetTerminalDeInstallationRequestApprovalModelInput ObjClass)
        {
            var procedureName = "UspGetTerminalDeInstallationRequestApproval";
            var parameters = new DynamicParameters();
            parameters.Add("FromDate", ObjClass.FromDate, DbType.String, ParameterDirection.Input);
            parameters.Add("ToDate", ObjClass.ToDate, DbType.String, ParameterDirection.Input);
            parameters.Add("MerchantId", ObjClass.MerchantId, DbType.String, ParameterDirection.Input);
            parameters.Add("TerminalId", ObjClass.TerminalId, DbType.String, ParameterDirection.Input);
            parameters.Add("ZonalOfficeId", ObjClass.ZonalOfficeId, DbType.String, ParameterDirection.Input);
            parameters.Add("RegionalOfficeId", ObjClass.RegionalOfficeId, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<MerchantGetTerminalDeInstallationRequestApprovalModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }


        public async Task<IEnumerable<MerchantInsertTerminalDeInstallationRequestApprovalModelOutput>> InsertTerminalDeInstallationRequestApproval([FromBody] MerchantInsertTerminalDeInstallationRequestApprovalModelInput ObjClass)
        {
            var dtDBR = new DataTable("TypeMerchantTerminalMap");
            dtDBR.Columns.Add("MerchantId", typeof(string));
            dtDBR.Columns.Add("TerminalID", typeof(string));


            if (ObjClass.ObjTerminalDeInstallationInsertInput != null)
            {
                foreach (MerchantTerminalDeInstallationInsertInput ObjDetail in ObjClass.ObjTerminalDeInstallationInsertInput)
                {
                    DataRow dr = dtDBR.NewRow();
                    dr["MerchantId"] = ObjDetail.MerchantId;
                    dr["TerminalID"] = ObjDetail.TerminalID;
                    dtDBR.Rows.Add(dr);
                    dtDBR.AcceptChanges();
                }
            }

            var procedureName = "UspUpdateTerminalDeInstallationRequestApproval";
            var parameters = new DynamicParameters();
            parameters.Add("Remark", ObjClass.Remark, DbType.String, ParameterDirection.Input);
            parameters.Add("Action", ObjClass.Action, DbType.String, ParameterDirection.Input);
            parameters.Add("ModifiedBy", ObjClass.ModifiedBy, DbType.String, ParameterDirection.Input);
            parameters.Add("UpdateTerminalInstReq", dtDBR, DbType.Object, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<MerchantInsertTerminalDeInstallationRequestApprovalModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }


        public async Task<IEnumerable<MerchantGetTerminalDeInstallationRequestAuthorizationModelOutput>> GetTerminalDeInstallationRequestAuthorization([FromBody] MerchantGetTerminalDeInstallationRequestAuthorizationModelInput ObjClass)
        {
            var procedureName = "UspGetTerminalDeInstallationRequestAuthorization";
            var parameters = new DynamicParameters();
            parameters.Add("FromDate", ObjClass.FromDate, DbType.String, ParameterDirection.Input);
            parameters.Add("ToDate", ObjClass.ToDate, DbType.String, ParameterDirection.Input);
            parameters.Add("MerchantId", ObjClass.MerchantId, DbType.String, ParameterDirection.Input);
            parameters.Add("TerminalId", ObjClass.TerminalId, DbType.String, ParameterDirection.Input);
            parameters.Add("ZonalOfficeId", ObjClass.ZonalOfficeId, DbType.String, ParameterDirection.Input);
            parameters.Add("RegionalOfficeId", ObjClass.RegionalOfficeId, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<MerchantGetTerminalDeInstallationRequestAuthorizationModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }


        public async Task<IEnumerable<MerchantInsertTerminalDeInstallationRequestAuthorizationModelOutput>> InsertTerminalDeInstallationRequestAuthorization([FromBody] MerchantInsertTerminalDeInstallationRequestAuthorizationModelInput ObjClass)
        {
            var dtDBR = new DataTable("TypeMerchantTerminalMap");
            dtDBR.Columns.Add("MerchantId", typeof(string));
            dtDBR.Columns.Add("TerminalId", typeof(string));


            if (ObjClass.ObjTerminalDeInstallationAuthorizationInput != null)
            {
                foreach (MerchantTerminalDeInstallationAuthorizationInsertInput ObjDetail in ObjClass.ObjTerminalDeInstallationAuthorizationInput)
                {
                    DataRow dr = dtDBR.NewRow();
                    dr["MerchantId"] = ObjDetail.MerchantId;
                    dr["TerminalId"] = ObjDetail.TerminalId;
                    dtDBR.Rows.Add(dr);
                    dtDBR.AcceptChanges();
                }
            }

            var procedureName = "UspUpdateTerminalDeInstallationRequestAuthorization";
            var parameters = new DynamicParameters();
            parameters.Add("Remark", ObjClass.Remark, DbType.String, ParameterDirection.Input);
            parameters.Add("Action", ObjClass.Action, DbType.String, ParameterDirection.Input);
            parameters.Add("ModifiedBy", ObjClass.ModifiedBy, DbType.String, ParameterDirection.Input);
            parameters.Add("UpdateTerminalInstReq", dtDBR, DbType.Object, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<MerchantInsertTerminalDeInstallationRequestAuthorizationModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }


        public async Task<IEnumerable<MerchantViewTerminalDeInstallationRequestStatusModelOutput>> ViewTerminalDeInstallationRequestStatus([FromBody] MerchantViewTerminalDeInstallationRequestStatusModelInput ObjClass)
        {
            var procedureName = "UspViewTerminalDeInstallationRequestStatus";
            var parameters = new DynamicParameters();
            parameters.Add("FromDate", ObjClass.FromDate, DbType.String, ParameterDirection.Input);
            parameters.Add("ToDate", ObjClass.ToDate, DbType.String, ParameterDirection.Input);
            parameters.Add("MerchantId", ObjClass.MerchantId, DbType.String, ParameterDirection.Input);
            parameters.Add("TerminalId", ObjClass.TerminalId, DbType.String, ParameterDirection.Input);
            parameters.Add("ZonalOfficeId", ObjClass.ZonalOfficeId, DbType.String, ParameterDirection.Input);
            parameters.Add("RegionalOfficeId", ObjClass.RegionalOfficeId, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<MerchantViewTerminalDeInstallationRequestStatusModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }


        public async Task<IEnumerable<MerchantGetProblematicDeinstalledToDeinstalledModelOutput>> GetProblematicDeinstalledToDeinstalled([FromBody] MerchantGetProblematicDeinstalledToDeinstalledModelInput ObjClass)
        {
            var procedureName = "UspGetProblematicDeinstalledToDeinstalled";
            var parameters = new DynamicParameters();
            parameters.Add("FromDate", ObjClass.FromDate, DbType.String, ParameterDirection.Input);
            parameters.Add("ToDate", ObjClass.ToDate, DbType.String, ParameterDirection.Input);
            parameters.Add("MerchantId", ObjClass.MerchantId, DbType.String, ParameterDirection.Input);
            parameters.Add("TerminalId", ObjClass.TerminalId, DbType.String, ParameterDirection.Input);
            parameters.Add("ZonalOfficeId", ObjClass.ZonalOfficeId, DbType.String, ParameterDirection.Input);
            parameters.Add("RegionalOfficeId", ObjClass.RegionalOfficeId, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<MerchantGetProblematicDeinstalledToDeinstalledModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }


        public async Task<IEnumerable<MerchantInsertProblematicDeinstalledToDeinstalledModelOutput>> InsertProblematicDeinstalledToDeinstalled([FromBody] MerchantInsertProblematicDeinstalledToDeinstalledModelInput ObjClass)
        {
            var dtDBR = new DataTable("TypeMerchantTerminalMap");
            dtDBR.Columns.Add("MerchantId", typeof(string));
            dtDBR.Columns.Add("TerminalId", typeof(string));


            if (ObjClass.ObjTerminalProblematicDeinstalledToDeinstalled != null)
            {
                foreach (TerminalProblematicDeinstalledToDeinstalled ObjDetail in ObjClass.ObjTerminalProblematicDeinstalledToDeinstalled)
                {
                    DataRow dr = dtDBR.NewRow();
                    dr["MerchantId"] = ObjDetail.MerchantId;
                    dr["TerminalId"] = ObjDetail.TerminalId;
                    dtDBR.Rows.Add(dr);
                    dtDBR.AcceptChanges();
                }
            }

            var procedureName = "UspUpdateProblematicDeinstalledToDeinstalled";
            var parameters = new DynamicParameters();
            parameters.Add("Remark", ObjClass.Remark, DbType.String, ParameterDirection.Input);
            parameters.Add("ModifiedBy", ObjClass.ModifiedBy, DbType.String, ParameterDirection.Input);
            parameters.Add("UpdateTerminalInstReq", dtDBR, DbType.Object, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<MerchantInsertProblematicDeinstalledToDeinstalledModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<MerchantGetManageTerminalDetailsModelOutput>> GetManageTerminalDetails([FromBody] MerchantGetManageTerminalDetailsModelInput ObjClass)
        {
            var procedureName = "UspGetManageTerminalDetails";
            var parameters = new DynamicParameters();
            parameters.Add("DeploymentStatus", ObjClass.DeploymentStatus, DbType.String, ParameterDirection.Input);
            parameters.Add("MerchantId", ObjClass.MerchantId, DbType.String, ParameterDirection.Input);
            parameters.Add("TerminalId", ObjClass.TerminalId, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<MerchantGetManageTerminalDetailsModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }


        public async Task<IEnumerable<MerchantGetTerminalTypeModelOutput>> GetTerminalType([FromBody] MerchantGetTerminalTypeModelInput ObjClass)
        {
            var procedureName = "UspGetTerminalType";
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<MerchantGetTerminalTypeModelOutput>(procedureName, null, commandType: CommandType.StoredProcedure);
        }

        public async Task<MerchantTerminalDetailModelOutput> TerminalDetail([FromBody] MerchantTerminalDetailModelInput ObjClass)
        {
            var procedureName = "UspTerminalDetails";
            var parameters = new DynamicParameters();
            parameters.Add("TerminalId", ObjClass.TerminalId, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            var result = await connection.QueryMultipleAsync(procedureName, parameters, commandType: CommandType.StoredProcedure);
            var storedProcedureResult = new MerchantTerminalDetailModelOutput();
            storedProcedureResult.ObjTerminalDetail = (List<TerminalDetail>)await result.ReadAsync<TerminalDetail>();
            storedProcedureResult.ObjTerminalDeploymentDetail = (List<TerminalDeploymentDetail>)await result.ReadAsync<TerminalDeploymentDetail>();
            return storedProcedureResult;
        }

        public async Task<IEnumerable<MerchantSearchTerminalModelOutput>> SearchTerminal([FromBody] MerchantSearchTerminalModelInput ObjClass)
        {
            var procedureName = "UspSearchTerminal";
            var parameters = new DynamicParameters();
            parameters.Add("MerchantId", ObjClass.MerchantId, DbType.String, ParameterDirection.Input);
            parameters.Add("TerminalId", ObjClass.TerminalId, DbType.String, ParameterDirection.Input);
            parameters.Add("TerminalType", ObjClass.TerminalType, DbType.String, ParameterDirection.Input);
            parameters.Add("IssueDate", ObjClass.IssueDate, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<MerchantSearchTerminalModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }
    }
}
