using HPCL.DataModel.TMS;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.TMS
{
    public interface ITMSRepository
    {
        public Task<IEnumerable<GetEnrollTransportManagementSystemModelOutput>> GetEnrollTransportManagementSystem([FromBody] GetEnrollTransportManagementSystemModelInput ObjClass);
        public Task<IEnumerable<GetEnrollmentStatusModelOutput>> GetEnrollmentStatus([FromBody] GetEnrollmentStatusModelInput ObjClass);
        public Task<GetEnrollVehicleModelOutput> GetEnrollVehicle([FromBody] GetEnrollVehicleModelInput ObjClass);
        public Task<IEnumerable<GetManageEnrollmentsModelOutput>> GetManageEnrollments([FromBody] GetManageEnrollmentsModelInput ObjClass);

        public void InsertAPIRequestResponse([FromBody] ApiRequestResponse ObjClass);
        public Task<IEnumerable<CargoFlRegisterTrucker>> GetCargoFlRegisterTruckerDetail([FromBody] string CustomerId);
        public Task<IEnumerable<GetCustomerDetailForEnrollmentApprovalOutput>> GetCustomerDetailForEnrollmentApproval([FromBody] GetCustomerDetailForEnrollmentApprovalInput ObjClass);
        public Task<IEnumerable<GetEnrollmentStatusModelOutput>> GetEnrollmentStatus();
        public Task<IEnumerable<TMSUpdateEnrollmentStatusModelOutput>> TMSInsertCustomerTracking([FromBody] TMSUpdateEnrollmentStatusModelInput ObjClass,string ApiUrl);
    }
}
