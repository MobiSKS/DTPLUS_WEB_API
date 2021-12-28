using System;
using System.Collections.Generic;
using System.Text;

namespace HPCL.DataModel.Settings
{
    public class SettingGetHQModelInput 
    {
        public string Useragent { get; set; }
        public string Userip { get; set; }
        public string Userid { get; set; }
    }

    public class SettingGetHQModelOutput 
    {
        public int HQID { get; set; }
        public string HQName { get; set; }
        public string HQShortName { get; set; }
    }
}
