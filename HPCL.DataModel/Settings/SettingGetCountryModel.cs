namespace HPCL.DataModel.Settings
{

    public class SettingGetCountryModelInput : BaseClass
    {

    }
    public class SettingGetCountryModelOutput
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }
    }
}
