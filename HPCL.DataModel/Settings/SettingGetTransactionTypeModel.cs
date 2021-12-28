namespace HPCL.DataModel.Settings
{

    public class SettingGetTransactionTypeModelInput : BaseClass
    {

    }
    public class SettingGetTransactionTypeModelOutput
    {
        public int TransactionID { get; set; }
        public string TransactionType { get; set; }
    }
}
