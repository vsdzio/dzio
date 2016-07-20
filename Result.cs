using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contract
{
  [Serializable]
  class Result
  {
    int ContractId { get; set; }
    int SubScriberId { get; set; }
    DateTime CalcDate { get; set; }
    Decimal DebtTotal { get; set; }
    Decimal DebtPlan { get; set; }
    Decimal DebtPany { get; set; }
  }
}
