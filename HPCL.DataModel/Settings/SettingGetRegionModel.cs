namespace HPCL.DataModel.Settings
{

    public class SettingGetRegionModelInput : BaseClass
    {
        public int ZoneID { get; set; }
    }
    public class SettingGetRegionModelOutput
    {
        public int ZoneID { get; set; }
        public string RegionName { get; set; }
        public string RegionShortName { get; set; }
    }
}
