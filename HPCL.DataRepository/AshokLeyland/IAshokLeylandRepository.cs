using HPCL.DataModel.AshokLeyland;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.AshokLeyland
{
    public interface IAshokLeylandRepository
    {
        public Task<IEnumerable<ALDealerEnrollmentModelOutput>> InsertALDealerEnrollment([FromBody] ALDealerEnrollmentModelInput ObjClass);

        public Task<IEnumerable<UpdateALDealerEnrollmentModelOutput>> UpdateALDealerEnrollment([FromBody] UpdateALDealerEnrollmentModelInput ObjClass);

        public Task<IEnumerable<GetDealerNameModelOutput>> GetALDealerDetail([FromBody] GetDealerNameModelInput ObjClass);

        public Task<IEnumerable<CheckDealerCodeModelOutput>> CheckDealerCode([FromBody] CheckDealerCodeModelInput ObjClass);

        public Task<IEnumerable<InsertALCustomerModelOutput>> InsertALCustomer([FromBody] InsertALCustomerModelInput ObjClass);

        public Task<IEnumerable<InsertDealerWiseALOTCCardRequestModelOutput>> InsertDealerWiseALOTCCardRequest([FromBody] InsertDealerWiseALOTCCardRequestModelInput ObjClass);

        public Task<IEnumerable<GetAvailityALOTCCardCardOutput>> GetAvailityALOTCCard([FromBody] GetAvailityALOTCCardCardInput ObjClass);

        public Task<ALViewCardMerchantAllocationModelOutput> ViewALOTCCardDealerAllocation([FromBody] ALViewCardDealerAllocationModelInput ObjClass);

        public Task<GetAlAddonOTCCardMappingCustomerDetailsModelOutput> GetAlAddonOTCCardMappingCustomerDetails([FromBody] GetAlAddonOTCCardMappingCustomerDetailsModelInput ObjClass);

        public Task<IEnumerable<GetAlSalesExeEmpIdAddOnOTCCardMappingModelOutput>> GetAlSalesExeEmpIdAddOnOTCCardMapping([FromBody] GetAlSalesExeEmpIdAddOnOTCCardMappingModelInput ObjClass);

        public Task<IEnumerable<AlAddOnOTCCardModelOutput>> AlAddOnOTCCard([FromBody] AlAddOnOTCCardModelInput ObjClass);
        public Task<IEnumerable<GetALVerifyCustomerDocumentModelOutput>> GetALVerifyCustomerDocument([FromBody] ALVerifyCustomerDocumentModelInput ObjClass);


    }
}
