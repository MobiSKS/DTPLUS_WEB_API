namespace HPCL.DataModel.Settings
{

    public class SettingGetZoneModelInput : BaseClass
    {
        public int HQID { get; set; }
    }
    public class SettingGetZoneModelOutput
    {
        public int HQID { get; set; }
        public int ZoneID { get; set; }
        public string ZoneName { get; set; }
        public string ZoneShortName { get; set; }
    }
}
