﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HPCL.DataModel.User
{
    public class UserModel : BaseClass
    {
        public string Mobileno { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Useragent { get; set; }
        public string Userip { get; set; }
        public string Userid { get; set; }
    }
}
