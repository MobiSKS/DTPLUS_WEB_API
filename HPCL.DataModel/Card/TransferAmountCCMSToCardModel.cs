using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPCL.DataModel.Card
{
    public class TransferAmountCCMSToCardModelInput:BaseClass
    {
        public string CustomerId { get; set; }
        public List<CCMSToCardTransfer> CCMSToCardTransfer { get; set; }

    }
    public class CCMSToCardTransfer
    {
        public string CardNo { get; set; }
        public float TransferAmount { get; set; }    
    }

    public class TransferAmountCCMSToCardModelOutput:BaseClassOutput
    {

    }
}
