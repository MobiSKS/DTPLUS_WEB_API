namespace HPCL.DataModel.Settings
{

    public class SettingGetCustomerSubTypeModelInput : BaseClass
    {
        public int CustomerTypeId { get; set; }
    }
    public class SettingGetCustomerSubTypeModelOutput
    {
        public int CustomerSubtypeId { get; set; }
        public string CustomerSubtypeName { get; set; }
    }
}
