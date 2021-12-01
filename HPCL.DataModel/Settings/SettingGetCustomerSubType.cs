namespace HPCL.DataModel.Settings
{

    public class SettingGetCustomerSubTypeInput : BaseClass
    {
        public int CustomerTypeId { get; set; }
    }
    public class SettingGetCustomerSubTypeOutput
    {
        public int CustomerSubtypeId { get; set; }
        public string CustomerSubtypeName { get; set; }
    }
}
