using HPCL.DataModel.Officer;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.Officer
{
    public interface IOfficerRepository
    {
        public Task<IEnumerable<OfficerInsertModelOutput>> InsertOfficer([FromBody] OfficerInsertModelInput ObjClass);
        public Task<IEnumerable<GetOfficerModelOutput>> GetOfficerDetail([FromBody] GetOfficerModelInput ObjClass);
        public Task<IEnumerable<OfficerUpdateModelOutput>> UpdateOfficer([FromBody] OfficerUpdateModelInput ObjClass);
        public Task<IEnumerable<DeleteOfficerModelOutput>> DeleteOfficer([FromBody] DeleteOfficerModelInput ObjClass);
        public Task<IEnumerable<CheckOfficerModelOutput>> ChkUserName([FromBody] CheckOfficerModelInput ObjClass);
        public Task<IEnumerable<OfficerLocationMappingModelOutput>> InsertOfficerLocationMapping([FromBody] OfficerLocationMappingModelInput ObjClass);

        public Task<IEnumerable<OfficerDeleteLocationMappingModelOutput>> DeleteOfficerLocationMapping([FromBody] OfficerDeleteLocationMappingModelInput ObjClass);

        public Task<IEnumerable<GetOfficerModelOutput>> BindOfficer([FromBody] BindOfficerModelInput ObjClass);

        public Task<IEnumerable<GetOfficerTypeModelOutput>> GetOfficerType([FromBody] GetOfficerTypeModelInput ObjClass);

        public Task<IEnumerable<GetOfficerLocationMappingModelOutput>> GetOfficerLocationMapping([FromBody] BindOfficerModelInput ObjClass);

        public Task<IEnumerable<BindRBEOfficerModelOutput>> BindOfficerbyRBEId([FromBody] BindRBEOfficerModelInput ObjClass);

        public Task<IEnumerable<OfficerUpdateModelOutput>> UpdateRBEOfficer([FromBody] RBEOfficerUpdateModelInput ObjClass);

        public Task<IEnumerable<OfficerKYCModelOutput>> UploadOfficerKYC([Microsoft.AspNetCore.Mvc.FromForm] OfficerKYCModelInput ObjClass);

        public Task<IEnumerable<GetRBEMobilenoModelOutput>> CheckRBEMobileNo([FromBody] GetRBEMobilenoModelInput ObjClass);

        public Task<IEnumerable<GetOfficerCreationApprovalModelOutput>> BindRBEDetail([FromBody] GetOfficerCreationApprovalModelInput ObjClass);

        public Task<IEnumerable<GetRBEDetailbyUserNameModelOutput>> GetRBEDetailbyUserName([FromBody] GetRBEDetailbyUserNameModelInput ObjClass);

        public Task<IEnumerable<RBEApprovalRejectApprovalModelOutput>> ApproveRejectRBE([FromBody] RBEApprovalRejectModelInput ObjClass);

        public  Task<IEnumerable<GetOfficerDetailModelOutput>> GetOfficerDetailByLocation([FromBody] GetOfficerDetailModelInput ObjClass);

        public Task<IEnumerable<InsertRBEOfficerModelOutput>> InsertRBEOfficer([FromBody] InsertRBEOfficerModelInput ObjClass);

        public Task<IEnumerable<OfficerALDealerEnrollmentModelOutput>> InsertALDealerEnrollment([FromBody] OfficerALDealerEnrollmentModelInput ObjClass);

        public Task<IEnumerable<OfficerUpdateALDealerEnrollmentModelOutput>> UpdateALDealerEnrollment([FromBody] OfficerUpdateALDealerEnrollmentModelInput ObjClass);

        public Task<IEnumerable<OfficerGetDealerNameModelOutput>> GetALDealerDetail([FromBody] OfficerGetDealerNameModelInput ObjClass);

    }
}
