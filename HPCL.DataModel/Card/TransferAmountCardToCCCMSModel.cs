using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPCL.DataModel.Card
{
    public class TransferAmountCardToCCCMSModel
    {
    }
    public class TransferAmountCardToCCMSModelInput : BaseClass
    {
        public string CustomerId { get; set; }
        public List<CardToCCMSTransfer> CardToCCMSTransfer { get; set; }
    }
    public class CardToCCMSTransfer
    {
        public string CardNo { get; set; }
        public float TransferAmount { get; set; }
    }

    public class TransferAmountCardToCCMSModeloutput : BaseClassOutput
    {

    }
}
