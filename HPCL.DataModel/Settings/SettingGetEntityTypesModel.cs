namespace HPCL.DataModel.Settings
{

    public class SettingGetEntityTypesModelInput : BaseClass
    {
        public int EntityTypeId { get; set; }
    }
    public class SettingGetEntityTypesModelOutput
    {
        public int EntityTypeId { get; set; }
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public string StatusCode { get; set; }
        public string StatusDescription { get; set; }
    }
}
