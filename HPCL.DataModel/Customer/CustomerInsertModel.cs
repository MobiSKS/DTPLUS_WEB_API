using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace HPCL.DataModel.Officer
{
    public class CustomerInsertModelInput : BaseClass
    {
        //[JsonProperty("CustomerID")]
        //[DataMember]
        //public Int64 CustomerID { get; set; }

        [Required]
        [JsonProperty("CustomerType")]
        [DataMember]
        public Int32 CustomerType { get; set; }


        [Required]
        [JsonProperty("CustomerSubtype")]
        [DataMember]
        public Int32 CustomerSubtype { get; set; }

        [Required]

        [JsonProperty("ZonalOffice")]
        [DataMember]
        public Int32 ZonalOffice { get; set; }


        [Required]
        [JsonProperty("RegionalOffice")]
        [DataMember]
        public Int32 RegionalOffice { get; set; }


        [Required]
        [JsonProperty("DateOfApplication")]
        [DataMember]
        public DateTime DateOfApplication { get; set; }

        [Required]
        [JsonProperty("SalesArea")]
        [DataMember]
        public Int32 SalesArea { get; set; }

        [Required]
        [JsonProperty("CreatedBy")]
        [DataMember]
        public Int32 CreatedBy { get; set; }


        [Required]
        [JsonProperty("IndividualOrgNameTitle")]
        [DataMember]
        public string IndividualOrgNameTitle { get; set; }


        [Required]
        [JsonProperty("IndividualOrgName")]
        [DataMember]
        public string IndividualOrgName { get; set; }


        [Required]
        [JsonProperty("NameOnCard")]
        [DataMember]
        public string NameOnCard { get; set; }


        [Required]
        [JsonProperty("TypeOfBusinessEntity")]
        [DataMember]
        public Int32 TypeOfBusinessEntity { get; set; }


        [Required]
        [JsonProperty("ResidenceStatus")]
        [DataMember]
        public string ResidenceStatus { get; set; }


        [Required]
        [JsonProperty("IncomeTaxPan")]
        [DataMember]
        [RegularExpression("^[a-zA-Z]{5}[0-9]{4}[a-zA-Z]{1}$", ErrorMessage = "Invalid Pancard Number")]
        public string IncomeTaxPan { get; set; }


        [Required]
        [JsonProperty("CommunicationAddress1")]
        [DataMember]
        public string CommunicationAddress1 { get; set; }

        [Required]
        [JsonProperty("CommunicationAddress2")]
        [DataMember]
        public string CommunicationAddress2 { get; set; }


        [JsonProperty("CommunicationAddress3")]
        [DataMember]
        public string CommunicationAddress3 { get; set; }

        [JsonProperty("CommunicationLocation")]
        [DataMember]
        public string CommunicationLocation { get; set; }

        [Required]
        [JsonProperty("CommunicationCityId")]
        [DataMember]
        public Int32 CommunicationCityId { get; set; }

        [Required]
        [JsonProperty("CommunicationPincode")]
        [DataMember]
        public string CommunicationPincode { get; set; }

        [Required]
        [JsonProperty("CommunicationStateId")]
        [DataMember]
        public Int32 CommunicationStateId { get; set; }


        [Required]
        [JsonProperty("CommunicationDistrictId")]
        [DataMember]
        public Int32 CommunicationDistrictId { get; set; }

        [Required]
        [JsonProperty("CommunicationPhoneNo")]
        [DataMember]
        public string CommunicationPhoneNo { get; set; }


        [JsonProperty("CommunicationFax")]
        [DataMember]
        public string CommunicationFax { get; set; }


        [Required]
        [JsonProperty("CommunicationMobileNo")]
        [StringLength(10, MinimumLength = 10)]
        [DataMember]
        public string CommunicationMobileNo { get; set; }


        [JsonProperty("CommunicationEmailid")]
        [DataMember]
        [RegularExpression("\\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\\Z", ErrorMessage = "Invalid Email Id")]
        public string CommunicationEmailid { get; set; }


        [Required]
        [JsonProperty("PermanentAddress1")]
        [DataMember]
        public string PermanentAddress1 { get; set; }

        [Required]
        [JsonProperty("PermanentAddress2")]
        [DataMember]
        public string PermanentAddress2 { get; set; }


        [JsonProperty("PermanentAddress3")]
        [DataMember]
        public string PermanentAddress3 { get; set; }


        [JsonProperty("PermanentLocation")]
        [DataMember]
        public string PermanentLocation { get; set; }


        [Required]
        [JsonProperty("PermanentCityId")]
        [DataMember]
        public Int32 PermanentCityId { get; set; }


        [Required]
        [JsonProperty("PermanentPincode")]
        [DataMember]
        public string PermanentPincode { get; set; }

        [Required]
        [JsonProperty("PermanentStateId")]
        [DataMember]
        public Int32 PermanentStateId { get; set; }


        [Required]
        [JsonProperty("PermanentDistrictId")]
        [DataMember]
        public Int32 PermanentDistrictId { get; set; }


        [JsonProperty("PermanentPhoneNo")]
        [DataMember]
        public string PermanentPhoneNo { get; set; }


        [JsonProperty("PermanentFax")]
        [DataMember]
        public string PermanentFax { get; set; }


        [Required]
        [JsonProperty("KeyOfficialTitle")]
        [DataMember]
        public string KeyOfficialTitle { get; set; }



        [JsonProperty("KeyOfficialIndividualInitials")]
        [DataMember]
        public string KeyOfficialIndividualInitials { get; set; }


        [Required]
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


        [Required]
        [JsonProperty("KeyOfficialDesignation")]
        [DataMember]
        public string KeyOfficialDesignation { get; set; }


        [JsonProperty("KeyOfficialEmail")]
        [DataMember]
        [RegularExpression("\\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\\Z", ErrorMessage = "Invalid Email Id")]
        public string KeyOfficialEmail { get; set; }


        [JsonProperty("KeyOfficialPhoneNo")]
        [DataMember]
        public string KeyOfficialPhoneNo { get; set; }


        [JsonProperty("KeyOfficialDOA")]
        [DataMember]
        public DateTime KeyOfficialDOA { get; set; }


        [Required]
        [JsonProperty("KeyOfficialMobile")]
        [StringLength(10, MinimumLength = 10)]
        [DataMember]
        public string KeyOfficialMobile { get; set; }

        [JsonProperty("KeyOfficialDOB")]
        [DataMember]
        public DateTime KeyOfficialDOB { get; set; }


        [JsonProperty("KeyOfficialSecretQuestion")]
        [DataMember]
        public string KeyOfficialSecretQuestion { get; set; }


        [JsonProperty("KeyOfficialSecretAnswer")]
        [DataMember]
        public string KeyOfficialSecretAnswer { get; set; }


        [JsonProperty("KeyOfficialTypeOfFleet")]
        [DataMember]
        public string KeyOfficialTypeOfFleet { get; set; }

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
        public Int32 NoOfCards { get; set; }



        [JsonProperty("FeePaymentsCollectFeeWaiver")]
        [DataMember]
        public Int16 FeePaymentsCollectFeeWaiver { get; set; }



        [JsonProperty("FeePaymentsChequeNo")]
        [DataMember]
        public string FeePaymentsChequeNo { get; set; }


        [JsonProperty("FeePaymentsChequeDate")]
        [DataMember]
        public DateTime FeePaymentsChequeDate { get; set; }

         

    }

     


}
