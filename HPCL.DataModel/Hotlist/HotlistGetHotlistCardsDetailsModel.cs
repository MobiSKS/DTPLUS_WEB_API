using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;


namespace HPCL.DataModel.Hotlist;

public class HotlistGetHotlistCardsDetailsModelInput:BaseClass
{
    [JsonPropertyName("CustomerID")]
    [DataMember]
    public string CustomerID { get; set; }

    [JsonPropertyName("CardNo")]
    [DataMember]
    public string CardNo { get; set; }
}

public class HotlistGetHotlistCardsDetailsModelOutput : BaseClassOutput
{

    //[JsonProperty("CustomerID")]
    //[DataMember]
    //public string CustomerID { get; set; }

    [JsonProperty("CardNo")]
    [DataMember]
    public string CardNo { get; set; }


    [JsonProperty("UserName")]
    [DataMember]
    public string UserName { get; set; }


    [JsonProperty("KeyOfficialTypeOfFleet")]
    [DataMember]
    public string KeyOfficialTypeOfFleet { get; set; }


    [JsonProperty("VechileNo")]
    [DataMember]
    public string VechileNo { get; set; }


    [JsonProperty("VechileType")]
    [DataMember]
    public string VechileType { get; set; }


    [JsonProperty("YearOfRegistration")]
    [DataMember]
    public string YearOfRegistration { get; set; }


    [JsonProperty("Manufacturer")]
    [DataMember]
    public string Manufacturer { get; set; }


    [JsonProperty("CardCategory")]
    [DataMember]
    public string CardCategory { get; set; }
}
