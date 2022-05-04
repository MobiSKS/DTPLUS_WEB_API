using Dapper;
using HPCL.DataModel.AggregatorCustomer;
using HPCL.DataRepository.DBDapper;
using HPCL.Infrastructure.CommonClass;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.AggregatorCustomer
{
    public class AggregatorCustomerRepository : IAggregatorCustomerRepository
    {
        private readonly DapperContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;

        public AggregatorCustomerRepository(DapperContext context, IHostingEnvironment hostingEnvironment) // , IConfiguration configuration
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        public async Task<IEnumerable<AggregatorCustomerInsertModelOutput>> InsertAggregatorCustomer([FromBody] AggregatorCustomerInsertModelInput ObjClass)
        {
            //var dtDBR = new DataTable("UserDTNoofCards");
            //dtDBR.Columns.Add("CardIdentifier", typeof(string));
            //dtDBR.Columns.Add("VechileNo", typeof(string));
            //dtDBR.Columns.Add("VehicleMake", typeof(string));
            //dtDBR.Columns.Add("VehicleType", typeof(string));
            //dtDBR.Columns.Add("YearOfRegistration", typeof(int));

            //var procedureName = "UspInsertCustomer";
            var procedureName = "UspInsertRawCustomer";
            var parameters = new DynamicParameters();
            parameters.Add("CustomerType", ObjClass.CustomerType, DbType.Int32, ParameterDirection.Input);
            parameters.Add("CustomerSubtype", ObjClass.CustomerSubtype, DbType.Int32, ParameterDirection.Input);
            parameters.Add("ZonalOffice", ObjClass.ZonalOffice, DbType.Int32, ParameterDirection.Input);
            parameters.Add("RegionalOffice", ObjClass.RegionalOffice, DbType.Int32, ParameterDirection.Input);
            parameters.Add("DateOfApplication", ObjClass.DateOfApplication, DbType.DateTime, ParameterDirection.Input);
            parameters.Add("SalesArea", ObjClass.SalesArea, DbType.Int32, ParameterDirection.Input);
            parameters.Add("CreatedBy", ObjClass.CreatedBy, DbType.String, ParameterDirection.Input);
            parameters.Add("IndividualOrgNameTitle", ObjClass.IndividualOrgNameTitle, DbType.String, ParameterDirection.Input);
            parameters.Add("IndividualOrgName", ObjClass.IndividualOrgName, DbType.String, ParameterDirection.Input);
            parameters.Add("NameOnCard", ObjClass.NameOnCard, DbType.String, ParameterDirection.Input);
            parameters.Add("TypeOfBusinessEntity", ObjClass.TypeOfBusinessEntity, DbType.Int32, ParameterDirection.Input);
            parameters.Add("ResidenceStatus", ObjClass.ResidenceStatus, DbType.String, ParameterDirection.Input);
            parameters.Add("IncomeTaxPan", ObjClass.IncomeTaxPan, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationAddress1", ObjClass.CommunicationAddress1, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationAddress2", ObjClass.CommunicationAddress2, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationAddress3", ObjClass.CommunicationAddress3, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationLocation", ObjClass.CommunicationLocation, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationCityName", ObjClass.CommunicationCityName, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationPincode", ObjClass.CommunicationPincode, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationStateId", ObjClass.CommunicationStateId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("CommunicationDistrictId", ObjClass.CommunicationDistrictId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("CommunicationPhoneNo", ObjClass.CommunicationPhoneNo, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationFax", ObjClass.CommunicationFax, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationMobileNo", ObjClass.CommunicationMobileNo, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationEmailid", ObjClass.CommunicationEmailid, DbType.String, ParameterDirection.Input);
            parameters.Add("PermanentAddress1", ObjClass.PermanentAddress1, DbType.String, ParameterDirection.Input);
            parameters.Add("PermanentAddress2", ObjClass.PermanentAddress2, DbType.String, ParameterDirection.Input);
            parameters.Add("PermanentAddress3", ObjClass.PermanentAddress3, DbType.String, ParameterDirection.Input);
            parameters.Add("PermanentLocation", ObjClass.PermanentLocation, DbType.String, ParameterDirection.Input);
            parameters.Add("PermanentCityName", ObjClass.PermanentCityName, DbType.String, ParameterDirection.Input);
            parameters.Add("PermanentPincode", ObjClass.PermanentPincode, DbType.String, ParameterDirection.Input);
            parameters.Add("PermanentStateId", ObjClass.PermanentStateId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("PermanentDistrictId", ObjClass.PermanentDistrictId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("PermanentPhoneNo", ObjClass.PermanentPhoneNo, DbType.String, ParameterDirection.Input);
            parameters.Add("PermanentFax", ObjClass.PermanentFax, DbType.String, ParameterDirection.Input);
            parameters.Add("KeyOfficialTitle", ObjClass.KeyOfficialTitle, DbType.String, ParameterDirection.Input);
            parameters.Add("KeyOfficialIndividualInitials", ObjClass.KeyOfficialIndividualInitials, DbType.String, ParameterDirection.Input);
            parameters.Add("KeyOfficialFirstName", ObjClass.KeyOfficialFirstName, DbType.String, ParameterDirection.Input);
            parameters.Add("KeyOfficialMiddleName", ObjClass.KeyOfficialMiddleName, DbType.String, ParameterDirection.Input);
            parameters.Add("KeyOfficialLastName", ObjClass.KeyOfficialLastName, DbType.String, ParameterDirection.Input);
            parameters.Add("KeyOfficialFax", ObjClass.KeyOfficialFax, DbType.String, ParameterDirection.Input);
            parameters.Add("KeyOfficialDesignation", ObjClass.KeyOfficialDesignation, DbType.String, ParameterDirection.Input);
            parameters.Add("KeyOfficialEmail", ObjClass.KeyOfficialEmail, DbType.String, ParameterDirection.Input);
            parameters.Add("KeyOfficialPhoneNo", ObjClass.KeyOfficialPhoneNo, DbType.String, ParameterDirection.Input);
            parameters.Add("KeyOfficialDOA", ObjClass.KeyOfficialDOA, DbType.DateTime, ParameterDirection.Input);
            parameters.Add("KeyOfficialMobile", ObjClass.KeyOfficialMobile, DbType.String, ParameterDirection.Input);
            parameters.Add("KeyOfficialDOB", ObjClass.KeyOfficialDOB, DbType.DateTime, ParameterDirection.Input);
            parameters.Add("KeyOfficialSecretQuestion", ObjClass.KeyOfficialSecretQuestion, DbType.Int32, ParameterDirection.Input);
            parameters.Add("KeyOfficialSecretAnswer", ObjClass.KeyOfficialSecretAnswer, DbType.String, ParameterDirection.Input);
            parameters.Add("KeyOfficialTypeOfFleet", ObjClass.KeyOfficialTypeOfFleet, DbType.Int32, ParameterDirection.Input);
            parameters.Add("KeyOfficialCardAppliedFor", ObjClass.KeyOfficialCardAppliedFor, DbType.String, ParameterDirection.Input);
            parameters.Add("KeyOfficialApproxMonthlySpendsonVechile1", ObjClass.KeyOfficialApproxMonthlySpendsonVechile1, DbType.Double, ParameterDirection.Input);
            parameters.Add("KeyOfficialApproxMonthlySpendsonVechile2", ObjClass.KeyOfficialApproxMonthlySpendsonVechile2, DbType.Double, ParameterDirection.Input);
            parameters.Add("AreaOfOperation", ObjClass.AreaOfOperation, DbType.String, ParameterDirection.Input);
            parameters.Add("FleetSizeNoOfVechileOwnedHCV", ObjClass.FleetSizeNoOfVechileOwnedHCV, DbType.Int16, ParameterDirection.Input);
            parameters.Add("FleetSizeNoOfVechileOwnedLCV", ObjClass.FleetSizeNoOfVechileOwnedLCV, DbType.Int16, ParameterDirection.Input);
            parameters.Add("FleetSizeNoOfVechileOwnedMUVSUV", ObjClass.FleetSizeNoOfVechileOwnedMUVSUV, DbType.Int16, ParameterDirection.Input);
            parameters.Add("FleetSizeNoOfVechileOwnedCarJeep", ObjClass.FleetSizeNoOfVechileOwnedCarJeep, DbType.Int16, ParameterDirection.Input);
            //parameters.Add("NoOfCards", ObjClass.NoOfCards, DbType.Int32, ParameterDirection.Input);
            //parameters.Add("FeePaymentsCollectFeeWaiver", ObjClass.FeePaymentsCollectFeeWaiver, DbType.Int16, ParameterDirection.Input);
            //parameters.Add("FeePaymentsChequeNo", ObjClass.FeePaymentsChequeNo, DbType.String, ParameterDirection.Input);
            //parameters.Add("FeePaymentsChequeDate", ObjClass.FeePaymentsChequeDate, DbType.DateTime, ParameterDirection.Input);
            parameters.Add("Useragent", ObjClass.Useragent, DbType.String, ParameterDirection.Input);
            parameters.Add("Userid", ObjClass.Userid, DbType.String, ParameterDirection.Input);
            parameters.Add("Userip", ObjClass.Userip, DbType.String, ParameterDirection.Input);
            parameters.Add("ReferenceId", Variables.FunGenerateStringUId(), DbType.String, ParameterDirection.Input);
            parameters.Add("TierOfCustomer", ObjClass.TierOfCustomer, DbType.Int32, ParameterDirection.Input);
            parameters.Add("TypeOfCustomer", ObjClass.TypeOfCustomer, DbType.Int32, ParameterDirection.Input);
            parameters.Add("RBEId", ObjClass.RBEId, DbType.String, ParameterDirection.Input);
            parameters.Add("FormNumber", ObjClass.FormNumber, DbType.Int64, ParameterDirection.Input);
            parameters.Add("PanCardRemarks", ObjClass.PanCardRemarks, DbType.String, ParameterDirection.Input);
            //if (ObjClass.NoOfCards > 0 && ObjClass.ObjCardDetail != null)
            //{
            //    foreach (CardDetail ObjCardDetails in ObjClass.ObjCardDetail)
            //    {
            //        DataRow dr = dtDBR.NewRow();
            //        dr["CardIdentifier"] = ObjCardDetails.CardIdentifier;
            //        dr["VechileNo"] = ObjCardDetails.VechileNo;
            //        dr["VehicleMake"] = ObjCardDetails.VehicleMake;
            //        dr["VehicleType"] = ObjCardDetails.VehicleType;
            //        dr["YearOfRegistration"] = ObjCardDetails.YearOfRegistration;

            //        dtDBR.Rows.Add(dr);
            //        dtDBR.AcceptChanges();
            //    }
            //}
            //parameters.Add("CardDetails", dtDBR, DbType.Object, ParameterDirection.Input);

            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<AggregatorCustomerInsertModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

    }

}
