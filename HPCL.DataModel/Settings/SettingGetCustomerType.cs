namespace HPCL.DataModel.Settings
{

    public class SettingGetCustomerTypeInput : BaseClass
    {

    }
    public class SettingGetCustomerTypeOutput
    {
        public int CustomerTypeId { get; set; }
        public string CustomerTypeName { get; set; }
    }
}
