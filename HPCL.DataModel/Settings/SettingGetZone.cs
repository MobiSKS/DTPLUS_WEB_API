namespace HPCL.DataModel.Settings
{

    public class SettingGetZoneInput : BaseClass
    {
        public int HQID { get; set; }
    }
    public class SettingGetZoneOutput
    {
        public int HQID { get; set; }
        public int ZoneID { get; set; }
        public string ZoneName { get; set; }
        public string ZoneShortName { get; set; }
    }
}
