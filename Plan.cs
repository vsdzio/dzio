using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contract
{
  [Serializable]
  class Plan
  {
    internal int ContractId { get; set; }
    internal int SubScriberId { get; set; }
    internal int Yno { get; set; }
    internal int Mno { get; set; }
    internal DateTime dBeg { get; set; }
    internal DateTime dEnd { get; set; }
    internal int Days { get; set; }
    internal decimal kfxDays { get; set; }
    internal decimal PaySizeFull { get; set; }
    internal decimal PaySizeCalc { get; set; }
    internal ePayType PayType { get; set; }
    internal DateTime dDue { get; set; }
  }
}
