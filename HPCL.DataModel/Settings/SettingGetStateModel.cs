namespace HPCL.DataModel.Settings
{

    public class SettingGetStateModelInput : BaseClass
    {
        public int CountryID { get; set; }
    }
    public class SettingGetStateModelOutput
    {
        public int CountryID { get; set; }
        public int StateID { get; set; }
        public string StateName { get; set; }
    }
}
