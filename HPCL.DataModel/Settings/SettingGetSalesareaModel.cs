namespace HPCL.DataModel.Settings
{

    public class SettingGetSalesareaModelInput : BaseClass
    {
        public int RegionID { get; set; }
    }
    public class SettingGetSalesareaModelOutput
    {
        public int RegionID { get; set; }
        public int SalesAreaID { get; set; }
        public string SalesAreaName { get; set; }
    }
}
