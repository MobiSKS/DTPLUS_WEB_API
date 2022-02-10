﻿using HPCL.DataModel.Customer;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.Customer
{
    public interface ICustomerRepository
    {
        public Task<IEnumerable<GetCustomerTypeModelOutput>> GetCustomerType([FromBody] GetCustomerTypeModelInput ObjClass);
        public Task<IEnumerable<GetCustomerSubTypeModelOutput>> GetCustomerSubType([FromBody] GetCustomerSubTypeModelInput ObjClass);
        public Task<IEnumerable<GetCustomerTBEntityNameModelOutput>> GetTBEntityName([FromBody] GetCustomerTBEntityNameModelInput ObjClass);
        public Task<IEnumerable<GetCustomerSecretQuestionModelOutput>> GetSecretQuestion([FromBody] GetCustomerSecretQuestionModelInput ObjClass);
        public Task<IEnumerable<GetCustomerTypeOfFleetModelOutput>> GetTypeOfFleet([FromBody] GetCustomerTypeOfFleetModelInput ObjClass);
        public Task<IEnumerable<CustomerInsertModelOutput>> InsertCustomer([FromBody] CustomerInsertModelInput ObjClass);
        public Task<IEnumerable<CustomerUpdateModelOutput>> UpdateCustomer([FromBody] CustomerUpdateModelInput ObjClass);
        public Task<IEnumerable<CustomerViewOnlineFormStatusModelOutput>> ViewOnlineFormStatus([FromBody] CustomerViewOnlineFormStatusModelInput ObjClass);
        public Task<IEnumerable<CustomerKYCModelOutput>> UploadCustomerKYC([Microsoft.AspNetCore.Mvc.FromForm] CustomerKYCModelInput ObjClass);
        public Task<IEnumerable<CustomerApprovalModelOutput>> ApproveRejectCustomer([FromBody] CustomerApprovalModelInput ObjClass);
        
        public Task<IEnumerable<CustomerGetVehicleTypeModelOutput>> GetVehicleType([FromBody] CustomerGetVehicleTypeModelInput ObjClass);
        public Task<IEnumerable<CustomerFeewaiverApprovalModelOutput>> ApproveRejectFeewaiver([FromBody] CustomerFeewaiverApprovalModelInput ObjClass);
        public Task<IEnumerable<CustomerGetCustomerReferenceNoModelOutput>> GetNameandFormNumberbyReferenceNo([FromBody] CustomerGetCustomerReferenceNoModelInput ObjClass);
        


        public Task<IEnumerable<CustomerDetailsModelOutput>> GetCustomerByCustomerId([FromBody] CustomerGetByCustomerIdModelInput ObjClass);
        public Task<IEnumerable<CustomerDetailsModelOutput>> GetCustomerDetails([FromBody] CustomerDetailsModelInput ObjClass);

        public Task<IEnumerable<CustomerDetailsModelOutput>> GetRawCustomerDetails([FromBody] CustomerDetailsModelInput ObjClass);

        public Task<IEnumerable<RBEGetModelOutput>> GetRBEId([FromBody] RBEGetModelInput ObjClass);
    }

}
