using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Customer
{
    public class CustomerGetByCustomerIdModelInput : BaseClass
    {
        [JsonPropertyName("CustomerID")]
        [DataMember]
        public string CustomerID { get; set; }
    }

    public class CustomerDetailsModelInput : BaseClass
    {
        [JsonPropertyName("CustomerID")]
        [DataMember]
        public string CustomerID { get; set; }

        [JsonPropertyName("CustomerTypeId")]
        [DataMember]
        public string CustomerTypeId { get; set; }

        [JsonPropertyName("CustomerSubtypeId")]
        [DataMember]
        public string CustomerSubtypeId { get; set; }

        [JsonPropertyName("ZonalOfficeID")]
        [DataMember]
        public string ZonalOfficeID { get; set; }

        [JsonPropertyName("RegionalOfficeID")]
        [DataMember]
        public string RegionalOfficeID { get; set; }

        [JsonPropertyName("CreatedBy")]
        [DataMember]
        public string CreatedBy { get; set; }

        [JsonPropertyName("FromDate")]
        [DataMember]
        public string FromDate { get; set; }

        [JsonPropertyName("ToDate")]
        [DataMember]
        public string ToDate { get; set; }

        [JsonPropertyName("NameOnCard")]
        [DataMember]
        public string NameOnCard { get; set; }

        [JsonPropertyName("TypeOfBusinessEntity")]
        [DataMember]
        public string TypeOfBusinessEntity { get; set; }

        [JsonPropertyName("CommunicationStateId")]
        [DataMember]
        public string CommunicationStateId { get; set; }

        [JsonPropertyName("CommunicationDistrictId")]
        [DataMember]
        public string CommunicationDistrictId { get; set; }

        [JsonPropertyName("PermanentStateId")]
        [DataMember]
        public string PermanentStateId { get; set; }

        [JsonPropertyName("PermanentDistrictId")]
        [DataMember]
        public string PermanentDistrictId { get; set; }

        [JsonPropertyName("Email")]
        [DataMember]
        public string Email { get; set; }

        [JsonPropertyName("MobileNo")]
        [DataMember]
        public string MobileNo { get; set; }

        [JsonPropertyName("TypeOfFleetId")]
        [DataMember]
        public string TypeOfFleetId { get; set; }

        [JsonPropertyName("FeePaymentsCollectFeeWaiver")]
        [DataMember]
        public string FeePaymentsCollectFeeWaiver { get; set; }

        [JsonPropertyName("ReferenceId")]
        [DataMember]
        public string ReferenceId { get; set; }

        [JsonPropertyName("FormNumber")]
        [DataMember]
        public string FormNumber { get; set; }

        [JsonPropertyName("CustomerReferenceNo")]
        [DataMember]
        public string CustomerReferenceNo { get; set; }

        [JsonPropertyName("CustomerStatusId")]
        [DataMember]
        public string CustomerStatusId { get; set; }

        [JsonPropertyName("ApprovedBy")]
        [DataMember]
        public string ApprovedBy { get; set; }

        [JsonPropertyName("ApprovedonFromDate")]
        [DataMember]
        public string ApprovedonFromDate { get; set; }

        [JsonPropertyName("ApprovedonToDate")]
        [DataMember]
        public string ApprovedonToDate { get; set; }

        [JsonPropertyName("CustomerStatusFeewaiverID")]
        [DataMember]
        public string CustomerStatusFeewaiverID { get; set; }

        [JsonPropertyName("FeewaiverApprovedBy")]
        [DataMember]
        public string FeewaiverApprovedBy { get; set; }

        [JsonPropertyName("FeewaiverApprovedOnFromDate")]
        [DataMember]
        public string FeewaiverApprovedOnFromDate { get; set; }

        [JsonPropertyName("FeewaiverApprovedOnToDate")]
        [DataMember]
        public string FeewaiverApprovedOnToDate { get; set; }
    }

    public class CustomerDetailsModelOutput
    {
        [JsonProperty("CustomerID")]
        [DataMember]
        public string CustomerID { get; set; }


        [JsonProperty("CustomerTypeId")]
        [DataMember]
        public int CustomerTypeId { get; set; }


        [JsonProperty("CustomerTypeName")]
        [DataMember]
        public string CustomerTypeName { get; set; }



        [JsonProperty("CustomerSubtypeId")]
        [DataMember]
        public int CustomerSubtypeId { get; set; }


        [JsonProperty("CustomerSubtypeName")]
        [DataMember]
        public string CustomerSubtypeName { get; set; }



        [JsonProperty("ZonalOfficeID")]
        [DataMember]
        public int ZonalOfficeID { get; set; }


        [JsonProperty("ZonalOfficeName")]
        [DataMember]
        public string ZonalOfficeName { get; set; }


        [JsonProperty("RegionalOfficeID")]
        [DataMember]
        public int RegionalOfficeID { get; set; }


        [JsonProperty("RegionalOfficeName")]
        [DataMember]
        public string RegionalOfficeName { get; set; }


        [JsonProperty("DateOfApplication")]
        [DataMember]
        public DateTime DateOfApplication { get; set; }


        [JsonProperty("SalesArea")]
        [DataMember]
        public string SalesArea { get; set; }


        [JsonProperty("CreatedBy")]
        [DataMember]
        public string CreatedBy { get; set; }


        [JsonProperty("CreatedTime")]
        [DataMember]
        public DateTime CreatedTime { get; set; }


        [JsonProperty("ModifiedBy")]
        [DataMember]
        public string ModifiedBy { get; set; }


        [JsonProperty("ModifiedTime")]
        [DataMember]
        public DateTime ModifiedTime { get; set; }


        [JsonProperty("IndividualOrgNameTitle")]
        [DataMember]
        public string IndividualOrgNameTitle { get; set; }



        [JsonProperty("IndividualOrgName")]
        [DataMember]
        public string IndividualOrgName { get; set; }



        [JsonProperty("NameOnCard")]
        [DataMember]
        public string NameOnCard { get; set; }



        [JsonProperty("TypeOfBusinessEntityId")]
        [DataMember]
        public int TypeOfBusinessEntityId { get; set; }


        [JsonProperty("TypeOfBusinessEntityName")]
        [DataMember]
        public string TypeOfBusinessEntityName { get; set; }



        [JsonProperty("ResidenceStatus")]
        [DataMember]
        public string ResidenceStatus { get; set; }



        [JsonProperty("IncomeTaxPan")]
        [DataMember]
        public string IncomeTaxPan { get; set; }



        [JsonProperty("CommunicationAddress1")]
        [DataMember]
        public string CommunicationAddress1 { get; set; }


        [JsonProperty("CommunicationAddress2")]
        [DataMember]
        public string CommunicationAddress2 { get; set; }


        [JsonProperty("CommunicationAddress3")]
        [DataMember]
        public string CommunicationAddress3 { get; set; }

        [JsonProperty("CommunicationLocation")]
        [DataMember]
        public string CommunicationLocation { get; set; }


        [JsonProperty("CommunicationCityName")]
        [DataMember]
        public string CommunicationCityName { get; set; }


        [JsonProperty("CommunicationPincode")]
        [DataMember]
        public string CommunicationPincode { get; set; }


        [JsonProperty("CommunicationStateId")]
        [DataMember]
        public int CommunicationStateId { get; set; }


        [JsonProperty("CommunicationStateName")]
        [DataMember]
        public string CommunicationStateName { get; set; }


        [JsonProperty("CommunicationDistrictId")]
        [DataMember]
        public int CommunicationDistrictId { get; set; }


        [JsonProperty("CommunicationDistrictName")]
        [DataMember]
        public string CommunicationDistrictName { get; set; }


        [JsonProperty("CommunicationPhoneNo")]
        [DataMember]
        public string CommunicationPhoneNo { get; set; }


        [JsonProperty("CommunicationFax")]
        [DataMember]
        public string CommunicationFax { get; set; }



        [JsonProperty("CommunicationMobileNo")]
        [DataMember]
        public string CommunicationMobileNo { get; set; }


        [JsonProperty("CommunicationEmailid")]
        [DataMember]
        public string CommunicationEmailid { get; set; }



        [JsonProperty("PermanentAddress1")]
        [DataMember]
        public string PermanentAddress1 { get; set; }


        [JsonProperty("PermanentAddress2")]
        [DataMember]
        public string PermanentAddress2 { get; set; }


        [JsonProperty("PermanentAddress3")]
        [DataMember]
        public string PermanentAddress3 { get; set; }


        [JsonProperty("PermanentLocation")]
        [DataMember]
        public string PermanentLocation { get; set; }



        [JsonProperty("PermanentCityName")]
        [DataMember]
        public string PermanentCityName { get; set; }



        [JsonProperty("PermanentPincode")]
        [DataMember]
        public string PermanentPincode { get; set; }


        [JsonProperty("PermanentStateId")]
        [DataMember]
        public int PermanentStateId { get; set; }


        [JsonProperty("PermanentStateName")]
        [DataMember]
        public string PermanentStateName { get; set; }


        [JsonProperty("PermanentDistrictId")]
        [DataMember]
        public int PermanentDistrictId { get; set; }


        [JsonProperty("PermanentDistrictName")]
        [DataMember]
        public string PermanentDistrictName { get; set; }


        [JsonProperty("PermanentPhoneNo")]
        [DataMember]
        public string PermanentPhoneNo { get; set; }


        [JsonProperty("PermanentFax")]
        [DataMember]
        public string PermanentFax { get; set; }



        [JsonProperty("KeyOfficialTitle")]
        [DataMember]
        public string KeyOfficialTitle { get; set; }


        [JsonProperty("KeyOfficialIndividualInitials")]
        [DataMember]
        public string KeyOfficialIndividualInitials { get; set; }



        [JsonProperty("KeyOfficialFirstName")]
        [DataMember]
        public string KeyOfficialFirstName { get; set; }

        [JsonProperty("KeyOfficialMiddleName")]
        [DataMember]
        public string KeyOfficialMiddleName { get; set; }


        [JsonProperty("KeyOfficialLastName")]
        [DataMember]
        public string KeyOfficialLastName { get; set; }


        [JsonProperty("KeyOfficialFax")]
        [DataMember]
        public string KeyOfficialFax { get; set; }



        [JsonProperty("KeyOfficialDesignation")]
        [DataMember]
        public string KeyOfficialDesignation { get; set; }


        [JsonProperty("KeyOfficialEmail")]
        [DataMember]
        public string KeyOfficialEmail { get; set; }


        [JsonProperty("KeyOfficialPhoneNo")]
        [DataMember]
        public string KeyOfficialPhoneNo { get; set; }


        [JsonProperty("KeyOfficialDOA")]
        [DataMember]
        public DateTime KeyOfficialDOA { get; set; }



        [JsonProperty("KeyOfficialMobile")]
        [DataMember]
        public string KeyOfficialMobile { get; set; }

        [JsonProperty("KeyOfficialDOB")]
        [DataMember]
        public DateTime KeyOfficialDOB { get; set; }


        [JsonProperty("KeyOfficialSecretQuestionId")]
        [DataMember]
        public int KeyOfficialSecretQuestionId { get; set; }

        [JsonProperty("KeyOfficialSecretQuestionName")]
        [DataMember]
        public string KeyOfficialSecretQuestionName { get; set; }


        [JsonProperty("KeyOfficialSecretAnswer")]
        [DataMember]
        public string KeyOfficialSecretAnswer { get; set; }


        [JsonProperty("KeyOfficialTypeOfFleetId")]
        [DataMember]
        public int KeyOfficialTypeOfFleetId { get; set; }



        [JsonProperty("KeyOfficialTypeOfFleetName")]
        [DataMember]
        public string KeyOfficialTypeOfFleetName { get; set; }



        [JsonProperty("KeyOfficialCardAppliedFor")]
        [DataMember]
        public string KeyOfficialCardAppliedFor { get; set; }



        [JsonProperty("KeyOfficialApproxMonthlySpendsonVechile1")]
        [DataMember]
        public float KeyOfficialApproxMonthlySpendsonVechile1 { get; set; }



        [JsonProperty("KeyOfficialApproxMonthlySpendsonVechile2")]
        [DataMember]
        public float KeyOfficialApproxMonthlySpendsonVechile2 { get; set; }


        [JsonProperty("AreaOfOperation")]
        [DataMember]
        public string AreaOfOperation { get; set; }


        [JsonProperty("FleetSizeNoOfVechileOwnedHCV")]
        [DataMember]
        public Int16 FleetSizeNoOfVechileOwnedHCV { get; set; }



        [JsonProperty("FleetSizeNoOfVechileOwnedLCV")]
        [DataMember]
        public Int16 FleetSizeNoOfVechileOwnedLCV { get; set; }


        [JsonProperty("FleetSizeNoOfVechileOwnedMUVSUV")]
        [DataMember]
        public Int16 FleetSizeNoOfVechileOwnedMUVSUV { get; set; }


        [JsonProperty("FleetSizeNoOfVechileOwnedCarJeep")]
        [DataMember]
        public Int16 FleetSizeNoOfVechileOwnedCarJeep { get; set; }


        [JsonProperty("NoOfCards")]
        [DataMember]
        public int NoOfCards { get; set; }

        [JsonProperty("FeePaymentsCollectFeeWaiverId")]
        [DataMember]
        public int FeePaymentsCollectFeeWaiverId { get; set; }

        [JsonProperty("FeePaymentsCollectFeeWaiver")]
        [DataMember]
        public string FeePaymentsCollectFeeWaiver { get; set; }


        [JsonProperty("FeePaymentsChequeNo")]
        [DataMember]
        public string FeePaymentsChequeNo { get; set; }


        [JsonProperty("FeePaymentsChequeDate")]
        [DataMember]
        public DateTime FeePaymentsChequeDate { get; set; }

        [JsonProperty("ReferenceId")]
        [DataMember]
        public string ReferenceId { get; set; }


        [JsonProperty("ControlCardNo")]
        [DataMember]
        public string ControlCardNo { get; set; }

        [JsonProperty("FormNumber")]
        [DataMember]
        public Int64 FormNumber { get; set; }


        [JsonProperty("CustomerReferenceNo")]
        [DataMember]
        public Int64 CustomerReferenceNo { get; set; }

        [JsonProperty("CustomerStatusId")]
        [DataMember]
        public int CustomerStatusId { get; set; }

        [JsonProperty("CustomerStatusName")]
        [DataMember]
        public string CustomerStatusName { get; set; }

        [JsonProperty("Remarks")]
        [DataMember]
        public string Remarks { get; set; }

        [JsonProperty("Approvedon")]
        [DataMember]
        public DateTime Approvedon { get; set; }

        [JsonProperty("ApprovedBy")]
        [DataMember]
        public string ApprovedBy { get; set; }

        [JsonProperty("CustomerStatusFeewaiverID")]
        [DataMember]
        public Int32 CustomerStatusFeewaiverID { get; set; }

        [JsonProperty("CustomerStatusFeewaiverName")]
        [DataMember]
        public string CustomerStatusFeewaiverName { get; set; }

        [JsonProperty("FeewaiverComments")]
        [DataMember]
        public string FeewaiverComments { get; set; }

        [JsonProperty("FeewaiverApprovedOn")]
        [DataMember]
        public DateTime FeewaiverApprovedOn { get; set; }

        [JsonProperty("FeewaiverApprovedBy")]
        [DataMember]
        public string FeewaiverApprovedBy { get; set; }
    }
}
