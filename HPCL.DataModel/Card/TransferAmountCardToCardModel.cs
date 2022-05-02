using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPCL.DataModel.Card
{
    public class TransferAmountCardToCardModelInput:BaseClass
    {
        public string CustomerId { get; set; }
        public List<CardToCardTransfer> CardToCardTransfer { get; set; }
    }
    public class CardToCardTransfer
    {
        public string FromCardNo { get; set; }
        public string ToCardNo { get; set; }
        public float TransferAmount { get; set; }
    }

    public class TransferAmountCardToCardModelOutput : BaseClassOutput
    {

    }
}
