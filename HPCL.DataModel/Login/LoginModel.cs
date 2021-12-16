using System;
using System.Collections.Generic;
using System.Text;

namespace HPCL.DataModel.Login
{
    public class LoginModel
    {
        //public class LoginInput
        //{
        //    [JsonProperty("Mobileno")]
            public string Mobileno { get; set; }

          //  [JsonProperty("Username")]
            public string Username { get; set; }

            //[Required]
            //[JsonProperty("Password")]
            public string Password { get; set; }

            //[Required]
            //[JsonProperty("Useragent")]
            public string Useragent { get; set; }

            //[Required]
            //[JsonProperty("Userip")]
            public string Userip { get; set; }

            //[Required]
            //[JsonProperty("Userid")]
            public string Userid { get; set; }

       // }
    }

}
